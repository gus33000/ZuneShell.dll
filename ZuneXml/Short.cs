﻿// Decompiled with JetBrains decompiler
// Type: ZuneXml.Short
// Assembly: ZuneShell, Version=4.7.0.0, Culture=neutral, PublicKeyToken=ddd0da4d3e678217
// MVID: FC8028F3-A47B-4FB4-B35B-11D1752D8264
// Assembly location: C:\Program Files\Zune\ZuneShell.dll

using Microsoft.Iris;
using System;

namespace ZuneXml
{
    internal class Short : TVVideo
    {
        internal static XmlDataProviderObject ConstructShortObject(
          DataProviderQuery owner,
          object objectTypeCookie)
        {
            return new Short(owner, objectTypeCookie);
        }

        internal Short(DataProviderQuery owner, object resultTypeCookie)
          : base(owner, resultTypeCookie)
        {
        }

        internal Guid BackgroundImageId => (Guid)base.GetProperty(nameof(BackgroundImageId));

        internal override Guid Id => (Guid)base.GetProperty(nameof(Id));

        internal override string Title => (string)base.GetProperty(nameof(Title));

        internal override string SortTitle => (string)base.GetProperty(nameof(SortTitle));

        internal override string Description => (string)base.GetProperty(nameof(Description));

        internal override DateTime ReleaseDate => (DateTime)base.GetProperty(nameof(ReleaseDate));

        internal override string Copyright => (string)base.GetProperty(nameof(Copyright));

        internal override string Rating => (string)base.GetProperty(nameof(Rating));

        internal override TimeSpan Duration => (TimeSpan)base.GetProperty(nameof(Duration));

        internal override string ProductionCompany => (string)base.GetProperty(nameof(ProductionCompany));

        internal override Guid ImageId => (Guid)base.GetProperty(nameof(ImageId));

        internal override MediaRights Rights => (MediaRights)base.GetProperty(nameof(Rights));

        internal override Network Network => (Network)base.GetProperty(nameof(Network));

        internal override double Popularity => (double)base.GetProperty(nameof(Popularity));

        public override object GetProperty(string propertyName)
        {
            switch (propertyName)
            {
                case "PointsPrice":
                    return PointsPrice;
                case "HasPreview":
                    return HasPreview;
                case "CanPreview":
                    return CanPreview;
                case "CanSubscriptionPlay":
                    return CanSubscriptionPlay;
                case "CanPurchase":
                    return CanPurchase;
                case "CanPurchaseHD":
                    return CanPurchaseHD;
                case "CanPurchaseSD":
                    return CanPurchaseSD;
                case "CanPurchaseSeason":
                    return CanPurchaseSeason;
                case "CanPurchaseSeasonHD":
                    return CanPurchaseSeasonHD;
                case "CanPurchaseSeasonSD":
                    return CanPurchaseSeasonSD;
                case "CanRent":
                    return CanRent;
                case "CanRentHD":
                    return CanRentHD;
                case "CanRentSD":
                    return CanRentSD;
                case "CanPurchaseAlbumOnly":
                    return CanPurchaseAlbumOnly;
                case "CanSync":
                    return CanSync;
                case "InCollection":
                    return InCollection;
                case "InCollectionShortcut":
                    return InCollectionShortcut;
                case "IsDownloading":
                    return IsDownloading;
                case "IsParentallyBlocked":
                    return IsParentallyBlocked;
                case "PrimaryArtist":
                    return PrimaryArtist;
                case "Artists":
                    return Artists;
                default:
                    return base.GetProperty(propertyName);
            }
        }
    }
}
