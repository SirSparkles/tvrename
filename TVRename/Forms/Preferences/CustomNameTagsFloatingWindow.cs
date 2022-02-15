//
// Main website for TVRename is http://tvrename.com
//
// Source code available at https://github.com/TV-Rename/tvrename
//
// Copyright (c) TV Rename. This code is released under GPLv3 https://github.com/TV-Rename/tvrename/blob/master/LICENSE.md
//
using System.Windows.Forms;

namespace TVRename
{
    /// <summary>
    /// Summary for CustomNameTagsFloatingWindow
    ///
    /// WARNING: If you change the name of this class, you will need to change the
    ///          'Resource File Name' property for the managed resource compiler tool
    ///          associated with all .resx files this class depends on.  Otherwise,
    ///          the designers will not be able to interact properly with localized
    ///          resources associated with this form.
    /// </summary>
    public partial class CustomNameTagsFloatingWindow : Form
    {
        public CustomNameTagsFloatingWindow(ProcessedEpisode? pe)
        {
            InitializeComponent();

            foreach (string s in CustomEpisodeName.TAGS)
            {
                string txt = s;
                if (pe != null)
                {
                    txt += " - " + CustomEpisodeName.NameForNoExt(pe, s);
                }

                label1.Text += txt + "\r\n";
            }
        }

        public CustomNameTagsFloatingWindow(ProcessedSeason? pe)
        {
            InitializeComponent();

            foreach (string s in CustomSeasonName.TAGS)
            {
                string txt = s;
                if (pe != null)
                {
                    txt += " - " + CustomSeasonName.NameFor(pe, s);
                }

                label1.Text += txt + "\r\n";
            }
        }

        public CustomNameTagsFloatingWindow(MovieConfiguration? movie)
        {
            InitializeComponent();

            foreach (string s in CustomMovieName.TAGS)
            {
                string txt = s;
                if (movie != null)
                {
                    txt += " - " + CustomMovieName.NameFor(movie, s);
                }

                label1.Text += txt + "\r\n";
            }
        }

        public CustomNameTagsFloatingWindow(ShowConfiguration? tvShow)
        {
            InitializeComponent();

            foreach (string s in CustomTvShowName.TAGS)
            {
                string txt = s;
                if (tvShow != null)
                {
                    txt += " - " + CustomTvShowName.NameFor(tvShow, s);
                }

                label1.Text += txt + "\r\n";
            }
        }
    }
}
