using JetBrains.Annotations;

namespace TVRename
{
    internal class CustomRegionTvShowCheck : CustomTvShowCheck
    {
        public CustomRegionTvShowCheck([NotNull] ShowConfiguration show, TVDoc doc) : base(show, doc)
        {
        }

        protected override void FixInternal()
        {
            Show.UseCustomRegion = false;
        }

        [NotNull]
        protected override string FieldName => "Use Custom Region";
        protected override bool Field => Show.UseCustomRegion;
    }
}
