using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TVRename;

/// <summary>
/// Parse and store command line arguments.
/// </summary>
public class CommandLineArgs
{
    /// <summary>
    /// Actions to perform when a missing folder is found.
    /// </summary>
    public enum MissingFolderBehavior
    {
        ask,
        ignore,
        create
    }

    public bool Hide { get; }
    public MissingFolderBehavior MissingFolder { get; private set; }
    public bool RenameCheck { get; }
    public bool Quit { get; }
    public bool ForceRecover { get; }
    public bool Scan { get; }
    public bool Save { get; }
    public bool QuickScan { get; }
    public bool RecentScan { get; }
    public bool DoAll { get; }
    public bool ForceRefresh { get; }
    public bool ForceUpdate { get; }
    public bool Unattended { get; }
    public bool QuickUpdate { get; }
    public bool Export { get; }
    public string? UserFilePath { get; }

    private MissingFolderBehavior previousMissingFolderBehavior;

    /// <summary>
    /// Initializes a new instance populated with values parsed from the command line arguments.
    /// </summary>
    /// <param name="args">The command line arguments.</param>
    public CommandLineArgs(IReadOnlyCollection<string> args)
    {
        Hide = args.Contains("/hide", StringComparer.OrdinalIgnoreCase);
        RenameCheck = !args.Contains("/norenamecheck", StringComparer.OrdinalIgnoreCase);
        Quit = args.Contains("/quit", StringComparer.OrdinalIgnoreCase);
        ForceRecover = args.Contains("/recover", StringComparer.OrdinalIgnoreCase);
        DoAll = args.Contains("/doall", StringComparer.OrdinalIgnoreCase);
        Scan = args.Contains("/scan", StringComparer.OrdinalIgnoreCase);
        QuickScan = args.Contains("/quickscan", StringComparer.OrdinalIgnoreCase);
        RecentScan = args.Contains("/recentscan", StringComparer.OrdinalIgnoreCase);
        Unattended = args.Contains("/unattended", StringComparer.OrdinalIgnoreCase);
        ForceRefresh = args.Contains("/forcerefresh", StringComparer.OrdinalIgnoreCase);
        ForceUpdate = args.Contains("/forceupdate", StringComparer.OrdinalIgnoreCase);
        QuickUpdate = args.Contains("/quickupdate", StringComparer.OrdinalIgnoreCase);
        Export = args.Contains("/export", StringComparer.OrdinalIgnoreCase);

        Save = args.Contains("/save", StringComparer.OrdinalIgnoreCase);

        UserFilePath = args.Where(a => a.StartsWith("/userfilepath:", StringComparison.OrdinalIgnoreCase)).Select(a => a.Substring(a.IndexOf(":", StringComparison.Ordinal) + 1)).FirstOrDefault();

        MissingFolder = DecodeMissingFolderType(args);
    }

    private static MissingFolderBehavior DecodeMissingFolderType(IReadOnlyCollection<string> args)
    {
        if (args.Contains("/createmissing", StringComparer.OrdinalIgnoreCase))
        {
            return MissingFolderBehavior.create;
        }
        if (args.Contains("/ignoremissing", StringComparer.OrdinalIgnoreCase))
        {
            return MissingFolderBehavior.ignore;
        }
        return MissingFolderBehavior.ask;
    }

    public static string Helptext()
    {
        StringBuilder output = new();
        output.AppendLine();
        output.AppendLine("/forcerefresh will refresh all TVDB, TMDB and TV Maze information");
        output.AppendLine("/forceupdate will verify TVDB & TMDB information is up to date");
        output.AppendLine("/quickupdate will do a quick update from TVDB, TMDB and TV Maze");
        output.AppendLine("/scan will Tell TV Rename to run a full scan");
        output.AppendLine("/quickscan will scan shows most likely to need an update: http://www.tvrename.com/userguide#scan");
        output.AppendLine("/recentscan will scan recent shows: http://www.tvrename.com/userguide#scan");
        output.AppendLine("/doall Tell TV Rename execute all the actions it can.");
        output.AppendLine("/export Tell TV Rename do any configured exports.");
        output.AppendLine("/quit Tell a running TV Rename session to exit.");
        output.AppendLine("/save Tell a running TV Rename session to save its caches.");
        output.AppendLine("");
        output.AppendLine("/hide will hide the UI for all UI elements");
        output.AppendLine("/unattended will hide the UI for all blocking UI elements");
        output.AppendLine("");
        output.AppendLine("/recover will load a dialog box that enables the user to recover a prior TVDB.xml or TVRenameSettings.xml file");
        output.AppendLine("/userfilepath:BLAH  Sets a custom folder path for the settings files.");
        output.AppendLine("/createmissing will Create folders if they are missing.");
        output.AppendLine("/ignoremissing will Ignore missing folders.");
        output.AppendLine("/norenamecheck requests an existing TV Rename session to scan without renaming.");
        output.AppendLine("");
        output.AppendLine("Further information is available at https://www.tvrename.com/manual/cmd-line/");

        return output.ToString();
    }

    public void RevertFromTempUse()
    {
        MissingFolder = previousMissingFolderBehavior;
    }

    public void TemporarilyUse(CommandLineArgs localArgs)
    {
        // Temporarily override behavior for missing folders
        previousMissingFolderBehavior = MissingFolder;

        if (localArgs.MissingFolder != MissingFolderBehavior.ask)
        {
            // Temporarily override behavior for missing folders
            MissingFolder = localArgs.MissingFolder;
        }
    }
}
