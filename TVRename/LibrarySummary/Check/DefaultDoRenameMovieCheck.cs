namespace TVRename;

internal class DefaultDoRenameMovieCheck : DefaultMovieCheck
{
    public DefaultDoRenameMovieCheck(MovieConfiguration movie, TVDoc doc) : base(movie, doc)
    {
    }

    protected override string FieldName => "Rename Check";

    protected override bool Field => Movie.DoRename;

    protected override bool Default => TVSettings.Instance.DefMovieDoRenaming;

    protected override void FixInternal()
    {
        Movie.DoRename = Default;
    }
}
