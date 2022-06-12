//
// Main website for TVRename is http://tvrename.com
//
// Source code available at https://github.com/TV-Rename/tvrename
//
// Copyright (c) TV Rename. This code is released under GPLv3 https://github.com/TV-Rename/tvrename/blob/master/LICENSE.md
//

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using JetBrains.Annotations;
using Alphaleonis.Win32.Filesystem;

namespace TVRename
{
    public partial class LinkMovie : Form
    {
        private readonly FileInfo chosenFile;
        public MovieConfiguration? ChosenShow;

        public LinkMovie([NotNull] List<MovieConfiguration> matchingShows, [NotNull] FileInfo file)
        {
            InitializeComponent();
            lblSourceFileName.Text = file.FullName.ToUiVersion();
            chosenFile = file;
            DialogResult = DialogResult.Abort;
            foreach (MovieConfiguration movie in matchingShows)
            {
                cbShows.Items.Add(movie);
            }

            cbShows.SelectedIndex = 0;
            cbShows.DisplayMember = "ShowNameWithYear";
        }

        private void lnkOpenLeftFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Helpers.OpenFolderSelectFile(chosenFile.FullName);
        }

        private void btnUseSelectedMovie_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            ChosenShow = (MovieConfiguration)cbShows.SelectedItem;
            Close();
        }

        private void Ignore_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Close();
        }

        private void btnNewMovie_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
