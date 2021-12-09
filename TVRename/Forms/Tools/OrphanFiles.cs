using Alphaleonis.Win32.Filesystem;
using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TVRename.Forms.Tools
{
    public partial class OrphanFiles : Form
    {
        private UI MainWindow { get; }
        private readonly TVDoc mDoc;
        private readonly List<FileIssue> issues;
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public OrphanFiles(TVDoc mDoc, UI parent)
        {
            MainWindow = parent;
            this.mDoc = mDoc;
            issues = new List<FileIssue>();
            InitializeComponent();
            olvSeason.GroupKeyGetter = GroupSeasonKeyDelegate;
            olvFileDirectory.GroupKeyGetter = GroupFolderTitleDelegate;
            olvFileIssues.SetObjects(issues);
            Scan();
        }

        private static object GroupFolderTitleDelegate(object rowObject)
        {
            FileIssue ep = (FileIssue)rowObject;
            foreach (string folder in TVSettings.Instance.LibraryFolders)
            {
                if (ep.Directory.StartsWith(folder, StringComparison.OrdinalIgnoreCase))
                {
                    return folder;
                }
            }

            return ep.Directory;
        }

        [NotNull]
        private static object GroupSeasonKeyDelegate(object rowObject)
        {
            FileIssue ep = (FileIssue)rowObject;
            return ep.SeasonNumber.HasValue ? $"{ep.Showname} - Season {ep.SeasonNumber}" : ep.Showname;
        }

        private void OlvFileIssues_MouseClick(object sender, [NotNull] MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
            {
                return;
            }

            Point pt = ((ListView)sender).PointToScreen(new Point(e.X, e.Y));
            if (olvFileIssues.FocusedObject is not FileIssue iss)
            {
                return;
            }

            showRightClickMenu.Items.Clear();

            AddRcMenuItem("View on Source Provider...", (_, _) => TvSourceFor(iss.Show));
            AddRcMenuItem("Open Folder", (_, _) => Helpers.OpenFolderSelectFile(iss.File.FullName));
            AddRcMenuItem("Episode Guide", (_, _) => MainWindow.GotoEpguideFor(iss.Show, true));

            showRightClickMenu.Show(pt);
        }

        private static void TvSourceFor(ShowConfiguration? si)
        {
            if (si != null)
            {
                if (si.WebsiteUrl.HasValue())
                {
                    Helpers.OpenUrl(si.WebsiteUrl!);
                }
                else if (si.CachedShow?.WebUrl.HasValue() ?? false)
                {
                    Helpers.OpenUrl(si.CachedShow?.WebUrl!);
                }
            }
        }

        private void AddRcMenuItem([NotNull] string name, EventHandler command)
        {
            ToolStripMenuItem tsi = new(name.Replace("&", "&&"));
            tsi.Click += command;
            showRightClickMenu.Items.Add(tsi);
        }

        private void BwRescan_DoWork(object sender, DoWorkEventArgs e)
        {
            System.Threading.Thread.CurrentThread.Name ??= "OrphanFiles Scan Thread"; // Can only set it once
            issues.Clear();
            UpdateIssues((BackgroundWorker)sender);
        }

        private void UpdateIssues(BackgroundWorker bw)
        {
            List<string> doneFolders = new();
            int total = mDoc.TvLibrary.Shows.Count();
            int current = 0;

            foreach (ShowConfiguration show in mDoc.TvLibrary.Shows.OrderBy(item => item.ShowName))
            {
                Logger.Info($"Finding old eps for {show.ShowName}");
                bw.ReportProgress(100 * current++ / total, show.ShowName);

                Dictionary<int, SafeList<string>> folders = show.AllFolderLocations(true);

                foreach (KeyValuePair<int, SafeList<string>> showfolders in folders)
                {
                    foreach (string showFolder in showfolders.Value)
                    {
                        if (doneFolders.Contains(showFolder))
                        {
                            continue;
                        }
                        doneFolders.Add(showFolder);
                        foreach (FileInfo file in new DirectoryInfo(showFolder).GetFiles()
                            .Where(file => file.IsMovieFile()))
                        {
                            FinderHelper.FindSeasEp(file, out int seasonNumber, out int episodeNumber, out int _, show);

                            if (seasonNumber < 0)
                            {
                                issues.Add(new FileIssue(show, file, "File does not match a Filename Processor"));
                            }
                            else if (folders.ContainsKey(seasonNumber) && !folders[seasonNumber].Contains(showFolder))
                            {
                                issues.Add(new FileIssue(show, file, "File is in the wrong cachedSeries folder", seasonNumber, episodeNumber));
                            }
                            else
                            {
                                if (!show.SeasonEpisodes.ContainsKey(seasonNumber))
                                {
                                    issues.Add(new FileIssue(show, file, "Season not found", seasonNumber));
                                }
                                else if (!HasEpisode(show.SeasonEpisodes[seasonNumber], episodeNumber))
                                {
                                    issues.Add(new FileIssue(show, file, "Episode not found", seasonNumber, episodeNumber));
                                }
                            }
                        }
                    }
                }
            }

            foreach (FileIssue i in issues)
            {
                Logger.Warn($"Finding old eps for {i.Show.ShowName} S{i.SeasonNumber}E{i.EpisodeNumber} {i.File.Name} in {i.File.DirectoryName} ");
            }
        }

        private static bool HasEpisode([NotNull] IEnumerable<ProcessedEpisode> showSeasonEpisode, int episodeNumber)
        {
            return showSeasonEpisode.Any(episode => episodeNumber == episode.AppropriateEpNum);
        }

        private void BwRescan_ProgressChanged(object sender, [NotNull] ProgressChangedEventArgs e)
        {
            pbProgress.Value = e.ProgressPercentage.Between(0, 100);
            lblStatus.Text = e.UserState.ToString();
        }

        private void BwRescan_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnRefresh.Visible = true;
            pbProgress.Visible = false;
            lblStatus.Visible = false;
            if (olvFileIssues.IsDisposed)
            {
                return;
            }
            olvFileIssues.RebuildColumns();
            AutosizeColumns(olvFileIssues);
        }

        private static void AutosizeColumns([NotNull] BrightIdeasSoftware.ObjectListView olv)
        {
            foreach (ColumnHeader col in olv.Columns)
            {
                //auto resize column width

                int colWidthBeforeAutoResize = col.Width;
                col.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
                int colWidthAfterAutoResizeByHeader = col.Width;
                col.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                int colWidthAfterAutoResizeByContent = col.Width;

                if (colWidthAfterAutoResizeByHeader > colWidthAfterAutoResizeByContent)
                {
                    col.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
                }

                //specific adjusts

                //first column
                if (col.Index == 0)
                //we have to manually take care of tree structure, checkbox and image
                {
                    col.Width += 16 + 16 + olv.SmallImageSize.Width;
                }
                //last column
                else if (col.Index == olv.Columns.Count - 1)
                //avoid "fill free space" issue
                {
                    col.Width = colWidthBeforeAutoResize > colWidthAfterAutoResizeByContent ? colWidthBeforeAutoResize : colWidthAfterAutoResizeByContent;
                }
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Scan();
        }

        private void Scan()
        {
            btnRefresh.Visible = false;
            pbProgress.Visible = true;
            lblStatus.Visible = true;
            bwRescan.RunWorkerAsync();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
