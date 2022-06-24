//
// Main website for TVRename is http://tvrename.com
//
// Source code available at https://github.com/TV-Rename/tvrename
//
// Copyright (c) TV Rename. This code is released under GPLv3 https://github.com/TV-Rename/tvrename/blob/master/LICENSE.md
//

using System.Drawing;

namespace TVRename;

using System;
using System.Windows.Forms;

public partial class BulkAddEditShow : Form
{
    public int Code;

    private readonly CodeFinder codeFinderControl;
    public TVDoc.ProviderType ProviderType => codeFinderControl.Source;

    public BulkAddEditShow(PossibleNewTvShow hint)
    {
        codeFinderControl = new TvCodeFinder("", TVSettings.Instance.DefaultProvider) { Dock = DockStyle.Fill };
        InitializeComponent();

        codeFinderControl.SelectionChanged += CodeChanged;
        codeFinderControl.lvMatches.DoubleClick += MatchDoubleClick;
        label1.Text = $"Search for {TVSettings.Instance.DefaultProvider.PrettyPrint()} entry, by partial name or ID:";

        pnlCF.SuspendLayout();
        pnlCF.Controls.Add(codeFinderControl);
        pnlCF.ResumeLayout();

        if (hint.CodeKnown)
        {
            codeFinderControl.SetHint(hint.ProviderCode.ToString(), hint.Provider);
        }
        else
        {
            string s = hint.Folder.FullName;
            int p = s.LastIndexOf(System.IO.Path.DirectorySeparatorChar);
            codeFinderControl.SetHint(string.IsNullOrWhiteSpace(hint.RefinedHint)
                ? s.Substring(p + 1)
                : hint.RefinedHint, TVDoc.ProviderType.libraryDefault);
        }
        Code = -1;
    }
    protected override void ScaleControl(SizeF factor, BoundsSpecified specified)
    {
        base.ScaleControl(factor, specified);
        codeFinderControl.lvMatches.ScaleListViewColumns(factor);
    }

    private void MatchDoubleClick(object? sender, EventArgs e)
    {
        DialogResult = DialogResult.OK;
        Code = codeFinderControl.SelectedCode();
        Close();
    }

    private static void CodeChanged(object? sender, EventArgs e)
    {
        //Nothing to do
    }

    private void bnCancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }

    private void bnOK_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.OK;
        Code = codeFinderControl.SelectedCode();
        Close();
    }
}
