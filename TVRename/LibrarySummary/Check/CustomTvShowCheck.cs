using JetBrains.Annotations;

namespace TVRename
{
    internal abstract class CustomTvShowCheck : TvShowCheck
    {
        protected CustomTvShowCheck([NotNull] ShowConfiguration show, TVDoc doc) : base(show, doc)
        {
        }

        [NotNull]
        public override string CheckName => "[TV] " + FieldName;
        protected abstract string FieldName { get; }
        protected abstract bool Field { get; }

        public override bool Check()
        {
            return Field;
        }

        [NotNull]
        public override string Explain()
        {
            return $"{FieldName} is enabled for this TV Show, by default is is not.";
        }
    }
}
