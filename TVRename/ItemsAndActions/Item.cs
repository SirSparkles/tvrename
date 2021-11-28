//
// Main website for TVRename is http://tvrename.com
//
// Source code available at https://github.com/TV-Rename/tvrename
//
// Copyright (c) TV Rename. This code is released under GPLv3 https://github.com/TV-Rename/tvrename/blob/master/LICENSE.md
//

using JetBrains.Annotations;
using System;

namespace TVRename
{
    public abstract class Item : IComparable // something shown in the list on the Scan tab (not always an Action)
    {
        public abstract string TargetFolder { get; } // return a list of folders for right-click menu
        public abstract string ScanListViewGroup { get; } // which group name for the listview
        public abstract int IconNumber { get; } // which icon number to use in "ilIcons" (UI.cs). -1 for none
        public abstract IgnoreItem? Ignore { get; } // what to add to the ignore list / compare against the ignore list
        public ProcessedEpisode? Episode { get; protected set; } // associated episode
        public MovieConfiguration? Movie { get; protected set; } // associated movie

        public abstract int CompareTo(Item obj); // for sorting items in scan list (ActionItemSorter)

        public abstract bool SameAs(Item o); // are we the same thing as that other one?

        public abstract string Name { get; } // Name of this action, e.g. "Copy", "Move", "Download"

        public ItemMissing? UndoItemMissing; //Item to revert to if we have to cancel this action

        protected static IgnoreItem? GenerateIgnore(string? file) => string.IsNullOrEmpty(file) ? null : new IgnoreItem(file);

        [NotNull]
        public virtual string SeriesName => Episode is null ? Movie?.ShowName ?? string.Empty : UI.GenerateShowUIName(Episode); //UI.GenerateShowUiName(Movie!):UI.GenerateShowUIName(Episode);

        [NotNull]
        public virtual string SeasonNumber => Episode?.SeasonNumberAsText ?? string.Empty;

        [NotNull]
        public virtual string EpisodeString => Episode?.EpNumsAsString() ?? string.Empty;

        public int? EpisodeNumber => Episode?.AppropriateEpNum;

        [NotNull]
        public virtual string AirDateString => Episode?.GetAirDateDt(true).PrettyPrint() ?? Movie?.CachedMovie?.FirstAired.PrettyPrint() ?? string.Empty;

        public DateTime? AirDate => Episode?.GetAirDateDt(true) ?? Movie?.CachedMovie?.FirstAired;
        public abstract string DestinationFolder { get; }
        public abstract string DestinationFile { get; }

        [NotNull]
        public virtual string SourceDetails => string.Empty;

        public string ErrorText { get; protected internal set; } // Human-readable error message, for when Error is true

        public int CompareTo(object obj) => CompareTo((Item)obj);

        public override bool Equals(object obj)
        {
            if (obj is not Item other)
            {
                return false;
            }
            return CompareTo(other) == 0;
        }

        public static bool operator ==([CanBeNull] Item left, [CanBeNull] Item right)
        {
            if (left is null)
            {
                return right is null;
            }
            return left.Equals(right);
        }
        public static bool operator !=([CanBeNull] Item left, [CanBeNull] Item right)
        {
            return !(left == right);
        }
        public static bool operator <(Item left, Item right)
        {
            return Compare(left, right) < 0;
        }
        public static bool operator >(Item left, Item right)
        {
            return Compare(left, right) > 0;
        }
        public static int Compare(Item left, Item right)
        {
            if (ReferenceEquals(left, right))
            {
                return 0;
            }
            if (left is null)
            {
                return -1;
            }
            return left.CompareTo(right);
        }
    }
}
