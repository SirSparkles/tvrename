//
// Main website for TVRename is http://tvrename.com
//
// Source code available at https://github.com/TV-Rename/tvrename
//
// Copyright (c) TV Rename. This code is released under GPLv3 https://github.com/TV-Rename/tvrename/blob/master/LICENSE.md
//

using NodaTime;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace TVRename;

public class ProcessedSeason
{
    protected static readonly NLog.Logger LOGGER = NLog.LogManager.GetCurrentClassLogger();
    public enum SeasonStatus
    {
        aired, // Season completely aired ... no further shows in this season scheduled to date
        partiallyAired, // Season partially aired ... there are further shows in this season which are unaired to date
        noneAired, // Season completely unaired ... no show of this season as aired yet
        noEpisodes
    }

    public enum SeasonType
    {
        dvd,
        aired,
        absolute,
        alternate
    }

    public readonly ConcurrentDictionary<int, Episode> Episodes;
    public readonly int SeasonId;
    public readonly int SeasonNumber;
    public readonly ShowConfiguration Show;

    // ReSharper disable once NotAccessedField.Local
    public readonly SeasonType SeasonStyle;

    public ProcessedSeason(ShowConfiguration theShow, int number, int seasonId, SeasonType t)
    {
        Show = theShow;
        SeasonNumber = number;
        SeasonId = seasonId;
        Episodes = new ConcurrentDictionary<int, Episode>();
        SeasonStyle = t;
    }

    // ReSharper disable once InconsistentNaming
    public static string UISeasonWord(int season)
    {
        if (TVSettings.Instance.defaultSeasonWord.Length > 1 && TVSettings.Instance.LeadingZeroOnSeason)
        {
            return TVSettings.Instance.defaultSeasonWord + " " + season.ToString("00");
        }

        if (TVSettings.Instance.defaultSeasonWord.Length > 1)
        {
            return TVSettings.Instance.defaultSeasonWord + " " + season;
        }

        if (TVSettings.Instance.LeadingZeroOnSeason)
        {
            return TVSettings.Instance.defaultSeasonWord + season.ToString("00");
        }

        return TVSettings.Instance.defaultSeasonWord + season;
    }

    // ReSharper disable once InconsistentNaming
    public static string UIFullSeasonWord(int snum)
    {
        return snum == 0
            ? TVSettings.Instance.SpecialsFolderName
            : UISeasonWord(snum);
    }

    public SeasonStatus Status(DateTimeZone tz)
    {
        if (!HasEpisodes)
        {
            return SeasonStatus.noEpisodes;
        }

        if (HasAiredEpisodes(tz) && !HasUnairedEpisodes(tz))
        {
            return SeasonStatus.aired;
        }

        if (HasAiredEpisodes(tz) && HasUnairedEpisodes(tz))
        {
            return SeasonStatus.partiallyAired;
        }

        if (!HasAiredEpisodes(tz) && HasUnairedEpisodes(tz))
        {
            return SeasonStatus.noneAired;
        }

        // Can happen if a Season has Episodes WITHOUT Airdates.
        return SeasonStatus.noEpisodes;
    }

    internal int MinYear()
    {
        return Episodes.Values
            .Select(e => e.Year)
            .Where(adt => adt.HasValue)
            .MinOrDefault(adt => adt!.Value, 9999);
    }

    internal int MaxYear()
    {
        return Episodes.Values
            .Select(e => e.Year)
            .Where(adt => adt.HasValue)
            .MaxOrDefault(adt => adt!.Value, 0);
    }

    private bool HasEpisodes => !Episodes.IsEmpty;

    public int SeasonIndex => Show.GetSeasonIndex(SeasonNumber);

    private bool HasUnairedEpisodes(DateTimeZone tz)
    {
        if (!HasEpisodes)
        {
            return false;
        }

        foreach (Episode e in Episodes.Values)
        {
            DateTime? adt = e.GetAirDateDt(tz);
            if (!adt.HasValue)
            {
                continue;
            }

            DateTime airDateTime = adt.Value;
            if (airDateTime > DateTime.Now)
            {
                return true;
            }
        }

        return false;
    }

    private bool HasAiredEpisodes(DateTimeZone tz)
    {
        if (!HasEpisodes)
        {
            return false;
        }

        foreach (Episode e in Episodes.Values)
        {
            DateTime? adt = e.GetAirDateDt(tz);
            if (!adt.HasValue)
            {
                continue;
            }

            DateTime airDateTime = adt.Value;
            if (airDateTime < DateTime.Now)
            {
                return true;
            }
        }

        return false;
    }

    public DateTime? LastAiredDate()
    {
        DateTime? returnValue = null;
        foreach (DateTime episodeAirDate in Episodes.Values.Select(a => a.FirstAired)
                     .Where(episodeAirDate => episodeAirDate.HasValue)
                     .Select(epis=> epis!.Value)
                     .Where(episodeAirDate =>
                         DateTime.Compare(episodeAirDate.ToUniversalTime(), TimeHelpers.UtcNow()) <= 0))
        {
            //If we don't have a best offer yet
            if (!returnValue.HasValue)
            {
                returnValue = episodeAirDate;
            }
            //else the currently tested date is better than the current value
            else if (DateTime.Compare(episodeAirDate, returnValue.Value) > 0)
            {
                returnValue = episodeAirDate;
            }
        }

        return returnValue;
    }

    public string? GetBannerPath() => Show.CachedShow?.GetSeasonBannerPath(SeasonNumber);

    public string? GetWideBannerPath() => Show.CachedShow?.GetSeasonWideBannerPath(SeasonNumber);

    public void AddUpdateEpisode(Episode newEpisode)
    {
        try
        {
            Episodes.AddOrUpdate(newEpisode.EpisodeId, newEpisode, (_, _) => newEpisode);
        }
        catch (OverflowException ex)
        {
            LOGGER.Warn($"Could not add {newEpisode.EpisodeId} to the list of episodes for season {this.SeasonNumber}, so ignoring for now. If this happens consistenly contact the developer", ex);
        }
    }

    public bool ContainsEpisode(int episodeNumber, SeasonType order)
    {
        return Episodes.Values.Any(ep => ep.GetEpisodeNumber(order) == episodeNumber);
    }

    public void RemoveEpisode(int episodeId)
    {
        if (Episodes.ContainsKey(episodeId))
        {
            Episodes.TryRemove(episodeId, out _);
        }
    }

    public bool IsSpecial => SeasonNumber == 0;

    // ReSharper disable once InconsistentNaming
    public string TVDBWebsiteUrl => TheTVDB.API.WebsiteSeasonUrl(this);

    public string? WebsiteUrl
    {
        get
        {
            if (Show.Provider == TVDoc.ProviderType.TheTVDB)
            {
                return TVDBWebsiteUrl;
            }

            return Show.CachedShow?.Season(SeasonNumber)?.Url;
        }
    }

    public bool NextEpisodeIs(int episodeNumber, SeasonType order)
    {
        int maxEpNum = Episodes.Values.MaxOrDefault(ep => ep.GetEpisodeNumber(order), 0);

        return episodeNumber == maxEpNum + 1;
    }

    public IEnumerable<ShowImage>? Images(MediaImage.ImageType t, MediaImage.ImageSubject s) => Show.CachedShow?.Images(t, s, SeasonNumber);

    public IEnumerable<ShowImage>? Images(MediaImage.ImageType t) => Show.CachedShow?.Images(t);
}
