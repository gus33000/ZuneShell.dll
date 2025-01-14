﻿#if OPENZUNE

using CommunityToolkit.Diagnostics;
using MicrosoftZunePlayback;
using OwlCore.Storage;
using OwlCore.Storage.SystemIO;
using StrixMusic.Sdk.MediaPlayback;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Zune.Playback
{
    public class PlayerInteropAudioService : IAudioPlayerService
    {
        private readonly PlayerInterop _playbackWrapper = PlayerInterop.Instance;
        private readonly IModifiableFolder _tempFolder;
        private PlaybackItem m_currentSource;
        private int _playbackId = 0;
        private TimeSpan _position;

        public PlayerInteropAudioService(IModifiableFolder tempFolder) : this()
        {
            _tempFolder = tempFolder;
        }

        public PlayerInteropAudioService(string? path = null) : this()
        {
            path ??= Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"Microsoft\Zune\OpenZune\PlayerInteropTemp");

            DirectoryInfo cacheFolderPath = new(path);
            cacheFolderPath.Create();
            _tempFolder = new SystemFolder(cacheFolderPath);
        }

        private PlayerInteropAudioService()
        {
            _playbackWrapper.Initialize();

            _playbackWrapper.TransportPositionChanged += PlaybackWrapper_TransportPositionChanged;
        }

        public static PlayerInteropAudioService Instance => new();

        public PlayerInterop PlaybackWrapper => _playbackWrapper;

        public PlaybackItem CurrentSource
        {
            get => m_currentSource;
            set
            {
                m_currentSource = value;
                CurrentSourceChanged?.Invoke(this, value);
            }
        }

        public TimeSpan Position
        {
            get => _position;
            set
            {
                _position = value;
                PositionChanged?.Invoke(this, value);
            }
        }

        public PlaybackState PlaybackState => _playbackWrapper.TransportState switch
        {
            MCTransportState.Playing => PlaybackState.Playing,

            MCTransportState.Paused or
            MCTransportState.Stopped => PlaybackState.Paused,

            MCTransportState.Buffering => PlaybackState.Loading,

            MCTransportState.Invalid or _ => PlaybackState.None,
        };

        public double Volume => _playbackWrapper.Volume / 100d;

        public double PlaybackSpeed => _playbackWrapper.Rate;

        public event EventHandler<PlaybackItem> CurrentSourceChanged;
        public event EventHandler<float[]> QuantumProcessed;
        public event EventHandler<TimeSpan> PositionChanged;
        public event EventHandler<PlaybackState> PlaybackStateChanged;
        public event EventHandler<double> VolumeChanged;
        public event EventHandler<double> PlaybackSpeedChanged;

        public Task ChangePlaybackSpeedAsync(double speed, CancellationToken cancellationToken = default)
        {
            _playbackWrapper.Rate = (float)speed;
            return Task.CompletedTask;
        }

        public Task ChangeVolumeAsync(double volume, CancellationToken cancellationToken = default)
        {
            _playbackWrapper.Volume = (int)(volume * 100);
            return Task.CompletedTask;
        }

        public Task PauseAsync(CancellationToken cancellationToken = default)
        {
            _playbackWrapper.Pause();
            return Task.CompletedTask;
        }

        public async Task Play(PlaybackItem sourceConfig, CancellationToken cancellationToken = default)
        {
            var media = await LoadAsync(sourceConfig.MediaConfig);

            Iris.Application.DeferredInvoke(new Iris.DeferredInvokeHandler(delegate
            {
                // Play cannot be called immediately after SetUri,
                // so we have to listen for when the change is done.
                _playbackWrapper.UriSet += PlaybackWrapper_UriSet;
                _playbackWrapper.SetUri(media.Uri, 0, media.Id);
            }), Iris.DeferredInvokePriority.Normal);
        }

        private void PlaybackWrapper_UriSet(object sender, EventArgs e)
        {
            Iris.Application.DeferredInvoke(new Iris.DeferredInvokeHandler(delegate
            {
                _playbackWrapper.UriSet -= PlaybackWrapper_UriSet;
                _playbackWrapper.Play();
            }), Iris.DeferredInvokePriority.Normal);
        }

        public async Task Preload(PlaybackItem sourceConfig, CancellationToken cancellationToken = default)
        {
            var media = await LoadAsync(sourceConfig.MediaConfig);
            _playbackWrapper.SetNextUri(media.Uri, 0, media.Id);
        }

        public Task ResumeAsync(CancellationToken cancellationToken = default)
        {
            _playbackWrapper.Play();
            return Task.CompletedTask;
        }

        public Task SeekAsync(TimeSpan position, CancellationToken cancellationToken = default)
        {
            if (_playbackWrapper.CanSeek)
                _playbackWrapper.SeekToAbsolutePosition(position.Ticks);
            return Task.CompletedTask;
        }

        private async Task<PlayerInteropMedia> LoadAsync(IMediaSourceConfig mediaConfig, bool saveStream = true)
        {
            Guard.IsNotNull(mediaConfig);

            mediaConfig.FileStreamSource?.Dispose();

            var url = mediaConfig.MediaSourceUri?.ToString();
            if (url is null)
            {
                if (IsValidUri(mediaConfig.Id))
                {
                    url = mediaConfig.Id;
                }
                else if (saveStream && mediaConfig.FileStreamSource is not null)
                {
                    var dstFile = await _tempFolder.CreateFileAsync(mediaConfig.Id, true);
                    using (var stream = await dstFile.OpenStreamAsync(FileAccess.ReadWrite))
                    {
                        await mediaConfig.FileStreamSource.CopyToAsync(stream);
                    }

                    Guard.IsTrue(IsValidUri(url));
                    url = dstFile.Id;
                }
                else
                {
                    throw new ArgumentException("PlayerInterop can only load media from a URI.");
                }
            }

            int playbackId;
            if (mediaConfig is ZuneMediaSourceConfig zuneSrcCfg)
                playbackId = zuneSrcCfg.PlaybackId;
            else
                playbackId = ++_playbackId;

            return new(url, playbackId);
        }

        private static bool IsValidUri(string? url) => Uri.TryCreate(url, UriKind.Absolute, out _);

        private readonly struct PlayerInteropMedia
        {
            public PlayerInteropMedia(string uri, int id)
            {
                Uri = uri;
                Id = id;
            }

            public string Uri { get; }
            public int Id { get; }
        }

        private void PlaybackWrapper_TransportPositionChanged(object sender, EventArgs e)
        {
            Position = new(_playbackWrapper.Position);
        }
    }
}

#endif
