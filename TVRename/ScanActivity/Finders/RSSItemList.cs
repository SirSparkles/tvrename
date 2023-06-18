//
// Main website for TVRename is http://tvrename.com
//
// Source code available at https://github.com/TV-Rename/tvrename
//
// Copyright (c) TV Rename. This code is released under GPLv3 https://github.com/TV-Rename/tvrename/blob/master/LICENSE.md
//

using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;

namespace TVRename;

internal class RssItemList : List<RSSItem>
{
    private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

    // ReSharper disable once InconsistentNaming
    public bool DownloadRSS(string url, bool useCloudflareProtection, string sourcePrefix)
    {
        string? response = null;

        try
        {
            try
            {
                response = HttpHelper.GetUrl(url, useCloudflareProtection);
            }
            catch (InvalidOperationException ioe)
            {
                Logger.Warn($"Could not download RSS page at:{url} Message was: {ioe.Message}");
                return false;
            }

            using StringReader stringReader = new(response);
            XElement x = XElement.Load(stringReader);

            if (x.Name.LocalName != "rss")
            {
                return false;
            }

            if (!ReadChannel(x.Descendants("channel").First(), url, sourcePrefix))
            {
                return false;
            }
        }
        catch (WebException e)
        {
            Logger.LogWebException($"Could not download RSS page at: {url} got the following message:", e);
            return false;
        }
        catch (XmlException e)
        {
            Logger.Warn($"Could not parse RSS page at:{url} Message was: {e.Message}");
            Logger.Info(response);
            return false;
        }
        catch (AggregateException ex) when (ex.InnerException is WebException wex)
        {
            Logger.LogWebException($"Could not download RSS page at: {url} got the following message: ", wex);
            return false;
        }
        catch (AggregateException ex) when (ex.InnerException is System.Net.Http.HttpRequestException hex)
        {
            Logger.LogHttpRequestException($"Could not download RSS page at: {url} got the following message: ", hex);
            return false;
        }
        catch (Exception e)
        {
            Logger.Error(e, $"Could not parse RSS page at:{url}");
            return false;
        }

        return true;
    }

    private bool ReadChannel(XContainer x, string sourceUrl, string sourcePrefix) => x.Descendants("item").All(element => ReadItem(element, sourceUrl, sourcePrefix));

    private bool ReadItem(XElement itemElement, string sourceUrl, string sourcePrefix)
    {
        string title = itemElement.ExtractString("title");
        string link = itemElement.ExtractString("link");
        string description = itemElement.ExtractString("description");
        string? enclosureLink = itemElement.Descendants("enclosure").FirstOrDefault(enclosure => enclosure.Attribute("type")?.Value == "application/x-bittorrent")?.Attribute("url")?.Value;
        int seeders = GetSeeders(itemElement);
        long size = itemElement.ExtractLong("size", 0);
        string source = itemElement.ExtractString("jackettindexer", sourceUrl);

        if (TVSettings.Instance.DetailedRSSJSONLogging)
        {
            Logger.Info("Processing RSS Item");
            Logger.Info(itemElement.ToString);
            Logger.Info("Extracted");
            Logger.Info($"Title:       {title}");
            Logger.Info($"Link:        {link}");
            Logger.Info($"Description: {description}");
            Logger.Info($"encLink:     {enclosureLink}");
            Logger.Info($"Seeders:     {seeders}");
            Logger.Info($"Size:        {size}");
            Logger.Info($"Source:      {source}");
        }

        link = string.IsNullOrWhiteSpace(enclosureLink) ? link : enclosureLink;

        if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(link))
        {
            return false;
        }

        string showName = string.Empty;

        FinderHelper.FindSeasEp(title, out int season, out int episode, out int _, null);

        if (TVSettings.Instance.DetailedRSSJSONLogging)
        {
            Logger.Info($"Season:      {season}");
            Logger.Info($"Episode:     {episode}");
        }

        try
        {
            Match m = Regex.Match(description, "Show Name: (.*?)[;|$]", RegexOptions.IgnoreCase);
            if (m.Success)
            {
                showName = m.Groups[1].ToString();
            }

            m = Regex.Match(description, "Season: ([0-9]+)", RegexOptions.IgnoreCase);
            if (m.Success)
            {
                season = int.Parse(m.Groups[1].ToString());
            }

            m = Regex.Match(description, "Episode: ([0-9]+)", RegexOptions.IgnoreCase);
            if (m.Success)
            {
                episode = int.Parse(m.Groups[1].ToString());
            }
        }
        catch
        {
            // ignored
        }

        if (TVSettings.Instance.DetailedRSSJSONLogging)
        {
            Logger.Info($"Show Name:   {showName}");
            Logger.Info($"Season:      {season}");
            Logger.Info($"Episode:     {episode}");
        }

        if (season != -1 && episode != -1)
        {
            Add(new RSSItem(link, title, season, episode, showName, seeders, size, $"{sourcePrefix}: {source}"));
        }

        return true;
    }

    private static int GetSeeders(XContainer itemElement)
    {
        return itemElement
            .Descendants()
            .Where(element => element.Name.LocalName == "attr")
            .Where(IsSeederElement)
            .Select(GetSeederValue)
            .FirstOrDefault();
    }

    private static int GetSeederValue(XElement element)
    {
        foreach (string seedersAsString in from att in element.Attributes() where att.Name == "value" select att.Value)
        {
            bool success = int.TryParse(seedersAsString, out int returnValue);
            if (success)
            {
                return returnValue;
            }
        }

        return 0;
    }

    private static bool IsSeederElement(XElement element)
    {
        return element.Attributes().Any(att => att.Name == "name" && att.Value == "seeders");
    }
}
