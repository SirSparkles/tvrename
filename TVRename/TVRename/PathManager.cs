//
// Main website for TVRename is http://tvrename.com
//
// Source code available at https://github.com/TV-Rename/tvrename
//
// Copyright (c) TV Rename. This code is released under GPLv3 https://github.com/TV-Rename/tvrename/blob/master/LICENSE.md
//
using Alphaleonis.Win32.Filesystem;
using System;

namespace TVRename;

public static class PathManager
{
    private const string TVDB_FILE_NAME = "TheTVDB.xml";
    private const string TVMAZE_FILE_NAME = "TVmaze.xml";
    private const string TMDB_FILE_NAME = "TMDB.xml";
    private const string SETTINGS_FILE_NAME = "TVRenameSettings.xml";
    private const string UI_LAYOUT_FILE_NAME = "Layout.xml";
    private const string STATISTICS_FILE_NAME = "Statistics.xml";
    private const string STATE_FILE_NAME = "State.xml";

    private static string? UserDefinedBasePath;

    public static FileInfo[] GetPossibleSettingsHistory() => new DirectoryInfo(System.IO.Path.GetDirectoryName(TVDocSettingsFile.FullName)).GetFiles(SETTINGS_FILE_NAME + "*");

    public static FileInfo[] GetPossibleTvdbHistory() => new DirectoryInfo(System.IO.Path.GetDirectoryName(TVDocSettingsFile.FullName)).GetFiles(TVDB_FILE_NAME + "*");

    public static FileInfo[] GetPossibleTvMazeHistory() => new DirectoryInfo(System.IO.Path.GetDirectoryName(TVDocSettingsFile.FullName)).GetFiles(TVMAZE_FILE_NAME + "*");

    public static FileInfo[] GetPossibleTmdbHistory() => new DirectoryInfo(System.IO.Path.GetDirectoryName(TVDocSettingsFile.FullName)).GetFiles(TMDB_FILE_NAME + "*");

    public static void SetUserDefinedBasePath(string path)
    {
        if (string.IsNullOrEmpty(path))
        {
            throw new ArgumentNullException(nameof(path));
        }
        if (System.IO.File.Exists(path))
        {
            throw new ArgumentException($"File at {path} does not exist",nameof(path));
        }
        path = System.IO.Path.GetFullPath(path); // Get absolute path, in case the given path was a relative one. This will make the Path absolute depending on the Environment.CurrentDirectory.
        // Why are we getting a absolute path here ? Simply because it is not guaranteed that the Environment.CurrentDirectory will not change a some point during runtime and then all bets are off were the Files are going to be saved, which would be fatal to the data integrity.(Saved changes might go to some file nobody even knew about )
        if (!System.IO.Directory.Exists(path))
        {
            System.IO.Directory.CreateDirectory(path);
        }
        UserDefinedBasePath = path;
    }

    private static FileInfo GetFileInfo(string file)
    {
        string path = UserDefinedBasePath.HasValue()
            ? UserDefinedBasePath
            : Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TVRename",
                "TVRename", "2.1");
        Directory.CreateDirectory(path);
        return new FileInfo(System.IO.Path.Combine(path, file));
    }

    public static FileInfo StateFile => GetFileInfo(STATE_FILE_NAME);

    public static FileInfo StatisticsFile => GetFileInfo(STATISTICS_FILE_NAME);

    // ReSharper disable once InconsistentNaming
    public static FileInfo UILayoutFile => GetFileInfo(UI_LAYOUT_FILE_NAME);

    // ReSharper disable once InconsistentNaming
    public static FileInfo TVDBFile => GetFileInfo(TVDB_FILE_NAME);

    // ReSharper disable once InconsistentNaming
    public static FileInfo TVmazeFile => GetFileInfo(TVMAZE_FILE_NAME);

    public static FileInfo TmdbFile => GetFileInfo(TMDB_FILE_NAME);

    // ReSharper disable once InconsistentNaming
    public static FileInfo TVDocSettingsFile => GetFileInfo(SETTINGS_FILE_NAME);

    public static string CefCachePath
    {
        get
        {
            {
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TVRename", "cache");
                Directory.CreateDirectory(path);
                return path;
            }
        }
    }
    public static string CefLogFile
    {
        get
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TVRename", "log");
            Directory.CreateDirectory(path);
            return Path.Combine(path, "cef-debug.log");
        }
    }
    public static string AuditLogFile(string postfix)
    {
        string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TVRename", "audit");
        Directory.CreateDirectory(path);
        return Path.Combine(path, $"Updates{postfix}.json");
    }
}
