using System;
using System.Collections.Generic;
using System.Linq;
using Alphaleonis.Win32.Filesystem;

namespace TVRename;

internal class SubdirectoryMovieCheck : MovieCheck
{
    public SubdirectoryMovieCheck(MovieConfiguration movie, TVDoc doc) : base(movie, doc)
    {
    }

    public override bool Check() => Movie.UseCustomFolderNameFormat;

    public override string Explain() => $"This movie does not use the standard folder naming format '{TVSettings.Instance.MovieFolderFormat}', it uses '{Movie.CustomFolderNameFormat}'";

    protected override void FixInternal()
    {
        List<string> currentLocations = Movie.AutomaticLocations().ToList();
        string newLocation = Movie.AutomaticFolderRoot.EnsureEndsWithSeparator() + CustomMovieName.DirectoryNameFor(Movie, TVSettings.Instance.MovieFolderFormat);

        Movie.UseCustomFolderNameFormat = false;

        if (!currentLocations.Any())
        {
            return;
        }
        string message = $"Could not move files for {Movie.ShowName}. Would have liked to move files from [{currentLocations.ToCsv()}] to '{newLocation}'";

        if (currentLocations.Count > 1)
        {
            LOGGER.Warn($"{message}, but there are more than one source. ");
            return;
        }

        string currentLocation = currentLocations.Single();
        if (currentLocation == newLocation)
        {
            //Nothing to do
            return;
        }

        LOGGER.Info($"Moving files from '{currentLocations.Single()}' to '{newLocation}'");

        if (Directory.Exists(newLocation))
        {
            LOGGER.Warn($"{message}, but that directory already exists.");
            return;
        }

        try
        {
            Directory.Move(currentLocations.Single(), newLocation);
        }
        catch (UnauthorizedAccessException uae)
        {
            throw new FixCheckException(message + ": " + uae.Message);
        }
        catch (System.IO.DirectoryNotFoundException)
        {
            //the source was not present anyway, so do nothing
        }
        catch (System.IO.PathTooLongException ptle)
        {
            throw new FixCheckException(message + ": " + ptle.Message);
        }
    }

    protected override string MovieCheckName => "Use custom folder name format";
}
