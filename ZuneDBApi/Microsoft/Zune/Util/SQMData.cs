namespace Microsoft.Zune.Util
{
	public class SQMData
	{
		public static SQMDataPoint[] s_rgSQMDataPoints = new SQMDataPoint[229];

		public static SQMDataPoint s_sqmDataPointInvalid;

		static SQMData()
		{
			s_rgSQMDataPoints[0] = new SQMDataPoint(SQMDataId.OperatingSystemVersion, SQMAction.NumStream, 3);
			s_rgSQMDataPoints[1] = new SQMDataPoint(SQMDataId.SetupDurations, SQMAction.NumStream, 5);
			s_rgSQMDataPoints[2] = new SQMDataPoint(SQMDataId.DeviceArrival, SQMAction.Inc, 1);
			s_rgSQMDataPoints[3] = new SQMDataPoint(SQMDataId.DeviceWiredArrival, SQMAction.Inc, 1);
			s_rgSQMDataPoints[4] = new SQMDataPoint(SQMDataId.DeviceWirelessArrival, SQMAction.Inc, 1);
			s_rgSQMDataPoints[5] = new SQMDataPoint(SQMDataId.DeviceWirelessSetup, SQMAction.Inc, 1);
			s_rgSQMDataPoints[6] = new SQMDataPoint(SQMDataId.WirelessSyncWizardComplete, SQMAction.Inc, 1);
			s_rgSQMDataPoints[7] = new SQMDataPoint(SQMDataId.WirelessSyncWizardCancel, SQMAction.Inc, 1);
			s_rgSQMDataPoints[8] = new SQMDataPoint(SQMDataId.WirelessSyncWizardCancelFail, SQMAction.Inc, 1);
			s_rgSQMDataPoints[9] = new SQMDataPoint(SQMDataId.BandwidthTestResultAndDecision, SQMAction.NumStream, 2);
			s_rgSQMDataPoints[10] = new SQMDataPoint(SQMDataId.BandwidthTestDoesnotMeetMin, SQMAction.Inc, 1);
			s_rgSQMDataPoints[11] = new SQMDataPoint(SQMDataId.BandwidthTestTimeout, SQMAction.Inc, 1);
			s_rgSQMDataPoints[12] = new SQMDataPoint(SQMDataId.BandwidthTestRetryDifferentResult, SQMAction.Inc, 1);
			s_rgSQMDataPoints[13] = new SQMDataPoint(SQMDataId.DeviceSize, SQMAction.NumStream, 2);
			s_rgSQMDataPoints[14] = new SQMDataPoint(SQMDataId.DeviceSyncPreferences, SQMAction.NumStream, 1);
			s_rgSQMDataPoints[15] = new SQMDataPoint(SQMDataId.DeviceSyncAllPreferences, SQMAction.NumStream, 6);
			s_rgSQMDataPoints[16] = new SQMDataPoint(SQMDataId.DeviceInformation, SQMAction.MixedStream, 6);
			s_rgSQMDataPoints[17] = new SQMDataPoint(SQMDataId.DeviceSyncRelationship, SQMAction.SetBits, 1);
			s_rgSQMDataPoints[18] = new SQMDataPoint(SQMDataId.DeviceSyncRelationshipChange, SQMAction.NumStream, 2);
			s_rgSQMDataPoints[19] = new SQMDataPoint(SQMDataId.DeviceFormat, SQMAction.Inc, 1);
			s_rgSQMDataPoints[20] = new SQMDataPoint(SQMDataId.SyncTranscode, SQMAction.NumStream, 2);
			s_rgSQMDataPoints[21] = new SQMDataPoint(SQMDataId.SyncRunMetrics, SQMAction.NumStream, 6);
			s_rgSQMDataPoints[22] = new SQMDataPoint(SQMDataId.PodcastAdhocDownload, SQMAction.Inc, 1);
			s_rgSQMDataPoints[23] = new SQMDataPoint(SQMDataId.PodcastManualEpisodeDownload, SQMAction.Inc, 1);
			s_rgSQMDataPoints[24] = new SQMDataPoint(SQMDataId.PodcastSubscriptionSourceZMP, SQMAction.Inc, 1);
			s_rgSQMDataPoints[25] = new SQMDataPoint(SQMDataId.PodcastSubscriptionSourceProtocolHandler, SQMAction.Inc, 1);
			s_rgSQMDataPoints[26] = new SQMDataPoint(SQMDataId.PodcastSubscriptionSourceUrl, SQMAction.Inc, 1);
			s_rgSQMDataPoints[27] = new SQMDataPoint(SQMDataId.PodcastSubscriptionSourceInbox, SQMAction.Inc, 1);
			s_rgSQMDataPoints[28] = new SQMDataPoint(SQMDataId.PodcastVideoEpisodePlayed, SQMAction.Inc, 1);
			s_rgSQMDataPoints[29] = new SQMDataPoint(SQMDataId.PodcastAudioEpisodePlayed, SQMAction.Inc, 1);
			s_rgSQMDataPoints[30] = new SQMDataPoint(SQMDataId.PodcastDefaultKeepEpisodesChanged, SQMAction.Inc, 1);
			s_rgSQMDataPoints[31] = new SQMDataPoint(SQMDataId.PodcastDefaultPlaybackOrderChanged, SQMAction.Inc, 1);
			s_rgSQMDataPoints[32] = new SQMDataPoint(SQMDataId.PodcastSeriesKeepEpisodesChanged, SQMAction.Inc, 1);
			s_rgSQMDataPoints[33] = new SQMDataPoint(SQMDataId.PodcastSeriesPlaybackOrderChanged, SQMAction.Inc, 1);
			s_rgSQMDataPoints[34] = new SQMDataPoint(SQMDataId.ManualCheckForUpdatesInvoked, SQMAction.Inc, 1);
			s_rgSQMDataPoints[35] = new SQMDataPoint(SQMDataId.MetadataUpdatesEnabled, SQMAction.SetFlag, 1);
			s_rgSQMDataPoints[36] = new SQMDataPoint(SQMDataId.OverwriteAllMetadataEnabled, SQMAction.SetFlag, 1);
			s_rgSQMDataPoints[37] = new SQMDataPoint(SQMDataId.AutoOrganizeEnabled, SQMAction.SetFlag, 1);
			s_rgSQMDataPoints[38] = new SQMDataPoint(SQMDataId.UserEditMetadataField, SQMAction.Inc, 1);
			s_rgSQMDataPoints[39] = new SQMDataPoint(SQMDataId.UserEditMusicMetadata, SQMAction.Inc, 1);
			s_rgSQMDataPoints[40] = new SQMDataPoint(SQMDataId.UserEditVideoMetadata, SQMAction.Inc, 1);
			s_rgSQMDataPoints[41] = new SQMDataPoint(SQMDataId.UserFindAlbumInfoUpdate, SQMAction.Inc, 1);
			s_rgSQMDataPoints[42] = new SQMDataPoint(SQMDataId.UserReplaceAlbumArt, SQMAction.Inc, 1);
			s_rgSQMDataPoints[43] = new SQMDataPoint(SQMDataId.UserDeferredAutomaticUpdate, SQMAction.Inc, 1);
			s_rgSQMDataPoints[44] = new SQMDataPoint(SQMDataId.UserConfiguredSettingsFUE, SQMAction.SetFlag, 1);
			s_rgSQMDataPoints[45] = new SQMDataPoint(SQMDataId.DXModeEnabled, SQMAction.SetFlag, 1);
			s_rgSQMDataPoints[46] = new SQMDataPoint(SQMDataId.LanguageLocale, SQMAction.MixedStream, 1);
			s_rgSQMDataPoints[47] = new SQMDataPoint(SQMDataId.InboxMessageRead, SQMAction.Inc, 1);
			s_rgSQMDataPoints[48] = new SQMDataPoint(SQMDataId.InboxMessageDelete, SQMAction.Inc, 1);
			s_rgSQMDataPoints[49] = new SQMDataPoint(SQMDataId.InboxMessageReply, SQMAction.Inc, 1);
			s_rgSQMDataPoints[50] = new SQMDataPoint(SQMDataId.InboxMessageAcceptFriend, SQMAction.Inc, 1);
			s_rgSQMDataPoints[51] = new SQMDataPoint(SQMDataId.InboxMessageRejectFriend, SQMAction.Inc, 1);
			s_rgSQMDataPoints[52] = new SQMDataPoint(SQMDataId.InboxMessageSendMessage, SQMAction.Inc, 1);
			s_rgSQMDataPoints[53] = new SQMDataPoint(SQMDataId.InboxMessageSendUserPlaylist, SQMAction.Inc, 1);
			s_rgSQMDataPoints[54] = new SQMDataPoint(SQMDataId.InboxMessageSendPlaylist, SQMAction.Inc, 1);
			s_rgSQMDataPoints[55] = new SQMDataPoint(SQMDataId.InboxMessageSendAlbum, SQMAction.Inc, 1);
			s_rgSQMDataPoints[56] = new SQMDataPoint(SQMDataId.InboxMessageSendProfileCard, SQMAction.Inc, 1);
			s_rgSQMDataPoints[57] = new SQMDataPoint(SQMDataId.InboxMessageSendTrack, SQMAction.Inc, 1);
			s_rgSQMDataPoints[58] = new SQMDataPoint(SQMDataId.InboxMessageSendVideo, SQMAction.Inc, 1);
			s_rgSQMDataPoints[59] = new SQMDataPoint(SQMDataId.InboxMessageSendPodcast, SQMAction.Inc, 1);
			s_rgSQMDataPoints[60] = new SQMDataPoint(SQMDataId.SocialAddComment, SQMAction.Inc, 1);
			s_rgSQMDataPoints[61] = new SQMDataPoint(SQMDataId.SocialDeleteComment, SQMAction.Inc, 1);
			s_rgSQMDataPoints[62] = new SQMDataPoint(SQMDataId.SocialViewComments, SQMAction.Inc, 1);
			s_rgSQMDataPoints[63] = new SQMDataPoint(SQMDataId.SocialViewRecentPlays, SQMAction.Inc, 1);
			s_rgSQMDataPoints[64] = new SQMDataPoint(SQMDataId.SocialViewTopArtists, SQMAction.Inc, 1);
			s_rgSQMDataPoints[65] = new SQMDataPoint(SQMDataId.SocialViewFavorites, SQMAction.Inc, 1);
			s_rgSQMDataPoints[66] = new SQMDataPoint(SQMDataId.SocialViewBadges, SQMAction.Inc, 1);
			s_rgSQMDataPoints[67] = new SQMDataPoint(SQMDataId.SocialViewAbout, SQMAction.Inc, 1);
			s_rgSQMDataPoints[68] = new SQMDataPoint(SQMDataId.SocialEditTile, SQMAction.Inc, 1);
			s_rgSQMDataPoints[69] = new SQMDataPoint(SQMDataId.SocialEditBackground, SQMAction.Inc, 1);
			s_rgSQMDataPoints[70] = new SQMDataPoint(SQMDataId.SocialSyncAddProfileCard, SQMAction.Inc, 1);
			s_rgSQMDataPoints[71] = new SQMDataPoint(SQMDataId.SocialSyncDeleteProfileCard, SQMAction.Inc, 1);
			s_rgSQMDataPoints[72] = new SQMDataPoint(SQMDataId.FavoritesAdd, SQMAction.Inc, 1);
			s_rgSQMDataPoints[73] = new SQMDataPoint(SQMDataId.FavoritesRemove, SQMAction.Inc, 1);
			s_rgSQMDataPoints[74] = new SQMDataPoint(SQMDataId.InboxDownload, SQMAction.Inc, 1);
			s_rgSQMDataPoints[75] = new SQMDataPoint(SQMDataId.InboxPurchase, SQMAction.Inc, 1);
			s_rgSQMDataPoints[76] = new SQMDataPoint(SQMDataId.SearchExecuted, SQMAction.Inc, 1);
			s_rgSQMDataPoints[77] = new SQMDataPoint(SQMDataId.SearchWordWheelCount, SQMAction.Inc, 1);
			s_rgSQMDataPoints[78] = new SQMDataPoint(SQMDataId.SearchFiltersCount, SQMAction.Inc, 1);
			s_rgSQMDataPoints[79] = new SQMDataPoint(SQMDataId.SearchFiltersSelection, SQMAction.NumStream, 1);
			s_rgSQMDataPoints[80] = new SQMDataPoint(SQMDataId.SearchCollectionResultsCount, SQMAction.Inc, 1);
			s_rgSQMDataPoints[81] = new SQMDataPoint(SQMDataId.SearchMarketplaceResultsCount, SQMAction.Inc, 1);
			s_rgSQMDataPoints[82] = new SQMDataPoint(SQMDataId.SearchContextMenuAction, SQMAction.NumStream, 1);
			s_rgSQMDataPoints[83] = new SQMDataPoint(SQMDataId.MarketplacePurchase, SQMAction.Inc, 1);
			s_rgSQMDataPoints[84] = new SQMDataPoint(SQMDataId.MarketplaceDownload, SQMAction.Inc, 1);
			s_rgSQMDataPoints[85] = new SQMDataPoint(SQMDataId.MarketplacePreviewStream, SQMAction.Inc, 1);
			s_rgSQMDataPoints[86] = new SQMDataPoint(SQMDataId.MarketplaceSubscriptionStream, SQMAction.Inc, 1);
			s_rgSQMDataPoints[87] = new SQMDataPoint(SQMDataId.SignedInWithCachedCredentials, SQMAction.Inc, 1);
			s_rgSQMDataPoints[88] = new SQMDataPoint(SQMDataId.SignedInWithoutCachedCredentials, SQMAction.Inc, 1);
			s_rgSQMDataPoints[89] = new SQMDataPoint(SQMDataId.SignInPersistedAccounts, SQMAction.Add, 1);
			s_rgSQMDataPoints[90] = new SQMDataPoint(SQMDataId.RipRecordMode, SQMAction.NumStream, 1);
			s_rgSQMDataPoints[91] = new SQMDataPoint(SQMDataId.AudioCDBurn, SQMAction.Inc, 1);
			s_rgSQMDataPoints[92] = new SQMDataPoint(SQMDataId.DataCDBurn, SQMAction.Inc, 1);
			s_rgSQMDataPoints[93] = new SQMDataPoint(SQMDataId.MonitoredAudioFolders, SQMAction.NumStream, 1);
			s_rgSQMDataPoints[94] = new SQMDataPoint(SQMDataId.MonitoredPhotoFolders, SQMAction.NumStream, 1);
			s_rgSQMDataPoints[95] = new SQMDataPoint(SQMDataId.MonitoredPodcastFolders, SQMAction.NumStream, 1);
			s_rgSQMDataPoints[96] = new SQMDataPoint(SQMDataId.MonitoredVideoFolders, SQMAction.NumStream, 1);
			s_rgSQMDataPoints[97] = new SQMDataPoint(SQMDataId.ErrorEvent, SQMAction.NumStream, 3);
			s_rgSQMDataPoints[98] = new SQMDataPoint(SQMDataId.CollectionClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[99] = new SQMDataPoint(SQMDataId.DeviceClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[100] = new SQMDataPoint(SQMDataId.MarketplaceClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[101] = new SQMDataPoint(SQMDataId.SocialClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[102] = new SQMDataPoint(SQMDataId.DiscClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[103] = new SQMDataPoint(SQMDataId.QuickPlayClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[104] = new SQMDataPoint(SQMDataId.CollectionMusicClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[105] = new SQMDataPoint(SQMDataId.CollectionVideoClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[106] = new SQMDataPoint(SQMDataId.CollectionPicturesClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[107] = new SQMDataPoint(SQMDataId.CollectionPodcastsClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[108] = new SQMDataPoint(SQMDataId.CollectionChannelsClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[109] = new SQMDataPoint(SQMDataId.DeviceStatusClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[110] = new SQMDataPoint(SQMDataId.DeviceMusicClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[111] = new SQMDataPoint(SQMDataId.DeviceVideoClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[112] = new SQMDataPoint(SQMDataId.DevicePicturesClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[113] = new SQMDataPoint(SQMDataId.DevicePodcastsClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[114] = new SQMDataPoint(SQMDataId.DeviceFriendsClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[115] = new SQMDataPoint(SQMDataId.DeviceChannelsClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[116] = new SQMDataPoint(SQMDataId.MarketplaceRecommendationsClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[117] = new SQMDataPoint(SQMDataId.MarketplaceMusicClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[118] = new SQMDataPoint(SQMDataId.MarketplaceVideosClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[119] = new SQMDataPoint(SQMDataId.MarketplacePodcastsClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[120] = new SQMDataPoint(SQMDataId.MarketplaceCartClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[121] = new SQMDataPoint(SQMDataId.MarketplaceChannelsClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[122] = new SQMDataPoint(SQMDataId.TitleBarCartClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[123] = new SQMDataPoint(SQMDataId.MarketplaceDownloadsClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[124] = new SQMDataPoint(SQMDataId.SocialFriendsClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[125] = new SQMDataPoint(SQMDataId.SocialProfileClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[126] = new SQMDataPoint(SQMDataId.SocialInboxClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[127] = new SQMDataPoint(SQMDataId.TitleBarInboxClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[128] = new SQMDataPoint(SQMDataId.DiscTitleClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[129] = new SQMDataPoint(SQMDataId.PlayClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[130] = new SQMDataPoint(SQMDataId.PauseClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[131] = new SQMDataPoint(SQMDataId.StopClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[132] = new SQMDataPoint(SQMDataId.SkipForwardClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[133] = new SQMDataPoint(SQMDataId.SkipBackwardClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[134] = new SQMDataPoint(SQMDataId.RepeatClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[135] = new SQMDataPoint(SQMDataId.ShuffleClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[136] = new SQMDataPoint(SQMDataId.VolumeAdjustmentClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[137] = new SQMDataPoint(SQMDataId.VolumeMuteClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[138] = new SQMDataPoint(SQMDataId.NowPlayingClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[139] = new SQMDataPoint(SQMDataId.NowPlayingEQClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[140] = new SQMDataPoint(SQMDataId.NowPlayingAlbumArtClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[141] = new SQMDataPoint(SQMDataId.SettingsClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[142] = new SQMDataPoint(SQMDataId.HelpClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[143] = new SQMDataPoint(SQMDataId.BackClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[144] = new SQMDataPoint(SQMDataId.DeviceLogoClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[145] = new SQMDataPoint(SQMDataId.DeviceLogoDrops, SQMAction.Inc, 1);
			s_rgSQMDataPoints[146] = new SQMDataPoint(SQMDataId.DiscLogoClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[147] = new SQMDataPoint(SQMDataId.DiscLogoDrops, SQMAction.Inc, 1);
			s_rgSQMDataPoints[148] = new SQMDataPoint(SQMDataId.PlaylistLogoClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[149] = new SQMDataPoint(SQMDataId.PlaylistLogoDrops, SQMAction.Inc, 1);
			s_rgSQMDataPoints[150] = new SQMDataPoint(SQMDataId.ComputerLogoDrops, SQMAction.Inc, 1);
			s_rgSQMDataPoints[151] = new SQMDataPoint(SQMDataId.AutoPlaylistCreations, SQMAction.Inc, 1);
			s_rgSQMDataPoints[152] = new SQMDataPoint(SQMDataId.ArtistViewClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[153] = new SQMDataPoint(SQMDataId.GenreViewClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[154] = new SQMDataPoint(SQMDataId.AlbumViewClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[155] = new SQMDataPoint(SQMDataId.SongViewClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[156] = new SQMDataPoint(SQMDataId.PlaylistViewClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[157] = new SQMDataPoint(SQMDataId.MixViewClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[158] = new SQMDataPoint(SQMDataId.MixViewPlayClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[159] = new SQMDataPoint(SQMDataId.MixViewAddToNowPlayingClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[160] = new SQMDataPoint(SQMDataId.QuickPlayPlays, SQMAction.Inc, 1);
			s_rgSQMDataPoints[161] = new SQMDataPoint(SQMDataId.QuickPlayAsDefaultStarts, SQMAction.Inc, 1);
			s_rgSQMDataPoints[162] = new SQMDataPoint(SQMDataId.QuickPlayAsDefaultSkips, SQMAction.Inc, 1);
			s_rgSQMDataPoints[163] = new SQMDataPoint(SQMDataId.CompactModeOnTopSetting, SQMAction.Inc, 1);
			s_rgSQMDataPoints[164] = new SQMDataPoint(SQMDataId.CompactModeSessions, SQMAction.Inc, 1);
			s_rgSQMDataPoints[165] = new SQMDataPoint(SQMDataId.ToolbarPlayerInstallVista, SQMAction.Inc, 1);
			s_rgSQMDataPoints[166] = new SQMDataPoint(SQMDataId.ToolbarPlayerInstallWin7, SQMAction.Inc, 1);
			s_rgSQMDataPoints[167] = new SQMDataPoint(SQMDataId.ToolbarPlayerInstallXP, SQMAction.Inc, 1);
			s_rgSQMDataPoints[168] = new SQMDataPoint(SQMDataId.LibraryContentTypeAllClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[169] = new SQMDataPoint(SQMDataId.LibraryContentTypePersonalClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[170] = new SQMDataPoint(SQMDataId.LibraryContentTypeProtectedClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[171] = new SQMDataPoint(SQMDataId.LibraryContentTypeZunePassClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[172] = new SQMDataPoint(SQMDataId.TrackPurchaseDownload, SQMAction.Inc, 1);
			s_rgSQMDataPoints[173] = new SQMDataPoint(SQMDataId.TrackSubscriptionDownload, SQMAction.Inc, 1);
			s_rgSQMDataPoints[174] = new SQMDataPoint(SQMDataId.MusicVideoPurchaseDownload, SQMAction.Inc, 1);
			s_rgSQMDataPoints[175] = new SQMDataPoint(SQMDataId.TVEpisodePurchaseDownload, SQMAction.Inc, 1);
			s_rgSQMDataPoints[176] = new SQMDataPoint(SQMDataId.MoviePurchaseDownload, SQMAction.Inc, 1);
			s_rgSQMDataPoints[177] = new SQMDataPoint(SQMDataId.MovieRental, SQMAction.Inc, 1);
			s_rgSQMDataPoints[178] = new SQMDataPoint(SQMDataId.MarketplacePicksClicks, SQMAction.Inc, 1);
			s_rgSQMDataPoints[179] = new SQMDataPoint(SQMDataId.ArtistViewTime, SQMAction.Add, 1);
			s_rgSQMDataPoints[180] = new SQMDataPoint(SQMDataId.SongViewTime, SQMAction.Add, 1);
			s_rgSQMDataPoints[181] = new SQMDataPoint(SQMDataId.AlbumViewTime, SQMAction.Add, 1);
			s_rgSQMDataPoints[182] = new SQMDataPoint(SQMDataId.GenreViewTime, SQMAction.Add, 1);
			s_rgSQMDataPoints[183] = new SQMDataPoint(SQMDataId.PlaylistViewTime, SQMAction.Add, 1);
			s_rgSQMDataPoints[184] = new SQMDataPoint(SQMDataId.MixViewTime, SQMAction.Add, 1);
			s_rgSQMDataPoints[185] = new SQMDataPoint(SQMDataId.NowPlayingViewTime, SQMAction.Add, 1);
			s_rgSQMDataPoints[186] = new SQMDataPoint(SQMDataId.IgnoredErrorEvent, SQMAction.NumStream, 1);
			s_rgSQMDataPoints[187] = new SQMDataPoint(SQMDataId.QuickMixElapsedSecondsDsp, SQMAction.NumStream, 1);
			s_rgSQMDataPoints[188] = new SQMDataPoint(SQMDataId.QuickMixElapsedSecondsMds, SQMAction.NumStream, 2);
			s_rgSQMDataPoints[189] = new SQMDataPoint(SQMDataId.QuickMixElapsedMillisSimilarity, SQMAction.NumStream, 2);
			s_rgSQMDataPoints[190] = new SQMDataPoint(SQMDataId.QuickMixSimilarTracksFound, SQMAction.NumStream, 2);
			s_rgSQMDataPoints[191] = new SQMDataPoint(SQMDataId.QuickMixSessionCount, SQMAction.Inc, 1);
			s_rgSQMDataPoints[192] = new SQMDataPoint(SQMDataId.QuickMixSessionNoResultsCount, SQMAction.Inc, 1);
			s_rgSQMDataPoints[193] = new SQMDataPoint(SQMDataId.QuickMixLocalPlays, SQMAction.Inc, 1);
			s_rgSQMDataPoints[194] = new SQMDataPoint(SQMDataId.QuickMixRadioPlays, SQMAction.Inc, 1);
			s_rgSQMDataPoints[195] = new SQMDataPoint(SQMDataId.QuickMixPlaylistCreates, SQMAction.Inc, 1);
			s_rgSQMDataPoints[196] = new SQMDataPoint(SQMDataId.QuickMixPlaylistPlays, SQMAction.Inc, 1);
			s_rgSQMDataPoints[197] = new SQMDataPoint(SQMDataId.QuickMixUpsell, SQMAction.Inc, 1);
			s_rgSQMDataPoints[198] = new SQMDataPoint(SQMDataId.QuickMixPlaytime, SQMAction.Add, 1);
			s_rgSQMDataPoints[199] = new SQMDataPoint(SQMDataId.QuickMixLocalSkips, SQMAction.Inc, 1);
			s_rgSQMDataPoints[200] = new SQMDataPoint(SQMDataId.QuickMixRemoteSkips, SQMAction.Inc, 1);
			s_rgSQMDataPoints[201] = new SQMDataPoint(SQMDataId.QuickMixTrackPlays, SQMAction.Inc, 1);
			s_rgSQMDataPoints[202] = new SQMDataPoint(SQMDataId.PlaylistAutoRefresh, SQMAction.SetFlag, 1);
			s_rgSQMDataPoints[203] = new SQMDataPoint(SQMDataId.PlaylistLimitType, SQMAction.NumStream, 1);
			s_rgSQMDataPoints[204] = new SQMDataPoint(SQMDataId.PlaylistSongLimitValue, SQMAction.NumStream, 1);
			s_rgSQMDataPoints[205] = new SQMDataPoint(SQMDataId.PlaylistMinuteLimitValue, SQMAction.NumStream, 1);
			s_rgSQMDataPoints[206] = new SQMDataPoint(SQMDataId.PlaylistSubType, SQMAction.NumStream, 1);
			s_rgSQMDataPoints[207] = new SQMDataPoint(SQMDataId.ShipAssert, SQMAction.NumStream, 2);
			s_rgSQMDataPoints[208] = new SQMDataPoint(SQMDataId.CompactModeViewTime, SQMAction.Add, 1);
			s_rgSQMDataPoints[209] = new SQMDataPoint(SQMDataId.NowPlayingMusicViewTime, SQMAction.Add, 1);
			s_rgSQMDataPoints[210] = new SQMDataPoint(SQMDataId.NowPlayingVideoViewTime, SQMAction.Add, 1);
			s_rgSQMDataPoints[211] = new SQMDataPoint(SQMDataId.NowPlayingPhotoViewTime, SQMAction.Add, 1);
			s_rgSQMDataPoints[212] = new SQMDataPoint(SQMDataId.UnlinkedDeviceNagDialogShow, SQMAction.Inc, 1);
			s_rgSQMDataPoints[213] = new SQMDataPoint(SQMDataId.UnlinkedDeviceNagDialogNo, SQMAction.Inc, 1);
			s_rgSQMDataPoints[214] = new SQMDataPoint(SQMDataId.UnlinkedDeviceNagDialogYes, SQMAction.Inc, 1);
			s_rgSQMDataPoints[215] = new SQMDataPoint(SQMDataId.UnlinkedDeviceNagDialogNoShow, SQMAction.Inc, 1);
			s_rgSQMDataPoints[216] = new SQMDataPoint(SQMDataId.PlaySlideshow, SQMAction.Inc, 1);
			s_rgSQMDataPoints[217] = new SQMDataPoint(SQMDataId.DeviceFolder, SQMAction.Inc, 1);
			s_rgSQMDataPoints[218] = new SQMDataPoint(SQMDataId.LaunchMovieMaker, SQMAction.Inc, 1);
			s_rgSQMDataPoints[219] = new SQMDataPoint(SQMDataId.LaunchWLPG, SQMAction.Inc, 1);
			s_rgSQMDataPoints[220] = new SQMDataPoint(SQMDataId.AutoReverseSyncPictures, SQMAction.Add, 1);
			s_rgSQMDataPoints[221] = new SQMDataPoint(SQMDataId.ZuneWin7LibraryOpt, SQMAction.SetFlag, 1);
			s_rgSQMDataPoints[222] = new SQMDataPoint(SQMDataId.OPLPlayUnrestricted, SQMAction.Inc, 1);
			s_rgSQMDataPoints[223] = new SQMDataPoint(SQMDataId.OPLBestEffort, SQMAction.Inc, 1);
			s_rgSQMDataPoints[224] = new SQMDataPoint(SQMDataId.OPLEnforcementSucceeded, SQMAction.Inc, 1);
			s_rgSQMDataPoints[225] = new SQMDataPoint(SQMDataId.OPLDownResOnRestriction, SQMAction.Inc, 1);
			s_rgSQMDataPoints[226] = new SQMDataPoint(SQMDataId.OPLDownResOnFailedEnforce, SQMAction.Inc, 1);
			s_rgSQMDataPoints[227] = new SQMDataPoint(SQMDataId.OPLEnforcementFailed, SQMAction.Inc, 1);
			s_rgSQMDataPoints[228] = new SQMDataPoint(SQMDataId.GdiMode, SQMAction.SetFlag, 1);
			s_sqmDataPointInvalid = new SQMDataPoint(SQMDataId.Invalid, SQMAction.Add, 0);
		}
	}
}
