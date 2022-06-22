namespace TVRename
{
    internal abstract class MovieCheck : SettingsCheck
    {
        public readonly MovieConfiguration Movie;

        protected MovieCheck(MovieConfiguration movie, TVDoc doc) : base(doc)
        {
            Movie = movie;
        }

        protected override void MarkMediaDirty()
        {
            if (Movie.CachedMovie == null)
            {
                return;
            }

            Movie.CachedMovie.Dirty = true;
            Doc.MoviesAddedOrEdited(false,true,true,null, Movie);
        }

        public override MediaConfiguration.MediaType Type() => MediaConfiguration.MediaType.movie;

        public override string MediaName => Movie.ShowName;

        public sealed override string CheckName => "[Movie] " + MovieCheckName;

        protected abstract string MovieCheckName { get; }
    }
}
