//
// Main website for TVRename is http://tvrename.com
//
// Source code available at https://github.com/TV-Rename/tvrename
//
// Copyright (c) TV Rename. This code is released under GPLv3 https://github.com/TV-Rename/tvrename/blob/master/LICENSE.md
//


namespace TVRename
{
    partial class Preferences
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            this.cntfw?.Close();
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preferences));
            this.OKButton = new System.Windows.Forms.Button();
            this.bnCancel = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbMonitorFolder = new System.Windows.Forms.CheckBox();
            this.txtEmptyIgnoreExtensions = new System.Windows.Forms.TextBox();
            this.txtEmptyIgnoreWords = new System.Windows.Forms.TextBox();
            this.lbSearchFolders = new System.Windows.Forms.ListBox();
            this.lstFMMonitorFolders = new System.Windows.Forms.ListBox();
            this.tbIgnoreSuffixes = new System.Windows.Forms.TextBox();
            this.tbMovieTerms = new System.Windows.Forms.TextBox();
            this.txtKeepTogether = new System.Windows.Forms.TextBox();
            this.txtOtherExtensions = new System.Windows.Forms.TextBox();
            this.cbCopyFutureDatedEps = new System.Windows.Forms.CheckBox();
            this.label40 = new System.Windows.Forms.Label();
            this.domainUpDown2 = new System.Windows.Forms.DomainUpDown();
            this.tbSeasonSearchTerms = new System.Windows.Forms.TextBox();
            this.chkForceBulkAddToUseSettingsOnly = new System.Windows.Forms.CheckBox();
            this.cbIgnoreRecycleBin = new System.Windows.Forms.CheckBox();
            this.cbIgnoreNoVideoFolders = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.chkScheduledScan = new System.Windows.Forms.CheckBox();
            this.chkScanOnStartup = new System.Windows.Forms.CheckBox();
            this.chkIgnoreAllSpecials = new System.Windows.Forms.CheckBox();
            this.cbAutoSaveOnExit = new System.Windows.Forms.CheckBox();
            this.label84 = new System.Windows.Forms.Label();
            this.lstMovieMonitorFolders = new System.Windows.Forms.ListBox();
            this.chkIncludeMoviesQuickRecent = new System.Windows.Forms.CheckBox();
            this.tbCleanUpDownloadDirMoviesLength = new System.Windows.Forms.TextBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.cmDefaults = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.KODIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pyTivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mede8erToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tpDisplay = new System.Windows.Forms.TabPage();
            this.chkShowAccessibilityOptions = new System.Windows.Forms.CheckBox();
            this.cbUseColoursOnWtw = new System.Windows.Forms.CheckBox();
            this.chkBasicShowDetails = new System.Windows.Forms.CheckBox();
            this.chkPostpendThe = new System.Windows.Forms.CheckBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboShowStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtShowStatusColor = new System.Windows.Forms.TextBox();
            this.btnSelectColor = new System.Windows.Forms.Button();
            this.bnRemoveDefinedColor = new System.Windows.Forms.Button();
            this.btnAddShowStatusColoring = new System.Windows.Forms.Button();
            this.lvwDefinedColors = new System.Windows.Forms.ListView();
            this.colShowStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label61 = new System.Windows.Forms.Label();
            this.cbLeadingZero = new System.Windows.Forms.CheckBox();
            this.txtSeasonFolderName = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.chkHideWtWSpoilers = new System.Windows.Forms.CheckBox();
            this.chkHideMyShowsSpoilers = new System.Windows.Forms.CheckBox();
            this.rbWTWScan = new System.Windows.Forms.RadioButton();
            this.rbWTWSearch = new System.Windows.Forms.RadioButton();
            this.cbStartupTab = new System.Windows.Forms.ComboBox();
            this.cbAutoSelInMyShows = new System.Windows.Forms.CheckBox();
            this.cbShowEpisodePictures = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkShowInTaskbar = new System.Windows.Forms.CheckBox();
            this.cbNotificationIcon = new System.Windows.Forms.CheckBox();
            this.pbDisplay = new System.Windows.Forms.PictureBox();
            this.tpRSSJSONSearch = new System.Windows.Forms.TabPage();
            this.pbRSSJSONSearch = new System.Windows.Forms.PictureBox();
            this.label59 = new System.Windows.Forms.Label();
            this.cbSearchJSON = new System.Windows.Forms.CheckBox();
            this.cbSearchRSS = new System.Windows.Forms.CheckBox();
            this.gbJSON = new System.Windows.Forms.GroupBox();
            this.label78 = new System.Windows.Forms.Label();
            this.tbJSONSeedersToken = new System.Windows.Forms.TextBox();
            this.cbJSONCloudflareProtection = new System.Windows.Forms.CheckBox();
            this.cbSearchJSONManualScanOnly = new System.Windows.Forms.CheckBox();
            this.label55 = new System.Windows.Forms.Label();
            this.tbJSONFilesizeToken = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.tbJSONFilenameToken = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.tbJSONURLToken = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.tbJSONRootNode = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.tbJSONURL = new System.Windows.Forms.TextBox();
            this.gbRSS = new System.Windows.Forms.GroupBox();
            this.cbRSSCloudflareProtection = new System.Windows.Forms.CheckBox();
            this.cbSearchRSSManualScanOnly = new System.Windows.Forms.CheckBox();
            this.RSSGrid = new SourceGrid.Grid();
            this.label25 = new System.Windows.Forms.Label();
            this.bnRSSRemove = new System.Windows.Forms.Button();
            this.bnRSSGo = new System.Windows.Forms.Button();
            this.bnRSSAdd = new System.Windows.Forms.Button();
            this.tpLibraryFolders = new System.Windows.Forms.TabPage();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtMovieFilenameFormat = new System.Windows.Forms.TextBox();
            this.label90 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtMovieFolderFormat = new System.Windows.Forms.TextBox();
            this.label85 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.bnOpenMovieMonFolder = new System.Windows.Forms.Button();
            this.bnAddMovieMonFolder = new System.Windows.Forms.Button();
            this.bnRemoveMovieMonFolder = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSeasonFormat = new System.Windows.Forms.TextBox();
            this.txtSpecialsFolderName = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.bnOpenMonFolder = new System.Windows.Forms.Button();
            this.bnAddMonFolder = new System.Windows.Forms.Button();
            this.bnRemoveMonFolder = new System.Windows.Forms.Button();
            this.pbLibraryFolders = new System.Windows.Forms.PictureBox();
            this.tpTorrentNZB = new System.Windows.Forms.TabPage();
            this.pbuTorrentNZB = new System.Windows.Forms.PictureBox();
            this.label58 = new System.Windows.Forms.Label();
            this.cbCheckqBitTorrent = new System.Windows.Forms.CheckBox();
            this.cbCheckSABnzbd = new System.Windows.Forms.CheckBox();
            this.cbCheckuTorrent = new System.Windows.Forms.CheckBox();
            this.qBitTorrent = new System.Windows.Forms.GroupBox();
            this.chkRemoveCompletedTorrents = new System.Windows.Forms.CheckBox();
            this.llqBitTorrentLink = new System.Windows.Forms.LinkLabel();
            this.label79 = new System.Windows.Forms.Label();
            this.rdoqBitTorrentAPIVersionv2 = new System.Windows.Forms.RadioButton();
            this.rdoqBitTorrentAPIVersionv1 = new System.Windows.Forms.RadioButton();
            this.rdoqBitTorrentAPIVersionv0 = new System.Windows.Forms.RadioButton();
            this.label29 = new System.Windows.Forms.Label();
            this.cbDownloadTorrentBeforeDownloading = new System.Windows.Forms.CheckBox();
            this.tbqBitTorrentHost = new System.Windows.Forms.TextBox();
            this.tbqBitTorrentPort = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.gbSAB = new System.Windows.Forms.GroupBox();
            this.txtSABHostPort = new System.Windows.Forms.TextBox();
            this.txtSABAPIKey = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbuTorrent = new System.Windows.Forms.GroupBox();
            this.bnUTBrowseResumeDat = new System.Windows.Forms.Button();
            this.txtUTResumeDatPath = new System.Windows.Forms.TextBox();
            this.bnRSSBrowseuTorrent = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtRSSuTorrentPath = new System.Windows.Forms.TextBox();
            this.tbSearchFolders = new System.Windows.Forms.TabPage();
            this.chkUseSearchFullPathWhenMatchingShows = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cbMovieHigherQuality = new System.Windows.Forms.CheckBox();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.tbPercentBetter = new System.Windows.Forms.TextBox();
            this.tbPriorityOverrideTerms = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.cbHigherQuality = new System.Windows.Forms.CheckBox();
            this.label67 = new System.Windows.Forms.Label();
            this.gbAutoAdd = new System.Windows.Forms.GroupBox();
            this.chkAutoSearchForDownloadedFiles = new System.Windows.Forms.CheckBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.cbLeaveOriginals = new System.Windows.Forms.CheckBox();
            this.cbSearchLocally = new System.Windows.Forms.CheckBox();
            this.chkAutoMergeDownloadEpisodes = new System.Windows.Forms.CheckBox();
            this.bnOpenSearchFolder = new System.Windows.Forms.Button();
            this.bnRemoveSearchFolder = new System.Windows.Forms.Button();
            this.bnAddSearchFolder = new System.Windows.Forms.Button();
            this.pbSearchFolders = new System.Windows.Forms.PictureBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tbMediaCenter = new System.Windows.Forms.TabPage();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.cbWDLiveEpisodeFiles = new System.Windows.Forms.CheckBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.cbXMLFiles = new System.Windows.Forms.CheckBox();
            this.cbSeriesJpg = new System.Windows.Forms.CheckBox();
            this.cbShrinkLarge = new System.Windows.Forms.CheckBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.cbMeta = new System.Windows.Forms.CheckBox();
            this.cbMetaSubfolder = new System.Windows.Forms.CheckBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.cbNFOMovies = new System.Windows.Forms.CheckBox();
            this.cbEpTBNs = new System.Windows.Forms.CheckBox();
            this.cbNFOShows = new System.Windows.Forms.CheckBox();
            this.cbKODIImages = new System.Windows.Forms.CheckBox();
            this.cbNFOEpisodes = new System.Windows.Forms.CheckBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.cbFantArtJpg = new System.Windows.Forms.CheckBox();
            this.cbFolderJpg = new System.Windows.Forms.CheckBox();
            this.cbEpThumbJpg = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbFolderBanner = new System.Windows.Forms.RadioButton();
            this.rbFolderPoster = new System.Windows.Forms.RadioButton();
            this.rbFolderFanArt = new System.Windows.Forms.RadioButton();
            this.rbFolderSeasonPoster = new System.Windows.Forms.RadioButton();
            this.label64 = new System.Windows.Forms.Label();
            this.bnMCPresets = new System.Windows.Forms.Button();
            this.pbMediaCenter = new System.Windows.Forms.PictureBox();
            this.tbFolderDeleting = new System.Windows.Forms.TabPage();
            this.cbDeleteMovieFromDisk = new System.Windows.Forms.CheckBox();
            this.groupBox28 = new System.Windows.Forms.GroupBox();
            this.cbCleanUpDownloadDirMoviesLength = new System.Windows.Forms.CheckBox();
            this.cbCleanUpDownloadDirMovies = new System.Windows.Forms.CheckBox();
            this.cbCleanUpDownloadDir = new System.Windows.Forms.CheckBox();
            this.label69 = new System.Windows.Forms.Label();
            this.cbDeleteShowFromDisk = new System.Windows.Forms.CheckBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.txtEmptyMaxSize = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.cbRecycleNotDelete = new System.Windows.Forms.CheckBox();
            this.cbEmptyMaxSize = new System.Windows.Forms.CheckBox();
            this.cbEmptyIgnoreWords = new System.Windows.Forms.CheckBox();
            this.cbEmptyIgnoreExtensions = new System.Windows.Forms.CheckBox();
            this.cbDeleteEmpty = new System.Windows.Forms.CheckBox();
            this.pbFolderDeleting = new System.Windows.Forms.PictureBox();
            this.tbAutoExport = new System.Windows.Forms.TabPage();
            this.pbuExportEpisodes = new System.Windows.Forms.PictureBox();
            this.label88 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.bnBrowseWPL = new System.Windows.Forms.Button();
            this.txtWPL = new System.Windows.Forms.TextBox();
            this.cbWPL = new System.Windows.Forms.CheckBox();
            this.bnBrowseASX = new System.Windows.Forms.Button();
            this.txtASX = new System.Windows.Forms.TextBox();
            this.cbASX = new System.Windows.Forms.CheckBox();
            this.bnBrowseM3U = new System.Windows.Forms.Button();
            this.txtM3U = new System.Windows.Forms.TextBox();
            this.cbM3U = new System.Windows.Forms.CheckBox();
            this.bnBrowseXSPF = new System.Windows.Forms.Button();
            this.txtXSPF = new System.Windows.Forms.TextBox();
            this.cbXSPF = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.bnBrowseFOXML = new System.Windows.Forms.Button();
            this.cbFOXML = new System.Windows.Forms.CheckBox();
            this.txtFOXML = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bnBrowseRenamingXML = new System.Windows.Forms.Button();
            this.cbRenamingXML = new System.Windows.Forms.CheckBox();
            this.txtRenamingXML = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bnBrowseWTWTXT = new System.Windows.Forms.Button();
            this.txtWTWTXT = new System.Windows.Forms.TextBox();
            this.cbWTWTXT = new System.Windows.Forms.CheckBox();
            this.bnBrowseWTWICAL = new System.Windows.Forms.Button();
            this.txtWTWICAL = new System.Windows.Forms.TextBox();
            this.cbWTWICAL = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExportRSSDaysPast = new System.Windows.Forms.TextBox();
            this.bnBrowseWTWXML = new System.Windows.Forms.Button();
            this.txtWTWXML = new System.Windows.Forms.TextBox();
            this.cbWTWXML = new System.Windows.Forms.CheckBox();
            this.bnBrowseWTWRSS = new System.Windows.Forms.Button();
            this.txtWTWRSS = new System.Windows.Forms.TextBox();
            this.cbWTWRSS = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtExportRSSMaxDays = new System.Windows.Forms.TextBox();
            this.txtExportRSSMaxShows = new System.Windows.Forms.TextBox();
            this.tbFilesAndFolders = new System.Windows.Forms.TabPage();
            this.chkUseLibraryFullPathWhenMatchingShows = new System.Windows.Forms.CheckBox();
            this.label66 = new System.Windows.Forms.Label();
            this.txtMaxSampleSize = new System.Windows.Forms.TextBox();
            this.txtVideoExtensions = new System.Windows.Forms.TextBox();
            this.bnTags = new System.Windows.Forms.Button();
            this.label39 = new System.Windows.Forms.Label();
            this.cbKeepTogetherMode = new System.Windows.Forms.ComboBox();
            this.bnReplaceRemove = new System.Windows.Forms.Button();
            this.bnReplaceAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ReplacementsGrid = new SourceGrid.Grid();
            this.label19 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbKeepTogether = new System.Windows.Forms.CheckBox();
            this.cbForceLower = new System.Windows.Forms.CheckBox();
            this.cbIgnoreSamples = new System.Windows.Forms.CheckBox();
            this.pbFilesAndFolders = new System.Windows.Forms.PictureBox();
            this.tbGeneral = new System.Windows.Forms.TabPage();
            this.chkAutoAddAsPartOfQuickRename = new System.Windows.Forms.CheckBox();
            this.chkShareCriticalLogs = new System.Windows.Forms.CheckBox();
            this.label60 = new System.Windows.Forms.Label();
            this.pbGeneral = new System.Windows.Forms.PictureBox();
            this.txtWTWDays = new System.Windows.Forms.TextBox();
            this.cbMode = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tcTabs = new System.Windows.Forms.TabControl();
            this.tpDataSources = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdoMovieTMDB = new System.Windows.Forms.RadioButton();
            this.rdoMovieTheTVDB = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdoTVTMDB = new System.Windows.Forms.RadioButton();
            this.rdoTVTVMaze = new System.Windows.Forms.RadioButton();
            this.rdoTVTVDB = new System.Windows.Forms.RadioButton();
            this.label83 = new System.Windows.Forms.Label();
            this.gbTMDB = new System.Windows.Forms.GroupBox();
            this.cbTMDBRegions = new System.Windows.Forms.ComboBox();
            this.label80 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.tbTMDBPercentDirty = new System.Windows.Forms.TextBox();
            this.label82 = new System.Windows.Forms.Label();
            this.cbTMDBLanguages = new System.Windows.Forms.ComboBox();
            this.label63 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.txtParallelDownloads = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.label91 = new System.Windows.Forms.Label();
            this.cbTVDBVersion = new System.Windows.Forms.ComboBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.tbPercentDirty = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbTVDBLanguages = new System.Windows.Forms.ComboBox();
            this.label33 = new System.Windows.Forms.Label();
            this.pbSources = new System.Windows.Forms.PictureBox();
            this.tpMovieDefaults = new System.Windows.Forms.TabPage();
            this.label86 = new System.Windows.Forms.Label();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.cmbDefMovieLocation = new System.Windows.Forms.ComboBox();
            this.cbDefMovieUseDefLocation = new System.Windows.Forms.CheckBox();
            this.cbDefMovieAutoFolders = new System.Windows.Forms.CheckBox();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.cbDefMovieIncludeNoAirdate = new System.Windows.Forms.CheckBox();
            this.cbDefMovieIncludeFuture = new System.Windows.Forms.CheckBox();
            this.cbDefMovieDoMissing = new System.Windows.Forms.CheckBox();
            this.cbDefMovieDoRenaming = new System.Windows.Forms.CheckBox();
            this.pbMovieDefaults = new System.Windows.Forms.PictureBox();
            this.tpShowDefaults = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.cbTimeZone = new System.Windows.Forms.ComboBox();
            this.rbDefShowUseSubFolders = new System.Windows.Forms.RadioButton();
            this.rbDefShowUseBase = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbDefShowLocation = new System.Windows.Forms.ComboBox();
            this.cbDefShowUseDefLocation = new System.Windows.Forms.CheckBox();
            this.cbDefShowAutoFolders = new System.Windows.Forms.CheckBox();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.cbDefShowAlternateOrder = new System.Windows.Forms.CheckBox();
            this.cbDefShowEpNameMatching = new System.Windows.Forms.CheckBox();
            this.label68 = new System.Windows.Forms.Label();
            this.cbDefShowAirdateMatching = new System.Windows.Forms.CheckBox();
            this.cbDefShowSpecialsCount = new System.Windows.Forms.CheckBox();
            this.cbDefShowSequentialMatching = new System.Windows.Forms.CheckBox();
            this.cbDefShowIncludeNoAirdate = new System.Windows.Forms.CheckBox();
            this.cbDefShowDoMissingCheck = new System.Windows.Forms.CheckBox();
            this.cbDefShowDVDOrder = new System.Windows.Forms.CheckBox();
            this.cbDefShowIncludeFuture = new System.Windows.Forms.CheckBox();
            this.cbDefShowDoRenaming = new System.Windows.Forms.CheckBox();
            this.cbDefShowNextAirdate = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tpScanSettings = new System.Windows.Forms.TabPage();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.cbIgnorePreviouslySeenMovies = new System.Windows.Forms.CheckBox();
            this.chkMoveLibraryFiles = new System.Windows.Forms.CheckBox();
            this.lblScanAction = new System.Windows.Forms.Label();
            this.rdoQuickScan = new System.Windows.Forms.RadioButton();
            this.rdoRecentScan = new System.Windows.Forms.RadioButton();
            this.rdoFullScan = new System.Windows.Forms.RadioButton();
            this.cbIgnorePreviouslySeen = new System.Windows.Forms.CheckBox();
            this.chkPreventMove = new System.Windows.Forms.CheckBox();
            this.label28 = new System.Windows.Forms.Label();
            this.cbRenameCheck = new System.Windows.Forms.CheckBox();
            this.cbMissing = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkCleanLibraryAfterActions = new System.Windows.Forms.CheckBox();
            this.cbxUpdateAirDate = new System.Windows.Forms.CheckBox();
            this.cbAutoCreateFolders = new System.Windows.Forms.CheckBox();
            this.chkAutoMergeLibraryEpisodes = new System.Windows.Forms.CheckBox();
            this.cbScanIncludesBulkAdd = new System.Windows.Forms.CheckBox();
            this.gbBulkAdd = new System.Windows.Forms.GroupBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.pbScanOptions = new System.Windows.Forms.PictureBox();
            this.tpJackett = new System.Windows.Forms.TabPage();
            this.chkSearchJackettButton = new System.Windows.Forms.CheckBox();
            this.cmbSupervisedDuplicateAction = new System.Windows.Forms.ComboBox();
            this.label77 = new System.Windows.Forms.Label();
            this.cmbUnattendedDuplicateAction = new System.Windows.Forms.ComboBox();
            this.label76 = new System.Windows.Forms.Label();
            this.cbDetailedRSSJSONLogging = new System.Windows.Forms.CheckBox();
            this.pbuJackett = new System.Windows.Forms.PictureBox();
            this.label70 = new System.Windows.Forms.Label();
            this.cbSearchJackett = new System.Windows.Forms.CheckBox();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.chkUseJackettTextSearch = new System.Windows.Forms.CheckBox();
            this.chkSkipJackettFullScans = new System.Windows.Forms.CheckBox();
            this.llJackettLink = new System.Windows.Forms.LinkLabel();
            this.label71 = new System.Windows.Forms.Label();
            this.cbSearchJackettOnManualScansOnly = new System.Windows.Forms.CheckBox();
            this.label72 = new System.Windows.Forms.Label();
            this.txtJackettIndexer = new System.Windows.Forms.TextBox();
            this.label73 = new System.Windows.Forms.Label();
            this.txtJackettAPIKey = new System.Windows.Forms.TextBox();
            this.label74 = new System.Windows.Forms.Label();
            this.txtJackettPort = new System.Windows.Forms.TextBox();
            this.label75 = new System.Windows.Forms.Label();
            this.txtJackettServer = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.tbPreferredRSSTerms = new System.Windows.Forms.TextBox();
            this.tpAutoExportLibrary = new System.Windows.Forms.TabPage();
            this.pbuShowExport = new System.Windows.Forms.PictureBox();
            this.label89 = new System.Windows.Forms.Label();
            this.groupBox26 = new System.Windows.Forms.GroupBox();
            this.bnBrowseMoviesHTML = new System.Windows.Forms.Button();
            this.cbMoviesHTML = new System.Windows.Forms.CheckBox();
            this.txtMoviesHTMLTo = new System.Windows.Forms.TextBox();
            this.bnBrowseMoviesTXT = new System.Windows.Forms.Button();
            this.cbMoviesTXT = new System.Windows.Forms.CheckBox();
            this.txtMoviesTXTTo = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.bnBrowseShowsHTML = new System.Windows.Forms.Button();
            this.cbShowsHTML = new System.Windows.Forms.CheckBox();
            this.txtShowsHTMLTo = new System.Windows.Forms.TextBox();
            this.bnBrowseShowsTXT = new System.Windows.Forms.Button();
            this.cbShowsTXT = new System.Windows.Forms.CheckBox();
            this.txtShowsTXTTo = new System.Windows.Forms.TextBox();
            this.groupBox27 = new System.Windows.Forms.GroupBox();
            this.bnBrowseMissingMoviesCSV = new System.Windows.Forms.Button();
            this.bnBrowseMissingMoviesXML = new System.Windows.Forms.Button();
            this.txtMissingMoviesCSV = new System.Windows.Forms.TextBox();
            this.cbMissingMoviesXML = new System.Windows.Forms.CheckBox();
            this.cbMissingMoviesCSV = new System.Windows.Forms.CheckBox();
            this.txtMissingMoviesXML = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bnBrowseMissingCSV = new System.Windows.Forms.Button();
            this.bnBrowseMissingXML = new System.Windows.Forms.Button();
            this.txtMissingCSV = new System.Windows.Forms.TextBox();
            this.cbMissingXML = new System.Windows.Forms.CheckBox();
            this.cbMissingCSV = new System.Windows.Forms.CheckBox();
            this.txtMissingXML = new System.Windows.Forms.TextBox();
            this.tbAppUpdate = new System.Windows.Forms.TabPage();
            this.pbuUpdates = new System.Windows.Forms.PictureBox();
            this.label92 = new System.Windows.Forms.Label();
            this.grpUpdateIntervalOption = new System.Windows.Forms.GroupBox();
            this.chkNoPopupOnUpdate = new System.Windows.Forms.CheckBox();
            this.chkUpdateCheckEnabled = new System.Windows.Forms.CheckBox();
            this.cboUpdateCheckInterval = new System.Windows.Forms.ComboBox();
            this.optUpdateCheckInterval = new System.Windows.Forms.RadioButton();
            this.optUpdateCheckAlways = new System.Windows.Forms.RadioButton();
            this.tpSubtitles = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.cbTxtToSub = new System.Windows.Forms.CheckBox();
            this.label46 = new System.Windows.Forms.Label();
            this.txtSubtitleExtensions = new System.Windows.Forms.TextBox();
            this.chkRetainLanguageSpecificSubtitles = new System.Windows.Forms.CheckBox();
            this.label93 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox29 = new System.Windows.Forms.GroupBox();
            this.label94 = new System.Windows.Forms.Label();
            this.txtSubtitleFolderNames = new System.Windows.Forms.TextBox();
            this.cbCopySubsFolders = new System.Windows.Forms.CheckBox();
            this.cbFileNameCaseSensitiveMatch = new System.Windows.Forms.CheckBox();
            this.cbAutomateAutoAddWhenOneShowFound = new System.Windows.Forms.CheckBox();
            this.cbAutomateAutoAddWhenOneMovieFound = new System.Windows.Forms.CheckBox();
            this.label95 = new System.Windows.Forms.Label();
            this.cmbDefMovieFolderFormat = new System.Windows.Forms.ComboBox();
            this.cmDefaults.SuspendLayout();
            this.tpDisplay.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplay)).BeginInit();
            this.tpRSSJSONSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRSSJSONSearch)).BeginInit();
            this.gbJSON.SuspendLayout();
            this.gbRSS.SuspendLayout();
            this.tpLibraryFolders.SuspendLayout();
            this.groupBox23.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLibraryFolders)).BeginInit();
            this.tpTorrentNZB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbuTorrentNZB)).BeginInit();
            this.qBitTorrent.SuspendLayout();
            this.gbSAB.SuspendLayout();
            this.gbuTorrent.SuspendLayout();
            this.tbSearchFolders.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.gbAutoAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchFolders)).BeginInit();
            this.tbMediaCenter.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMediaCenter)).BeginInit();
            this.tbFolderDeleting.SuspendLayout();
            this.groupBox28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFolderDeleting)).BeginInit();
            this.tbAutoExport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbuExportEpisodes)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tbFilesAndFolders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilesAndFolders)).BeginInit();
            this.tbGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGeneral)).BeginInit();
            this.tcTabs.SuspendLayout();
            this.tpDataSources.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbTMDB.SuspendLayout();
            this.groupBox20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSources)).BeginInit();
            this.tpMovieDefaults.SuspendLayout();
            this.groupBox24.SuspendLayout();
            this.groupBox25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMovieDefaults)).BeginInit();
            this.tpShowDefaults.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tpScanSettings.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbBulkAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbScanOptions)).BeginInit();
            this.tpJackett.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbuJackett)).BeginInit();
            this.groupBox22.SuspendLayout();
            this.tpAutoExportLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbuShowExport)).BeginInit();
            this.groupBox26.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox27.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tbAppUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbuUpdates)).BeginInit();
            this.grpUpdateIntervalOption.SuspendLayout();
            this.tpSubtitles.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox29.SuspendLayout();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Location = new System.Drawing.Point(412, 587);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // bnCancel
            // 
            this.bnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bnCancel.Location = new System.Drawing.Point(493, 587);
            this.bnCancel.Name = "bnCancel";
            this.bnCancel.Size = new System.Drawing.Size(75, 23);
            this.bnCancel.TabIndex = 1;
            this.bnCancel.Text = "Cancel";
            this.bnCancel.UseVisualStyleBackColor = true;
            this.bnCancel.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // saveFile
            // 
            this.saveFile.Filter = resources.GetString("saveFile.Filter");
            // 
            // folderBrowser
            // 
            this.folderBrowser.ShowNewFolderButton = false;
            // 
            // openFile
            // 
            this.openFile.Filter = "Torrent files (*.torrent)|*.torrent|All files (*.*)|*.*";
            // 
            // cbMonitorFolder
            // 
            this.cbMonitorFolder.AutoSize = true;
            this.cbMonitorFolder.Location = new System.Drawing.Point(6, 127);
            this.cbMonitorFolder.Name = "cbMonitorFolder";
            this.cbMonitorFolder.Size = new System.Drawing.Size(342, 17);
            this.cbMonitorFolder.TabIndex = 5;
            this.cbMonitorFolder.Text = "&Monitor Search Folders for changes (run a scan when files change)";
            this.toolTip1.SetToolTip(this.cbMonitorFolder, "If the contents of any of these folder change, then automatically do a \"Scan\" and" +
        " \"Do\".");
            this.cbMonitorFolder.UseVisualStyleBackColor = true;
            // 
            // txtEmptyIgnoreExtensions
            // 
            this.txtEmptyIgnoreExtensions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmptyIgnoreExtensions.Location = new System.Drawing.Point(95, 161);
            this.txtEmptyIgnoreExtensions.Name = "txtEmptyIgnoreExtensions";
            this.txtEmptyIgnoreExtensions.Size = new System.Drawing.Size(318, 20);
            this.txtEmptyIgnoreExtensions.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtEmptyIgnoreExtensions, "For example \".par2;.nzb;.nfo\"");
            // 
            // txtEmptyIgnoreWords
            // 
            this.txtEmptyIgnoreWords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmptyIgnoreWords.Location = new System.Drawing.Point(95, 111);
            this.txtEmptyIgnoreWords.Name = "txtEmptyIgnoreWords";
            this.txtEmptyIgnoreWords.Size = new System.Drawing.Size(318, 20);
            this.txtEmptyIgnoreWords.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtEmptyIgnoreWords, "For example \"sample\"");
            // 
            // lbSearchFolders
            // 
            this.lbSearchFolders.AllowDrop = true;
            this.lbSearchFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSearchFolders.FormattingEnabled = true;
            this.lbSearchFolders.Location = new System.Drawing.Point(5, 207);
            this.lbSearchFolders.Name = "lbSearchFolders";
            this.lbSearchFolders.ScrollAlwaysVisible = true;
            this.lbSearchFolders.Size = new System.Drawing.Size(405, 69);
            this.lbSearchFolders.TabIndex = 1;
            this.toolTip1.SetToolTip(this.lbSearchFolders, resources.GetString("lbSearchFolders.ToolTip"));
            this.lbSearchFolders.SelectedIndexChanged += new System.EventHandler(this.lbSearchFolders_SelectedIndexChanged);
            this.lbSearchFolders.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbSearchFolders_DragDrop);
            this.lbSearchFolders.DragOver += new System.Windows.Forms.DragEventHandler(this.lbSearchFolders_DragOver);
            this.lbSearchFolders.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbSearchFolders_KeyDown);
            // 
            // lstFMMonitorFolders
            // 
            this.lstFMMonitorFolders.AllowDrop = true;
            this.lstFMMonitorFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFMMonitorFolders.FormattingEnabled = true;
            this.lstFMMonitorFolders.IntegralHeight = false;
            this.lstFMMonitorFolders.Location = new System.Drawing.Point(6, 69);
            this.lstFMMonitorFolders.Name = "lstFMMonitorFolders";
            this.lstFMMonitorFolders.ScrollAlwaysVisible = true;
            this.lstFMMonitorFolders.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstFMMonitorFolders.Size = new System.Drawing.Size(408, 97);
            this.lstFMMonitorFolders.TabIndex = 32;
            this.toolTip1.SetToolTip(this.lstFMMonitorFolders, resources.GetString("lstFMMonitorFolders.ToolTip"));
            this.lstFMMonitorFolders.SelectedIndexChanged += new System.EventHandler(this.lstFMMonitorFolders_SelectedIndexChanged);
            this.lstFMMonitorFolders.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstFMMonitorFolders_DragDrop);
            this.lstFMMonitorFolders.DragOver += new System.Windows.Forms.DragEventHandler(this.FileIcon_DragOver);
            this.lstFMMonitorFolders.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstFMMonitorFolders_KeyDown);
            // 
            // tbIgnoreSuffixes
            // 
            this.tbIgnoreSuffixes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIgnoreSuffixes.Location = new System.Drawing.Point(100, 101);
            this.tbIgnoreSuffixes.Name = "tbIgnoreSuffixes";
            this.tbIgnoreSuffixes.Size = new System.Drawing.Size(305, 20);
            this.tbIgnoreSuffixes.TabIndex = 15;
            this.toolTip1.SetToolTip(this.tbIgnoreSuffixes, "These terms and any text after them will be ignored when\r\nsearching on TVDB for t" +
        "he show title based on the filename.");
            // 
            // tbMovieTerms
            // 
            this.tbMovieTerms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMovieTerms.Location = new System.Drawing.Point(100, 75);
            this.tbMovieTerms.Name = "tbMovieTerms";
            this.tbMovieTerms.Size = new System.Drawing.Size(305, 20);
            this.tbMovieTerms.TabIndex = 13;
            this.toolTip1.SetToolTip(this.tbMovieTerms, "If a filename contains any of these terms then it is assumed\r\nthat it is a Film a" +
        "nd not a TV Show. Hence \'Auto Add\' is not\r\ninvoked for this file.");
            // 
            // txtKeepTogether
            // 
            this.txtKeepTogether.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKeepTogether.Location = new System.Drawing.Point(204, 311);
            this.txtKeepTogether.Name = "txtKeepTogether";
            this.txtKeepTogether.Size = new System.Drawing.Size(204, 20);
            this.txtKeepTogether.TabIndex = 23;
            this.toolTip1.SetToolTip(this.txtKeepTogether, "Which file extensions should be copied from the Search\r\nFolders into the library?" +
        "");
            // 
            // txtOtherExtensions
            // 
            this.txtOtherExtensions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOtherExtensions.Location = new System.Drawing.Point(99, 259);
            this.txtOtherExtensions.Name = "txtOtherExtensions";
            this.txtOtherExtensions.Size = new System.Drawing.Size(309, 20);
            this.txtOtherExtensions.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtOtherExtensions, "Which file extensions in the library should be renamed along\r\nwith the video file" +
        "s?");
            // 
            // cbCopyFutureDatedEps
            // 
            this.cbCopyFutureDatedEps.AutoSize = true;
            this.cbCopyFutureDatedEps.Location = new System.Drawing.Point(6, 150);
            this.cbCopyFutureDatedEps.Name = "cbCopyFutureDatedEps";
            this.cbCopyFutureDatedEps.Size = new System.Drawing.Size(270, 17);
            this.cbCopyFutureDatedEps.TabIndex = 41;
            this.cbCopyFutureDatedEps.Text = "Copy future dated episodes found in Search Folders";
            this.toolTip1.SetToolTip(this.cbCopyFutureDatedEps, "If set then any episodes in the search folders will be copied into the library, e" +
        "ven if they are yet to officially air.");
            this.cbCopyFutureDatedEps.UseVisualStyleBackColor = true;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(161, 153);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(33, 13);
            this.label40.TabIndex = 54;
            this.label40.Text = "hours";
            this.toolTip1.SetToolTip(this.label40, "If checked the system will automatically scan and complete actions on a periodic " +
        "schedule");
            // 
            // domainUpDown2
            // 
            this.domainUpDown2.Items.Add("96");
            this.domainUpDown2.Items.Add("48");
            this.domainUpDown2.Items.Add("24");
            this.domainUpDown2.Items.Add("12");
            this.domainUpDown2.Items.Add("8");
            this.domainUpDown2.Items.Add("6");
            this.domainUpDown2.Items.Add("5");
            this.domainUpDown2.Items.Add("4");
            this.domainUpDown2.Items.Add("3");
            this.domainUpDown2.Items.Add("2");
            this.domainUpDown2.Items.Add("1");
            this.domainUpDown2.Location = new System.Drawing.Point(117, 151);
            this.domainUpDown2.Name = "domainUpDown2";
            this.domainUpDown2.Size = new System.Drawing.Size(40, 20);
            this.domainUpDown2.TabIndex = 53;
            this.domainUpDown2.Text = "1";
            this.toolTip1.SetToolTip(this.domainUpDown2, "How often should TV Rename update itself from upstream data sources?");
            this.domainUpDown2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SuppressKeyPress);
            // 
            // tbSeasonSearchTerms
            // 
            this.tbSeasonSearchTerms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSeasonSearchTerms.Location = new System.Drawing.Point(126, 85);
            this.tbSeasonSearchTerms.Name = "tbSeasonSearchTerms";
            this.tbSeasonSearchTerms.Size = new System.Drawing.Size(268, 20);
            this.tbSeasonSearchTerms.TabIndex = 22;
            this.toolTip1.SetToolTip(this.tbSeasonSearchTerms, "Which terms should the system look for in directory\r\nnames that indicate that the" +
        " folder contains a season\'s\r\nworth of episodes for a show.\r\nThey should be separ" +
        "ated by a semi-colon - ; ");
            // 
            // chkForceBulkAddToUseSettingsOnly
            // 
            this.chkForceBulkAddToUseSettingsOnly.AutoSize = true;
            this.chkForceBulkAddToUseSettingsOnly.Location = new System.Drawing.Point(6, 65);
            this.chkForceBulkAddToUseSettingsOnly.Name = "chkForceBulkAddToUseSettingsOnly";
            this.chkForceBulkAddToUseSettingsOnly.Size = new System.Drawing.Size(248, 17);
            this.chkForceBulkAddToUseSettingsOnly.TabIndex = 15;
            this.chkForceBulkAddToUseSettingsOnly.Text = "Force to Use Season Words from Settings Only";
            this.toolTip1.SetToolTip(this.chkForceBulkAddToUseSettingsOnly, "If set then Bulk Add just uses the season words from settings. If not set (recomm" +
        "ended) then Bulk Add finds addition season words from each show\'s configuration." +
        "");
            this.chkForceBulkAddToUseSettingsOnly.UseVisualStyleBackColor = true;
            // 
            // cbIgnoreRecycleBin
            // 
            this.cbIgnoreRecycleBin.AutoSize = true;
            this.cbIgnoreRecycleBin.Location = new System.Drawing.Point(6, 42);
            this.cbIgnoreRecycleBin.Name = "cbIgnoreRecycleBin";
            this.cbIgnoreRecycleBin.Size = new System.Drawing.Size(116, 17);
            this.cbIgnoreRecycleBin.TabIndex = 14;
            this.cbIgnoreRecycleBin.Text = "Ignore &Recycle Bin";
            this.toolTip1.SetToolTip(this.cbIgnoreRecycleBin, "If set then Bulk Add ignores all files in the Recycle Bin");
            this.cbIgnoreRecycleBin.UseVisualStyleBackColor = true;
            // 
            // cbIgnoreNoVideoFolders
            // 
            this.cbIgnoreNoVideoFolders.AutoSize = true;
            this.cbIgnoreNoVideoFolders.Location = new System.Drawing.Point(6, 19);
            this.cbIgnoreNoVideoFolders.Name = "cbIgnoreNoVideoFolders";
            this.cbIgnoreNoVideoFolders.Size = new System.Drawing.Size(225, 17);
            this.cbIgnoreNoVideoFolders.TabIndex = 13;
            this.cbIgnoreNoVideoFolders.Text = "&Only Include Folders containing Video files";
            this.toolTip1.SetToolTip(this.cbIgnoreNoVideoFolders, "If set then only folders that contain video files are considered for the \'Bulk Ad" +
        "d\' feature");
            this.cbIgnoreNoVideoFolders.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "hours";
            this.toolTip1.SetToolTip(this.label1, "If checked the system will automatically scan and complete actions on a periodic " +
        "schedule");
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("96");
            this.domainUpDown1.Items.Add("48");
            this.domainUpDown1.Items.Add("24");
            this.domainUpDown1.Items.Add("12");
            this.domainUpDown1.Items.Add("8");
            this.domainUpDown1.Items.Add("6");
            this.domainUpDown1.Items.Add("5");
            this.domainUpDown1.Items.Add("4");
            this.domainUpDown1.Items.Add("3");
            this.domainUpDown1.Items.Add("2");
            this.domainUpDown1.Items.Add("1");
            this.domainUpDown1.Location = new System.Drawing.Point(141, 81);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(40, 20);
            this.domainUpDown1.TabIndex = 46;
            this.domainUpDown1.Text = "1";
            this.toolTip1.SetToolTip(this.domainUpDown1, "If checked the system will automatically scan and complete actions on a periodic " +
        "schedule");
            // 
            // chkScheduledScan
            // 
            this.chkScheduledScan.AutoSize = true;
            this.chkScheduledScan.Location = new System.Drawing.Point(10, 82);
            this.chkScheduledScan.Name = "chkScheduledScan";
            this.chkScheduledScan.Size = new System.Drawing.Size(135, 17);
            this.chkScheduledScan.TabIndex = 45;
            this.chkScheduledScan.Text = "Sc&heduled scan every ";
            this.toolTip1.SetToolTip(this.chkScheduledScan, "If checked the system will automatically scan and complete actions on a periodic " +
        "schedule");
            this.chkScheduledScan.UseVisualStyleBackColor = true;
            // 
            // chkScanOnStartup
            // 
            this.chkScanOnStartup.AutoSize = true;
            this.chkScanOnStartup.Location = new System.Drawing.Point(10, 59);
            this.chkScanOnStartup.Name = "chkScanOnStartup";
            this.chkScanOnStartup.Size = new System.Drawing.Size(103, 17);
            this.chkScanOnStartup.TabIndex = 44;
            this.chkScanOnStartup.Text = "&Scan on Startup";
            this.toolTip1.SetToolTip(this.chkScanOnStartup, "If checked the system will automatically scan and complete actions on startup");
            this.chkScanOnStartup.UseVisualStyleBackColor = true;
            // 
            // chkIgnoreAllSpecials
            // 
            this.chkIgnoreAllSpecials.AutoSize = true;
            this.chkIgnoreAllSpecials.Location = new System.Drawing.Point(29, 210);
            this.chkIgnoreAllSpecials.Name = "chkIgnoreAllSpecials";
            this.chkIgnoreAllSpecials.Size = new System.Drawing.Size(165, 17);
            this.chkIgnoreAllSpecials.TabIndex = 49;
            this.chkIgnoreAllSpecials.Text = "Ignore Specials  for all Shows";
            this.toolTip1.SetToolTip(this.chkIgnoreAllSpecials, "Ignores \'specials\' season for all shows");
            this.chkIgnoreAllSpecials.UseVisualStyleBackColor = true;
            // 
            // cbAutoSaveOnExit
            // 
            this.cbAutoSaveOnExit.AutoSize = true;
            this.cbAutoSaveOnExit.Location = new System.Drawing.Point(13, 150);
            this.cbAutoSaveOnExit.Name = "cbAutoSaveOnExit";
            this.cbAutoSaveOnExit.Size = new System.Drawing.Size(109, 17);
            this.cbAutoSaveOnExit.TabIndex = 44;
            this.cbAutoSaveOnExit.Text = "Auto save on Exit";
            this.toolTip1.SetToolTip(this.cbAutoSaveOnExit, "Should the system ask the user or always save when the application is shutdown?");
            this.cbAutoSaveOnExit.UseVisualStyleBackColor = true;
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(10, 48);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(85, 13);
            this.label84.TabIndex = 26;
            this.label84.Text = "&Preferred region:";
            this.toolTip1.SetToolTip(this.label84, "TMDB will return release dates and certifications based on your location");
            // 
            // lstMovieMonitorFolders
            // 
            this.lstMovieMonitorFolders.AllowDrop = true;
            this.lstMovieMonitorFolders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstMovieMonitorFolders.FormattingEnabled = true;
            this.lstMovieMonitorFolders.IntegralHeight = false;
            this.lstMovieMonitorFolders.Location = new System.Drawing.Point(6, 323);
            this.lstMovieMonitorFolders.Name = "lstMovieMonitorFolders";
            this.lstMovieMonitorFolders.ScrollAlwaysVisible = true;
            this.lstMovieMonitorFolders.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstMovieMonitorFolders.Size = new System.Drawing.Size(408, 97);
            this.lstMovieMonitorFolders.TabIndex = 49;
            this.toolTip1.SetToolTip(this.lstMovieMonitorFolders, resources.GetString("lstMovieMonitorFolders.ToolTip"));
            this.lstMovieMonitorFolders.SelectedIndexChanged += new System.EventHandler(this.lstMovieMonitorFolders_SelectedIndexChanged);
            this.lstMovieMonitorFolders.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstMovieMonitorFolders_DragDrop);
            this.lstMovieMonitorFolders.DragOver += new System.Windows.Forms.DragEventHandler(this.FileIcon_DragOver);
            this.lstMovieMonitorFolders.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstMovieMonitorFolders_KeyDown);
            // 
            // chkIncludeMoviesQuickRecent
            // 
            this.chkIncludeMoviesQuickRecent.AutoSize = true;
            this.chkIncludeMoviesQuickRecent.Location = new System.Drawing.Point(226, 19);
            this.chkIncludeMoviesQuickRecent.Name = "chkIncludeMoviesQuickRecent";
            this.chkIncludeMoviesQuickRecent.Size = new System.Drawing.Size(180, 17);
            this.chkIncludeMoviesQuickRecent.TabIndex = 50;
            this.chkIncludeMoviesQuickRecent.Text = "&Include Movies in Quick/Recent";
            this.toolTip1.SetToolTip(this.chkIncludeMoviesQuickRecent, "If checked the system will automatically scan and complete actions on startup");
            this.chkIncludeMoviesQuickRecent.UseVisualStyleBackColor = true;
            // 
            // tbCleanUpDownloadDirMoviesLength
            // 
            this.tbCleanUpDownloadDirMoviesLength.Location = new System.Drawing.Point(216, 65);
            this.tbCleanUpDownloadDirMoviesLength.Name = "tbCleanUpDownloadDirMoviesLength";
            this.tbCleanUpDownloadDirMoviesLength.Size = new System.Drawing.Size(55, 20);
            this.tbCleanUpDownloadDirMoviesLength.TabIndex = 14;
            this.toolTip1.SetToolTip(this.tbCleanUpDownloadDirMoviesLength, "Number of letters that the name of the movie must be. To prevent \'Up\' ");
            // 
            // cmDefaults
            // 
            this.cmDefaults.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KODIToolStripMenuItem,
            this.pyTivoToolStripMenuItem,
            this.mede8erToolStripMenuItem,
            this.noneToolStripMenuItem});
            this.cmDefaults.Name = "cmDefaults";
            this.cmDefaults.Size = new System.Drawing.Size(121, 92);
            this.cmDefaults.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmDefaults_ItemClicked);
            // 
            // KODIToolStripMenuItem
            // 
            this.KODIToolStripMenuItem.Name = "KODIToolStripMenuItem";
            this.KODIToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.KODIToolStripMenuItem.Tag = "1";
            this.KODIToolStripMenuItem.Text = "&KODI";
            // 
            // pyTivoToolStripMenuItem
            // 
            this.pyTivoToolStripMenuItem.Name = "pyTivoToolStripMenuItem";
            this.pyTivoToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.pyTivoToolStripMenuItem.Tag = "2";
            this.pyTivoToolStripMenuItem.Text = "&pyTivo";
            // 
            // mede8erToolStripMenuItem
            // 
            this.mede8erToolStripMenuItem.Name = "mede8erToolStripMenuItem";
            this.mede8erToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.mede8erToolStripMenuItem.Tag = "3";
            this.mede8erToolStripMenuItem.Text = "&Mede8er";
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.noneToolStripMenuItem.Tag = "4";
            this.noneToolStripMenuItem.Text = "&None";
            // 
            // tpDisplay
            // 
            this.tpDisplay.Controls.Add(this.chkShowAccessibilityOptions);
            this.tpDisplay.Controls.Add(this.cbUseColoursOnWtw);
            this.tpDisplay.Controls.Add(this.chkBasicShowDetails);
            this.tpDisplay.Controls.Add(this.chkPostpendThe);
            this.tpDisplay.Controls.Add(this.groupBox11);
            this.tpDisplay.Controls.Add(this.label61);
            this.tpDisplay.Controls.Add(this.cbLeadingZero);
            this.tpDisplay.Controls.Add(this.txtSeasonFolderName);
            this.tpDisplay.Controls.Add(this.label35);
            this.tpDisplay.Controls.Add(this.chkHideWtWSpoilers);
            this.tpDisplay.Controls.Add(this.chkHideMyShowsSpoilers);
            this.tpDisplay.Controls.Add(this.rbWTWScan);
            this.tpDisplay.Controls.Add(this.rbWTWSearch);
            this.tpDisplay.Controls.Add(this.cbStartupTab);
            this.tpDisplay.Controls.Add(this.cbAutoSelInMyShows);
            this.tpDisplay.Controls.Add(this.cbShowEpisodePictures);
            this.tpDisplay.Controls.Add(this.label11);
            this.tpDisplay.Controls.Add(this.label6);
            this.tpDisplay.Controls.Add(this.chkShowInTaskbar);
            this.tpDisplay.Controls.Add(this.cbNotificationIcon);
            this.tpDisplay.Controls.Add(this.pbDisplay);
            this.tpDisplay.Location = new System.Drawing.Point(139, 4);
            this.tpDisplay.Name = "tpDisplay";
            this.tpDisplay.Padding = new System.Windows.Forms.Padding(3);
            this.tpDisplay.Size = new System.Drawing.Size(417, 561);
            this.tpDisplay.TabIndex = 13;
            this.tpDisplay.Text = "Display";
            this.tpDisplay.UseVisualStyleBackColor = true;
            // 
            // chkShowAccessibilityOptions
            // 
            this.chkShowAccessibilityOptions.AutoSize = true;
            this.chkShowAccessibilityOptions.Location = new System.Drawing.Point(220, 288);
            this.chkShowAccessibilityOptions.Name = "chkShowAccessibilityOptions";
            this.chkShowAccessibilityOptions.Size = new System.Drawing.Size(150, 17);
            this.chkShowAccessibilityOptions.TabIndex = 45;
            this.chkShowAccessibilityOptions.Text = "Show Accessibilty Options";
            this.chkShowAccessibilityOptions.UseVisualStyleBackColor = true;
            // 
            // cbUseColoursOnWtw
            // 
            this.cbUseColoursOnWtw.AutoSize = true;
            this.cbUseColoursOnWtw.Location = new System.Drawing.Point(220, 311);
            this.cbUseColoursOnWtw.Name = "cbUseColoursOnWtw";
            this.cbUseColoursOnWtw.Size = new System.Drawing.Size(146, 17);
            this.cbUseColoursOnWtw.TabIndex = 44;
            this.cbUseColoursOnWtw.Text = "Use Colours on Schedule";
            this.cbUseColoursOnWtw.UseVisualStyleBackColor = true;
            // 
            // chkBasicShowDetails
            // 
            this.chkBasicShowDetails.AutoSize = true;
            this.chkBasicShowDetails.Location = new System.Drawing.Point(10, 311);
            this.chkBasicShowDetails.Name = "chkBasicShowDetails";
            this.chkBasicShowDetails.Size = new System.Drawing.Size(147, 17);
            this.chkBasicShowDetails.TabIndex = 43;
            this.chkBasicShowDetails.Text = "Show Basic Show Details";
            this.chkBasicShowDetails.UseVisualStyleBackColor = true;
            // 
            // chkPostpendThe
            // 
            this.chkPostpendThe.AutoSize = true;
            this.chkPostpendThe.Location = new System.Drawing.Point(10, 216);
            this.chkPostpendThe.Name = "chkPostpendThe";
            this.chkPostpendThe.Size = new System.Drawing.Size(237, 17);
            this.chkPostpendThe.TabIndex = 42;
            this.chkPostpendThe.Text = "Move \'The\' to the end of show/movie names";
            this.chkPostpendThe.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox11.Controls.Add(this.label7);
            this.groupBox11.Controls.Add(this.cboShowStatus);
            this.groupBox11.Controls.Add(this.label5);
            this.groupBox11.Controls.Add(this.txtShowStatusColor);
            this.groupBox11.Controls.Add(this.btnSelectColor);
            this.groupBox11.Controls.Add(this.bnRemoveDefinedColor);
            this.groupBox11.Controls.Add(this.btnAddShowStatusColoring);
            this.groupBox11.Controls.Add(this.lvwDefinedColors);
            this.groupBox11.Location = new System.Drawing.Point(6, 334);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(402, 221);
            this.groupBox11.TabIndex = 41;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Show Colouring";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "&Status:";
            // 
            // cboShowStatus
            // 
            this.cboShowStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboShowStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboShowStatus.FormattingEnabled = true;
            this.cboShowStatus.Location = new System.Drawing.Point(50, 166);
            this.cboShowStatus.Name = "cboShowStatus";
            this.cboShowStatus.Size = new System.Drawing.Size(346, 21);
            this.cboShowStatus.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "&Text Color:";
            // 
            // txtShowStatusColor
            // 
            this.txtShowStatusColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtShowStatusColor.Location = new System.Drawing.Point(67, 193);
            this.txtShowStatusColor.Name = "txtShowStatusColor";
            this.txtShowStatusColor.Size = new System.Drawing.Size(100, 20);
            this.txtShowStatusColor.TabIndex = 13;
            this.txtShowStatusColor.TextChanged += new System.EventHandler(this.txtShowStatusColor_TextChanged);
            // 
            // btnSelectColor
            // 
            this.btnSelectColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelectColor.Location = new System.Drawing.Point(173, 192);
            this.btnSelectColor.Name = "btnSelectColor";
            this.btnSelectColor.Size = new System.Drawing.Size(75, 23);
            this.btnSelectColor.TabIndex = 12;
            this.btnSelectColor.Text = "Select &Color";
            this.btnSelectColor.UseVisualStyleBackColor = true;
            this.btnSelectColor.Click += new System.EventHandler(this.btnSelectColor_Click);
            // 
            // bnRemoveDefinedColor
            // 
            this.bnRemoveDefinedColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bnRemoveDefinedColor.Enabled = false;
            this.bnRemoveDefinedColor.Location = new System.Drawing.Point(3, 137);
            this.bnRemoveDefinedColor.Name = "bnRemoveDefinedColor";
            this.bnRemoveDefinedColor.Size = new System.Drawing.Size(75, 23);
            this.bnRemoveDefinedColor.TabIndex = 10;
            this.bnRemoveDefinedColor.Text = "&Remove";
            this.bnRemoveDefinedColor.UseVisualStyleBackColor = true;
            this.bnRemoveDefinedColor.Click += new System.EventHandler(this.bnRemoveDefinedColor_Click);
            // 
            // btnAddShowStatusColoring
            // 
            this.btnAddShowStatusColoring.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddShowStatusColoring.Location = new System.Drawing.Point(321, 192);
            this.btnAddShowStatusColoring.Name = "btnAddShowStatusColoring";
            this.btnAddShowStatusColoring.Size = new System.Drawing.Size(75, 23);
            this.btnAddShowStatusColoring.TabIndex = 11;
            this.btnAddShowStatusColoring.Text = "&Add";
            this.btnAddShowStatusColoring.UseVisualStyleBackColor = true;
            this.btnAddShowStatusColoring.Click += new System.EventHandler(this.btnAddShowStatusColoring_Click);
            // 
            // lvwDefinedColors
            // 
            this.lvwDefinedColors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwDefinedColors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colShowStatus,
            this.colColor});
            this.lvwDefinedColors.GridLines = true;
            this.lvwDefinedColors.HideSelection = false;
            this.lvwDefinedColors.Location = new System.Drawing.Point(6, 19);
            this.lvwDefinedColors.MultiSelect = false;
            this.lvwDefinedColors.Name = "lvwDefinedColors";
            this.lvwDefinedColors.Size = new System.Drawing.Size(390, 112);
            this.lvwDefinedColors.TabIndex = 9;
            this.lvwDefinedColors.UseCompatibleStateImageBehavior = false;
            this.lvwDefinedColors.View = System.Windows.Forms.View.Details;
            this.lvwDefinedColors.SelectedIndexChanged += new System.EventHandler(this.EnableDisable);
            this.lvwDefinedColors.DoubleClick += new System.EventHandler(this.lvwDefinedColors_DoubleClick);
            // 
            // colShowStatus
            // 
            this.colShowStatus.Text = "Show Status";
            this.colShowStatus.Width = 297;
            // 
            // colColor
            // 
            this.colColor.Text = "Color";
            this.colColor.Width = 92;
            // 
            // label61
            // 
            this.label61.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(7, 7);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(298, 39);
            this.label61.TabIndex = 40;
            this.label61.Text = "Settings that contol the way that TV Rename looks. These do\r\nnot have any impact " +
    "on the main scanning, just on the way \r\nthe interface looks.";
            // 
            // cbLeadingZero
            // 
            this.cbLeadingZero.AutoSize = true;
            this.cbLeadingZero.Location = new System.Drawing.Point(10, 288);
            this.cbLeadingZero.Name = "cbLeadingZero";
            this.cbLeadingZero.Size = new System.Drawing.Size(170, 17);
            this.cbLeadingZero.TabIndex = 38;
            this.cbLeadingZero.Text = "&Leading 0 on Season numbers";
            this.cbLeadingZero.UseVisualStyleBackColor = true;
            // 
            // txtSeasonFolderName
            // 
            this.txtSeasonFolderName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSeasonFolderName.Location = new System.Drawing.Point(114, 262);
            this.txtSeasonFolderName.Name = "txtSeasonFolderName";
            this.txtSeasonFolderName.Size = new System.Drawing.Size(294, 20);
            this.txtSeasonFolderName.TabIndex = 37;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(7, 265);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(80, 13);
            this.label35.TabIndex = 36;
            this.label35.Text = "&Seasons name:";
            // 
            // chkHideWtWSpoilers
            // 
            this.chkHideWtWSpoilers.AutoSize = true;
            this.chkHideWtWSpoilers.Location = new System.Drawing.Point(220, 193);
            this.chkHideWtWSpoilers.Name = "chkHideWtWSpoilers";
            this.chkHideWtWSpoilers.Size = new System.Drawing.Size(147, 17);
            this.chkHideWtWSpoilers.TabIndex = 35;
            this.chkHideWtWSpoilers.Text = "Hide Spoilers in Schedule";
            this.chkHideWtWSpoilers.UseVisualStyleBackColor = true;
            // 
            // chkHideMyShowsSpoilers
            // 
            this.chkHideMyShowsSpoilers.AutoSize = true;
            this.chkHideMyShowsSpoilers.Location = new System.Drawing.Point(10, 193);
            this.chkHideMyShowsSpoilers.Name = "chkHideMyShowsSpoilers";
            this.chkHideMyShowsSpoilers.Size = new System.Drawing.Size(151, 17);
            this.chkHideMyShowsSpoilers.TabIndex = 34;
            this.chkHideMyShowsSpoilers.Text = "Hide Spoilers in My Shows";
            this.chkHideMyShowsSpoilers.UseVisualStyleBackColor = true;
            // 
            // rbWTWScan
            // 
            this.rbWTWScan.AutoSize = true;
            this.rbWTWScan.Location = new System.Drawing.Point(28, 98);
            this.rbWTWScan.Name = "rbWTWScan";
            this.rbWTWScan.Size = new System.Drawing.Size(50, 17);
            this.rbWTWScan.TabIndex = 27;
            this.rbWTWScan.Text = "S&can";
            this.rbWTWScan.UseVisualStyleBackColor = true;
            // 
            // rbWTWSearch
            // 
            this.rbWTWSearch.AutoSize = true;
            this.rbWTWSearch.Checked = true;
            this.rbWTWSearch.Location = new System.Drawing.Point(28, 79);
            this.rbWTWSearch.Name = "rbWTWSearch";
            this.rbWTWSearch.Size = new System.Drawing.Size(59, 17);
            this.rbWTWSearch.TabIndex = 26;
            this.rbWTWSearch.TabStop = true;
            this.rbWTWSearch.Text = "S&earch";
            this.rbWTWSearch.UseVisualStyleBackColor = true;
            // 
            // cbStartupTab
            // 
            this.cbStartupTab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStartupTab.FormattingEnabled = true;
            this.cbStartupTab.Items.AddRange(new object[] {
            "Movies",
            "TV Shows",
            "Scan",
            "Schedule"});
            this.cbStartupTab.Location = new System.Drawing.Point(75, 120);
            this.cbStartupTab.Name = "cbStartupTab";
            this.cbStartupTab.Size = new System.Drawing.Size(135, 21);
            this.cbStartupTab.TabIndex = 29;
            // 
            // cbAutoSelInMyShows
            // 
            this.cbAutoSelInMyShows.AutoSize = true;
            this.cbAutoSelInMyShows.Location = new System.Drawing.Point(10, 239);
            this.cbAutoSelInMyShows.Name = "cbAutoSelInMyShows";
            this.cbAutoSelInMyShows.Size = new System.Drawing.Size(268, 17);
            this.cbAutoSelInMyShows.TabIndex = 33;
            this.cbAutoSelInMyShows.Text = "&Automatically select show and season in My Shows";
            this.cbAutoSelInMyShows.UseVisualStyleBackColor = true;
            // 
            // cbShowEpisodePictures
            // 
            this.cbShowEpisodePictures.AutoSize = true;
            this.cbShowEpisodePictures.Location = new System.Drawing.Point(10, 170);
            this.cbShowEpisodePictures.Name = "cbShowEpisodePictures";
            this.cbShowEpisodePictures.Size = new System.Drawing.Size(218, 17);
            this.cbShowEpisodePictures.TabIndex = 32;
            this.cbShowEpisodePictures.Text = "S&how episode pictures in episode guides";
            this.cbShowEpisodePictures.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Double-click in Schedule does:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "&Startup tab:";
            // 
            // chkShowInTaskbar
            // 
            this.chkShowInTaskbar.AutoSize = true;
            this.chkShowInTaskbar.Location = new System.Drawing.Point(220, 147);
            this.chkShowInTaskbar.Name = "chkShowInTaskbar";
            this.chkShowInTaskbar.Size = new System.Drawing.Size(102, 17);
            this.chkShowInTaskbar.TabIndex = 31;
            this.chkShowInTaskbar.Text = "Show in &taskbar";
            this.chkShowInTaskbar.UseVisualStyleBackColor = true;
            this.chkShowInTaskbar.CheckedChanged += new System.EventHandler(this.EnableDisable);
            // 
            // cbNotificationIcon
            // 
            this.cbNotificationIcon.AutoSize = true;
            this.cbNotificationIcon.Location = new System.Drawing.Point(10, 147);
            this.cbNotificationIcon.Name = "cbNotificationIcon";
            this.cbNotificationIcon.Size = new System.Drawing.Size(154, 17);
            this.cbNotificationIcon.TabIndex = 30;
            this.cbNotificationIcon.Text = "Show &notification area icon";
            this.cbNotificationIcon.UseVisualStyleBackColor = true;
            this.cbNotificationIcon.CheckedChanged += new System.EventHandler(this.EnableDisable);
            // 
            // pbDisplay
            // 
            this.pbDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDisplay.Image = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pbDisplay.InitialImage = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pbDisplay.Location = new System.Drawing.Point(368, 6);
            this.pbDisplay.Name = "pbDisplay";
            this.pbDisplay.Size = new System.Drawing.Size(43, 40);
            this.pbDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbDisplay.TabIndex = 39;
            this.pbDisplay.TabStop = false;
            this.pbDisplay.Click += new System.EventHandler(this.pbDisplay_Click);
            // 
            // tpRSSJSONSearch
            // 
            this.tpRSSJSONSearch.Controls.Add(this.pbRSSJSONSearch);
            this.tpRSSJSONSearch.Controls.Add(this.label59);
            this.tpRSSJSONSearch.Controls.Add(this.cbSearchJSON);
            this.tpRSSJSONSearch.Controls.Add(this.cbSearchRSS);
            this.tpRSSJSONSearch.Controls.Add(this.gbJSON);
            this.tpRSSJSONSearch.Controls.Add(this.gbRSS);
            this.tpRSSJSONSearch.Location = new System.Drawing.Point(139, 4);
            this.tpRSSJSONSearch.Name = "tpRSSJSONSearch";
            this.tpRSSJSONSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tpRSSJSONSearch.Size = new System.Drawing.Size(417, 561);
            this.tpRSSJSONSearch.TabIndex = 12;
            this.tpRSSJSONSearch.Text = "RSS/JSON Search";
            this.tpRSSJSONSearch.UseVisualStyleBackColor = true;
            // 
            // pbRSSJSONSearch
            // 
            this.pbRSSJSONSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbRSSJSONSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRSSJSONSearch.Image = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pbRSSJSONSearch.InitialImage = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pbRSSJSONSearch.Location = new System.Drawing.Point(368, 6);
            this.pbRSSJSONSearch.Name = "pbRSSJSONSearch";
            this.pbRSSJSONSearch.Size = new System.Drawing.Size(43, 40);
            this.pbRSSJSONSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbRSSJSONSearch.TabIndex = 38;
            this.pbRSSJSONSearch.TabStop = false;
            this.pbRSSJSONSearch.Click += new System.EventHandler(this.pbRSSJSONSearch_Click);
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(3, 13);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(334, 39);
            this.label59.TabIndex = 37;
            this.label59.Text = "If an episode is missing from your library, TV Rename will look in the \r\nfollowin" +
    "g URLs for appropriate files to download. It will use the torrent \r\nhandlers to " +
    "download the file(s)";
            // 
            // cbSearchJSON
            // 
            this.cbSearchJSON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbSearchJSON.AutoSize = true;
            this.cbSearchJSON.Location = new System.Drawing.Point(8, 320);
            this.cbSearchJSON.Name = "cbSearchJSON";
            this.cbSearchJSON.Size = new System.Drawing.Size(164, 17);
            this.cbSearchJSON.TabIndex = 36;
            this.cbSearchJSON.Text = "Search &JSON for missing files";
            this.cbSearchJSON.UseVisualStyleBackColor = true;
            this.cbSearchJSON.CheckedChanged += new System.EventHandler(this.EnableDisable);
            // 
            // cbSearchRSS
            // 
            this.cbSearchRSS.AutoSize = true;
            this.cbSearchRSS.Location = new System.Drawing.Point(6, 66);
            this.cbSearchRSS.Name = "cbSearchRSS";
            this.cbSearchRSS.Size = new System.Drawing.Size(158, 17);
            this.cbSearchRSS.TabIndex = 35;
            this.cbSearchRSS.Text = "&Search RSS for missing files";
            this.cbSearchRSS.UseVisualStyleBackColor = true;
            this.cbSearchRSS.CheckedChanged += new System.EventHandler(this.EnableDisable);
            // 
            // gbJSON
            // 
            this.gbJSON.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbJSON.Controls.Add(this.label78);
            this.gbJSON.Controls.Add(this.tbJSONSeedersToken);
            this.gbJSON.Controls.Add(this.cbJSONCloudflareProtection);
            this.gbJSON.Controls.Add(this.cbSearchJSONManualScanOnly);
            this.gbJSON.Controls.Add(this.label55);
            this.gbJSON.Controls.Add(this.tbJSONFilesizeToken);
            this.gbJSON.Controls.Add(this.label51);
            this.gbJSON.Controls.Add(this.tbJSONFilenameToken);
            this.gbJSON.Controls.Add(this.label50);
            this.gbJSON.Controls.Add(this.tbJSONURLToken);
            this.gbJSON.Controls.Add(this.label49);
            this.gbJSON.Controls.Add(this.tbJSONRootNode);
            this.gbJSON.Controls.Add(this.label48);
            this.gbJSON.Controls.Add(this.tbJSONURL);
            this.gbJSON.Location = new System.Drawing.Point(6, 343);
            this.gbJSON.Name = "gbJSON";
            this.gbJSON.Size = new System.Drawing.Size(408, 199);
            this.gbJSON.TabIndex = 33;
            this.gbJSON.TabStop = false;
            this.gbJSON.Text = "JSON Search";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(7, 175);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(83, 13);
            this.label78.TabIndex = 42;
            this.label78.Text = "Seeders Token:";
            // 
            // tbJSONSeedersToken
            // 
            this.tbJSONSeedersToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbJSONSeedersToken.Location = new System.Drawing.Point(98, 172);
            this.tbJSONSeedersToken.Name = "tbJSONSeedersToken";
            this.tbJSONSeedersToken.Size = new System.Drawing.Size(305, 20);
            this.tbJSONSeedersToken.TabIndex = 41;
            // 
            // cbJSONCloudflareProtection
            // 
            this.cbJSONCloudflareProtection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbJSONCloudflareProtection.AutoSize = true;
            this.cbJSONCloudflareProtection.Location = new System.Drawing.Point(253, 19);
            this.cbJSONCloudflareProtection.Name = "cbJSONCloudflareProtection";
            this.cbJSONCloudflareProtection.Size = new System.Drawing.Size(145, 17);
            this.cbJSONCloudflareProtection.TabIndex = 40;
            this.cbJSONCloudflareProtection.Text = "Use Cloudflare protection";
            this.cbJSONCloudflareProtection.UseVisualStyleBackColor = true;
            // 
            // cbSearchJSONManualScanOnly
            // 
            this.cbSearchJSONManualScanOnly.AutoSize = true;
            this.cbSearchJSONManualScanOnly.Location = new System.Drawing.Point(9, 19);
            this.cbSearchJSONManualScanOnly.Name = "cbSearchJSONManualScanOnly";
            this.cbSearchJSONManualScanOnly.Size = new System.Drawing.Size(130, 17);
            this.cbSearchJSONManualScanOnly.TabIndex = 38;
            this.cbSearchJSONManualScanOnly.Text = "Only on manual scans";
            this.cbSearchJSONManualScanOnly.UseVisualStyleBackColor = true;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(6, 149);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(64, 13);
            this.label55.TabIndex = 39;
            this.label55.Text = "Size Token:";
            // 
            // tbJSONFilesizeToken
            // 
            this.tbJSONFilesizeToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbJSONFilesizeToken.Location = new System.Drawing.Point(97, 146);
            this.tbJSONFilesizeToken.Name = "tbJSONFilesizeToken";
            this.tbJSONFilesizeToken.Size = new System.Drawing.Size(305, 20);
            this.tbJSONFilesizeToken.TabIndex = 38;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(6, 97);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(86, 13);
            this.label51.TabIndex = 37;
            this.label51.Text = "Filename Token:";
            // 
            // tbJSONFilenameToken
            // 
            this.tbJSONFilenameToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbJSONFilenameToken.Location = new System.Drawing.Point(98, 94);
            this.tbJSONFilenameToken.Name = "tbJSONFilenameToken";
            this.tbJSONFilenameToken.Size = new System.Drawing.Size(305, 20);
            this.tbJSONFilenameToken.TabIndex = 36;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(6, 123);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(66, 13);
            this.label50.TabIndex = 35;
            this.label50.Text = "URL Token:";
            // 
            // tbJSONURLToken
            // 
            this.tbJSONURLToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbJSONURLToken.Location = new System.Drawing.Point(98, 120);
            this.tbJSONURLToken.Name = "tbJSONURLToken";
            this.tbJSONURLToken.Size = new System.Drawing.Size(305, 20);
            this.tbJSONURLToken.TabIndex = 34;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(6, 71);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(62, 13);
            this.label49.TabIndex = 33;
            this.label49.Text = "Root Node:";
            // 
            // tbJSONRootNode
            // 
            this.tbJSONRootNode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbJSONRootNode.Location = new System.Drawing.Point(98, 68);
            this.tbJSONRootNode.Name = "tbJSONRootNode";
            this.tbJSONRootNode.Size = new System.Drawing.Size(305, 20);
            this.tbJSONRootNode.TabIndex = 32;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(6, 45);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(32, 13);
            this.label48.TabIndex = 31;
            this.label48.Text = "URL:";
            // 
            // tbJSONURL
            // 
            this.tbJSONURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbJSONURL.Location = new System.Drawing.Point(97, 42);
            this.tbJSONURL.Name = "tbJSONURL";
            this.tbJSONURL.Size = new System.Drawing.Size(305, 20);
            this.tbJSONURL.TabIndex = 30;
            // 
            // gbRSS
            // 
            this.gbRSS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRSS.Controls.Add(this.cbRSSCloudflareProtection);
            this.gbRSS.Controls.Add(this.cbSearchRSSManualScanOnly);
            this.gbRSS.Controls.Add(this.RSSGrid);
            this.gbRSS.Controls.Add(this.label25);
            this.gbRSS.Controls.Add(this.bnRSSRemove);
            this.gbRSS.Controls.Add(this.bnRSSGo);
            this.gbRSS.Controls.Add(this.bnRSSAdd);
            this.gbRSS.Location = new System.Drawing.Point(3, 86);
            this.gbRSS.Name = "gbRSS";
            this.gbRSS.Size = new System.Drawing.Size(407, 228);
            this.gbRSS.TabIndex = 32;
            this.gbRSS.TabStop = false;
            this.gbRSS.Text = "RSS Search";
            // 
            // cbRSSCloudflareProtection
            // 
            this.cbRSSCloudflareProtection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRSSCloudflareProtection.AutoSize = true;
            this.cbRSSCloudflareProtection.Location = new System.Drawing.Point(256, 19);
            this.cbRSSCloudflareProtection.Name = "cbRSSCloudflareProtection";
            this.cbRSSCloudflareProtection.Size = new System.Drawing.Size(145, 17);
            this.cbRSSCloudflareProtection.TabIndex = 41;
            this.cbRSSCloudflareProtection.Text = "Use Cloudflare protection";
            this.cbRSSCloudflareProtection.UseVisualStyleBackColor = true;
            // 
            // cbSearchRSSManualScanOnly
            // 
            this.cbSearchRSSManualScanOnly.AutoSize = true;
            this.cbSearchRSSManualScanOnly.Location = new System.Drawing.Point(6, 19);
            this.cbSearchRSSManualScanOnly.Name = "cbSearchRSSManualScanOnly";
            this.cbSearchRSSManualScanOnly.Size = new System.Drawing.Size(130, 17);
            this.cbSearchRSSManualScanOnly.TabIndex = 37;
            this.cbSearchRSSManualScanOnly.Text = "Only on manual scans";
            this.cbSearchRSSManualScanOnly.UseVisualStyleBackColor = true;
            // 
            // RSSGrid
            // 
            this.RSSGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RSSGrid.BackColor = System.Drawing.SystemColors.Window;
            this.RSSGrid.EnableSort = true;
            this.RSSGrid.Location = new System.Drawing.Point(6, 55);
            this.RSSGrid.Name = "RSSGrid";
            this.RSSGrid.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.RSSGrid.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.RSSGrid.Size = new System.Drawing.Size(395, 134);
            this.RSSGrid.TabIndex = 26;
            this.RSSGrid.TabStop = true;
            this.RSSGrid.ToolTipText = "";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(3, 39);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(99, 13);
            this.label25.TabIndex = 25;
            this.label25.Text = "Torrent RSS URLs:";
            // 
            // bnRSSRemove
            // 
            this.bnRSSRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bnRSSRemove.Location = new System.Drawing.Point(87, 198);
            this.bnRSSRemove.Name = "bnRSSRemove";
            this.bnRSSRemove.Size = new System.Drawing.Size(75, 23);
            this.bnRSSRemove.TabIndex = 28;
            this.bnRSSRemove.Text = "&Remove";
            this.bnRSSRemove.UseVisualStyleBackColor = true;
            this.bnRSSRemove.Click += new System.EventHandler(this.bnRSSRemove_Click);
            // 
            // bnRSSGo
            // 
            this.bnRSSGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bnRSSGo.Location = new System.Drawing.Point(168, 198);
            this.bnRSSGo.Name = "bnRSSGo";
            this.bnRSSGo.Size = new System.Drawing.Size(75, 23);
            this.bnRSSGo.TabIndex = 29;
            this.bnRSSGo.Text = "&Open";
            this.bnRSSGo.UseVisualStyleBackColor = true;
            this.bnRSSGo.Click += new System.EventHandler(this.bnRSSGo_Click);
            // 
            // bnRSSAdd
            // 
            this.bnRSSAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bnRSSAdd.Location = new System.Drawing.Point(6, 198);
            this.bnRSSAdd.Name = "bnRSSAdd";
            this.bnRSSAdd.Size = new System.Drawing.Size(75, 23);
            this.bnRSSAdd.TabIndex = 27;
            this.bnRSSAdd.Text = "&Add";
            this.bnRSSAdd.UseVisualStyleBackColor = true;
            this.bnRSSAdd.Click += new System.EventHandler(this.bnRSSAdd_Click);
            // 
            // tpLibraryFolders
            // 
            this.tpLibraryFolders.Controls.Add(this.groupBox23);
            this.tpLibraryFolders.Controls.Add(this.label87);
            this.tpLibraryFolders.Controls.Add(this.bnOpenMovieMonFolder);
            this.tpLibraryFolders.Controls.Add(this.bnAddMovieMonFolder);
            this.tpLibraryFolders.Controls.Add(this.bnRemoveMovieMonFolder);
            this.tpLibraryFolders.Controls.Add(this.lstMovieMonitorFolders);
            this.tpLibraryFolders.Controls.Add(this.groupBox6);
            this.tpLibraryFolders.Controls.Add(this.label65);
            this.tpLibraryFolders.Controls.Add(this.label56);
            this.tpLibraryFolders.Controls.Add(this.bnOpenMonFolder);
            this.tpLibraryFolders.Controls.Add(this.bnAddMonFolder);
            this.tpLibraryFolders.Controls.Add(this.bnRemoveMonFolder);
            this.tpLibraryFolders.Controls.Add(this.pbLibraryFolders);
            this.tpLibraryFolders.Controls.Add(this.lstFMMonitorFolders);
            this.tpLibraryFolders.Location = new System.Drawing.Point(139, 4);
            this.tpLibraryFolders.Name = "tpLibraryFolders";
            this.tpLibraryFolders.Padding = new System.Windows.Forms.Padding(3);
            this.tpLibraryFolders.Size = new System.Drawing.Size(417, 561);
            this.tpLibraryFolders.TabIndex = 10;
            this.tpLibraryFolders.Text = "Library Folders";
            this.tpLibraryFolders.UseVisualStyleBackColor = true;
            // 
            // groupBox23
            // 
            this.groupBox23.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox23.Controls.Add(this.button3);
            this.groupBox23.Controls.Add(this.txtMovieFilenameFormat);
            this.groupBox23.Controls.Add(this.label90);
            this.groupBox23.Controls.Add(this.button2);
            this.groupBox23.Controls.Add(this.txtMovieFolderFormat);
            this.groupBox23.Controls.Add(this.label85);
            this.groupBox23.Location = new System.Drawing.Point(9, 455);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(401, 86);
            this.groupBox23.TabIndex = 54;
            this.groupBox23.TabStop = false;
            this.groupBox23.Text = "Default Movie Library Folder Format";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(333, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 23);
            this.button3.TabIndex = 34;
            this.button3.Text = "Tags...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtMovieFilenameFormat
            // 
            this.txtMovieFilenameFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMovieFilenameFormat.Location = new System.Drawing.Point(124, 52);
            this.txtMovieFilenameFormat.Name = "txtMovieFilenameFormat";
            this.txtMovieFilenameFormat.Size = new System.Drawing.Size(203, 20);
            this.txtMovieFilenameFormat.TabIndex = 33;
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(6, 56);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(84, 13);
            this.label90.TabIndex = 32;
            this.label90.Text = "Filename format:";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(333, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "Tags...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtMovieFolderFormat
            // 
            this.txtMovieFolderFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMovieFolderFormat.Location = new System.Drawing.Point(124, 23);
            this.txtMovieFolderFormat.Name = "txtMovieFolderFormat";
            this.txtMovieFolderFormat.Size = new System.Drawing.Size(203, 20);
            this.txtMovieFolderFormat.TabIndex = 30;
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(6, 27);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(71, 13);
            this.label85.TabIndex = 29;
            this.label85.Text = "&Folder format:";
            // 
            // label87
            // 
            this.label87.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(6, 307);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(107, 13);
            this.label87.TabIndex = 53;
            this.label87.Text = "Movie &Library Folders";
            // 
            // bnOpenMovieMonFolder
            // 
            this.bnOpenMovieMonFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bnOpenMovieMonFolder.Enabled = false;
            this.bnOpenMovieMonFolder.Location = new System.Drawing.Point(168, 426);
            this.bnOpenMovieMonFolder.Name = "bnOpenMovieMonFolder";
            this.bnOpenMovieMonFolder.Size = new System.Drawing.Size(75, 23);
            this.bnOpenMovieMonFolder.TabIndex = 52;
            this.bnOpenMovieMonFolder.Text = "&Open";
            this.bnOpenMovieMonFolder.UseVisualStyleBackColor = true;
            this.bnOpenMovieMonFolder.Click += new System.EventHandler(this.bnOpenMovieMonFolder_Click);
            // 
            // bnAddMovieMonFolder
            // 
            this.bnAddMovieMonFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bnAddMovieMonFolder.Location = new System.Drawing.Point(6, 426);
            this.bnAddMovieMonFolder.Name = "bnAddMovieMonFolder";
            this.bnAddMovieMonFolder.Size = new System.Drawing.Size(75, 23);
            this.bnAddMovieMonFolder.TabIndex = 50;
            this.bnAddMovieMonFolder.Text = "&Add";
            this.bnAddMovieMonFolder.UseVisualStyleBackColor = true;
            this.bnAddMovieMonFolder.Click += new System.EventHandler(this.bnAddMovieMonFolder_Click);
            // 
            // bnRemoveMovieMonFolder
            // 
            this.bnRemoveMovieMonFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bnRemoveMovieMonFolder.Enabled = false;
            this.bnRemoveMovieMonFolder.Location = new System.Drawing.Point(87, 426);
            this.bnRemoveMovieMonFolder.Name = "bnRemoveMovieMonFolder";
            this.bnRemoveMovieMonFolder.Size = new System.Drawing.Size(75, 23);
            this.bnRemoveMovieMonFolder.TabIndex = 51;
            this.bnRemoveMovieMonFolder.Text = "&Remove";
            this.bnRemoveMovieMonFolder.UseVisualStyleBackColor = true;
            this.bnRemoveMovieMonFolder.Click += new System.EventHandler(this.bnRemoveMovieMonFolder_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.txtSeasonFormat);
            this.groupBox6.Controls.Add(this.txtSpecialsFolderName);
            this.groupBox6.Controls.Add(this.label47);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Location = new System.Drawing.Point(9, 201);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(401, 100);
            this.groupBox6.TabIndex = 48;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Default TV Library Folder Format";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(333, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Tags...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSeasonFormat
            // 
            this.txtSeasonFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSeasonFormat.Location = new System.Drawing.Point(124, 53);
            this.txtSeasonFormat.Name = "txtSeasonFormat";
            this.txtSeasonFormat.Size = new System.Drawing.Size(203, 20);
            this.txtSeasonFormat.TabIndex = 30;
            // 
            // txtSpecialsFolderName
            // 
            this.txtSpecialsFolderName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSpecialsFolderName.Location = new System.Drawing.Point(124, 27);
            this.txtSpecialsFolderName.Name = "txtSpecialsFolderName";
            this.txtSpecialsFolderName.Size = new System.Drawing.Size(271, 20);
            this.txtSpecialsFolderName.TabIndex = 28;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(6, 57);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(112, 13);
            this.label47.TabIndex = 29;
            this.label47.Text = "&Seasons folder format:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "&Specials folder name:";
            // 
            // label65
            // 
            this.label65.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(6, 6);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(299, 26);
            this.label65.TabIndex = 44;
            this.label65.Text = "TV Rename considers 2 sets of folders. Library Folders are the\r\nbase folders for " +
    "a sorted collection of files";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(3, 53);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(92, 13);
            this.label56.TabIndex = 36;
            this.label56.Text = "TV &Library Folders";
            // 
            // bnOpenMonFolder
            // 
            this.bnOpenMonFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bnOpenMonFolder.Enabled = false;
            this.bnOpenMonFolder.Location = new System.Drawing.Point(168, 172);
            this.bnOpenMonFolder.Name = "bnOpenMonFolder";
            this.bnOpenMonFolder.Size = new System.Drawing.Size(75, 23);
            this.bnOpenMonFolder.TabIndex = 35;
            this.bnOpenMonFolder.Text = "&Open";
            this.bnOpenMonFolder.UseVisualStyleBackColor = true;
            this.bnOpenMonFolder.Click += new System.EventHandler(this.bnOpenMonFolder_Click);
            // 
            // bnAddMonFolder
            // 
            this.bnAddMonFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bnAddMonFolder.Location = new System.Drawing.Point(6, 172);
            this.bnAddMonFolder.Name = "bnAddMonFolder";
            this.bnAddMonFolder.Size = new System.Drawing.Size(75, 23);
            this.bnAddMonFolder.TabIndex = 33;
            this.bnAddMonFolder.Text = "&Add";
            this.bnAddMonFolder.UseVisualStyleBackColor = true;
            this.bnAddMonFolder.Click += new System.EventHandler(this.bnAddMonFolder_Click);
            // 
            // bnRemoveMonFolder
            // 
            this.bnRemoveMonFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bnRemoveMonFolder.Enabled = false;
            this.bnRemoveMonFolder.Location = new System.Drawing.Point(87, 172);
            this.bnRemoveMonFolder.Name = "bnRemoveMonFolder";
            this.bnRemoveMonFolder.Size = new System.Drawing.Size(75, 23);
            this.bnRemoveMonFolder.TabIndex = 34;
            this.bnRemoveMonFolder.Text = "&Remove";
            this.bnRemoveMonFolder.UseVisualStyleBackColor = true;
            this.bnRemoveMonFolder.Click += new System.EventHandler(this.bnRemoveMonFolder_Click);
            // 
            // pbLibraryFolders
            // 
            this.pbLibraryFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLibraryFolders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLibraryFolders.Image = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pbLibraryFolders.InitialImage = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pbLibraryFolders.Location = new System.Drawing.Point(368, 6);
            this.pbLibraryFolders.Name = "pbLibraryFolders";
            this.pbLibraryFolders.Size = new System.Drawing.Size(43, 40);
            this.pbLibraryFolders.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLibraryFolders.TabIndex = 43;
            this.pbLibraryFolders.TabStop = false;
            this.pbLibraryFolders.Click += new System.EventHandler(this.pbLibraryFolders_Click);
            // 
            // tpTorrentNZB
            // 
            this.tpTorrentNZB.Controls.Add(this.pbuTorrentNZB);
            this.tpTorrentNZB.Controls.Add(this.label58);
            this.tpTorrentNZB.Controls.Add(this.cbCheckqBitTorrent);
            this.tpTorrentNZB.Controls.Add(this.cbCheckSABnzbd);
            this.tpTorrentNZB.Controls.Add(this.cbCheckuTorrent);
            this.tpTorrentNZB.Controls.Add(this.qBitTorrent);
            this.tpTorrentNZB.Controls.Add(this.gbSAB);
            this.tpTorrentNZB.Controls.Add(this.gbuTorrent);
            this.tpTorrentNZB.Location = new System.Drawing.Point(139, 4);
            this.tpTorrentNZB.Name = "tpTorrentNZB";
            this.tpTorrentNZB.Padding = new System.Windows.Forms.Padding(3);
            this.tpTorrentNZB.Size = new System.Drawing.Size(417, 561);
            this.tpTorrentNZB.TabIndex = 4;
            this.tpTorrentNZB.Text = "Torrents / NZB";
            this.tpTorrentNZB.UseVisualStyleBackColor = true;
            // 
            // pbuTorrentNZB
            // 
            this.pbuTorrentNZB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbuTorrentNZB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbuTorrentNZB.Image = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pbuTorrentNZB.InitialImage = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pbuTorrentNZB.Location = new System.Drawing.Point(368, 6);
            this.pbuTorrentNZB.Name = "pbuTorrentNZB";
            this.pbuTorrentNZB.Size = new System.Drawing.Size(43, 40);
            this.pbuTorrentNZB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbuTorrentNZB.TabIndex = 21;
            this.pbuTorrentNZB.TabStop = false;
            this.pbuTorrentNZB.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(3, 6);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(326, 26);
            this.label58.TabIndex = 20;
            this.label58.Text = "If an episode is missing from your library, TV Rename will look in the \r\nfollowin" +
    "g locations to see whether it is already being downloaded.";
            // 
            // cbCheckqBitTorrent
            // 
            this.cbCheckqBitTorrent.AutoSize = true;
            this.cbCheckqBitTorrent.Location = new System.Drawing.Point(6, 285);
            this.cbCheckqBitTorrent.Name = "cbCheckqBitTorrent";
            this.cbCheckqBitTorrent.Size = new System.Drawing.Size(145, 17);
            this.cbCheckqBitTorrent.TabIndex = 19;
            this.cbCheckqBitTorrent.Text = "Check &qBitTorrent queue";
            this.cbCheckqBitTorrent.UseVisualStyleBackColor = true;
            this.cbCheckqBitTorrent.CheckedChanged += new System.EventHandler(this.EnableDisable);
            // 
            // cbCheckSABnzbd
            // 
            this.cbCheckSABnzbd.AutoSize = true;
            this.cbCheckSABnzbd.Location = new System.Drawing.Point(6, 66);
            this.cbCheckSABnzbd.Name = "cbCheckSABnzbd";
            this.cbCheckSABnzbd.Size = new System.Drawing.Size(137, 17);
            this.cbCheckSABnzbd.TabIndex = 18;
            this.cbCheckSABnzbd.Text = "Check SA&Bnzbd queue";
            this.cbCheckSABnzbd.UseVisualStyleBackColor = true;
            this.cbCheckSABnzbd.CheckedChanged += new System.EventHandler(this.EnableDisable);
            // 
            // cbCheckuTorrent
            // 
            this.cbCheckuTorrent.AutoSize = true;
            this.cbCheckuTorrent.Location = new System.Drawing.Point(6, 176);
            this.cbCheckuTorrent.Name = "cbCheckuTorrent";
            this.cbCheckuTorrent.Size = new System.Drawing.Size(133, 17);
            this.cbCheckuTorrent.TabIndex = 17;
            this.cbCheckuTorrent.Text = "C&heck µTorrent queue";
            this.cbCheckuTorrent.UseVisualStyleBackColor = true;
            this.cbCheckuTorrent.CheckedChanged += new System.EventHandler(this.EnableDisable);
            // 
            // qBitTorrent
            // 
            this.qBitTorrent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.qBitTorrent.Controls.Add(this.chkRemoveCompletedTorrents);
            this.qBitTorrent.Controls.Add(this.llqBitTorrentLink);
            this.qBitTorrent.Controls.Add(this.label79);
            this.qBitTorrent.Controls.Add(this.rdoqBitTorrentAPIVersionv2);
            this.qBitTorrent.Controls.Add(this.rdoqBitTorrentAPIVersionv1);
            this.qBitTorrent.Controls.Add(this.rdoqBitTorrentAPIVersionv0);
            this.qBitTorrent.Controls.Add(this.label29);
            this.qBitTorrent.Controls.Add(this.cbDownloadTorrentBeforeDownloading);
            this.qBitTorrent.Controls.Add(this.tbqBitTorrentHost);
            this.qBitTorrent.Controls.Add(this.tbqBitTorrentPort);
            this.qBitTorrent.Controls.Add(this.label41);
            this.qBitTorrent.Controls.Add(this.label42);
            this.qBitTorrent.Location = new System.Drawing.Point(6, 308);
            this.qBitTorrent.Name = "qBitTorrent";
            this.qBitTorrent.Size = new System.Drawing.Size(405, 176);
            this.qBitTorrent.TabIndex = 7;
            this.qBitTorrent.TabStop = false;
            this.qBitTorrent.Text = "qBitTorrent";
            // 
            // chkRemoveCompletedTorrents
            // 
            this.chkRemoveCompletedTorrents.AutoSize = true;
            this.chkRemoveCompletedTorrents.Location = new System.Drawing.Point(75, 125);
            this.chkRemoveCompletedTorrents.Name = "chkRemoveCompletedTorrents";
            this.chkRemoveCompletedTorrents.Size = new System.Drawing.Size(184, 17);
            this.chkRemoveCompletedTorrents.TabIndex = 22;
            this.chkRemoveCompletedTorrents.Text = "Automatically Remove Completed";
            this.chkRemoveCompletedTorrents.UseVisualStyleBackColor = true;
            // 
            // llqBitTorrentLink
            // 
            this.llqBitTorrentLink.AutoSize = true;
            this.llqBitTorrentLink.Location = new System.Drawing.Point(76, 146);
            this.llqBitTorrentLink.Name = "llqBitTorrentLink";
            this.llqBitTorrentLink.Size = new System.Drawing.Size(83, 13);
            this.llqBitTorrentLink.TabIndex = 42;
            this.llqBitTorrentLink.TabStop = true;
            this.llqBitTorrentLink.Text = "llqBitTorrentLink";
            this.llqBitTorrentLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(8, 145);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(21, 13);
            this.label79.TabIndex = 41;
            this.label79.Text = "UI:";
            // 
            // rdoqBitTorrentAPIVersionv2
            // 
            this.rdoqBitTorrentAPIVersionv2.AutoSize = true;
            this.rdoqBitTorrentAPIVersionv2.Location = new System.Drawing.Point(225, 75);
            this.rdoqBitTorrentAPIVersionv2.Name = "rdoqBitTorrentAPIVersionv2";
            this.rdoqBitTorrentAPIVersionv2.Size = new System.Drawing.Size(52, 17);
            this.rdoqBitTorrentAPIVersionv2.TabIndex = 24;
            this.rdoqBitTorrentAPIVersionv2.TabStop = true;
            this.rdoqBitTorrentAPIVersionv2.Text = "v4.1+";
            this.rdoqBitTorrentAPIVersionv2.UseVisualStyleBackColor = true;
            // 
            // rdoqBitTorrentAPIVersionv1
            // 
            this.rdoqBitTorrentAPIVersionv1.AutoSize = true;
            this.rdoqBitTorrentAPIVersionv1.Location = new System.Drawing.Point(137, 75);
            this.rdoqBitTorrentAPIVersionv1.Name = "rdoqBitTorrentAPIVersionv1";
            this.rdoqBitTorrentAPIVersionv1.Size = new System.Drawing.Size(82, 17);
            this.rdoqBitTorrentAPIVersionv1.TabIndex = 23;
            this.rdoqBitTorrentAPIVersionv1.TabStop = true;
            this.rdoqBitTorrentAPIVersionv1.Text = "v3.2 to v4.0";
            this.rdoqBitTorrentAPIVersionv1.UseVisualStyleBackColor = true;
            // 
            // rdoqBitTorrentAPIVersionv0
            // 
            this.rdoqBitTorrentAPIVersionv0.AutoSize = true;
            this.rdoqBitTorrentAPIVersionv0.Location = new System.Drawing.Point(76, 75);
            this.rdoqBitTorrentAPIVersionv0.Name = "rdoqBitTorrentAPIVersionv0";
            this.rdoqBitTorrentAPIVersionv0.Size = new System.Drawing.Size(55, 17);
            this.rdoqBitTorrentAPIVersionv0.TabIndex = 22;
            this.rdoqBitTorrentAPIVersionv0.TabStop = true;
            this.rdoqBitTorrentAPIVersionv0.Text = "< v3.1";
            this.rdoqBitTorrentAPIVersionv0.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(11, 77);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(45, 13);
            this.label29.TabIndex = 21;
            this.label29.Text = "Version:";
            // 
            // cbDownloadTorrentBeforeDownloading
            // 
            this.cbDownloadTorrentBeforeDownloading.AutoSize = true;
            this.cbDownloadTorrentBeforeDownloading.Location = new System.Drawing.Point(75, 102);
            this.cbDownloadTorrentBeforeDownloading.Name = "cbDownloadTorrentBeforeDownloading";
            this.cbDownloadTorrentBeforeDownloading.Size = new System.Drawing.Size(227, 17);
            this.cbDownloadTorrentBeforeDownloading.TabIndex = 20;
            this.cbDownloadTorrentBeforeDownloading.Text = "Download .torrent files before downloading";
            this.cbDownloadTorrentBeforeDownloading.UseVisualStyleBackColor = true;
            // 
            // tbqBitTorrentHost
            // 
            this.tbqBitTorrentHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbqBitTorrentHost.Location = new System.Drawing.Point(75, 19);
            this.tbqBitTorrentHost.Name = "tbqBitTorrentHost";
            this.tbqBitTorrentHost.Size = new System.Drawing.Size(324, 20);
            this.tbqBitTorrentHost.TabIndex = 1;
            this.tbqBitTorrentHost.TextChanged += new System.EventHandler(this.QBitDetailsChanged);
            // 
            // tbqBitTorrentPort
            // 
            this.tbqBitTorrentPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbqBitTorrentPort.Location = new System.Drawing.Point(75, 48);
            this.tbqBitTorrentPort.Name = "tbqBitTorrentPort";
            this.tbqBitTorrentPort.Size = new System.Drawing.Size(324, 20);
            this.tbqBitTorrentPort.TabIndex = 4;
            this.tbqBitTorrentPort.TextChanged += new System.EventHandler(this.QBitDetailsChanged);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(11, 51);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(29, 13);
            this.label41.TabIndex = 3;
            this.label41.Text = "Port:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(11, 22);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(32, 13);
            this.label42.TabIndex = 0;
            this.label42.Text = "Host:";
            // 
            // gbSAB
            // 
            this.gbSAB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSAB.Controls.Add(this.txtSABHostPort);
            this.gbSAB.Controls.Add(this.txtSABAPIKey);
            this.gbSAB.Controls.Add(this.label8);
            this.gbSAB.Controls.Add(this.label9);
            this.gbSAB.Location = new System.Drawing.Point(6, 89);
            this.gbSAB.Name = "gbSAB";
            this.gbSAB.Size = new System.Drawing.Size(405, 81);
            this.gbSAB.TabIndex = 6;
            this.gbSAB.TabStop = false;
            this.gbSAB.Text = "SABnzbd";
            // 
            // txtSABHostPort
            // 
            this.txtSABHostPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSABHostPort.Location = new System.Drawing.Point(75, 19);
            this.txtSABHostPort.Name = "txtSABHostPort";
            this.txtSABHostPort.Size = new System.Drawing.Size(324, 20);
            this.txtSABHostPort.TabIndex = 1;
            // 
            // txtSABAPIKey
            // 
            this.txtSABAPIKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSABAPIKey.Location = new System.Drawing.Point(75, 48);
            this.txtSABAPIKey.Name = "txtSABAPIKey";
            this.txtSABAPIKey.Size = new System.Drawing.Size(324, 20);
            this.txtSABAPIKey.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "API Key:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Host:Port";
            // 
            // gbuTorrent
            // 
            this.gbuTorrent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbuTorrent.Controls.Add(this.bnUTBrowseResumeDat);
            this.gbuTorrent.Controls.Add(this.txtUTResumeDatPath);
            this.gbuTorrent.Controls.Add(this.bnRSSBrowseuTorrent);
            this.gbuTorrent.Controls.Add(this.label27);
            this.gbuTorrent.Controls.Add(this.label26);
            this.gbuTorrent.Controls.Add(this.txtRSSuTorrentPath);
            this.gbuTorrent.Location = new System.Drawing.Point(6, 199);
            this.gbuTorrent.Name = "gbuTorrent";
            this.gbuTorrent.Size = new System.Drawing.Size(405, 80);
            this.gbuTorrent.TabIndex = 5;
            this.gbuTorrent.TabStop = false;
            this.gbuTorrent.Text = "µTorrent";
            // 
            // bnUTBrowseResumeDat
            // 
            this.bnUTBrowseResumeDat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnUTBrowseResumeDat.Location = new System.Drawing.Point(324, 46);
            this.bnUTBrowseResumeDat.Name = "bnUTBrowseResumeDat";
            this.bnUTBrowseResumeDat.Size = new System.Drawing.Size(75, 23);
            this.bnUTBrowseResumeDat.TabIndex = 5;
            this.bnUTBrowseResumeDat.Text = "Bro&wse...";
            this.bnUTBrowseResumeDat.UseVisualStyleBackColor = true;
            this.bnUTBrowseResumeDat.Click += new System.EventHandler(this.bnUTBrowseResumeDat_Click);
            // 
            // txtUTResumeDatPath
            // 
            this.txtUTResumeDatPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUTResumeDatPath.Location = new System.Drawing.Point(75, 48);
            this.txtUTResumeDatPath.Name = "txtUTResumeDatPath";
            this.txtUTResumeDatPath.Size = new System.Drawing.Size(243, 20);
            this.txtUTResumeDatPath.TabIndex = 4;
            // 
            // bnRSSBrowseuTorrent
            // 
            this.bnRSSBrowseuTorrent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnRSSBrowseuTorrent.Location = new System.Drawing.Point(324, 16);
            this.bnRSSBrowseuTorrent.Name = "bnRSSBrowseuTorrent";
            this.bnRSSBrowseuTorrent.Size = new System.Drawing.Size(75, 23);
            this.bnRSSBrowseuTorrent.TabIndex = 2;
            this.bnRSSBrowseuTorrent.Text = "&Browse...";
            this.bnRSSBrowseuTorrent.UseVisualStyleBackColor = true;
            this.bnRSSBrowseuTorrent.Click += new System.EventHandler(this.bnRSSBrowseuTorrent_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(7, 22);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(62, 13);
            this.label27.TabIndex = 0;
            this.label27.Text = "A&pplication:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(7, 51);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(62, 13);
            this.label26.TabIndex = 3;
            this.label26.Text = "resume.&dat:";
            // 
            // txtRSSuTorrentPath
            // 
            this.txtRSSuTorrentPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRSSuTorrentPath.Location = new System.Drawing.Point(75, 19);
            this.txtRSSuTorrentPath.Name = "txtRSSuTorrentPath";
            this.txtRSSuTorrentPath.Size = new System.Drawing.Size(243, 20);
            this.txtRSSuTorrentPath.TabIndex = 1;
            // 
            // tbSearchFolders
            // 
            this.tbSearchFolders.Controls.Add(this.chkUseSearchFullPathWhenMatchingShows);
            this.tbSearchFolders.Controls.Add(this.cbCopyFutureDatedEps);
            this.tbSearchFolders.Controls.Add(this.groupBox8);
            this.tbSearchFolders.Controls.Add(this.label67);
            this.tbSearchFolders.Controls.Add(this.gbAutoAdd);
            this.tbSearchFolders.Controls.Add(this.cbLeaveOriginals);
            this.tbSearchFolders.Controls.Add(this.cbSearchLocally);
            this.tbSearchFolders.Controls.Add(this.chkAutoMergeDownloadEpisodes);
            this.tbSearchFolders.Controls.Add(this.cbMonitorFolder);
            this.tbSearchFolders.Controls.Add(this.bnOpenSearchFolder);
            this.tbSearchFolders.Controls.Add(this.bnRemoveSearchFolder);
            this.tbSearchFolders.Controls.Add(this.bnAddSearchFolder);
            this.tbSearchFolders.Controls.Add(this.pbSearchFolders);
            this.tbSearchFolders.Controls.Add(this.lbSearchFolders);
            this.tbSearchFolders.Controls.Add(this.label23);
            this.tbSearchFolders.Location = new System.Drawing.Point(139, 4);
            this.tbSearchFolders.Name = "tbSearchFolders";
            this.tbSearchFolders.Size = new System.Drawing.Size(417, 561);
            this.tbSearchFolders.TabIndex = 3;
            this.tbSearchFolders.Text = "Search Folders";
            this.tbSearchFolders.UseVisualStyleBackColor = true;
            // 
            // chkUseSearchFullPathWhenMatchingShows
            // 
            this.chkUseSearchFullPathWhenMatchingShows.AutoSize = true;
            this.chkUseSearchFullPathWhenMatchingShows.Location = new System.Drawing.Point(6, 171);
            this.chkUseSearchFullPathWhenMatchingShows.Name = "chkUseSearchFullPathWhenMatchingShows";
            this.chkUseSearchFullPathWhenMatchingShows.Size = new System.Drawing.Size(416, 17);
            this.chkUseSearchFullPathWhenMatchingShows.TabIndex = 42;
            this.chkUseSearchFullPathWhenMatchingShows.Text = "Use name of Search Folder when searching for a match between a file and a show";
            this.chkUseSearchFullPathWhenMatchingShows.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.cbMovieHigherQuality);
            this.groupBox8.Controls.Add(this.label53);
            this.groupBox8.Controls.Add(this.label54);
            this.groupBox8.Controls.Add(this.tbPercentBetter);
            this.groupBox8.Controls.Add(this.tbPriorityOverrideTerms);
            this.groupBox8.Controls.Add(this.label52);
            this.groupBox8.Controls.Add(this.cbHigherQuality);
            this.groupBox8.Location = new System.Drawing.Point(6, 442);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(406, 115);
            this.groupBox8.TabIndex = 40;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Upgrade Shows when better quality files found";
            // 
            // cbMovieHigherQuality
            // 
            this.cbMovieHigherQuality.AutoSize = true;
            this.cbMovieHigherQuality.Location = new System.Drawing.Point(6, 36);
            this.cbMovieHigherQuality.Name = "cbMovieHigherQuality";
            this.cbMovieHigherQuality.Size = new System.Drawing.Size(332, 17);
            this.cbMovieHigherQuality.TabIndex = 39;
            this.cbMovieHigherQuality.Text = "Update movies when higher-quality ones found in Search Folders";
            this.cbMovieHigherQuality.UseVisualStyleBackColor = true;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(7, 89);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(129, 13);
            this.label53.TabIndex = 36;
            this.label53.Text = "Consider a file better if it is";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(173, 88);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(129, 13);
            this.label54.TabIndex = 38;
            this.label54.Text = "% higher resolution/longer";
            // 
            // tbPercentBetter
            // 
            this.tbPercentBetter.Location = new System.Drawing.Point(141, 85);
            this.tbPercentBetter.Name = "tbPercentBetter";
            this.tbPercentBetter.Size = new System.Drawing.Size(28, 20);
            this.tbPercentBetter.TabIndex = 37;
            this.tbPercentBetter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumberOnlyKeyPress);
            // 
            // tbPriorityOverrideTerms
            // 
            this.tbPriorityOverrideTerms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPriorityOverrideTerms.Location = new System.Drawing.Point(141, 59);
            this.tbPriorityOverrideTerms.Name = "tbPriorityOverrideTerms";
            this.tbPriorityOverrideTerms.Size = new System.Drawing.Size(263, 20);
            this.tbPriorityOverrideTerms.TabIndex = 35;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(8, 62);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(110, 13);
            this.label52.TabIndex = 34;
            this.label52.Text = "Priority override terms:";
            // 
            // cbHigherQuality
            // 
            this.cbHigherQuality.AutoSize = true;
            this.cbHigherQuality.Location = new System.Drawing.Point(6, 19);
            this.cbHigherQuality.Name = "cbHigherQuality";
            this.cbHigherQuality.Size = new System.Drawing.Size(341, 17);
            this.cbHigherQuality.TabIndex = 33;
            this.cbHigherQuality.Text = "Update episodes when higher-quality ones found in Search Folders";
            this.cbHigherQuality.UseVisualStyleBackColor = true;
            // 
            // label67
            // 
            this.label67.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label67.AutoEllipsis = true;
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(6, 6);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(331, 39);
            this.label67.TabIndex = 39;
            this.label67.Text = resources.GetString("label67.Text");
            // 
            // gbAutoAdd
            // 
            this.gbAutoAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAutoAdd.Controls.Add(this.cbAutomateAutoAddWhenOneMovieFound);
            this.gbAutoAdd.Controls.Add(this.cbAutomateAutoAddWhenOneShowFound);
            this.gbAutoAdd.Controls.Add(this.chkAutoSearchForDownloadedFiles);
            this.gbAutoAdd.Controls.Add(this.label43);
            this.gbAutoAdd.Controls.Add(this.label44);
            this.gbAutoAdd.Controls.Add(this.tbIgnoreSuffixes);
            this.gbAutoAdd.Controls.Add(this.tbMovieTerms);
            this.gbAutoAdd.Location = new System.Drawing.Point(6, 311);
            this.gbAutoAdd.Name = "gbAutoAdd";
            this.gbAutoAdd.Size = new System.Drawing.Size(407, 125);
            this.gbAutoAdd.TabIndex = 36;
            this.gbAutoAdd.TabStop = false;
            this.gbAutoAdd.Text = "Auto Add Shows from Search Folders";
            // 
            // chkAutoSearchForDownloadedFiles
            // 
            this.chkAutoSearchForDownloadedFiles.AutoSize = true;
            this.chkAutoSearchForDownloadedFiles.Location = new System.Drawing.Point(6, 19);
            this.chkAutoSearchForDownloadedFiles.Name = "chkAutoSearchForDownloadedFiles";
            this.chkAutoSearchForDownloadedFiles.Size = new System.Drawing.Size(186, 17);
            this.chkAutoSearchForDownloadedFiles.TabIndex = 16;
            this.chkAutoSearchForDownloadedFiles.Text = "Notify when new shows are found";
            this.chkAutoSearchForDownloadedFiles.UseVisualStyleBackColor = true;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(4, 104);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(78, 13);
            this.label43.TabIndex = 14;
            this.label43.Text = "&Ignore suffixes:";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(4, 78);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(71, 13);
            this.label44.TabIndex = 12;
            this.label44.Text = "&Movie Terms:";
            // 
            // cbLeaveOriginals
            // 
            this.cbLeaveOriginals.AutoSize = true;
            this.cbLeaveOriginals.Location = new System.Drawing.Point(17, 81);
            this.cbLeaveOriginals.Name = "cbLeaveOriginals";
            this.cbLeaveOriginals.Size = new System.Drawing.Size(129, 17);
            this.cbLeaveOriginals.TabIndex = 35;
            this.cbLeaveOriginals.Text = "&Copy files, don\'t move";
            this.cbLeaveOriginals.UseVisualStyleBackColor = true;
            // 
            // cbSearchLocally
            // 
            this.cbSearchLocally.AutoSize = true;
            this.cbSearchLocally.Checked = true;
            this.cbSearchLocally.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSearchLocally.Location = new System.Drawing.Point(6, 58);
            this.cbSearchLocally.Name = "cbSearchLocally";
            this.cbSearchLocally.Size = new System.Drawing.Size(218, 17);
            this.cbSearchLocally.TabIndex = 34;
            this.cbSearchLocally.Text = "&Look in \"Search Folders\" for missing files";
            this.cbSearchLocally.UseVisualStyleBackColor = true;
            this.cbSearchLocally.CheckedChanged += new System.EventHandler(this.EnableDisable);
            // 
            // chkAutoMergeDownloadEpisodes
            // 
            this.chkAutoMergeDownloadEpisodes.AutoSize = true;
            this.chkAutoMergeDownloadEpisodes.Location = new System.Drawing.Point(6, 104);
            this.chkAutoMergeDownloadEpisodes.Name = "chkAutoMergeDownloadEpisodes";
            this.chkAutoMergeDownloadEpisodes.Size = new System.Drawing.Size(331, 17);
            this.chkAutoMergeDownloadEpisodes.TabIndex = 32;
            this.chkAutoMergeDownloadEpisodes.Text = "Automatically create merge rules based on files in Search Folders";
            this.chkAutoMergeDownloadEpisodes.UseVisualStyleBackColor = true;
            // 
            // bnOpenSearchFolder
            // 
            this.bnOpenSearchFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bnOpenSearchFolder.Enabled = false;
            this.bnOpenSearchFolder.Location = new System.Drawing.Point(168, 282);
            this.bnOpenSearchFolder.Name = "bnOpenSearchFolder";
            this.bnOpenSearchFolder.Size = new System.Drawing.Size(75, 23);
            this.bnOpenSearchFolder.TabIndex = 4;
            this.bnOpenSearchFolder.Text = "&Open";
            this.bnOpenSearchFolder.UseVisualStyleBackColor = true;
            this.bnOpenSearchFolder.Click += new System.EventHandler(this.bnOpenSearchFolder_Click);
            // 
            // bnRemoveSearchFolder
            // 
            this.bnRemoveSearchFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bnRemoveSearchFolder.Enabled = false;
            this.bnRemoveSearchFolder.Location = new System.Drawing.Point(87, 282);
            this.bnRemoveSearchFolder.Name = "bnRemoveSearchFolder";
            this.bnRemoveSearchFolder.Size = new System.Drawing.Size(75, 23);
            this.bnRemoveSearchFolder.TabIndex = 3;
            this.bnRemoveSearchFolder.Text = "&Remove";
            this.bnRemoveSearchFolder.UseVisualStyleBackColor = true;
            this.bnRemoveSearchFolder.Click += new System.EventHandler(this.bnRemoveSearchFolder_Click);
            // 
            // bnAddSearchFolder
            // 
            this.bnAddSearchFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bnAddSearchFolder.Location = new System.Drawing.Point(6, 282);
            this.bnAddSearchFolder.Name = "bnAddSearchFolder";
            this.bnAddSearchFolder.Size = new System.Drawing.Size(75, 23);
            this.bnAddSearchFolder.TabIndex = 2;
            this.bnAddSearchFolder.Text = "&Add";
            this.bnAddSearchFolder.UseVisualStyleBackColor = true;
            this.bnAddSearchFolder.Click += new System.EventHandler(this.bnAddSearchFolder_Click);
            // 
            // pbSearchFolders
            // 
            this.pbSearchFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSearchFolders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSearchFolders.Image = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pbSearchFolders.InitialImage = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pbSearchFolders.Location = new System.Drawing.Point(368, 6);
            this.pbSearchFolders.Name = "pbSearchFolders";
            this.pbSearchFolders.Size = new System.Drawing.Size(43, 40);
            this.pbSearchFolders.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbSearchFolders.TabIndex = 37;
            this.pbSearchFolders.TabStop = false;
            this.pbSearchFolders.Click += new System.EventHandler(this.pbSearchFolders_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 191);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(78, 13);
            this.label23.TabIndex = 0;
            this.label23.Text = "&Search Folders";
            // 
            // tbMediaCenter
            // 
            this.tbMediaCenter.Controls.Add(this.groupBox16);
            this.tbMediaCenter.Controls.Add(this.groupBox13);
            this.tbMediaCenter.Controls.Add(this.groupBox14);
            this.tbMediaCenter.Controls.Add(this.groupBox15);
            this.tbMediaCenter.Controls.Add(this.groupBox12);
            this.tbMediaCenter.Controls.Add(this.label64);
            this.tbMediaCenter.Controls.Add(this.bnMCPresets);
            this.tbMediaCenter.Controls.Add(this.pbMediaCenter);
            this.tbMediaCenter.Location = new System.Drawing.Point(139, 4);
            this.tbMediaCenter.Name = "tbMediaCenter";
            this.tbMediaCenter.Padding = new System.Windows.Forms.Padding(3);
            this.tbMediaCenter.Size = new System.Drawing.Size(417, 561);
            this.tbMediaCenter.TabIndex = 8;
            this.tbMediaCenter.Text = "Media Centres";
            this.tbMediaCenter.UseVisualStyleBackColor = true;
            // 
            // groupBox16
            // 
            this.groupBox16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox16.Controls.Add(this.cbWDLiveEpisodeFiles);
            this.groupBox16.Location = new System.Drawing.Point(9, 355);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(402, 50);
            this.groupBox16.TabIndex = 41;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "WD TV Live Hub";
            // 
            // cbWDLiveEpisodeFiles
            // 
            this.cbWDLiveEpisodeFiles.AutoSize = true;
            this.cbWDLiveEpisodeFiles.Location = new System.Drawing.Point(6, 23);
            this.cbWDLiveEpisodeFiles.Name = "cbWDLiveEpisodeFiles";
            this.cbWDLiveEpisodeFiles.Size = new System.Drawing.Size(200, 17);
            this.cbWDLiveEpisodeFiles.TabIndex = 25;
            this.cbWDLiveEpisodeFiles.Text = "WD TV Live Hub Episode Files (.xml)";
            this.cbWDLiveEpisodeFiles.UseVisualStyleBackColor = true;
            // 
            // groupBox13
            // 
            this.groupBox13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox13.Controls.Add(this.cbXMLFiles);
            this.groupBox13.Controls.Add(this.cbSeriesJpg);
            this.groupBox13.Controls.Add(this.cbShrinkLarge);
            this.groupBox13.Location = new System.Drawing.Point(9, 249);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(402, 100);
            this.groupBox13.TabIndex = 40;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Mede8er";
            // 
            // cbXMLFiles
            // 
            this.cbXMLFiles.AutoSize = true;
            this.cbXMLFiles.Location = new System.Drawing.Point(6, 42);
            this.cbXMLFiles.Name = "cbXMLFiles";
            this.cbXMLFiles.Size = new System.Drawing.Size(183, 17);
            this.cbXMLFiles.TabIndex = 8;
            this.cbXMLFiles.Text = "&XML files for shows and episodes";
            this.cbXMLFiles.UseVisualStyleBackColor = true;
            // 
            // cbSeriesJpg
            // 
            this.cbSeriesJpg.AutoSize = true;
            this.cbSeriesJpg.Location = new System.Drawing.Point(6, 19);
            this.cbSeriesJpg.Name = "cbSeriesJpg";
            this.cbSeriesJpg.Size = new System.Drawing.Size(248, 17);
            this.cbSeriesJpg.TabIndex = 7;
            this.cbSeriesJpg.Text = "&Create cachedSeries poster (cachedSeries.jpg)";
            this.cbSeriesJpg.UseVisualStyleBackColor = true;
            // 
            // cbShrinkLarge
            // 
            this.cbShrinkLarge.AutoSize = true;
            this.cbShrinkLarge.Location = new System.Drawing.Point(6, 65);
            this.cbShrinkLarge.Name = "cbShrinkLarge";
            this.cbShrinkLarge.Size = new System.Drawing.Size(338, 17);
            this.cbShrinkLarge.TabIndex = 9;
            this.cbShrinkLarge.Text = "S&hrink large cachedSeries and episode images to 156 x 232 pixels";
            this.cbShrinkLarge.UseVisualStyleBackColor = true;
            // 
            // groupBox14
            // 
            this.groupBox14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox14.Controls.Add(this.cbMeta);
            this.groupBox14.Controls.Add(this.cbMetaSubfolder);
            this.groupBox14.Location = new System.Drawing.Point(9, 178);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(402, 65);
            this.groupBox14.TabIndex = 40;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "pyTivo";
            // 
            // cbMeta
            // 
            this.cbMeta.AutoSize = true;
            this.cbMeta.Location = new System.Drawing.Point(6, 19);
            this.cbMeta.Name = "cbMeta";
            this.cbMeta.Size = new System.Drawing.Size(154, 17);
            this.cbMeta.TabIndex = 4;
            this.cbMeta.Text = "&Meta files for episodes (.txt)";
            this.cbMeta.UseVisualStyleBackColor = true;
            this.cbMeta.CheckedChanged += new System.EventHandler(this.EnableDisable);
            // 
            // cbMetaSubfolder
            // 
            this.cbMetaSubfolder.AutoSize = true;
            this.cbMetaSubfolder.Location = new System.Drawing.Point(6, 42);
            this.cbMetaSubfolder.Name = "cbMetaSubfolder";
            this.cbMetaSubfolder.Size = new System.Drawing.Size(187, 17);
            this.cbMetaSubfolder.TabIndex = 5;
            this.cbMetaSubfolder.Text = "Pl&ace Meta files in .meta subfolder";
            this.cbMetaSubfolder.UseVisualStyleBackColor = true;
            // 
            // groupBox15
            // 
            this.groupBox15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox15.Controls.Add(this.cbNFOMovies);
            this.groupBox15.Controls.Add(this.cbEpTBNs);
            this.groupBox15.Controls.Add(this.cbNFOShows);
            this.groupBox15.Controls.Add(this.cbKODIImages);
            this.groupBox15.Controls.Add(this.cbNFOEpisodes);
            this.groupBox15.Location = new System.Drawing.Point(9, 72);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(402, 100);
            this.groupBox15.TabIndex = 40;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Kodi";
            // 
            // cbNFOMovies
            // 
            this.cbNFOMovies.AutoSize = true;
            this.cbNFOMovies.Location = new System.Drawing.Point(6, 58);
            this.cbNFOMovies.Name = "cbNFOMovies";
            this.cbNFOMovies.Size = new System.Drawing.Size(120, 17);
            this.cbNFOMovies.TabIndex = 25;
            this.cbNFOMovies.Text = "&NFO files for movies";
            this.cbNFOMovies.UseVisualStyleBackColor = true;
            // 
            // cbEpTBNs
            // 
            this.cbEpTBNs.AutoSize = true;
            this.cbEpTBNs.Location = new System.Drawing.Point(6, 19);
            this.cbEpTBNs.Name = "cbEpTBNs";
            this.cbEpTBNs.Size = new System.Drawing.Size(148, 17);
            this.cbEpTBNs.TabIndex = 1;
            this.cbEpTBNs.Text = "&Episode Thumbnails (.tbn)";
            this.cbEpTBNs.UseVisualStyleBackColor = true;
            // 
            // cbNFOShows
            // 
            this.cbNFOShows.AutoSize = true;
            this.cbNFOShows.Location = new System.Drawing.Point(6, 40);
            this.cbNFOShows.Name = "cbNFOShows";
            this.cbNFOShows.Size = new System.Drawing.Size(117, 17);
            this.cbNFOShows.TabIndex = 2;
            this.cbNFOShows.Text = "&NFO files for shows";
            this.cbNFOShows.UseVisualStyleBackColor = true;
            // 
            // cbKODIImages
            // 
            this.cbKODIImages.AutoSize = true;
            this.cbKODIImages.Location = new System.Drawing.Point(6, 78);
            this.cbKODIImages.Name = "cbKODIImages";
            this.cbKODIImages.Size = new System.Drawing.Size(238, 17);
            this.cbKODIImages.TabIndex = 17;
            this.cbKODIImages.Text = "Download &Images (fanart, poster, banner.jpg)";
            this.cbKODIImages.UseVisualStyleBackColor = true;
            // 
            // cbNFOEpisodes
            // 
            this.cbNFOEpisodes.AutoSize = true;
            this.cbNFOEpisodes.Location = new System.Drawing.Point(151, 40);
            this.cbNFOEpisodes.Name = "cbNFOEpisodes";
            this.cbNFOEpisodes.Size = new System.Drawing.Size(129, 17);
            this.cbNFOEpisodes.TabIndex = 24;
            this.cbNFOEpisodes.Text = "&NFO files for episodes";
            this.cbNFOEpisodes.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            this.groupBox12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox12.Controls.Add(this.cbFantArtJpg);
            this.groupBox12.Controls.Add(this.cbFolderJpg);
            this.groupBox12.Controls.Add(this.cbEpThumbJpg);
            this.groupBox12.Controls.Add(this.panel1);
            this.groupBox12.Location = new System.Drawing.Point(9, 411);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(402, 112);
            this.groupBox12.TabIndex = 39;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "General";
            // 
            // cbFantArtJpg
            // 
            this.cbFantArtJpg.AutoSize = true;
            this.cbFantArtJpg.Location = new System.Drawing.Point(9, 65);
            this.cbFantArtJpg.Name = "cbFantArtJpg";
            this.cbFantArtJpg.Size = new System.Drawing.Size(141, 17);
            this.cbFantArtJpg.TabIndex = 15;
            this.cbFantArtJpg.Text = "Fanar&t Image (fanart.jpg)";
            this.cbFantArtJpg.UseVisualStyleBackColor = true;
            // 
            // cbFolderJpg
            // 
            this.cbFolderJpg.AutoSize = true;
            this.cbFolderJpg.Location = new System.Drawing.Point(9, 22);
            this.cbFolderJpg.Name = "cbFolderJpg";
            this.cbFolderJpg.Size = new System.Drawing.Size(138, 17);
            this.cbFolderJpg.TabIndex = 11;
            this.cbFolderJpg.Text = "&Folder image (folder.jpg)";
            this.cbFolderJpg.UseVisualStyleBackColor = true;
            // 
            // cbEpThumbJpg
            // 
            this.cbEpThumbJpg.AutoSize = true;
            this.cbEpThumbJpg.Location = new System.Drawing.Point(9, 88);
            this.cbEpThumbJpg.Name = "cbEpThumbJpg";
            this.cbEpThumbJpg.Size = new System.Drawing.Size(147, 17);
            this.cbEpThumbJpg.TabIndex = 16;
            this.cbEpThumbJpg.Text = "Episode Thumbnails (.&jpg)";
            this.cbEpThumbJpg.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbFolderBanner);
            this.panel1.Controls.Add(this.rbFolderPoster);
            this.panel1.Controls.Add(this.rbFolderFanArt);
            this.panel1.Controls.Add(this.rbFolderSeasonPoster);
            this.panel1.Location = new System.Drawing.Point(30, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 24);
            this.panel1.TabIndex = 22;
            // 
            // rbFolderBanner
            // 
            this.rbFolderBanner.AutoSize = true;
            this.rbFolderBanner.Location = new System.Drawing.Point(0, 3);
            this.rbFolderBanner.Name = "rbFolderBanner";
            this.rbFolderBanner.Size = new System.Drawing.Size(59, 17);
            this.rbFolderBanner.TabIndex = 12;
            this.rbFolderBanner.TabStop = true;
            this.rbFolderBanner.Text = "&Banner";
            this.rbFolderBanner.UseVisualStyleBackColor = true;
            // 
            // rbFolderPoster
            // 
            this.rbFolderPoster.AutoSize = true;
            this.rbFolderPoster.Location = new System.Drawing.Point(60, 3);
            this.rbFolderPoster.Name = "rbFolderPoster";
            this.rbFolderPoster.Size = new System.Drawing.Size(55, 17);
            this.rbFolderPoster.TabIndex = 13;
            this.rbFolderPoster.TabStop = true;
            this.rbFolderPoster.Text = "&Poster";
            this.rbFolderPoster.UseVisualStyleBackColor = true;
            // 
            // rbFolderFanArt
            // 
            this.rbFolderFanArt.AutoSize = true;
            this.rbFolderFanArt.Location = new System.Drawing.Point(121, 3);
            this.rbFolderFanArt.Name = "rbFolderFanArt";
            this.rbFolderFanArt.Size = new System.Drawing.Size(59, 17);
            this.rbFolderFanArt.TabIndex = 14;
            this.rbFolderFanArt.TabStop = true;
            this.rbFolderFanArt.Text = "Fan A&rt";
            this.rbFolderFanArt.UseVisualStyleBackColor = true;
            // 
            // rbFolderSeasonPoster
            // 
            this.rbFolderSeasonPoster.AutoSize = true;
            this.rbFolderSeasonPoster.Location = new System.Drawing.Point(186, 3);
            this.rbFolderSeasonPoster.Name = "rbFolderSeasonPoster";
            this.rbFolderSeasonPoster.Size = new System.Drawing.Size(94, 17);
            this.rbFolderSeasonPoster.TabIndex = 16;
            this.rbFolderSeasonPoster.TabStop = true;
            this.rbFolderSeasonPoster.Text = "Seaso&n Poster";
            this.rbFolderSeasonPoster.UseVisualStyleBackColor = true;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(6, 7);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(302, 39);
            this.label64.TabIndex = 38;
            this.label64.Text = "While scanning your library folders TV Rename can create and\r\ndownload additional" +
    " files to help video playing applications to\r\nunderstand what is in your library" +
    " and display it in a nicer way.";
            // 
            // bnMCPresets
            // 
            this.bnMCPresets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnMCPresets.Location = new System.Drawing.Point(336, 533);
            this.bnMCPresets.Name = "bnMCPresets";
            this.bnMCPresets.Size = new System.Drawing.Size(75, 23);
            this.bnMCPresets.TabIndex = 16;
            this.bnMCPresets.Text = "Pre&sets...";
            this.bnMCPresets.UseVisualStyleBackColor = true;
            this.bnMCPresets.Click += new System.EventHandler(this.bnMCPresets_Click);
            // 
            // pbMediaCenter
            // 
            this.pbMediaCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMediaCenter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMediaCenter.Image = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pbMediaCenter.InitialImage = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pbMediaCenter.Location = new System.Drawing.Point(368, 6);
            this.pbMediaCenter.Name = "pbMediaCenter";
            this.pbMediaCenter.Size = new System.Drawing.Size(43, 40);
            this.pbMediaCenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMediaCenter.TabIndex = 27;
            this.pbMediaCenter.TabStop = false;
            this.pbMediaCenter.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // tbFolderDeleting
            // 
            this.tbFolderDeleting.Controls.Add(this.cbDeleteMovieFromDisk);
            this.tbFolderDeleting.Controls.Add(this.groupBox28);
            this.tbFolderDeleting.Controls.Add(this.label69);
            this.tbFolderDeleting.Controls.Add(this.cbDeleteShowFromDisk);
            this.tbFolderDeleting.Controls.Add(this.label32);
            this.tbFolderDeleting.Controls.Add(this.label30);
            this.tbFolderDeleting.Controls.Add(this.txtEmptyMaxSize);
            this.tbFolderDeleting.Controls.Add(this.txtEmptyIgnoreWords);
            this.tbFolderDeleting.Controls.Add(this.txtEmptyIgnoreExtensions);
            this.tbFolderDeleting.Controls.Add(this.label31);
            this.tbFolderDeleting.Controls.Add(this.cbRecycleNotDelete);
            this.tbFolderDeleting.Controls.Add(this.cbEmptyMaxSize);
            this.tbFolderDeleting.Controls.Add(this.cbEmptyIgnoreWords);
            this.tbFolderDeleting.Controls.Add(this.cbEmptyIgnoreExtensions);
            this.tbFolderDeleting.Controls.Add(this.cbDeleteEmpty);
            this.tbFolderDeleting.Controls.Add(this.pbFolderDeleting);
            this.tbFolderDeleting.Location = new System.Drawing.Point(139, 4);
            this.tbFolderDeleting.Name = "tbFolderDeleting";
            this.tbFolderDeleting.Padding = new System.Windows.Forms.Padding(3);
            this.tbFolderDeleting.Size = new System.Drawing.Size(417, 561);
            this.tbFolderDeleting.TabIndex = 9;
            this.tbFolderDeleting.Text = "Folder Deleting";
            this.tbFolderDeleting.UseVisualStyleBackColor = true;
            // 
            // cbDeleteMovieFromDisk
            // 
            this.cbDeleteMovieFromDisk.AutoSize = true;
            this.cbDeleteMovieFromDisk.Location = new System.Drawing.Point(16, 371);
            this.cbDeleteMovieFromDisk.Name = "cbDeleteMovieFromDisk";
            this.cbDeleteMovieFromDisk.Size = new System.Drawing.Size(303, 17);
            this.cbDeleteMovieFromDisk.TabIndex = 42;
            this.cbDeleteMovieFromDisk.Text = "Ask to delete from disk when deleting movie from database";
            this.cbDeleteMovieFromDisk.UseVisualStyleBackColor = true;
            // 
            // groupBox28
            // 
            this.groupBox28.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox28.Controls.Add(this.tbCleanUpDownloadDirMoviesLength);
            this.groupBox28.Controls.Add(this.cbCleanUpDownloadDirMoviesLength);
            this.groupBox28.Controls.Add(this.cbCleanUpDownloadDirMovies);
            this.groupBox28.Controls.Add(this.cbCleanUpDownloadDir);
            this.groupBox28.Location = new System.Drawing.Point(16, 242);
            this.groupBox28.Name = "groupBox28";
            this.groupBox28.Size = new System.Drawing.Size(395, 100);
            this.groupBox28.TabIndex = 41;
            this.groupBox28.TabStop = false;
            this.groupBox28.Text = "Clean Up Search Folders";
            // 
            // cbCleanUpDownloadDirMoviesLength
            // 
            this.cbCleanUpDownloadDirMoviesLength.AutoSize = true;
            this.cbCleanUpDownloadDirMoviesLength.Location = new System.Drawing.Point(45, 65);
            this.cbCleanUpDownloadDirMoviesLength.Name = "cbCleanUpDownloadDirMoviesLength";
            this.cbCleanUpDownloadDirMoviesLength.Size = new System.Drawing.Size(176, 17);
            this.cbCleanUpDownloadDirMoviesLength.TabIndex = 13;
            this.cbCleanUpDownloadDirMoviesLength.Text = "Only include movies longer than";
            this.cbCleanUpDownloadDirMoviesLength.UseVisualStyleBackColor = true;
            // 
            // cbCleanUpDownloadDirMovies
            // 
            this.cbCleanUpDownloadDirMovies.AutoSize = true;
            this.cbCleanUpDownloadDirMovies.Location = new System.Drawing.Point(6, 42);
            this.cbCleanUpDownloadDirMovies.Name = "cbCleanUpDownloadDirMovies";
            this.cbCleanUpDownloadDirMovies.Size = new System.Drawing.Size(284, 17);
            this.cbCleanUpDownloadDirMovies.TabIndex = 12;
            this.cbCleanUpDownloadDirMovies.Text = "Clean up already copied movie files from search folders";
            this.cbCleanUpDownloadDirMovies.UseVisualStyleBackColor = true;
            // 
            // cbCleanUpDownloadDir
            // 
            this.cbCleanUpDownloadDir.AutoSize = true;
            this.cbCleanUpDownloadDir.Location = new System.Drawing.Point(6, 19);
            this.cbCleanUpDownloadDir.Name = "cbCleanUpDownloadDir";
            this.cbCleanUpDownloadDir.Size = new System.Drawing.Size(293, 17);
            this.cbCleanUpDownloadDir.TabIndex = 11;
            this.cbCleanUpDownloadDir.Text = "Clean up already copied episode files from search folders";
            this.cbCleanUpDownloadDir.UseVisualStyleBackColor = true;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(6, 6);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(281, 26);
            this.label69.TabIndex = 40;
            this.label69.Text = "TV Rename can clean up the search folders to keep them\r\nclear of unused files and" +
    " duplicate downloads.";
            // 
            // cbDeleteShowFromDisk
            // 
            this.cbDeleteShowFromDisk.AutoSize = true;
            this.cbDeleteShowFromDisk.Location = new System.Drawing.Point(16, 348);
            this.cbDeleteShowFromDisk.Name = "cbDeleteShowFromDisk";
            this.cbDeleteShowFromDisk.Size = new System.Drawing.Size(300, 17);
            this.cbDeleteShowFromDisk.TabIndex = 13;
            this.cbDeleteShowFromDisk.Text = "Ask to delete from disk when deleting show from database";
            this.cbDeleteShowFromDisk.UseVisualStyleBackColor = true;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(13, 168);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(0, 13);
            this.label32.TabIndex = 6;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(13, 43);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(0, 13);
            this.label30.TabIndex = 1;
            // 
            // txtEmptyMaxSize
            // 
            this.txtEmptyMaxSize.Location = new System.Drawing.Point(218, 186);
            this.txtEmptyMaxSize.Name = "txtEmptyMaxSize";
            this.txtEmptyMaxSize.Size = new System.Drawing.Size(55, 20);
            this.txtEmptyMaxSize.TabIndex = 8;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(281, 193);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(0, 13);
            this.label31.TabIndex = 9;
            // 
            // cbRecycleNotDelete
            // 
            this.cbRecycleNotDelete.AutoSize = true;
            this.cbRecycleNotDelete.Location = new System.Drawing.Point(16, 219);
            this.cbRecycleNotDelete.Name = "cbRecycleNotDelete";
            this.cbRecycleNotDelete.Size = new System.Drawing.Size(299, 17);
            this.cbRecycleNotDelete.TabIndex = 10;
            this.cbRecycleNotDelete.Text = "Folders with files are moved to the &recycle bin, not deleted";
            this.cbRecycleNotDelete.UseVisualStyleBackColor = true;
            // 
            // cbEmptyMaxSize
            // 
            this.cbEmptyMaxSize.AutoSize = true;
            this.cbEmptyMaxSize.Location = new System.Drawing.Point(35, 188);
            this.cbEmptyMaxSize.Name = "cbEmptyMaxSize";
            this.cbEmptyMaxSize.Size = new System.Drawing.Size(177, 17);
            this.cbEmptyMaxSize.TabIndex = 7;
            this.cbEmptyMaxSize.Text = "&Maximum total file size to delete:";
            this.cbEmptyMaxSize.UseVisualStyleBackColor = true;
            // 
            // cbEmptyIgnoreWords
            // 
            this.cbEmptyIgnoreWords.AutoSize = true;
            this.cbEmptyIgnoreWords.Location = new System.Drawing.Point(35, 88);
            this.cbEmptyIgnoreWords.Name = "cbEmptyIgnoreWords";
            this.cbEmptyIgnoreWords.Size = new System.Drawing.Size(366, 17);
            this.cbEmptyIgnoreWords.TabIndex = 2;
            this.cbEmptyIgnoreWords.Text = "Ignore any files with these &words in their name: (semicolon separated list)";
            this.cbEmptyIgnoreWords.UseVisualStyleBackColor = true;
            // 
            // cbEmptyIgnoreExtensions
            // 
            this.cbEmptyIgnoreExtensions.AutoSize = true;
            this.cbEmptyIgnoreExtensions.Location = new System.Drawing.Point(35, 138);
            this.cbEmptyIgnoreExtensions.Name = "cbEmptyIgnoreExtensions";
            this.cbEmptyIgnoreExtensions.Size = new System.Drawing.Size(305, 17);
            this.cbEmptyIgnoreExtensions.TabIndex = 4;
            this.cbEmptyIgnoreExtensions.Text = "&Ignore files with these extensions: (semicolon separated list)";
            this.cbEmptyIgnoreExtensions.UseVisualStyleBackColor = true;
            // 
            // cbDeleteEmpty
            // 
            this.cbDeleteEmpty.AutoSize = true;
            this.cbDeleteEmpty.Location = new System.Drawing.Point(16, 65);
            this.cbDeleteEmpty.Name = "cbDeleteEmpty";
            this.cbDeleteEmpty.Size = new System.Drawing.Size(307, 17);
            this.cbDeleteEmpty.TabIndex = 0;
            this.cbDeleteEmpty.Text = "&Delete empty folders after moving files (from Search Folders)";
            this.cbDeleteEmpty.UseVisualStyleBackColor = true;
            // 
            // pbFolderDeleting
            // 
            this.pbFolderDeleting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFolderDeleting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFolderDeleting.Image = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pbFolderDeleting.InitialImage = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pbFolderDeleting.Location = new System.Drawing.Point(368, 6);
            this.pbFolderDeleting.Name = "pbFolderDeleting";
            this.pbFolderDeleting.Size = new System.Drawing.Size(43, 40);
            this.pbFolderDeleting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFolderDeleting.TabIndex = 24;
            this.pbFolderDeleting.TabStop = false;
            this.pbFolderDeleting.Click += new System.EventHandler(this.pbFolderDeleting_Click);
            // 
            // tbAutoExport
            // 
            this.tbAutoExport.Controls.Add(this.pbuExportEpisodes);
            this.tbAutoExport.Controls.Add(this.label88);
            this.tbAutoExport.Controls.Add(this.groupBox10);
            this.tbAutoExport.Controls.Add(this.groupBox5);
            this.tbAutoExport.Controls.Add(this.groupBox4);
            this.tbAutoExport.Controls.Add(this.groupBox2);
            this.tbAutoExport.Location = new System.Drawing.Point(139, 4);
            this.tbAutoExport.Name = "tbAutoExport";
            this.tbAutoExport.Padding = new System.Windows.Forms.Padding(3);
            this.tbAutoExport.Size = new System.Drawing.Size(417, 561);
            this.tbAutoExport.TabIndex = 2;
            this.tbAutoExport.Text = "Episode Export";
            this.tbAutoExport.UseVisualStyleBackColor = true;
            // 
            // pbuExportEpisodes
            // 
            this.pbuExportEpisodes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbuExportEpisodes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbuExportEpisodes.Image = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pbuExportEpisodes.InitialImage = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pbuExportEpisodes.Location = new System.Drawing.Point(367, 8);
            this.pbuExportEpisodes.Name = "pbuExportEpisodes";
            this.pbuExportEpisodes.Size = new System.Drawing.Size(43, 40);
            this.pbuExportEpisodes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbuExportEpisodes.TabIndex = 44;
            this.pbuExportEpisodes.TabStop = false;
            this.pbuExportEpisodes.Click += new System.EventHandler(this.pbuExportEpisodes_Click);
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(3, 3);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(260, 39);
            this.label88.TabIndex = 43;
            this.label88.Text = "TV Rename can export information about episodes\r\nin various formats. Some focus o" +
    "n upcoming episodes\r\nand others are based on recently aired.";
            // 
            // groupBox10
            // 
            this.groupBox10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox10.Controls.Add(this.bnBrowseWPL);
            this.groupBox10.Controls.Add(this.txtWPL);
            this.groupBox10.Controls.Add(this.cbWPL);
            this.groupBox10.Controls.Add(this.bnBrowseASX);
            this.groupBox10.Controls.Add(this.txtASX);
            this.groupBox10.Controls.Add(this.cbASX);
            this.groupBox10.Controls.Add(this.bnBrowseM3U);
            this.groupBox10.Controls.Add(this.txtM3U);
            this.groupBox10.Controls.Add(this.cbM3U);
            this.groupBox10.Controls.Add(this.bnBrowseXSPF);
            this.groupBox10.Controls.Add(this.txtXSPF);
            this.groupBox10.Controls.Add(this.cbXSPF);
            this.groupBox10.Location = new System.Drawing.Point(12, 343);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(405, 135);
            this.groupBox10.TabIndex = 5;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Recent Playlist";
            // 
            // bnBrowseWPL
            // 
            this.bnBrowseWPL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnBrowseWPL.Location = new System.Drawing.Point(322, 104);
            this.bnBrowseWPL.Name = "bnBrowseWPL";
            this.bnBrowseWPL.Size = new System.Drawing.Size(75, 23);
            this.bnBrowseWPL.TabIndex = 27;
            this.bnBrowseWPL.Text = "Browse...";
            this.bnBrowseWPL.UseVisualStyleBackColor = true;
            this.bnBrowseWPL.Click += new System.EventHandler(this.bnBrowseWPL_Click);
            // 
            // txtWPL
            // 
            this.txtWPL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWPL.Location = new System.Drawing.Point(65, 106);
            this.txtWPL.Name = "txtWPL";
            this.txtWPL.Size = new System.Drawing.Size(250, 20);
            this.txtWPL.TabIndex = 26;
            // 
            // cbWPL
            // 
            this.cbWPL.AutoSize = true;
            this.cbWPL.Location = new System.Drawing.Point(8, 108);
            this.cbWPL.Name = "cbWPL";
            this.cbWPL.Size = new System.Drawing.Size(50, 17);
            this.cbWPL.TabIndex = 25;
            this.cbWPL.Text = "WPL";
            this.cbWPL.UseVisualStyleBackColor = true;
            this.cbWPL.CheckedChanged += new System.EventHandler(this.EnableDisable);
            // 
            // bnBrowseASX
            // 
            this.bnBrowseASX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnBrowseASX.Location = new System.Drawing.Point(322, 76);
            this.bnBrowseASX.Name = "bnBrowseASX";
            this.bnBrowseASX.Size = new System.Drawing.Size(75, 23);
            this.bnBrowseASX.TabIndex = 24;
            this.bnBrowseASX.Text = "Browse...";
            this.bnBrowseASX.UseVisualStyleBackColor = true;
            this.bnBrowseASX.Click += new System.EventHandler(this.bnBrowseASX_Click);
            // 
            // txtASX
            // 
            this.txtASX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtASX.Location = new System.Drawing.Point(65, 78);
            this.txtASX.Name = "txtASX";
            this.txtASX.Size = new System.Drawing.Size(250, 20);
            this.txtASX.TabIndex = 23;
            // 
            // cbASX
            // 
            this.cbASX.AutoSize = true;
            this.cbASX.Location = new System.Drawing.Point(8, 80);
            this.cbASX.Name = "cbASX";
            this.cbASX.Size = new System.Drawing.Size(47, 17);
            this.cbASX.TabIndex = 22;
            this.cbASX.Text = "ASX";
            this.cbASX.UseVisualStyleBackColor = true;
            this.cbASX.CheckedChanged += new System.EventHandler(this.EnableDisable);
            // 
            // bnBrowseM3U
            // 
            this.bnBrowseM3U.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnBrowseM3U.Location = new System.Drawing.Point(321, 46);
            this.bnBrowseM3U.Name = "bnBrowseM3U";
            this.bnBrowseM3U.Size = new System.Drawing.Size(75, 23);
            this.bnBrowseM3U.TabIndex = 19;
            this.bnBrowseM3U.Text = "Browse...";
            this.bnBrowseM3U.UseVisualStyleBackColor = true;
            this.bnBrowseM3U.Click += new System.EventHandler(this.bnBrowseM3U_Click);
            // 
            // txtM3U
            // 
            this.txtM3U.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtM3U.Location = new System.Drawing.Point(65, 49);
            this.txtM3U.Name = "txtM3U";
            this.txtM3U.Size = new System.Drawing.Size(250, 20);
            this.txtM3U.TabIndex = 18;
            // 
            // cbM3U
            // 
            this.cbM3U.AutoSize = true;
            this.cbM3U.Location = new System.Drawing.Point(8, 51);
            this.cbM3U.Name = "cbM3U";
            this.cbM3U.Size = new System.Drawing.Size(60, 17);
            this.cbM3U.TabIndex = 17;
            this.cbM3U.Text = "M3U/8";
            this.cbM3U.UseVisualStyleBackColor = true;
            this.cbM3U.CheckedChanged += new System.EventHandler(this.EnableDisable);
            // 
            // bnBrowseXSPF
            // 
            this.bnBrowseXSPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnBrowseXSPF.Location = new System.Drawing.Point(322, 18);
            this.bnBrowseXSPF.Name = "bnBrowseXSPF";
            this.bnBrowseXSPF.Size = new System.Drawing.Size(75, 23);
            this.bnBrowseXSPF.TabIndex = 2;
            this.bnBrowseXSPF.Text = "Browse...";
            this.bnBrowseXSPF.UseVisualStyleBackColor = true;
            this.bnBrowseXSPF.Click += new System.EventHandler(this.bnBrowseXSPF_Click);
            // 
            // txtXSPF
            // 
            this.txtXSPF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtXSPF.Location = new System.Drawing.Point(64, 20);
            this.txtXSPF.Name = "txtXSPF";
            this.txtXSPF.Size = new System.Drawing.Size(252, 20);
            this.txtXSPF.TabIndex = 1;
            // 
            // cbXSPF
            // 
            this.cbXSPF.AutoSize = true;
            this.cbXSPF.Location = new System.Drawing.Point(8, 22);
            this.cbXSPF.Name = "cbXSPF";
            this.cbXSPF.Size = new System.Drawing.Size(53, 17);
            this.cbXSPF.TabIndex = 0;
            this.cbXSPF.Text = "XSPF";
            this.cbXSPF.UseVisualStyleBackColor = true;
            this.cbXSPF.CheckedChanged += new System.EventHandler(this.EnableDisable);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.bnBrowseFOXML);
            this.groupBox5.Controls.Add(this.cbFOXML);
            this.groupBox5.Controls.Add(this.txtFOXML);
            this.groupBox5.Location = new System.Drawing.Point(12, 282);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(405, 55);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Finding and Organising";
            // 
            // bnBrowseFOXML
            // 
            this.bnBrowseFOXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnBrowseFOXML.Location = new System.Drawing.Point(321, 19);
            this.bnBrowseFOXML.Name = "bnBrowseFOXML";
            this.bnBrowseFOXML.Size = new System.Drawing.Size(75, 23);
            this.bnBrowseFOXML.TabIndex = 2;
            this.bnBrowseFOXML.Text = "Browse...";
            this.bnBrowseFOXML.UseVisualStyleBackColor = true;
            this.bnBrowseFOXML.Click += new System.EventHandler(this.bnBrowseFOXML_Click);
            // 
            // cbFOXML
            // 
            this.cbFOXML.AutoSize = true;
            this.cbFOXML.Location = new System.Drawing.Point(8, 23);
            this.cbFOXML.Name = "cbFOXML";
            this.cbFOXML.Size = new System.Drawing.Size(48, 17);
            this.cbFOXML.TabIndex = 0;
            this.cbFOXML.Text = "XML";
            this.cbFOXML.UseVisualStyleBackColor = true;
            this.cbFOXML.CheckedChanged += new System.EventHandler(this.EnableDisable);
            // 
            // txtFOXML
            // 
            this.txtFOXML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFOXML.Location = new System.Drawing.Point(64, 21);
            this.txtFOXML.Name = "txtFOXML";
            this.txtFOXML.Size = new System.Drawing.Size(251, 20);
            this.txtFOXML.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.bnBrowseRenamingXML);
            this.groupBox4.Controls.Add(this.cbRenamingXML);
            this.groupBox4.Controls.Add(this.txtRenamingXML);
            this.groupBox4.Location = new System.Drawing.Point(12, 219);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(405, 57);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Renaming";
            // 
            // bnBrowseRenamingXML
            // 
            this.bnBrowseRenamingXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnBrowseRenamingXML.Location = new System.Drawing.Point(321, 19);
            this.bnBrowseRenamingXML.Name = "bnBrowseRenamingXML";
            this.bnBrowseRenamingXML.Size = new System.Drawing.Size(75, 23);
            this.bnBrowseRenamingXML.TabIndex = 2;
            this.bnBrowseRenamingXML.Text = "Browse...";
            this.bnBrowseRenamingXML.UseVisualStyleBackColor = true;
            this.bnBrowseRenamingXML.Click += new System.EventHandler(this.bnBrowseRenamingXML_Click);
            // 
            // cbRenamingXML
            // 
            this.cbRenamingXML.AutoSize = true;
            this.cbRenamingXML.Location = new System.Drawing.Point(8, 23);
            this.cbRenamingXML.Name = "cbRenamingXML";
            this.cbRenamingXML.Size = new System.Drawing.Size(48, 17);
            this.cbRenamingXML.TabIndex = 0;
            this.cbRenamingXML.Text = "XML";
            this.cbRenamingXML.UseVisualStyleBackColor = true;
            this.cbRenamingXML.CheckedChanged += new System.EventHandler(this.EnableDisable);
            // 
            // txtRenamingXML
            // 
            this.txtRenamingXML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRenamingXML.Location = new System.Drawing.Point(64, 21);
            this.txtRenamingXML.Name = "txtRenamingXML";
            this.txtRenamingXML.Size = new System.Drawing.Size(251, 20);
            this.txtRenamingXML.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.bnBrowseWTWTXT);
            this.groupBox2.Controls.Add(this.txtWTWTXT);
            this.groupBox2.Controls.Add(this.cbWTWTXT);
            this.groupBox2.Controls.Add(this.bnBrowseWTWICAL);
            this.groupBox2.Controls.Add(this.txtWTWICAL);
            this.groupBox2.Controls.Add(this.cbWTWICAL);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtExportRSSDaysPast);
            this.groupBox2.Controls.Add(this.bnBrowseWTWXML);
            this.groupBox2.Controls.Add(this.txtWTWXML);
            this.groupBox2.Controls.Add(this.cbWTWXML);
            this.groupBox2.Controls.Add(this.bnBrowseWTWRSS);
            this.groupBox2.Controls.Add(this.txtWTWRSS);
            this.groupBox2.Controls.Add(this.cbWTWRSS);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtExportRSSMaxDays);
            this.groupBox2.Controls.Add(this.txtExportRSSMaxShows);
            this.groupBox2.Location = new System.Drawing.Point(12, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 159);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Schedule";
            // 
            // bnBrowseWTWTXT
            // 
            this.bnBrowseWTWTXT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnBrowseWTWTXT.Location = new System.Drawing.Point(322, 102);
            this.bnBrowseWTWTXT.Name = "bnBrowseWTWTXT";
            this.bnBrowseWTWTXT.Size = new System.Drawing.Size(75, 23);
            this.bnBrowseWTWTXT.TabIndex = 27;
            this.bnBrowseWTWTXT.Text = "Browse...";
            this.bnBrowseWTWTXT.UseVisualStyleBackColor = true;
            this.bnBrowseWTWTXT.Click += new System.EventHandler(this.bnBrowseWTWTXT_Click);
            // 
            // txtWTWTXT
            // 
            this.txtWTWTXT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWTWTXT.Location = new System.Drawing.Point(65, 104);
            this.txtWTWTXT.Name = "txtWTWTXT";
            this.txtWTWTXT.Size = new System.Drawing.Size(250, 20);
            this.txtWTWTXT.TabIndex = 26;
            // 
            // cbWTWTXT
            // 
            this.cbWTWTXT.AutoSize = true;
            this.cbWTWTXT.Location = new System.Drawing.Point(8, 106);
            this.cbWTWTXT.Name = "cbWTWTXT";
            this.cbWTWTXT.Size = new System.Drawing.Size(47, 17);
            this.cbWTWTXT.TabIndex = 25;
            this.cbWTWTXT.Text = "TXT";
            this.cbWTWTXT.UseVisualStyleBackColor = true;
            this.cbWTWTXT.CheckedChanged += new System.EventHandler(this.EnableDisable);
            // 
            // bnBrowseWTWICAL
            // 
            this.bnBrowseWTWICAL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnBrowseWTWICAL.Location = new System.Drawing.Point(322, 76);
            this.bnBrowseWTWICAL.Name = "bnBrowseWTWICAL";
            this.bnBrowseWTWICAL.Size = new System.Drawing.Size(75, 23);
            this.bnBrowseWTWICAL.TabIndex = 24;
            this.bnBrowseWTWICAL.Text = "Browse...";
            this.bnBrowseWTWICAL.UseVisualStyleBackColor = true;
            this.bnBrowseWTWICAL.Click += new System.EventHandler(this.bnBrowseWTWICAL_Click);
            // 
            // txtWTWICAL
            // 
            this.txtWTWICAL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWTWICAL.Location = new System.Drawing.Point(65, 78);
            this.txtWTWICAL.Name = "txtWTWICAL";
            this.txtWTWICAL.Size = new System.Drawing.Size(250, 20);
            this.txtWTWICAL.TabIndex = 23;
            // 
            // cbWTWICAL
            // 
            this.cbWTWICAL.AutoSize = true;
            this.cbWTWICAL.Location = new System.Drawing.Point(8, 80);
            this.cbWTWICAL.Name = "cbWTWICAL";
            this.cbWTWICAL.Size = new System.Drawing.Size(43, 17);
            this.cbWTWICAL.TabIndex = 22;
            this.cbWTWICAL.Text = "iCal";
            this.cbWTWICAL.UseVisualStyleBackColor = true;
            this.cbWTWICAL.CheckedChanged += new System.EventHandler(this.EnableDisable);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "in the past.";
            // 
            // txtExportRSSDaysPast
            // 
            this.txtExportRSSDaysPast.Location = new System.Drawing.Point(291, 130);
            this.txtExportRSSDaysPast.Name = "txtExportRSSDaysPast";
            this.txtExportRSSDaysPast.Size = new System.Drawing.Size(28, 20);
            this.txtExportRSSDaysPast.TabIndex = 20;
            this.txtExportRSSDaysPast.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumberOnlyKeyPress);
            // 
            // bnBrowseWTWXML
            // 
            this.bnBrowseWTWXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnBrowseWTWXML.Location = new System.Drawing.Point(321, 46);
            this.bnBrowseWTWXML.Name = "bnBrowseWTWXML";
            this.bnBrowseWTWXML.Size = new System.Drawing.Size(75, 23);
            this.bnBrowseWTWXML.TabIndex = 19;
            this.bnBrowseWTWXML.Text = "Browse...";
            this.bnBrowseWTWXML.UseVisualStyleBackColor = true;
            this.bnBrowseWTWXML.Click += new System.EventHandler(this.bnBrowseWTWXML_Click);
            // 
            // txtWTWXML
            // 
            this.txtWTWXML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWTWXML.Location = new System.Drawing.Point(65, 49);
            this.txtWTWXML.Name = "txtWTWXML";
            this.txtWTWXML.Size = new System.Drawing.Size(250, 20);
            this.txtWTWXML.TabIndex = 18;
            // 
            // cbWTWXML
            // 
            this.cbWTWXML.AutoSize = true;
            this.cbWTWXML.Location = new System.Drawing.Point(8, 51);
            this.cbWTWXML.Name = "cbWTWXML";
            this.cbWTWXML.Size = new System.Drawing.Size(48, 17);
            this.cbWTWXML.TabIndex = 17;
            this.cbWTWXML.Text = "XML";
            this.cbWTWXML.UseVisualStyleBackColor = true;
            this.cbWTWXML.CheckedChanged += new System.EventHandler(this.EnableDisable);
            // 
            // bnBrowseWTWRSS
            // 
            this.bnBrowseWTWRSS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnBrowseWTWRSS.Location = new System.Drawing.Point(322, 18);
            this.bnBrowseWTWRSS.Name = "bnBrowseWTWRSS";
            this.bnBrowseWTWRSS.Size = new System.Drawing.Size(75, 23);
            this.bnBrowseWTWRSS.TabIndex = 2;
            this.bnBrowseWTWRSS.Text = "Browse...";
            this.bnBrowseWTWRSS.UseVisualStyleBackColor = true;
            this.bnBrowseWTWRSS.Click += new System.EventHandler(this.bnBrowseWTWRSS_Click);
            // 
            // txtWTWRSS
            // 
            this.txtWTWRSS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWTWRSS.Location = new System.Drawing.Point(64, 20);
            this.txtWTWRSS.Name = "txtWTWRSS";
            this.txtWTWRSS.Size = new System.Drawing.Size(252, 20);
            this.txtWTWRSS.TabIndex = 1;
            // 
            // cbWTWRSS
            // 
            this.cbWTWRSS.AutoSize = true;
            this.cbWTWRSS.Location = new System.Drawing.Point(8, 22);
            this.cbWTWRSS.Name = "cbWTWRSS";
            this.cbWTWRSS.Size = new System.Drawing.Size(48, 17);
            this.cbWTWRSS.TabIndex = 0;
            this.cbWTWRSS.Text = "RSS";
            this.cbWTWRSS.UseVisualStyleBackColor = true;
            this.cbWTWRSS.CheckedChanged += new System.EventHandler(this.EnableDisable);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(209, 133);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "days worth and";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(117, 133);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "shows, or";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 133);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "No more than";
            // 
            // txtExportRSSMaxDays
            // 
            this.txtExportRSSMaxDays.Location = new System.Drawing.Point(175, 130);
            this.txtExportRSSMaxDays.Name = "txtExportRSSMaxDays";
            this.txtExportRSSMaxDays.Size = new System.Drawing.Size(28, 20);
            this.txtExportRSSMaxDays.TabIndex = 6;
            this.txtExportRSSMaxDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumberOnlyKeyPress);
            // 
            // txtExportRSSMaxShows
            // 
            this.txtExportRSSMaxShows.Location = new System.Drawing.Point(83, 130);
            this.txtExportRSSMaxShows.Name = "txtExportRSSMaxShows";
            this.txtExportRSSMaxShows.Size = new System.Drawing.Size(28, 20);
            this.txtExportRSSMaxShows.TabIndex = 4;
            this.txtExportRSSMaxShows.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumberOnlyKeyPress);
            // 
            // tbFilesAndFolders
            // 
            this.tbFilesAndFolders.Controls.Add(this.cbFileNameCaseSensitiveMatch);
            this.tbFilesAndFolders.Controls.Add(this.chkUseLibraryFullPathWhenMatchingShows);
            this.tbFilesAndFolders.Controls.Add(this.label66);
            this.tbFilesAndFolders.Controls.Add(this.txtKeepTogether);
            this.tbFilesAndFolders.Controls.Add(this.txtMaxSampleSize);
            this.tbFilesAndFolders.Controls.Add(this.txtOtherExtensions);
            this.tbFilesAndFolders.Controls.Add(this.txtVideoExtensions);
            this.tbFilesAndFolders.Controls.Add(this.bnTags);
            this.tbFilesAndFolders.Controls.Add(this.label39);
            this.tbFilesAndFolders.Controls.Add(this.cbKeepTogetherMode);
            this.tbFilesAndFolders.Controls.Add(this.bnReplaceRemove);
            this.tbFilesAndFolders.Controls.Add(this.bnReplaceAdd);
            this.tbFilesAndFolders.Controls.Add(this.label3);
            this.tbFilesAndFolders.Controls.Add(this.ReplacementsGrid);
            this.tbFilesAndFolders.Controls.Add(this.label19);
            this.tbFilesAndFolders.Controls.Add(this.label22);
            this.tbFilesAndFolders.Controls.Add(this.label14);
            this.tbFilesAndFolders.Controls.Add(this.cbKeepTogether);
            this.tbFilesAndFolders.Controls.Add(this.cbForceLower);
            this.tbFilesAndFolders.Controls.Add(this.cbIgnoreSamples);
            this.tbFilesAndFolders.Controls.Add(this.pbFilesAndFolders);
            this.tbFilesAndFolders.Location = new System.Drawing.Point(139, 4);
            this.tbFilesAndFolders.Name = "tbFilesAndFolders";
            this.tbFilesAndFolders.Padding = new System.Windows.Forms.Padding(3);
            this.tbFilesAndFolders.Size = new System.Drawing.Size(417, 561);
            this.tbFilesAndFolders.TabIndex = 1;
            this.tbFilesAndFolders.Text = "Files and Folders";
            this.tbFilesAndFolders.UseVisualStyleBackColor = true;
            // 
            // chkUseLibraryFullPathWhenMatchingShows
            // 
            this.chkUseLibraryFullPathWhenMatchingShows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkUseLibraryFullPathWhenMatchingShows.AutoSize = true;
            this.chkUseLibraryFullPathWhenMatchingShows.Location = new System.Drawing.Point(3, 394);
            this.chkUseLibraryFullPathWhenMatchingShows.Name = "chkUseLibraryFullPathWhenMatchingShows";
            this.chkUseLibraryFullPathWhenMatchingShows.Size = new System.Drawing.Size(413, 17);
            this.chkUseLibraryFullPathWhenMatchingShows.TabIndex = 41;
            this.chkUseLibraryFullPathWhenMatchingShows.Text = "Use name of Library Folder when searching for a match between a file and a show";
            this.chkUseLibraryFullPathWhenMatchingShows.UseVisualStyleBackColor = true;
            // 
            // label66
            // 
            this.label66.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(6, 7);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(326, 39);
            this.label66.TabIndex = 39;
            this.label66.Text = "These preferences control how TV Rename copies files across from\r\nyour search fol" +
    "ders to your library. Often there are other files that\r\nyou\'d like copied as wel" +
    "l.";
            // 
            // txtMaxSampleSize
            // 
            this.txtMaxSampleSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaxSampleSize.Location = new System.Drawing.Point(169, 346);
            this.txtMaxSampleSize.Name = "txtMaxSampleSize";
            this.txtMaxSampleSize.Size = new System.Drawing.Size(53, 20);
            this.txtMaxSampleSize.TabIndex = 14;
            this.txtMaxSampleSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumberOnlyKeyPress);
            // 
            // txtVideoExtensions
            // 
            this.txtVideoExtensions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVideoExtensions.Location = new System.Drawing.Point(99, 233);
            this.txtVideoExtensions.Name = "txtVideoExtensions";
            this.txtVideoExtensions.Size = new System.Drawing.Size(309, 20);
            this.txtVideoExtensions.TabIndex = 5;
            // 
            // bnTags
            // 
            this.bnTags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnTags.Location = new System.Drawing.Point(458, 328);
            this.bnTags.Name = "bnTags";
            this.bnTags.Size = new System.Drawing.Size(75, 23);
            this.bnTags.TabIndex = 24;
            this.bnTags.Text = "Tags...";
            this.bnTags.UseVisualStyleBackColor = true;
            this.bnTags.Click += new System.EventHandler(this.bnTags_Click);
            // 
            // label39
            // 
            this.label39.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(25, 315);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(21, 13);
            this.label39.TabIndex = 22;
            this.label39.Text = "Do";
            // 
            // cbKeepTogetherMode
            // 
            this.cbKeepTogetherMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbKeepTogetherMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKeepTogetherMode.FormattingEnabled = true;
            this.cbKeepTogetherMode.Items.AddRange(new object[] {
            "All",
            "All but these",
            "Just"});
            this.cbKeepTogetherMode.Location = new System.Drawing.Point(52, 312);
            this.cbKeepTogetherMode.Name = "cbKeepTogetherMode";
            this.cbKeepTogetherMode.Size = new System.Drawing.Size(146, 21);
            this.cbKeepTogetherMode.Sorted = true;
            this.cbKeepTogetherMode.TabIndex = 21;
            this.cbKeepTogetherMode.SelectedIndexChanged += new System.EventHandler(this.EnableDisable);
            // 
            // bnReplaceRemove
            // 
            this.bnReplaceRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bnReplaceRemove.Location = new System.Drawing.Point(90, 196);
            this.bnReplaceRemove.Name = "bnReplaceRemove";
            this.bnReplaceRemove.Size = new System.Drawing.Size(75, 23);
            this.bnReplaceRemove.TabIndex = 3;
            this.bnReplaceRemove.Text = "&Remove";
            this.bnReplaceRemove.UseVisualStyleBackColor = true;
            this.bnReplaceRemove.Click += new System.EventHandler(this.bnReplaceRemove_Click);
            // 
            // bnReplaceAdd
            // 
            this.bnReplaceAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bnReplaceAdd.Location = new System.Drawing.Point(9, 196);
            this.bnReplaceAdd.Name = "bnReplaceAdd";
            this.bnReplaceAdd.Size = new System.Drawing.Size(75, 23);
            this.bnReplaceAdd.TabIndex = 2;
            this.bnReplaceAdd.Text = "&Add";
            this.bnReplaceAdd.UseVisualStyleBackColor = true;
            this.bnReplaceAdd.Click += new System.EventHandler(this.bnReplaceAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Filename Replacements";
            // 
            // ReplacementsGrid
            // 
            this.ReplacementsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReplacementsGrid.BackColor = System.Drawing.SystemColors.Window;
            this.ReplacementsGrid.EnableSort = true;
            this.ReplacementsGrid.Location = new System.Drawing.Point(6, 76);
            this.ReplacementsGrid.Name = "ReplacementsGrid";
            this.ReplacementsGrid.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.ReplacementsGrid.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.ReplacementsGrid.Size = new System.Drawing.Size(402, 114);
            this.ReplacementsGrid.TabIndex = 1;
            this.ReplacementsGrid.TabStop = true;
            this.ReplacementsGrid.ToolTipText = "";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(225, 349);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 13);
            this.label19.TabIndex = 15;
            this.label19.Text = "MB in size";
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 262);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(89, 13);
            this.label22.TabIndex = 6;
            this.label22.Text = "&Other extensions:";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 236);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "&Video extensions:";
            // 
            // cbKeepTogether
            // 
            this.cbKeepTogether.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbKeepTogether.AutoSize = true;
            this.cbKeepTogether.Location = new System.Drawing.Point(6, 285);
            this.cbKeepTogether.Name = "cbKeepTogether";
            this.cbKeepTogether.Size = new System.Drawing.Size(348, 17);
            this.cbKeepTogether.TabIndex = 8;
            this.cbKeepTogether.Text = "&Copy/Move files with same base name as video from Search Folders";
            this.cbKeepTogether.UseVisualStyleBackColor = true;
            this.cbKeepTogether.CheckedChanged += new System.EventHandler(this.EnableDisable);
            // 
            // cbForceLower
            // 
            this.cbForceLower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbForceLower.AutoSize = true;
            this.cbForceLower.Location = new System.Drawing.Point(3, 371);
            this.cbForceLower.Name = "cbForceLower";
            this.cbForceLower.Size = new System.Drawing.Size(167, 17);
            this.cbForceLower.TabIndex = 16;
            this.cbForceLower.Text = "&Make all filenames lower case";
            this.cbForceLower.UseVisualStyleBackColor = true;
            // 
            // cbIgnoreSamples
            // 
            this.cbIgnoreSamples.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbIgnoreSamples.AutoSize = true;
            this.cbIgnoreSamples.Location = new System.Drawing.Point(3, 348);
            this.cbIgnoreSamples.Name = "cbIgnoreSamples";
            this.cbIgnoreSamples.Size = new System.Drawing.Size(166, 17);
            this.cbIgnoreSamples.TabIndex = 13;
            this.cbIgnoreSamples.Text = "&Ignore \"sample\" videos, up to";
            this.cbIgnoreSamples.UseVisualStyleBackColor = true;
            // 
            // pbFilesAndFolders
            // 
            this.pbFilesAndFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFilesAndFolders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFilesAndFolders.Image = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pbFilesAndFolders.InitialImage = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pbFilesAndFolders.Location = new System.Drawing.Point(368, 6);
            this.pbFilesAndFolders.Name = "pbFilesAndFolders";
            this.pbFilesAndFolders.Size = new System.Drawing.Size(43, 40);
            this.pbFilesAndFolders.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFilesAndFolders.TabIndex = 33;
            this.pbFilesAndFolders.TabStop = false;
            this.pbFilesAndFolders.Click += new System.EventHandler(this.pbFilesAndFolders_Click);
            // 
            // tbGeneral
            // 
            this.tbGeneral.Controls.Add(this.cbAutoSaveOnExit);
            this.tbGeneral.Controls.Add(this.chkAutoAddAsPartOfQuickRename);
            this.tbGeneral.Controls.Add(this.chkShareCriticalLogs);
            this.tbGeneral.Controls.Add(this.label60);
            this.tbGeneral.Controls.Add(this.pbGeneral);
            this.tbGeneral.Controls.Add(this.txtWTWDays);
            this.tbGeneral.Controls.Add(this.cbMode);
            this.tbGeneral.Controls.Add(this.label34);
            this.tbGeneral.Controls.Add(this.label2);
            this.tbGeneral.Location = new System.Drawing.Point(139, 4);
            this.tbGeneral.Name = "tbGeneral";
            this.tbGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tbGeneral.Size = new System.Drawing.Size(417, 561);
            this.tbGeneral.TabIndex = 0;
            this.tbGeneral.Text = "General";
            this.tbGeneral.UseVisualStyleBackColor = true;
            // 
            // chkAutoAddAsPartOfQuickRename
            // 
            this.chkAutoAddAsPartOfQuickRename.AutoSize = true;
            this.chkAutoAddAsPartOfQuickRename.Location = new System.Drawing.Point(13, 127);
            this.chkAutoAddAsPartOfQuickRename.Name = "chkAutoAddAsPartOfQuickRename";
            this.chkAutoAddAsPartOfQuickRename.Size = new System.Drawing.Size(191, 17);
            this.chkAutoAddAsPartOfQuickRename.TabIndex = 43;
            this.chkAutoAddAsPartOfQuickRename.Text = "Auto-Add as part of Quick Rename";
            this.chkAutoAddAsPartOfQuickRename.UseVisualStyleBackColor = true;
            // 
            // chkShareCriticalLogs
            // 
            this.chkShareCriticalLogs.AutoSize = true;
            this.chkShareCriticalLogs.Location = new System.Drawing.Point(13, 104);
            this.chkShareCriticalLogs.Name = "chkShareCriticalLogs";
            this.chkShareCriticalLogs.Size = new System.Drawing.Size(207, 17);
            this.chkShareCriticalLogs.TabIndex = 42;
            this.chkShareCriticalLogs.Text = "Share critical Logs to help defeat bugs";
            this.chkShareCriticalLogs.UseVisualStyleBackColor = true;
            // 
            // label60
            // 
            this.label60.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(6, 6);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(293, 26);
            this.label60.TabIndex = 38;
            this.label60.Text = "General settings to control TV Rename\'s scan and download\r\nbehaviour";
            // 
            // pbGeneral
            // 
            this.pbGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbGeneral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbGeneral.Image = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pbGeneral.InitialImage = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pbGeneral.Location = new System.Drawing.Point(368, 6);
            this.pbGeneral.Name = "pbGeneral";
            this.pbGeneral.Size = new System.Drawing.Size(43, 40);
            this.pbGeneral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbGeneral.TabIndex = 23;
            this.pbGeneral.TabStop = false;
            this.pbGeneral.Click += new System.EventHandler(this.pbGeneral_Click);
            // 
            // txtWTWDays
            // 
            this.txtWTWDays.Location = new System.Drawing.Point(13, 51);
            this.txtWTWDays.Name = "txtWTWDays";
            this.txtWTWDays.Size = new System.Drawing.Size(28, 20);
            this.txtWTWDays.TabIndex = 1;
            this.txtWTWDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumberOnlyKeyPress);
            // 
            // cbMode
            // 
            this.cbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMode.FormattingEnabled = true;
            this.cbMode.Items.AddRange(new object[] {
            "Beta",
            "Production"});
            this.cbMode.Location = new System.Drawing.Point(117, 77);
            this.cbMode.Name = "cbMode";
            this.cbMode.Size = new System.Drawing.Size(146, 21);
            this.cbMode.Sorted = true;
            this.cbMode.TabIndex = 19;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(11, 80);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(37, 13);
            this.label34.TabIndex = 18;
            this.label34.Text = "&Mode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "days counts as recent";
            // 
            // tcTabs
            // 
            this.tcTabs.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tcTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcTabs.Controls.Add(this.tbGeneral);
            this.tcTabs.Controls.Add(this.tpDisplay);
            this.tcTabs.Controls.Add(this.tpDataSources);
            this.tcTabs.Controls.Add(this.tpLibraryFolders);
            this.tcTabs.Controls.Add(this.tpMovieDefaults);
            this.tcTabs.Controls.Add(this.tpShowDefaults);
            this.tcTabs.Controls.Add(this.tpScanSettings);
            this.tcTabs.Controls.Add(this.tbFilesAndFolders);
            this.tcTabs.Controls.Add(this.tpSubtitles);
            this.tcTabs.Controls.Add(this.tbSearchFolders);
            this.tcTabs.Controls.Add(this.tbFolderDeleting);
            this.tcTabs.Controls.Add(this.tbMediaCenter);
            this.tcTabs.Controls.Add(this.tpTorrentNZB);
            this.tcTabs.Controls.Add(this.tpRSSJSONSearch);
            this.tcTabs.Controls.Add(this.tpJackett);
            this.tcTabs.Controls.Add(this.tbAutoExport);
            this.tcTabs.Controls.Add(this.tpAutoExportLibrary);
            this.tcTabs.Controls.Add(this.tbAppUpdate);
            this.tcTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tcTabs.ItemSize = new System.Drawing.Size(30, 135);
            this.tcTabs.Location = new System.Drawing.Point(12, 12);
            this.tcTabs.Multiline = true;
            this.tcTabs.Name = "tcTabs";
            this.tcTabs.SelectedIndex = 0;
            this.tcTabs.Size = new System.Drawing.Size(560, 569);
            this.tcTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcTabs.TabIndex = 0;
            this.tcTabs.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tpSearch_DrawItem);
            // 
            // tpDataSources
            // 
            this.tpDataSources.Controls.Add(this.panel3);
            this.tpDataSources.Controls.Add(this.panel2);
            this.tpDataSources.Controls.Add(this.label83);
            this.tpDataSources.Controls.Add(this.gbTMDB);
            this.tpDataSources.Controls.Add(this.label63);
            this.tpDataSources.Controls.Add(this.label57);
            this.tpDataSources.Controls.Add(this.label40);
            this.tpDataSources.Controls.Add(this.domainUpDown2);
            this.tpDataSources.Controls.Add(this.txtParallelDownloads);
            this.tpDataSources.Controls.Add(this.label21);
            this.tpDataSources.Controls.Add(this.label20);
            this.tpDataSources.Controls.Add(this.groupBox21);
            this.tpDataSources.Controls.Add(this.groupBox20);
            this.tpDataSources.Controls.Add(this.label33);
            this.tpDataSources.Controls.Add(this.pbSources);
            this.tpDataSources.Location = new System.Drawing.Point(139, 4);
            this.tpDataSources.Name = "tpDataSources";
            this.tpDataSources.Size = new System.Drawing.Size(417, 561);
            this.tpDataSources.TabIndex = 15;
            this.tpDataSources.Text = "Data Sources";
            this.tpDataSources.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdoMovieTMDB);
            this.panel3.Controls.Add(this.rdoMovieTheTVDB);
            this.panel3.Location = new System.Drawing.Point(129, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(260, 29);
            this.panel3.TabIndex = 63;
            // 
            // rdoMovieTMDB
            // 
            this.rdoMovieTMDB.AutoSize = true;
            this.rdoMovieTMDB.Location = new System.Drawing.Point(173, 4);
            this.rdoMovieTMDB.Name = "rdoMovieTMDB";
            this.rdoMovieTMDB.Size = new System.Drawing.Size(56, 17);
            this.rdoMovieTMDB.TabIndex = 60;
            this.rdoMovieTMDB.TabStop = true;
            this.rdoMovieTMDB.Text = "TMDB";
            this.rdoMovieTMDB.UseVisualStyleBackColor = true;
            // 
            // rdoMovieTheTVDB
            // 
            this.rdoMovieTheTVDB.AutoSize = true;
            this.rdoMovieTheTVDB.Location = new System.Drawing.Point(3, 4);
            this.rdoMovieTheTVDB.Name = "rdoMovieTheTVDB";
            this.rdoMovieTheTVDB.Size = new System.Drawing.Size(76, 17);
            this.rdoMovieTheTVDB.TabIndex = 59;
            this.rdoMovieTheTVDB.TabStop = true;
            this.rdoMovieTheTVDB.Text = "The TVDB";
            this.rdoMovieTheTVDB.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdoTVTMDB);
            this.panel2.Controls.Add(this.rdoTVTVMaze);
            this.panel2.Controls.Add(this.rdoTVTVDB);
            this.panel2.Location = new System.Drawing.Point(129, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 29);
            this.panel2.TabIndex = 62;
            // 
            // rdoTVTMDB
            // 
            this.rdoTVTMDB.AutoSize = true;
            this.rdoTVTMDB.Location = new System.Drawing.Point(173, 4);
            this.rdoTVTMDB.Name = "rdoTVTMDB";
            this.rdoTVTMDB.Size = new System.Drawing.Size(56, 17);
            this.rdoTVTMDB.TabIndex = 61;
            this.rdoTVTMDB.TabStop = true;
            this.rdoTVTMDB.Text = "TMDB";
            this.rdoTVTMDB.UseVisualStyleBackColor = true;
            // 
            // rdoTVTVMaze
            // 
            this.rdoTVTVMaze.AutoSize = true;
            this.rdoTVTVMaze.Location = new System.Drawing.Point(90, 3);
            this.rdoTVTVMaze.Name = "rdoTVTVMaze";
            this.rdoTVTVMaze.Size = new System.Drawing.Size(68, 17);
            this.rdoTVTVMaze.TabIndex = 46;
            this.rdoTVTVMaze.TabStop = true;
            this.rdoTVTVMaze.Text = "TV Maze";
            this.rdoTVTVMaze.UseVisualStyleBackColor = true;
            // 
            // rdoTVTVDB
            // 
            this.rdoTVTVDB.AutoSize = true;
            this.rdoTVTVDB.Location = new System.Drawing.Point(3, 3);
            this.rdoTVTVDB.Name = "rdoTVTVDB";
            this.rdoTVTVDB.Size = new System.Drawing.Size(76, 17);
            this.rdoTVTVDB.TabIndex = 45;
            this.rdoTVTVDB.TabStop = true;
            this.rdoTVTVDB.Text = "The TVDB";
            this.rdoTVTVDB.UseVisualStyleBackColor = true;
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(9, 94);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(113, 13);
            this.label83.TabIndex = 61;
            this.label83.Text = "Default Movie Source:";
            this.label83.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gbTMDB
            // 
            this.gbTMDB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTMDB.Controls.Add(this.label84);
            this.gbTMDB.Controls.Add(this.cbTMDBRegions);
            this.gbTMDB.Controls.Add(this.label80);
            this.gbTMDB.Controls.Add(this.label81);
            this.gbTMDB.Controls.Add(this.tbTMDBPercentDirty);
            this.gbTMDB.Controls.Add(this.label82);
            this.gbTMDB.Controls.Add(this.cbTMDBLanguages);
            this.gbTMDB.Location = new System.Drawing.Point(12, 396);
            this.gbTMDB.Name = "gbTMDB";
            this.gbTMDB.Size = new System.Drawing.Size(394, 100);
            this.gbTMDB.TabIndex = 58;
            this.gbTMDB.TabStop = false;
            this.gbTMDB.Text = "TMDB";
            // 
            // cbTMDBRegions
            // 
            this.cbTMDBRegions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTMDBRegions.FormattingEnabled = true;
            this.cbTMDBRegions.Location = new System.Drawing.Point(116, 45);
            this.cbTMDBRegions.Name = "cbTMDBRegions";
            this.cbTMDBRegions.Size = new System.Drawing.Size(146, 21);
            this.cbTMDBRegions.Sorted = true;
            this.cbTMDBRegions.TabIndex = 27;
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(10, 75);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(114, 13);
            this.label80.TabIndex = 23;
            this.label80.Text = "Refresh entire series  if";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(162, 75);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(132, 13);
            this.label81.TabIndex = 25;
            this.label81.Text = "% of episodes are updated";
            // 
            // tbTMDBPercentDirty
            // 
            this.tbTMDBPercentDirty.Location = new System.Drawing.Point(127, 72);
            this.tbTMDBPercentDirty.Name = "tbTMDBPercentDirty";
            this.tbTMDBPercentDirty.Size = new System.Drawing.Size(28, 20);
            this.tbTMDBPercentDirty.TabIndex = 24;
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(11, 22);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(100, 13);
            this.label82.TabIndex = 18;
            this.label82.Text = "&Preferred language:";
            // 
            // cbTMDBLanguages
            // 
            this.cbTMDBLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTMDBLanguages.FormattingEnabled = true;
            this.cbTMDBLanguages.Location = new System.Drawing.Point(117, 19);
            this.cbTMDBLanguages.Name = "cbTMDBLanguages";
            this.cbTMDBLanguages.Size = new System.Drawing.Size(146, 21);
            this.cbTMDBLanguages.Sorted = true;
            this.cbTMDBLanguages.TabIndex = 19;
            // 
            // label63
            // 
            this.label63.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(9, 3);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(349, 26);
            this.label63.TabIndex = 57;
            this.label63.Text = "TV Rename downloads information from upstream sources to understand\r\nwhich shows " +
    "have epiosdes";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(9, 153);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(104, 13);
            this.label57.TabIndex = 55;
            this.label57.Text = "Update cache every";
            // 
            // txtParallelDownloads
            // 
            this.txtParallelDownloads.Location = new System.Drawing.Point(95, 119);
            this.txtParallelDownloads.Name = "txtParallelDownloads";
            this.txtParallelDownloads.Size = new System.Drawing.Size(28, 20);
            this.txtParallelDownloads.TabIndex = 51;
            this.txtParallelDownloads.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumberOnlyKeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 122);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(82, 13);
            this.label21.TabIndex = 50;
            this.label21.Text = "&Download up to";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(129, 122);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(146, 13);
            this.label20.TabIndex = 52;
            this.label20.Text = "shows/images simultaneously";
            // 
            // groupBox21
            // 
            this.groupBox21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox21.Location = new System.Drawing.Point(12, 290);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(394, 100);
            this.groupBox21.TabIndex = 49;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "TV Maze";
            // 
            // groupBox20
            // 
            this.groupBox20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox20.Controls.Add(this.label91);
            this.groupBox20.Controls.Add(this.cbTVDBVersion);
            this.groupBox20.Controls.Add(this.label37);
            this.groupBox20.Controls.Add(this.label38);
            this.groupBox20.Controls.Add(this.tbPercentDirty);
            this.groupBox20.Controls.Add(this.label10);
            this.groupBox20.Controls.Add(this.cbTVDBLanguages);
            this.groupBox20.Location = new System.Drawing.Point(12, 184);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(394, 100);
            this.groupBox20.TabIndex = 48;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "TheTVDB";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Location = new System.Drawing.Point(10, 75);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(45, 13);
            this.label91.TabIndex = 26;
            this.label91.Text = "Version:";
            // 
            // cbTVDBVersion
            // 
            this.cbTVDBVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTVDBVersion.FormattingEnabled = true;
            this.cbTVDBVersion.Items.AddRange(new object[] {
            "v3",
            "v4"});
            this.cbTVDBVersion.Location = new System.Drawing.Point(116, 72);
            this.cbTVDBVersion.Name = "cbTVDBVersion";
            this.cbTVDBVersion.Size = new System.Drawing.Size(146, 21);
            this.cbTVDBVersion.Sorted = true;
            this.cbTVDBVersion.TabIndex = 27;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(10, 49);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(114, 13);
            this.label37.TabIndex = 23;
            this.label37.Text = "Refresh entire series  if";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(162, 49);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(132, 13);
            this.label38.TabIndex = 25;
            this.label38.Text = "% of episodes are updated";
            // 
            // tbPercentDirty
            // 
            this.tbPercentDirty.Location = new System.Drawing.Point(127, 46);
            this.tbPercentDirty.Name = "tbPercentDirty";
            this.tbPercentDirty.Size = new System.Drawing.Size(28, 20);
            this.tbPercentDirty.TabIndex = 24;
            this.tbPercentDirty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumberOnlyKeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "&Preferred language:";
            // 
            // cbTVDBLanguages
            // 
            this.cbTVDBLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTVDBLanguages.FormattingEnabled = true;
            this.cbTVDBLanguages.Items.AddRange(new object[] {
            "My Shows",
            "Scan",
            "Schedule"});
            this.cbTVDBLanguages.Location = new System.Drawing.Point(117, 19);
            this.cbTVDBLanguages.Name = "cbTVDBLanguages";
            this.cbTVDBLanguages.Size = new System.Drawing.Size(146, 21);
            this.cbTVDBLanguages.Sorted = true;
            this.cbTVDBLanguages.TabIndex = 19;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(9, 65);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(98, 13);
            this.label33.TabIndex = 47;
            this.label33.Text = "Default TV Source:";
            this.label33.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pbSources
            // 
            this.pbSources.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSources.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSources.Image = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pbSources.InitialImage = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pbSources.Location = new System.Drawing.Point(371, 3);
            this.pbSources.Name = "pbSources";
            this.pbSources.Size = new System.Drawing.Size(43, 40);
            this.pbSources.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbSources.TabIndex = 56;
            this.pbSources.TabStop = false;
            this.pbSources.Click += new System.EventHandler(this.pbSources_Click);
            // 
            // tpMovieDefaults
            // 
            this.tpMovieDefaults.Controls.Add(this.label86);
            this.tpMovieDefaults.Controls.Add(this.groupBox24);
            this.tpMovieDefaults.Controls.Add(this.groupBox25);
            this.tpMovieDefaults.Controls.Add(this.pbMovieDefaults);
            this.tpMovieDefaults.Location = new System.Drawing.Point(139, 4);
            this.tpMovieDefaults.Name = "tpMovieDefaults";
            this.tpMovieDefaults.Padding = new System.Windows.Forms.Padding(3);
            this.tpMovieDefaults.Size = new System.Drawing.Size(417, 561);
            this.tpMovieDefaults.TabIndex = 18;
            this.tpMovieDefaults.Text = "Movies Defaults";
            this.tpMovieDefaults.UseVisualStyleBackColor = true;
            // 
            // label86
            // 
            this.label86.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(7, 11);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(324, 39);
            this.label86.TabIndex = 63;
            this.label86.Text = "These settings control the defaults used to add a new movie to the \r\nsystem. Once" +
    " the show has been created, you will need to modify\r\nits configuration directly." +
    "";
            // 
            // groupBox24
            // 
            this.groupBox24.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox24.Controls.Add(this.cmbDefMovieFolderFormat);
            this.groupBox24.Controls.Add(this.label95);
            this.groupBox24.Controls.Add(this.cmbDefMovieLocation);
            this.groupBox24.Controls.Add(this.cbDefMovieUseDefLocation);
            this.groupBox24.Controls.Add(this.cbDefMovieAutoFolders);
            this.groupBox24.Location = new System.Drawing.Point(6, 59);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new System.Drawing.Size(401, 134);
            this.groupBox24.TabIndex = 61;
            this.groupBox24.TabStop = false;
            this.groupBox24.Text = "Default Show Settings";
            // 
            // cmbDefMovieLocation
            // 
            this.cmbDefMovieLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDefMovieLocation.FormattingEnabled = true;
            this.cmbDefMovieLocation.Location = new System.Drawing.Point(29, 68);
            this.cmbDefMovieLocation.Name = "cmbDefMovieLocation";
            this.cmbDefMovieLocation.Size = new System.Drawing.Size(366, 21);
            this.cmbDefMovieLocation.TabIndex = 2;
            // 
            // cbDefMovieUseDefLocation
            // 
            this.cbDefMovieUseDefLocation.AutoSize = true;
            this.cbDefMovieUseDefLocation.Location = new System.Drawing.Point(9, 43);
            this.cbDefMovieUseDefLocation.Name = "cbDefMovieUseDefLocation";
            this.cbDefMovieUseDefLocation.Size = new System.Drawing.Size(126, 17);
            this.cbDefMovieUseDefLocation.TabIndex = 1;
            this.cbDefMovieUseDefLocation.Text = "Use Default Location";
            this.cbDefMovieUseDefLocation.UseVisualStyleBackColor = true;
            // 
            // cbDefMovieAutoFolders
            // 
            this.cbDefMovieAutoFolders.AutoSize = true;
            this.cbDefMovieAutoFolders.Location = new System.Drawing.Point(9, 20);
            this.cbDefMovieAutoFolders.Name = "cbDefMovieAutoFolders";
            this.cbDefMovieAutoFolders.Size = new System.Drawing.Size(132, 17);
            this.cbDefMovieAutoFolders.TabIndex = 0;
            this.cbDefMovieAutoFolders.Text = "Use Automatic Folders";
            this.cbDefMovieAutoFolders.UseVisualStyleBackColor = true;
            // 
            // groupBox25
            // 
            this.groupBox25.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox25.Controls.Add(this.cbDefMovieIncludeNoAirdate);
            this.groupBox25.Controls.Add(this.cbDefMovieIncludeFuture);
            this.groupBox25.Controls.Add(this.cbDefMovieDoMissing);
            this.groupBox25.Controls.Add(this.cbDefMovieDoRenaming);
            this.groupBox25.Location = new System.Drawing.Point(6, 199);
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.Size = new System.Drawing.Size(401, 116);
            this.groupBox25.TabIndex = 60;
            this.groupBox25.TabStop = false;
            this.groupBox25.Text = "Default Advanced Settings";
            // 
            // cbDefMovieIncludeNoAirdate
            // 
            this.cbDefMovieIncludeNoAirdate.AutoSize = true;
            this.cbDefMovieIncludeNoAirdate.Location = new System.Drawing.Point(25, 88);
            this.cbDefMovieIncludeNoAirdate.Name = "cbDefMovieIncludeNoAirdate";
            this.cbDefMovieIncludeNoAirdate.Size = new System.Drawing.Size(250, 17);
            this.cbDefMovieIncludeNoAirdate.TabIndex = 53;
            this.cbDefMovieIncludeNoAirdate.Text = "Include check when movie has no release date";
            this.cbDefMovieIncludeNoAirdate.UseVisualStyleBackColor = true;
            // 
            // cbDefMovieIncludeFuture
            // 
            this.cbDefMovieIncludeFuture.AutoSize = true;
            this.cbDefMovieIncludeFuture.Location = new System.Drawing.Point(25, 65);
            this.cbDefMovieIncludeFuture.Name = "cbDefMovieIncludeFuture";
            this.cbDefMovieIncludeFuture.Size = new System.Drawing.Size(274, 17);
            this.cbDefMovieIncludeFuture.TabIndex = 54;
            this.cbDefMovieIncludeFuture.Text = "Include check when movie has a future release date";
            this.cbDefMovieIncludeFuture.UseVisualStyleBackColor = true;
            // 
            // cbDefMovieDoMissing
            // 
            this.cbDefMovieDoMissing.AutoSize = true;
            this.cbDefMovieDoMissing.Location = new System.Drawing.Point(6, 42);
            this.cbDefMovieDoMissing.Name = "cbDefMovieDoMissing";
            this.cbDefMovieDoMissing.Size = new System.Drawing.Size(110, 17);
            this.cbDefMovieDoMissing.TabIndex = 52;
            this.cbDefMovieDoMissing.Text = "Do &missing check";
            this.cbDefMovieDoMissing.UseVisualStyleBackColor = true;
            // 
            // cbDefMovieDoRenaming
            // 
            this.cbDefMovieDoRenaming.AutoSize = true;
            this.cbDefMovieDoRenaming.Location = new System.Drawing.Point(6, 19);
            this.cbDefMovieDoRenaming.Name = "cbDefMovieDoRenaming";
            this.cbDefMovieDoRenaming.Size = new System.Drawing.Size(86, 17);
            this.cbDefMovieDoRenaming.TabIndex = 51;
            this.cbDefMovieDoRenaming.Text = "Do &renaming";
            this.cbDefMovieDoRenaming.UseVisualStyleBackColor = true;
            // 
            // pbMovieDefaults
            // 
            this.pbMovieDefaults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMovieDefaults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMovieDefaults.Image = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pbMovieDefaults.InitialImage = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pbMovieDefaults.Location = new System.Drawing.Point(368, 10);
            this.pbMovieDefaults.Name = "pbMovieDefaults";
            this.pbMovieDefaults.Size = new System.Drawing.Size(43, 40);
            this.pbMovieDefaults.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMovieDefaults.TabIndex = 62;
            this.pbMovieDefaults.TabStop = false;
            this.pbMovieDefaults.Click += new System.EventHandler(this.pbMovieDefaults_Click);
            // 
            // tpShowDefaults
            // 
            this.tpShowDefaults.Controls.Add(this.label18);
            this.tpShowDefaults.Controls.Add(this.groupBox19);
            this.tpShowDefaults.Controls.Add(this.groupBox18);
            this.tpShowDefaults.Controls.Add(this.pictureBox1);
            this.tpShowDefaults.Location = new System.Drawing.Point(139, 4);
            this.tpShowDefaults.Name = "tpShowDefaults";
            this.tpShowDefaults.Padding = new System.Windows.Forms.Padding(3);
            this.tpShowDefaults.Size = new System.Drawing.Size(417, 561);
            this.tpShowDefaults.TabIndex = 14;
            this.tpShowDefaults.Text = "Show Defaults";
            this.tpShowDefaults.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 7);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(321, 39);
            this.label18.TabIndex = 59;
            this.label18.Text = "These settings control the defaults used to add a new show to the \r\nsystem. Once " +
    "the show has been created, you will need to modify\r\nits configuration directly.";
            // 
            // groupBox19
            // 
            this.groupBox19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox19.Controls.Add(this.label24);
            this.groupBox19.Controls.Add(this.cbTimeZone);
            this.groupBox19.Controls.Add(this.rbDefShowUseSubFolders);
            this.groupBox19.Controls.Add(this.rbDefShowUseBase);
            this.groupBox19.Controls.Add(this.label12);
            this.groupBox19.Controls.Add(this.cmbDefShowLocation);
            this.groupBox19.Controls.Add(this.cbDefShowUseDefLocation);
            this.groupBox19.Controls.Add(this.cbDefShowAutoFolders);
            this.groupBox19.Location = new System.Drawing.Point(6, 55);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(401, 176);
            this.groupBox19.TabIndex = 57;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Default Show Settings";
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(9, 149);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(87, 13);
            this.label24.TabIndex = 6;
            this.label24.Text = "Airs in &Timezone:";
            this.label24.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbTimeZone
            // 
            this.cbTimeZone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTimeZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimeZone.FormattingEnabled = true;
            this.cbTimeZone.Location = new System.Drawing.Point(102, 141);
            this.cbTimeZone.Name = "cbTimeZone";
            this.cbTimeZone.Size = new System.Drawing.Size(293, 21);
            this.cbTimeZone.TabIndex = 7;
            // 
            // rbDefShowUseSubFolders
            // 
            this.rbDefShowUseSubFolders.AutoSize = true;
            this.rbDefShowUseSubFolders.Location = new System.Drawing.Point(175, 113);
            this.rbDefShowUseSubFolders.Name = "rbDefShowUseSubFolders";
            this.rbDefShowUseSubFolders.Size = new System.Drawing.Size(101, 17);
            this.rbDefShowUseSubFolders.TabIndex = 5;
            this.rbDefShowUseSubFolders.TabStop = true;
            this.rbDefShowUseSubFolders.Text = "in subdirectories";
            this.rbDefShowUseSubFolders.UseVisualStyleBackColor = true;
            // 
            // rbDefShowUseBase
            // 
            this.rbDefShowUseBase.AutoSize = true;
            this.rbDefShowUseBase.Location = new System.Drawing.Point(29, 113);
            this.rbDefShowUseBase.Name = "rbDefShowUseBase";
            this.rbDefShowUseBase.Size = new System.Drawing.Size(88, 17);
            this.rbDefShowUseBase.TabIndex = 4;
            this.rbDefShowUseBase.TabStop = true;
            this.rbDefShowUseBase.Text = "in base folder";
            this.rbDefShowUseBase.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Default season location:";
            // 
            // cmbDefShowLocation
            // 
            this.cmbDefShowLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDefShowLocation.FormattingEnabled = true;
            this.cmbDefShowLocation.Location = new System.Drawing.Point(29, 68);
            this.cmbDefShowLocation.Name = "cmbDefShowLocation";
            this.cmbDefShowLocation.Size = new System.Drawing.Size(366, 21);
            this.cmbDefShowLocation.TabIndex = 2;
            // 
            // cbDefShowUseDefLocation
            // 
            this.cbDefShowUseDefLocation.AutoSize = true;
            this.cbDefShowUseDefLocation.Location = new System.Drawing.Point(9, 43);
            this.cbDefShowUseDefLocation.Name = "cbDefShowUseDefLocation";
            this.cbDefShowUseDefLocation.Size = new System.Drawing.Size(126, 17);
            this.cbDefShowUseDefLocation.TabIndex = 1;
            this.cbDefShowUseDefLocation.Text = "Use Default Location";
            this.cbDefShowUseDefLocation.UseVisualStyleBackColor = true;
            this.cbDefShowUseDefLocation.CheckedChanged += new System.EventHandler(this.CbDefShowUseDefLocation_CheckedChanged);
            // 
            // cbDefShowAutoFolders
            // 
            this.cbDefShowAutoFolders.AutoSize = true;
            this.cbDefShowAutoFolders.Location = new System.Drawing.Point(9, 20);
            this.cbDefShowAutoFolders.Name = "cbDefShowAutoFolders";
            this.cbDefShowAutoFolders.Size = new System.Drawing.Size(132, 17);
            this.cbDefShowAutoFolders.TabIndex = 0;
            this.cbDefShowAutoFolders.Text = "Use Automatic Folders";
            this.cbDefShowAutoFolders.UseVisualStyleBackColor = true;
            // 
            // groupBox18
            // 
            this.groupBox18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox18.Controls.Add(this.cbDefShowAlternateOrder);
            this.groupBox18.Controls.Add(this.cbDefShowEpNameMatching);
            this.groupBox18.Controls.Add(this.label68);
            this.groupBox18.Controls.Add(this.cbDefShowAirdateMatching);
            this.groupBox18.Controls.Add(this.cbDefShowSpecialsCount);
            this.groupBox18.Controls.Add(this.cbDefShowSequentialMatching);
            this.groupBox18.Controls.Add(this.cbDefShowIncludeNoAirdate);
            this.groupBox18.Controls.Add(this.cbDefShowDoMissingCheck);
            this.groupBox18.Controls.Add(this.cbDefShowDVDOrder);
            this.groupBox18.Controls.Add(this.cbDefShowIncludeFuture);
            this.groupBox18.Controls.Add(this.cbDefShowDoRenaming);
            this.groupBox18.Controls.Add(this.cbDefShowNextAirdate);
            this.groupBox18.Location = new System.Drawing.Point(6, 237);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(401, 258);
            this.groupBox18.TabIndex = 56;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Default Advanced Settings";
            // 
            // cbDefShowAlternateOrder
            // 
            this.cbDefShowAlternateOrder.AutoSize = true;
            this.cbDefShowAlternateOrder.Location = new System.Drawing.Point(115, 28);
            this.cbDefShowAlternateOrder.Name = "cbDefShowAlternateOrder";
            this.cbDefShowAlternateOrder.Size = new System.Drawing.Size(119, 17);
            this.cbDefShowAlternateOrder.TabIndex = 59;
            this.cbDefShowAlternateOrder.Text = "Use Alternate Order";
            this.cbDefShowAlternateOrder.UseVisualStyleBackColor = true;
            this.cbDefShowAlternateOrder.CheckedChanged += new System.EventHandler(this.cbDefShowAlternateOrder_CheckedChanged);
            // 
            // cbDefShowEpNameMatching
            // 
            this.cbDefShowEpNameMatching.AutoSize = true;
            this.cbDefShowEpNameMatching.Location = new System.Drawing.Point(29, 231);
            this.cbDefShowEpNameMatching.Name = "cbDefShowEpNameMatching";
            this.cbDefShowEpNameMatching.Size = new System.Drawing.Size(182, 17);
            this.cbDefShowEpNameMatching.TabIndex = 58;
            this.cbDefShowEpNameMatching.Text = "Look for episode title in filenames";
            this.cbDefShowEpNameMatching.UseVisualStyleBackColor = true;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(9, 165);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(180, 13);
            this.label68.TabIndex = 57;
            this.label68.Text = "When finding missing episodes (only)";
            // 
            // cbDefShowAirdateMatching
            // 
            this.cbDefShowAirdateMatching.AutoSize = true;
            this.cbDefShowAirdateMatching.Location = new System.Drawing.Point(29, 208);
            this.cbDefShowAirdateMatching.Name = "cbDefShowAirdateMatching";
            this.cbDefShowAirdateMatching.Size = new System.Drawing.Size(158, 17);
            this.cbDefShowAirdateMatching.TabIndex = 56;
            this.cbDefShowAirdateMatching.Text = "&Look for airdate in filenames";
            this.cbDefShowAirdateMatching.UseVisualStyleBackColor = true;
            // 
            // cbDefShowSpecialsCount
            // 
            this.cbDefShowSpecialsCount.AutoSize = true;
            this.cbDefShowSpecialsCount.Location = new System.Drawing.Point(9, 74);
            this.cbDefShowSpecialsCount.Name = "cbDefShowSpecialsCount";
            this.cbDefShowSpecialsCount.Size = new System.Drawing.Size(155, 17);
            this.cbDefShowSpecialsCount.TabIndex = 50;
            this.cbDefShowSpecialsCount.Text = "S&pecials count as episodes";
            this.cbDefShowSpecialsCount.UseVisualStyleBackColor = true;
            // 
            // cbDefShowSequentialMatching
            // 
            this.cbDefShowSequentialMatching.AutoSize = true;
            this.cbDefShowSequentialMatching.Location = new System.Drawing.Point(29, 185);
            this.cbDefShowSequentialMatching.Name = "cbDefShowSequentialMatching";
            this.cbDefShowSequentialMatching.Size = new System.Drawing.Size(180, 17);
            this.cbDefShowSequentialMatching.TabIndex = 53;
            this.cbDefShowSequentialMatching.Text = "Use sequential number matching";
            this.cbDefShowSequentialMatching.UseVisualStyleBackColor = true;
            // 
            // cbDefShowIncludeNoAirdate
            // 
            this.cbDefShowIncludeNoAirdate.AutoSize = true;
            this.cbDefShowIncludeNoAirdate.Location = new System.Drawing.Point(175, 143);
            this.cbDefShowIncludeNoAirdate.Name = "cbDefShowIncludeNoAirdate";
            this.cbDefShowIncludeNoAirdate.Size = new System.Drawing.Size(111, 17);
            this.cbDefShowIncludeNoAirdate.TabIndex = 54;
            this.cbDefShowIncludeNoAirdate.Text = "Include no airdate";
            this.cbDefShowIncludeNoAirdate.UseVisualStyleBackColor = true;
            // 
            // cbDefShowDoMissingCheck
            // 
            this.cbDefShowDoMissingCheck.AutoSize = true;
            this.cbDefShowDoMissingCheck.Location = new System.Drawing.Point(9, 120);
            this.cbDefShowDoMissingCheck.Name = "cbDefShowDoMissingCheck";
            this.cbDefShowDoMissingCheck.Size = new System.Drawing.Size(110, 17);
            this.cbDefShowDoMissingCheck.TabIndex = 52;
            this.cbDefShowDoMissingCheck.Text = "Do &missing check";
            this.cbDefShowDoMissingCheck.UseVisualStyleBackColor = true;
            // 
            // cbDefShowDVDOrder
            // 
            this.cbDefShowDVDOrder.AutoSize = true;
            this.cbDefShowDVDOrder.Location = new System.Drawing.Point(9, 28);
            this.cbDefShowDVDOrder.Name = "cbDefShowDVDOrder";
            this.cbDefShowDVDOrder.Size = new System.Drawing.Size(100, 17);
            this.cbDefShowDVDOrder.TabIndex = 48;
            this.cbDefShowDVDOrder.Text = "&Use DVD Order";
            this.cbDefShowDVDOrder.UseVisualStyleBackColor = true;
            this.cbDefShowDVDOrder.CheckedChanged += new System.EventHandler(this.cbDefShowDVDOrder_CheckedChanged);
            // 
            // cbDefShowIncludeFuture
            // 
            this.cbDefShowIncludeFuture.AutoSize = true;
            this.cbDefShowIncludeFuture.Location = new System.Drawing.Point(29, 143);
            this.cbDefShowIncludeFuture.Name = "cbDefShowIncludeFuture";
            this.cbDefShowIncludeFuture.Size = new System.Drawing.Size(136, 17);
            this.cbDefShowIncludeFuture.TabIndex = 55;
            this.cbDefShowIncludeFuture.Text = "Include future episodes";
            this.cbDefShowIncludeFuture.UseVisualStyleBackColor = true;
            // 
            // cbDefShowDoRenaming
            // 
            this.cbDefShowDoRenaming.AutoSize = true;
            this.cbDefShowDoRenaming.Location = new System.Drawing.Point(9, 97);
            this.cbDefShowDoRenaming.Name = "cbDefShowDoRenaming";
            this.cbDefShowDoRenaming.Size = new System.Drawing.Size(86, 17);
            this.cbDefShowDoRenaming.TabIndex = 51;
            this.cbDefShowDoRenaming.Text = "Do &renaming";
            this.cbDefShowDoRenaming.UseVisualStyleBackColor = true;
            // 
            // cbDefShowNextAirdate
            // 
            this.cbDefShowNextAirdate.AutoSize = true;
            this.cbDefShowNextAirdate.Location = new System.Drawing.Point(9, 51);
            this.cbDefShowNextAirdate.Name = "cbDefShowNextAirdate";
            this.cbDefShowNextAirdate.Size = new System.Drawing.Size(174, 17);
            this.cbDefShowNextAirdate.TabIndex = 49;
            this.cbDefShowNextAirdate.Text = "Show &next airdate in \'Schedule\'";
            this.cbDefShowNextAirdate.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pictureBox1.InitialImage = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pictureBox1.Location = new System.Drawing.Point(368, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click_1);
            // 
            // tpScanSettings
            // 
            this.tpScanSettings.Controls.Add(this.groupBox17);
            this.tpScanSettings.Controls.Add(this.groupBox1);
            this.tpScanSettings.Controls.Add(this.cbScanIncludesBulkAdd);
            this.tpScanSettings.Controls.Add(this.gbBulkAdd);
            this.tpScanSettings.Controls.Add(this.label62);
            this.tpScanSettings.Controls.Add(this.pbScanOptions);
            this.tpScanSettings.Location = new System.Drawing.Point(139, 4);
            this.tpScanSettings.Name = "tpScanSettings";
            this.tpScanSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpScanSettings.Size = new System.Drawing.Size(417, 561);
            this.tpScanSettings.TabIndex = 16;
            this.tpScanSettings.Text = "Scan Settings";
            this.tpScanSettings.UseVisualStyleBackColor = true;
            // 
            // groupBox17
            // 
            this.groupBox17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox17.Controls.Add(this.cbIgnorePreviouslySeenMovies);
            this.groupBox17.Controls.Add(this.chkIncludeMoviesQuickRecent);
            this.groupBox17.Controls.Add(this.chkIgnoreAllSpecials);
            this.groupBox17.Controls.Add(this.chkMoveLibraryFiles);
            this.groupBox17.Controls.Add(this.label1);
            this.groupBox17.Controls.Add(this.domainUpDown1);
            this.groupBox17.Controls.Add(this.chkScheduledScan);
            this.groupBox17.Controls.Add(this.chkScanOnStartup);
            this.groupBox17.Controls.Add(this.lblScanAction);
            this.groupBox17.Controls.Add(this.rdoQuickScan);
            this.groupBox17.Controls.Add(this.rdoRecentScan);
            this.groupBox17.Controls.Add(this.rdoFullScan);
            this.groupBox17.Controls.Add(this.cbIgnorePreviouslySeen);
            this.groupBox17.Controls.Add(this.chkPreventMove);
            this.groupBox17.Controls.Add(this.label28);
            this.groupBox17.Controls.Add(this.cbRenameCheck);
            this.groupBox17.Controls.Add(this.cbMissing);
            this.groupBox17.Location = new System.Drawing.Point(7, 49);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(405, 246);
            this.groupBox17.TabIndex = 49;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Scan Options";
            // 
            // cbIgnorePreviouslySeenMovies
            // 
            this.cbIgnorePreviouslySeenMovies.AutoSize = true;
            this.cbIgnorePreviouslySeenMovies.Location = new System.Drawing.Point(213, 187);
            this.cbIgnorePreviouslySeenMovies.Name = "cbIgnorePreviouslySeenMovies";
            this.cbIgnorePreviouslySeenMovies.Size = new System.Drawing.Size(172, 17);
            this.cbIgnorePreviouslySeenMovies.TabIndex = 51;
            this.cbIgnorePreviouslySeenMovies.Text = "Ignore Movies Previously Seen";
            this.cbIgnorePreviouslySeenMovies.UseVisualStyleBackColor = true;
            // 
            // chkMoveLibraryFiles
            // 
            this.chkMoveLibraryFiles.AutoSize = true;
            this.chkMoveLibraryFiles.Checked = true;
            this.chkMoveLibraryFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMoveLibraryFiles.Location = new System.Drawing.Point(10, 229);
            this.chkMoveLibraryFiles.Name = "chkMoveLibraryFiles";
            this.chkMoveLibraryFiles.Size = new System.Drawing.Size(212, 17);
            this.chkMoveLibraryFiles.TabIndex = 48;
            this.chkMoveLibraryFiles.Text = "Move Files within Library to Keep it Tidy";
            this.chkMoveLibraryFiles.UseVisualStyleBackColor = true;
            // 
            // lblScanAction
            // 
            this.lblScanAction.AutoSize = true;
            this.lblScanAction.Location = new System.Drawing.Point(9, 19);
            this.lblScanAction.Name = "lblScanAction";
            this.lblScanAction.Size = new System.Drawing.Size(121, 13);
            this.lblScanAction.TabIndex = 43;
            this.lblScanAction.Text = "Default Auto &Scan Type";
            // 
            // rdoQuickScan
            // 
            this.rdoQuickScan.AutoSize = true;
            this.rdoQuickScan.Location = new System.Drawing.Point(141, 36);
            this.rdoQuickScan.Name = "rdoQuickScan";
            this.rdoQuickScan.Size = new System.Drawing.Size(53, 17);
            this.rdoQuickScan.TabIndex = 42;
            this.rdoQuickScan.TabStop = true;
            this.rdoQuickScan.Text = "&Quick";
            this.rdoQuickScan.UseVisualStyleBackColor = true;
            // 
            // rdoRecentScan
            // 
            this.rdoRecentScan.AutoSize = true;
            this.rdoRecentScan.Location = new System.Drawing.Point(75, 36);
            this.rdoRecentScan.Name = "rdoRecentScan";
            this.rdoRecentScan.Size = new System.Drawing.Size(60, 17);
            this.rdoRecentScan.TabIndex = 41;
            this.rdoRecentScan.TabStop = true;
            this.rdoRecentScan.Text = "&Recent";
            this.rdoRecentScan.UseVisualStyleBackColor = true;
            // 
            // rdoFullScan
            // 
            this.rdoFullScan.AutoSize = true;
            this.rdoFullScan.Location = new System.Drawing.Point(28, 36);
            this.rdoFullScan.Name = "rdoFullScan";
            this.rdoFullScan.Size = new System.Drawing.Size(41, 17);
            this.rdoFullScan.TabIndex = 40;
            this.rdoFullScan.TabStop = true;
            this.rdoFullScan.Text = "&Full";
            this.rdoFullScan.UseVisualStyleBackColor = true;
            // 
            // cbIgnorePreviouslySeen
            // 
            this.cbIgnorePreviouslySeen.AutoSize = true;
            this.cbIgnorePreviouslySeen.Location = new System.Drawing.Point(30, 187);
            this.cbIgnorePreviouslySeen.Name = "cbIgnorePreviouslySeen";
            this.cbIgnorePreviouslySeen.Size = new System.Drawing.Size(181, 17);
            this.cbIgnorePreviouslySeen.TabIndex = 39;
            this.cbIgnorePreviouslySeen.Text = "Ignore Episodes Previously Seen";
            this.cbIgnorePreviouslySeen.UseVisualStyleBackColor = true;
            // 
            // chkPreventMove
            // 
            this.chkPreventMove.AutoSize = true;
            this.chkPreventMove.Location = new System.Drawing.Point(30, 145);
            this.chkPreventMove.Name = "chkPreventMove";
            this.chkPreventMove.Size = new System.Drawing.Size(188, 17);
            this.chkPreventMove.TabIndex = 38;
            this.chkPreventMove.Text = "Pre&vent move of files (just rename)";
            this.chkPreventMove.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(9, 106);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(141, 13);
            this.label28.TabIndex = 35;
            this.label28.Text = "\"Scan\" checks and actions:";
            // 
            // cbRenameCheck
            // 
            this.cbRenameCheck.AutoSize = true;
            this.cbRenameCheck.Checked = true;
            this.cbRenameCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRenameCheck.Location = new System.Drawing.Point(10, 122);
            this.cbRenameCheck.Name = "cbRenameCheck";
            this.cbRenameCheck.Size = new System.Drawing.Size(100, 17);
            this.cbRenameCheck.TabIndex = 36;
            this.cbRenameCheck.Text = "&Rename Check";
            this.cbRenameCheck.UseVisualStyleBackColor = true;
            // 
            // cbMissing
            // 
            this.cbMissing.AutoSize = true;
            this.cbMissing.Checked = true;
            this.cbMissing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMissing.Location = new System.Drawing.Point(10, 168);
            this.cbMissing.Name = "cbMissing";
            this.cbMissing.Size = new System.Drawing.Size(95, 17);
            this.cbMissing.TabIndex = 37;
            this.cbMissing.Text = "&Missing Check";
            this.cbMissing.UseVisualStyleBackColor = true;
            this.cbMissing.CheckedChanged += new System.EventHandler(this.EnableDisable);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkCleanLibraryAfterActions);
            this.groupBox1.Controls.Add(this.cbxUpdateAirDate);
            this.groupBox1.Controls.Add(this.cbAutoCreateFolders);
            this.groupBox1.Controls.Add(this.chkAutoMergeLibraryEpisodes);
            this.groupBox1.Location = new System.Drawing.Point(6, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 115);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Additional Scan Options";
            // 
            // chkCleanLibraryAfterActions
            // 
            this.chkCleanLibraryAfterActions.AutoSize = true;
            this.chkCleanLibraryAfterActions.Location = new System.Drawing.Point(6, 88);
            this.chkCleanLibraryAfterActions.Name = "chkCleanLibraryAfterActions";
            this.chkCleanLibraryAfterActions.Size = new System.Drawing.Size(182, 17);
            this.chkCleanLibraryAfterActions.TabIndex = 42;
            this.chkCleanLibraryAfterActions.Text = "&Remove Unused Season Folders";
            this.chkCleanLibraryAfterActions.UseVisualStyleBackColor = true;
            // 
            // cbxUpdateAirDate
            // 
            this.cbxUpdateAirDate.AutoSize = true;
            this.cbxUpdateAirDate.Location = new System.Drawing.Point(6, 19);
            this.cbxUpdateAirDate.Name = "cbxUpdateAirDate";
            this.cbxUpdateAirDate.Size = new System.Drawing.Size(197, 17);
            this.cbxUpdateAirDate.TabIndex = 39;
            this.cbxUpdateAirDate.Text = "Update files and folders with air date";
            this.cbxUpdateAirDate.UseVisualStyleBackColor = true;
            // 
            // cbAutoCreateFolders
            // 
            this.cbAutoCreateFolders.AutoSize = true;
            this.cbAutoCreateFolders.Location = new System.Drawing.Point(6, 65);
            this.cbAutoCreateFolders.Name = "cbAutoCreateFolders";
            this.cbAutoCreateFolders.Size = new System.Drawing.Size(192, 17);
            this.cbAutoCreateFolders.TabIndex = 37;
            this.cbAutoCreateFolders.Text = "&Automatically create missing folders";
            this.cbAutoCreateFolders.UseVisualStyleBackColor = true;
            // 
            // chkAutoMergeLibraryEpisodes
            // 
            this.chkAutoMergeLibraryEpisodes.AutoSize = true;
            this.chkAutoMergeLibraryEpisodes.Location = new System.Drawing.Point(6, 42);
            this.chkAutoMergeLibraryEpisodes.Name = "chkAutoMergeLibraryEpisodes";
            this.chkAutoMergeLibraryEpisodes.Size = new System.Drawing.Size(306, 17);
            this.chkAutoMergeLibraryEpisodes.TabIndex = 41;
            this.chkAutoMergeLibraryEpisodes.Text = "Automatically create merge rules for merged library episodes";
            this.chkAutoMergeLibraryEpisodes.UseVisualStyleBackColor = true;
            // 
            // cbScanIncludesBulkAdd
            // 
            this.cbScanIncludesBulkAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbScanIncludesBulkAdd.AutoSize = true;
            this.cbScanIncludesBulkAdd.Location = new System.Drawing.Point(7, 422);
            this.cbScanIncludesBulkAdd.Name = "cbScanIncludesBulkAdd";
            this.cbScanIncludesBulkAdd.Size = new System.Drawing.Size(159, 17);
            this.cbScanIncludesBulkAdd.TabIndex = 47;
            this.cbScanIncludesBulkAdd.Text = "Do Bulk-Add as part of scan";
            this.cbScanIncludesBulkAdd.UseVisualStyleBackColor = true;
            // 
            // gbBulkAdd
            // 
            this.gbBulkAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBulkAdd.Controls.Add(this.tbSeasonSearchTerms);
            this.gbBulkAdd.Controls.Add(this.label36);
            this.gbBulkAdd.Controls.Add(this.chkForceBulkAddToUseSettingsOnly);
            this.gbBulkAdd.Controls.Add(this.cbIgnoreRecycleBin);
            this.gbBulkAdd.Controls.Add(this.cbIgnoreNoVideoFolders);
            this.gbBulkAdd.Location = new System.Drawing.Point(7, 445);
            this.gbBulkAdd.Name = "gbBulkAdd";
            this.gbBulkAdd.Size = new System.Drawing.Size(404, 111);
            this.gbBulkAdd.TabIndex = 46;
            this.gbBulkAdd.TabStop = false;
            this.gbBulkAdd.Text = "Bulk Add Shows from Library Folders";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(6, 88);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(109, 13);
            this.label36.TabIndex = 21;
            this.label36.Text = "Season search terms:";
            // 
            // label62
            // 
            this.label62.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(6, 3);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(293, 26);
            this.label62.TabIndex = 40;
            this.label62.Text = "General settings to control TV Rename\'s scan and download\r\nbehaviour";
            // 
            // pbScanOptions
            // 
            this.pbScanOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbScanOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbScanOptions.Image = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pbScanOptions.InitialImage = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pbScanOptions.Location = new System.Drawing.Point(368, 3);
            this.pbScanOptions.Name = "pbScanOptions";
            this.pbScanOptions.Size = new System.Drawing.Size(43, 40);
            this.pbScanOptions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbScanOptions.TabIndex = 39;
            this.pbScanOptions.TabStop = false;
            this.pbScanOptions.Click += new System.EventHandler(this.pbScanOptions_Click);
            // 
            // tpJackett
            // 
            this.tpJackett.Controls.Add(this.chkSearchJackettButton);
            this.tpJackett.Controls.Add(this.cmbSupervisedDuplicateAction);
            this.tpJackett.Controls.Add(this.label77);
            this.tpJackett.Controls.Add(this.cmbUnattendedDuplicateAction);
            this.tpJackett.Controls.Add(this.label76);
            this.tpJackett.Controls.Add(this.cbDetailedRSSJSONLogging);
            this.tpJackett.Controls.Add(this.pbuJackett);
            this.tpJackett.Controls.Add(this.label70);
            this.tpJackett.Controls.Add(this.cbSearchJackett);
            this.tpJackett.Controls.Add(this.groupBox22);
            this.tpJackett.Controls.Add(this.label45);
            this.tpJackett.Controls.Add(this.tbPreferredRSSTerms);
            this.tpJackett.Location = new System.Drawing.Point(139, 4);
            this.tpJackett.Name = "tpJackett";
            this.tpJackett.Padding = new System.Windows.Forms.Padding(3);
            this.tpJackett.Size = new System.Drawing.Size(417, 561);
            this.tpJackett.TabIndex = 17;
            this.tpJackett.Text = "Jackett Search";
            this.tpJackett.UseVisualStyleBackColor = true;
            // 
            // chkSearchJackettButton
            // 
            this.chkSearchJackettButton.AutoSize = true;
            this.chkSearchJackettButton.Location = new System.Drawing.Point(227, 195);
            this.chkSearchJackettButton.Name = "chkSearchJackettButton";
            this.chkSearchJackettButton.Size = new System.Drawing.Size(165, 17);
            this.chkSearchJackettButton.TabIndex = 48;
            this.chkSearchJackettButton.Text = "Show \'Search &Jackett\' button";
            this.chkSearchJackettButton.UseVisualStyleBackColor = true;
            // 
            // cmbSupervisedDuplicateAction
            // 
            this.cmbSupervisedDuplicateAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSupervisedDuplicateAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupervisedDuplicateAction.FormattingEnabled = true;
            this.cmbSupervisedDuplicateAction.Items.AddRange(new object[] {
            "Ask User",
            "Choose Largest File",
            "Choose Most Popular",
            "Download All",
            "Ignore",
            "Use First"});
            this.cmbSupervisedDuplicateAction.Location = new System.Drawing.Point(163, 151);
            this.cmbSupervisedDuplicateAction.Name = "cmbSupervisedDuplicateAction";
            this.cmbSupervisedDuplicateAction.Size = new System.Drawing.Size(235, 21);
            this.cmbSupervisedDuplicateAction.Sorted = true;
            this.cmbSupervisedDuplicateAction.TabIndex = 47;
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(10, 154);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(144, 13);
            this.label77.TabIndex = 46;
            this.label77.Text = "Supervised Duplicate Action:";
            // 
            // cmbUnattendedDuplicateAction
            // 
            this.cmbUnattendedDuplicateAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUnattendedDuplicateAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnattendedDuplicateAction.FormattingEnabled = true;
            this.cmbUnattendedDuplicateAction.Items.AddRange(new object[] {
            "Ask User",
            "Choose Largest File",
            "Choose Most Popular",
            "Download All",
            "Ignore",
            "Use First"});
            this.cmbUnattendedDuplicateAction.Location = new System.Drawing.Point(163, 124);
            this.cmbUnattendedDuplicateAction.Name = "cmbUnattendedDuplicateAction";
            this.cmbUnattendedDuplicateAction.Size = new System.Drawing.Size(235, 21);
            this.cmbUnattendedDuplicateAction.Sorted = true;
            this.cmbUnattendedDuplicateAction.TabIndex = 45;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(10, 127);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(147, 13);
            this.label76.TabIndex = 44;
            this.label76.Text = "Unattended Duplicate Action:";
            // 
            // cbDetailedRSSJSONLogging
            // 
            this.cbDetailedRSSJSONLogging.AutoSize = true;
            this.cbDetailedRSSJSONLogging.Location = new System.Drawing.Point(8, 75);
            this.cbDetailedRSSJSONLogging.Name = "cbDetailedRSSJSONLogging";
            this.cbDetailedRSSJSONLogging.Size = new System.Drawing.Size(307, 17);
            this.cbDetailedRSSJSONLogging.TabIndex = 43;
            this.cbDetailedRSSJSONLogging.Text = "Detailed logging (useful when setting up RSS/JSON Feeds)";
            this.cbDetailedRSSJSONLogging.UseVisualStyleBackColor = false;
            // 
            // pbuJackett
            // 
            this.pbuJackett.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbuJackett.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbuJackett.Image = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pbuJackett.InitialImage = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pbuJackett.Location = new System.Drawing.Point(368, 12);
            this.pbuJackett.Name = "pbuJackett";
            this.pbuJackett.Size = new System.Drawing.Size(43, 40);
            this.pbuJackett.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbuJackett.TabIndex = 42;
            this.pbuJackett.TabStop = false;
            this.pbuJackett.Click += new System.EventHandler(this.pbuJackett_Click);
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(4, 7);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(312, 39);
            this.label70.TabIndex = 41;
            this.label70.Text = "If an episode is missing from your library, TV Rename will talk to a\r\nrunning Jac" +
    "kett instance for appropriate files to download. It will \r\nuse the torrent handl" +
    "ers to download the file(s)";
            // 
            // cbSearchJackett
            // 
            this.cbSearchJackett.AutoSize = true;
            this.cbSearchJackett.Location = new System.Drawing.Point(8, 195);
            this.cbSearchJackett.Name = "cbSearchJackett";
            this.cbSearchJackett.Size = new System.Drawing.Size(171, 17);
            this.cbSearchJackett.TabIndex = 40;
            this.cbSearchJackett.Text = "Search &Jackett for missing files";
            this.cbSearchJackett.UseVisualStyleBackColor = true;
            this.cbSearchJackett.CheckedChanged += new System.EventHandler(this.EnableDisable);
            // 
            // groupBox22
            // 
            this.groupBox22.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox22.Controls.Add(this.chkUseJackettTextSearch);
            this.groupBox22.Controls.Add(this.chkSkipJackettFullScans);
            this.groupBox22.Controls.Add(this.llJackettLink);
            this.groupBox22.Controls.Add(this.label71);
            this.groupBox22.Controls.Add(this.cbSearchJackettOnManualScansOnly);
            this.groupBox22.Controls.Add(this.label72);
            this.groupBox22.Controls.Add(this.txtJackettIndexer);
            this.groupBox22.Controls.Add(this.label73);
            this.groupBox22.Controls.Add(this.txtJackettAPIKey);
            this.groupBox22.Controls.Add(this.label74);
            this.groupBox22.Controls.Add(this.txtJackettPort);
            this.groupBox22.Controls.Add(this.label75);
            this.groupBox22.Controls.Add(this.txtJackettServer);
            this.groupBox22.Location = new System.Drawing.Point(6, 218);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(408, 201);
            this.groupBox22.TabIndex = 39;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Jackett Search";
            // 
            // chkUseJackettTextSearch
            // 
            this.chkUseJackettTextSearch.AutoSize = true;
            this.chkUseJackettTextSearch.Location = new System.Drawing.Point(98, 146);
            this.chkUseJackettTextSearch.Name = "chkUseJackettTextSearch";
            this.chkUseJackettTextSearch.Size = new System.Drawing.Size(100, 17);
            this.chkUseJackettTextSearch.TabIndex = 42;
            this.chkUseJackettTextSearch.Text = "Use text search";
            this.chkUseJackettTextSearch.UseVisualStyleBackColor = true;
            // 
            // chkSkipJackettFullScans
            // 
            this.chkSkipJackettFullScans.AutoSize = true;
            this.chkSkipJackettFullScans.Location = new System.Drawing.Point(248, 19);
            this.chkSkipJackettFullScans.Name = "chkSkipJackettFullScans";
            this.chkSkipJackettFullScans.Size = new System.Drawing.Size(154, 17);
            this.chkSkipJackettFullScans.TabIndex = 41;
            this.chkSkipJackettFullScans.Text = "Skip Jackett On Full Scans";
            this.chkSkipJackettFullScans.UseVisualStyleBackColor = true;
            // 
            // llJackettLink
            // 
            this.llJackettLink.AutoSize = true;
            this.llJackettLink.Location = new System.Drawing.Point(98, 170);
            this.llJackettLink.Name = "llJackettLink";
            this.llJackettLink.Size = new System.Drawing.Size(55, 13);
            this.llJackettLink.TabIndex = 40;
            this.llJackettLink.TabStop = true;
            this.llJackettLink.Text = "linkLabel1";
            this.llJackettLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlJackettLink_LinkClicked);
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(6, 170);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(72, 13);
            this.label71.TabIndex = 39;
            this.label71.Text = "Configuration:";
            // 
            // cbSearchJackettOnManualScansOnly
            // 
            this.cbSearchJackettOnManualScansOnly.AutoSize = true;
            this.cbSearchJackettOnManualScansOnly.Location = new System.Drawing.Point(9, 19);
            this.cbSearchJackettOnManualScansOnly.Name = "cbSearchJackettOnManualScansOnly";
            this.cbSearchJackettOnManualScansOnly.Size = new System.Drawing.Size(130, 17);
            this.cbSearchJackettOnManualScansOnly.TabIndex = 38;
            this.cbSearchJackettOnManualScansOnly.Text = "Only on manual scans";
            this.cbSearchJackettOnManualScansOnly.UseVisualStyleBackColor = true;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(6, 97);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(70, 13);
            this.label72.TabIndex = 37;
            this.label72.Text = "Indexer Path:";
            // 
            // txtJackettIndexer
            // 
            this.txtJackettIndexer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJackettIndexer.Location = new System.Drawing.Point(98, 94);
            this.txtJackettIndexer.Name = "txtJackettIndexer";
            this.txtJackettIndexer.Size = new System.Drawing.Size(305, 20);
            this.txtJackettIndexer.TabIndex = 36;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(6, 123);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(48, 13);
            this.label73.TabIndex = 35;
            this.label73.Text = "API Key:";
            // 
            // txtJackettAPIKey
            // 
            this.txtJackettAPIKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJackettAPIKey.Location = new System.Drawing.Point(98, 120);
            this.txtJackettAPIKey.Name = "txtJackettAPIKey";
            this.txtJackettAPIKey.Size = new System.Drawing.Size(305, 20);
            this.txtJackettAPIKey.TabIndex = 34;
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(6, 71);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(29, 13);
            this.label74.TabIndex = 33;
            this.label74.Text = "Port:";
            // 
            // txtJackettPort
            // 
            this.txtJackettPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJackettPort.Location = new System.Drawing.Point(98, 68);
            this.txtJackettPort.Name = "txtJackettPort";
            this.txtJackettPort.Size = new System.Drawing.Size(305, 20);
            this.txtJackettPort.TabIndex = 32;
            this.txtJackettPort.TextChanged += new System.EventHandler(this.JackettDetailsUpdate);
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(6, 45);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(41, 13);
            this.label75.TabIndex = 31;
            this.label75.Text = "Server:";
            // 
            // txtJackettServer
            // 
            this.txtJackettServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJackettServer.Location = new System.Drawing.Point(97, 42);
            this.txtJackettServer.Name = "txtJackettServer";
            this.txtJackettServer.Size = new System.Drawing.Size(305, 20);
            this.txtJackettServer.TabIndex = 30;
            this.txtJackettServer.TextChanged += new System.EventHandler(this.JackettDetailsUpdate);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(6, 101);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(85, 13);
            this.label45.TabIndex = 33;
            this.label45.Text = "Preferred Terms:";
            // 
            // tbPreferredRSSTerms
            // 
            this.tbPreferredRSSTerms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPreferredRSSTerms.Location = new System.Drawing.Point(94, 98);
            this.tbPreferredRSSTerms.Name = "tbPreferredRSSTerms";
            this.tbPreferredRSSTerms.Size = new System.Drawing.Size(304, 20);
            this.tbPreferredRSSTerms.TabIndex = 32;
            // 
            // tpAutoExportLibrary
            // 
            this.tpAutoExportLibrary.Controls.Add(this.pbuShowExport);
            this.tpAutoExportLibrary.Controls.Add(this.label89);
            this.tpAutoExportLibrary.Controls.Add(this.groupBox26);
            this.tpAutoExportLibrary.Controls.Add(this.groupBox7);
            this.tpAutoExportLibrary.Controls.Add(this.groupBox27);
            this.tpAutoExportLibrary.Controls.Add(this.groupBox3);
            this.tpAutoExportLibrary.Location = new System.Drawing.Point(139, 4);
            this.tpAutoExportLibrary.Name = "tpAutoExportLibrary";
            this.tpAutoExportLibrary.Padding = new System.Windows.Forms.Padding(3);
            this.tpAutoExportLibrary.Size = new System.Drawing.Size(417, 561);
            this.tpAutoExportLibrary.TabIndex = 19;
            this.tpAutoExportLibrary.Text = "Library Export";
            this.tpAutoExportLibrary.UseVisualStyleBackColor = true;
            // 
            // pbuShowExport
            // 
            this.pbuShowExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbuShowExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbuShowExport.Image = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pbuShowExport.InitialImage = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pbuShowExport.Location = new System.Drawing.Point(368, 16);
            this.pbuShowExport.Name = "pbuShowExport";
            this.pbuShowExport.Size = new System.Drawing.Size(43, 40);
            this.pbuShowExport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbuShowExport.TabIndex = 44;
            this.pbuShowExport.TabStop = false;
            this.pbuShowExport.Click += new System.EventHandler(this.pbuShowExport_Click);
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(4, 11);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(230, 26);
            this.label89.TabIndex = 43;
            this.label89.Text = "TV Rename can export information about\r\nshows, movies and episodes in various for" +
    "mats.";
            // 
            // groupBox26
            // 
            this.groupBox26.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox26.Controls.Add(this.bnBrowseMoviesHTML);
            this.groupBox26.Controls.Add(this.cbMoviesHTML);
            this.groupBox26.Controls.Add(this.txtMoviesHTMLTo);
            this.groupBox26.Controls.Add(this.bnBrowseMoviesTXT);
            this.groupBox26.Controls.Add(this.cbMoviesTXT);
            this.groupBox26.Controls.Add(this.txtMoviesTXTTo);
            this.groupBox26.Location = new System.Drawing.Point(10, 300);
            this.groupBox26.Name = "groupBox26";
            this.groupBox26.Size = new System.Drawing.Size(404, 72);
            this.groupBox26.TabIndex = 10;
            this.groupBox26.TabStop = false;
            this.groupBox26.Text = "All Movies";
            // 
            // bnBrowseMoviesHTML
            // 
            this.bnBrowseMoviesHTML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnBrowseMoviesHTML.Location = new System.Drawing.Point(321, 45);
            this.bnBrowseMoviesHTML.Name = "bnBrowseMoviesHTML";
            this.bnBrowseMoviesHTML.Size = new System.Drawing.Size(75, 23);
            this.bnBrowseMoviesHTML.TabIndex = 8;
            this.bnBrowseMoviesHTML.Text = "Browse...";
            this.bnBrowseMoviesHTML.UseVisualStyleBackColor = true;
            this.bnBrowseMoviesHTML.Click += new System.EventHandler(this.bnBrowseMoviesHTML_Click);
            // 
            // cbMoviesHTML
            // 
            this.cbMoviesHTML.AutoSize = true;
            this.cbMoviesHTML.Location = new System.Drawing.Point(8, 49);
            this.cbMoviesHTML.Name = "cbMoviesHTML";
            this.cbMoviesHTML.Size = new System.Drawing.Size(56, 17);
            this.cbMoviesHTML.TabIndex = 6;
            this.cbMoviesHTML.Text = "HTML";
            this.cbMoviesHTML.UseVisualStyleBackColor = true;
            this.cbMoviesHTML.CheckedChanged += new System.EventHandler(this.EnableDisable);
            // 
            // txtMoviesHTMLTo
            // 
            this.txtMoviesHTMLTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMoviesHTMLTo.Location = new System.Drawing.Point(64, 47);
            this.txtMoviesHTMLTo.Name = "txtMoviesHTMLTo";
            this.txtMoviesHTMLTo.Size = new System.Drawing.Size(251, 20);
            this.txtMoviesHTMLTo.TabIndex = 7;
            // 
            // bnBrowseMoviesTXT
            // 
            this.bnBrowseMoviesTXT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnBrowseMoviesTXT.Location = new System.Drawing.Point(321, 21);
            this.bnBrowseMoviesTXT.Name = "bnBrowseMoviesTXT";
            this.bnBrowseMoviesTXT.Size = new System.Drawing.Size(75, 23);
            this.bnBrowseMoviesTXT.TabIndex = 5;
            this.bnBrowseMoviesTXT.Text = "Browse...";
            this.bnBrowseMoviesTXT.UseVisualStyleBackColor = true;
            this.bnBrowseMoviesTXT.Click += new System.EventHandler(this.bnBrowseMoviesTXT_Click);
            // 
            // cbMoviesTXT
            // 
            this.cbMoviesTXT.AutoSize = true;
            this.cbMoviesTXT.Location = new System.Drawing.Point(8, 25);
            this.cbMoviesTXT.Name = "cbMoviesTXT";
            this.cbMoviesTXT.Size = new System.Drawing.Size(47, 17);
            this.cbMoviesTXT.TabIndex = 3;
            this.cbMoviesTXT.Text = "TXT";
            this.cbMoviesTXT.UseVisualStyleBackColor = true;
            this.cbMoviesTXT.CheckedChanged += new System.EventHandler(this.EnableDisable);
            // 
            // txtMoviesTXTTo
            // 
            this.txtMoviesTXTTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMoviesTXTTo.Location = new System.Drawing.Point(64, 23);
            this.txtMoviesTXTTo.Name = "txtMoviesTXTTo";
            this.txtMoviesTXTTo.Size = new System.Drawing.Size(250, 20);
            this.txtMoviesTXTTo.TabIndex = 4;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.bnBrowseShowsHTML);
            this.groupBox7.Controls.Add(this.cbShowsHTML);
            this.groupBox7.Controls.Add(this.txtShowsHTMLTo);
            this.groupBox7.Controls.Add(this.bnBrowseShowsTXT);
            this.groupBox7.Controls.Add(this.cbShowsTXT);
            this.groupBox7.Controls.Add(this.txtShowsTXTTo);
            this.groupBox7.Location = new System.Drawing.Point(10, 142);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(404, 72);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "All Shows";
            // 
            // bnBrowseShowsHTML
            // 
            this.bnBrowseShowsHTML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnBrowseShowsHTML.Location = new System.Drawing.Point(321, 45);
            this.bnBrowseShowsHTML.Name = "bnBrowseShowsHTML";
            this.bnBrowseShowsHTML.Size = new System.Drawing.Size(75, 23);
            this.bnBrowseShowsHTML.TabIndex = 8;
            this.bnBrowseShowsHTML.Text = "Browse...";
            this.bnBrowseShowsHTML.UseVisualStyleBackColor = true;
            this.bnBrowseShowsHTML.Click += new System.EventHandler(this.bnBrowseShowsHTML_Click);
            // 
            // cbShowsHTML
            // 
            this.cbShowsHTML.AutoSize = true;
            this.cbShowsHTML.Location = new System.Drawing.Point(8, 49);
            this.cbShowsHTML.Name = "cbShowsHTML";
            this.cbShowsHTML.Size = new System.Drawing.Size(56, 17);
            this.cbShowsHTML.TabIndex = 6;
            this.cbShowsHTML.Text = "HTML";
            this.cbShowsHTML.UseVisualStyleBackColor = true;
            this.cbShowsHTML.CheckedChanged += new System.EventHandler(this.EnableDisable);
            // 
            // txtShowsHTMLTo
            // 
            this.txtShowsHTMLTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtShowsHTMLTo.Location = new System.Drawing.Point(64, 47);
            this.txtShowsHTMLTo.Name = "txtShowsHTMLTo";
            this.txtShowsHTMLTo.Size = new System.Drawing.Size(251, 20);
            this.txtShowsHTMLTo.TabIndex = 7;
            // 
            // bnBrowseShowsTXT
            // 
            this.bnBrowseShowsTXT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnBrowseShowsTXT.Location = new System.Drawing.Point(321, 21);
            this.bnBrowseShowsTXT.Name = "bnBrowseShowsTXT";
            this.bnBrowseShowsTXT.Size = new System.Drawing.Size(75, 23);
            this.bnBrowseShowsTXT.TabIndex = 5;
            this.bnBrowseShowsTXT.Text = "Browse...";
            this.bnBrowseShowsTXT.UseVisualStyleBackColor = true;
            this.bnBrowseShowsTXT.Click += new System.EventHandler(this.bnBrowseShowsTXT_Click);
            // 
            // cbShowsTXT
            // 
            this.cbShowsTXT.AutoSize = true;
            this.cbShowsTXT.Location = new System.Drawing.Point(8, 25);
            this.cbShowsTXT.Name = "cbShowsTXT";
            this.cbShowsTXT.Size = new System.Drawing.Size(47, 17);
            this.cbShowsTXT.TabIndex = 3;
            this.cbShowsTXT.Text = "TXT";
            this.cbShowsTXT.UseVisualStyleBackColor = true;
            this.cbShowsTXT.CheckedChanged += new System.EventHandler(this.EnableDisable);
            // 
            // txtShowsTXTTo
            // 
            this.txtShowsTXTTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtShowsTXTTo.Location = new System.Drawing.Point(64, 23);
            this.txtShowsTXTTo.Name = "txtShowsTXTTo";
            this.txtShowsTXTTo.Size = new System.Drawing.Size(250, 20);
            this.txtShowsTXTTo.TabIndex = 4;
            // 
            // groupBox27
            // 
            this.groupBox27.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox27.Controls.Add(this.bnBrowseMissingMoviesCSV);
            this.groupBox27.Controls.Add(this.bnBrowseMissingMoviesXML);
            this.groupBox27.Controls.Add(this.txtMissingMoviesCSV);
            this.groupBox27.Controls.Add(this.cbMissingMoviesXML);
            this.groupBox27.Controls.Add(this.cbMissingMoviesCSV);
            this.groupBox27.Controls.Add(this.txtMissingMoviesXML);
            this.groupBox27.Location = new System.Drawing.Point(9, 220);
            this.groupBox27.Name = "groupBox27";
            this.groupBox27.Size = new System.Drawing.Size(405, 79);
            this.groupBox27.TabIndex = 9;
            this.groupBox27.TabStop = false;
            this.groupBox27.Text = "Missing Movies";
            // 
            // bnBrowseMissingMoviesCSV
            // 
            this.bnBrowseMissingMoviesCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnBrowseMissingMoviesCSV.Location = new System.Drawing.Point(321, 47);
            this.bnBrowseMissingMoviesCSV.Name = "bnBrowseMissingMoviesCSV";
            this.bnBrowseMissingMoviesCSV.Size = new System.Drawing.Size(75, 23);
            this.bnBrowseMissingMoviesCSV.TabIndex = 2;
            this.bnBrowseMissingMoviesCSV.Text = "Browse...";
            this.bnBrowseMissingMoviesCSV.UseVisualStyleBackColor = true;
            this.bnBrowseMissingMoviesCSV.Click += new System.EventHandler(this.bnBrowseMissingMoviesCSV_Click);
            // 
            // bnBrowseMissingMoviesXML
            // 
            this.bnBrowseMissingMoviesXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnBrowseMissingMoviesXML.Location = new System.Drawing.Point(322, 19);
            this.bnBrowseMissingMoviesXML.Name = "bnBrowseMissingMoviesXML";
            this.bnBrowseMissingMoviesXML.Size = new System.Drawing.Size(75, 23);
            this.bnBrowseMissingMoviesXML.TabIndex = 5;
            this.bnBrowseMissingMoviesXML.Text = "Browse...";
            this.bnBrowseMissingMoviesXML.UseVisualStyleBackColor = true;
            this.bnBrowseMissingMoviesXML.Click += new System.EventHandler(this.bnBrowseMissingMoviesXML_Click);
            // 
            // txtMissingMoviesCSV
            // 
            this.txtMissingMoviesCSV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMissingMoviesCSV.Location = new System.Drawing.Point(64, 48);
            this.txtMissingMoviesCSV.Name = "txtMissingMoviesCSV";
            this.txtMissingMoviesCSV.Size = new System.Drawing.Size(251, 20);
            this.txtMissingMoviesCSV.TabIndex = 1;
            // 
            // cbMissingMoviesXML
            // 
            this.cbMissingMoviesXML.AutoSize = true;
            this.cbMissingMoviesXML.Location = new System.Drawing.Point(8, 23);
            this.cbMissingMoviesXML.Name = "cbMissingMoviesXML";
            this.cbMissingMoviesXML.Size = new System.Drawing.Size(48, 17);
            this.cbMissingMoviesXML.TabIndex = 3;
            this.cbMissingMoviesXML.Text = "XML";
            this.cbMissingMoviesXML.UseVisualStyleBackColor = true;
            this.cbMissingMoviesXML.CheckedChanged += new System.EventHandler(this.EnableDisable);
            // 
            // cbMissingMoviesCSV
            // 
            this.cbMissingMoviesCSV.AutoSize = true;
            this.cbMissingMoviesCSV.Location = new System.Drawing.Point(9, 48);
            this.cbMissingMoviesCSV.Name = "cbMissingMoviesCSV";
            this.cbMissingMoviesCSV.Size = new System.Drawing.Size(47, 17);
            this.cbMissingMoviesCSV.TabIndex = 0;
            this.cbMissingMoviesCSV.Text = "CSV";
            this.cbMissingMoviesCSV.UseVisualStyleBackColor = true;
            this.cbMissingMoviesCSV.CheckedChanged += new System.EventHandler(this.EnableDisable);
            // 
            // txtMissingMoviesXML
            // 
            this.txtMissingMoviesXML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMissingMoviesXML.Location = new System.Drawing.Point(64, 21);
            this.txtMissingMoviesXML.Name = "txtMissingMoviesXML";
            this.txtMissingMoviesXML.Size = new System.Drawing.Size(251, 20);
            this.txtMissingMoviesXML.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.bnBrowseMissingCSV);
            this.groupBox3.Controls.Add(this.bnBrowseMissingXML);
            this.groupBox3.Controls.Add(this.txtMissingCSV);
            this.groupBox3.Controls.Add(this.cbMissingXML);
            this.groupBox3.Controls.Add(this.cbMissingCSV);
            this.groupBox3.Controls.Add(this.txtMissingXML);
            this.groupBox3.Location = new System.Drawing.Point(9, 62);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(405, 79);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Missing Episodes";
            // 
            // bnBrowseMissingCSV
            // 
            this.bnBrowseMissingCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnBrowseMissingCSV.Location = new System.Drawing.Point(321, 47);
            this.bnBrowseMissingCSV.Name = "bnBrowseMissingCSV";
            this.bnBrowseMissingCSV.Size = new System.Drawing.Size(75, 23);
            this.bnBrowseMissingCSV.TabIndex = 2;
            this.bnBrowseMissingCSV.Text = "Browse...";
            this.bnBrowseMissingCSV.UseVisualStyleBackColor = true;
            this.bnBrowseMissingCSV.Click += new System.EventHandler(this.bnBrowseMissingCSV_Click);
            // 
            // bnBrowseMissingXML
            // 
            this.bnBrowseMissingXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnBrowseMissingXML.Location = new System.Drawing.Point(322, 19);
            this.bnBrowseMissingXML.Name = "bnBrowseMissingXML";
            this.bnBrowseMissingXML.Size = new System.Drawing.Size(75, 23);
            this.bnBrowseMissingXML.TabIndex = 5;
            this.bnBrowseMissingXML.Text = "Browse...";
            this.bnBrowseMissingXML.UseVisualStyleBackColor = true;
            this.bnBrowseMissingXML.Click += new System.EventHandler(this.bnBrowseMissingXML_Click);
            // 
            // txtMissingCSV
            // 
            this.txtMissingCSV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMissingCSV.Location = new System.Drawing.Point(64, 48);
            this.txtMissingCSV.Name = "txtMissingCSV";
            this.txtMissingCSV.Size = new System.Drawing.Size(251, 20);
            this.txtMissingCSV.TabIndex = 1;
            // 
            // cbMissingXML
            // 
            this.cbMissingXML.AutoSize = true;
            this.cbMissingXML.Location = new System.Drawing.Point(8, 23);
            this.cbMissingXML.Name = "cbMissingXML";
            this.cbMissingXML.Size = new System.Drawing.Size(48, 17);
            this.cbMissingXML.TabIndex = 3;
            this.cbMissingXML.Text = "XML";
            this.cbMissingXML.UseVisualStyleBackColor = true;
            this.cbMissingXML.CheckedChanged += new System.EventHandler(this.EnableDisable);
            // 
            // cbMissingCSV
            // 
            this.cbMissingCSV.AutoSize = true;
            this.cbMissingCSV.Location = new System.Drawing.Point(9, 48);
            this.cbMissingCSV.Name = "cbMissingCSV";
            this.cbMissingCSV.Size = new System.Drawing.Size(47, 17);
            this.cbMissingCSV.TabIndex = 0;
            this.cbMissingCSV.Text = "CSV";
            this.cbMissingCSV.UseVisualStyleBackColor = true;
            this.cbMissingCSV.CheckedChanged += new System.EventHandler(this.EnableDisable);
            // 
            // txtMissingXML
            // 
            this.txtMissingXML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMissingXML.Location = new System.Drawing.Point(64, 21);
            this.txtMissingXML.Name = "txtMissingXML";
            this.txtMissingXML.Size = new System.Drawing.Size(251, 20);
            this.txtMissingXML.TabIndex = 4;
            // 
            // tbAppUpdate
            // 
            this.tbAppUpdate.Controls.Add(this.pbuUpdates);
            this.tbAppUpdate.Controls.Add(this.label92);
            this.tbAppUpdate.Controls.Add(this.grpUpdateIntervalOption);
            this.tbAppUpdate.Location = new System.Drawing.Point(139, 4);
            this.tbAppUpdate.Name = "tbAppUpdate";
            this.tbAppUpdate.Size = new System.Drawing.Size(417, 561);
            this.tbAppUpdate.TabIndex = 20;
            this.tbAppUpdate.Text = "App Updates";
            this.tbAppUpdate.UseVisualStyleBackColor = true;
            // 
            // pbuUpdates
            // 
            this.pbuUpdates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbuUpdates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbuUpdates.Image = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pbuUpdates.InitialImage = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pbuUpdates.Location = new System.Drawing.Point(367, 14);
            this.pbuUpdates.Name = "pbuUpdates";
            this.pbuUpdates.Size = new System.Drawing.Size(43, 40);
            this.pbuUpdates.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbuUpdates.TabIndex = 46;
            this.pbuUpdates.TabStop = false;
            this.pbuUpdates.Click += new System.EventHandler(this.pbuUpdates_Click);
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Location = new System.Drawing.Point(3, 9);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(230, 26);
            this.label92.TabIndex = 45;
            this.label92.Text = "Define how TV Rename alerts users about new\r\nversions being available";
            // 
            // grpUpdateIntervalOption
            // 
            this.grpUpdateIntervalOption.Controls.Add(this.chkNoPopupOnUpdate);
            this.grpUpdateIntervalOption.Controls.Add(this.chkUpdateCheckEnabled);
            this.grpUpdateIntervalOption.Controls.Add(this.cboUpdateCheckInterval);
            this.grpUpdateIntervalOption.Controls.Add(this.optUpdateCheckInterval);
            this.grpUpdateIntervalOption.Controls.Add(this.optUpdateCheckAlways);
            this.grpUpdateIntervalOption.Location = new System.Drawing.Point(11, 60);
            this.grpUpdateIntervalOption.Name = "grpUpdateIntervalOption";
            this.grpUpdateIntervalOption.Size = new System.Drawing.Size(399, 135);
            this.grpUpdateIntervalOption.TabIndex = 1;
            this.grpUpdateIntervalOption.TabStop = false;
            // 
            // chkNoPopupOnUpdate
            // 
            this.chkNoPopupOnUpdate.AutoSize = true;
            this.chkNoPopupOnUpdate.Location = new System.Drawing.Point(16, 112);
            this.chkNoPopupOnUpdate.Name = "chkNoPopupOnUpdate";
            this.chkNoPopupOnUpdate.Size = new System.Drawing.Size(206, 17);
            this.chkNoPopupOnUpdate.TabIndex = 2;
            this.chkNoPopupOnUpdate.Text = "No dialog when an update is available";
            this.chkNoPopupOnUpdate.UseVisualStyleBackColor = true;
            // 
            // chkUpdateCheckEnabled
            // 
            this.chkUpdateCheckEnabled.AutoSize = true;
            this.chkUpdateCheckEnabled.BackColor = System.Drawing.Color.White;
            this.chkUpdateCheckEnabled.Location = new System.Drawing.Point(0, 1);
            this.chkUpdateCheckEnabled.Name = "chkUpdateCheckEnabled";
            this.chkUpdateCheckEnabled.Size = new System.Drawing.Size(115, 17);
            this.chkUpdateCheckEnabled.TabIndex = 0;
            this.chkUpdateCheckEnabled.Text = "Check for Updates";
            this.chkUpdateCheckEnabled.UseVisualStyleBackColor = false;
            this.chkUpdateCheckEnabled.CheckedChanged += new System.EventHandler(this.chkUpdateCheckEnabled_CheckedChanged);
            // 
            // cboUpdateCheckInterval
            // 
            this.cboUpdateCheckInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUpdateCheckInterval.FormattingEnabled = true;
            this.cboUpdateCheckInterval.Location = new System.Drawing.Point(16, 78);
            this.cboUpdateCheckInterval.Name = "cboUpdateCheckInterval";
            this.cboUpdateCheckInterval.Size = new System.Drawing.Size(166, 21);
            this.cboUpdateCheckInterval.TabIndex = 2;
            // 
            // optUpdateCheckInterval
            // 
            this.optUpdateCheckInterval.AutoSize = true;
            this.optUpdateCheckInterval.Location = new System.Drawing.Point(16, 54);
            this.optUpdateCheckInterval.Name = "optUpdateCheckInterval";
            this.optUpdateCheckInterval.Size = new System.Drawing.Size(111, 17);
            this.optUpdateCheckInterval.TabIndex = 1;
            this.optUpdateCheckInterval.TabStop = true;
            this.optUpdateCheckInterval.Text = "at certain intervals";
            this.optUpdateCheckInterval.UseVisualStyleBackColor = true;
            this.optUpdateCheckInterval.CheckedChanged += new System.EventHandler(this.updateCheckOption_CheckedChanged);
            // 
            // optUpdateCheckAlways
            // 
            this.optUpdateCheckAlways.AutoSize = true;
            this.optUpdateCheckAlways.Location = new System.Drawing.Point(16, 30);
            this.optUpdateCheckAlways.Name = "optUpdateCheckAlways";
            this.optUpdateCheckAlways.Size = new System.Drawing.Size(89, 17);
            this.optUpdateCheckAlways.TabIndex = 0;
            this.optUpdateCheckAlways.TabStop = true;
            this.optUpdateCheckAlways.Text = "on every start";
            this.optUpdateCheckAlways.UseVisualStyleBackColor = true;
            this.optUpdateCheckAlways.CheckedChanged += new System.EventHandler(this.updateCheckOption_CheckedChanged);
            // 
            // tpSubtitles
            // 
            this.tpSubtitles.Controls.Add(this.groupBox29);
            this.tpSubtitles.Controls.Add(this.label93);
            this.tpSubtitles.Controls.Add(this.pictureBox2);
            this.tpSubtitles.Controls.Add(this.groupBox9);
            this.tpSubtitles.Location = new System.Drawing.Point(139, 4);
            this.tpSubtitles.Name = "tpSubtitles";
            this.tpSubtitles.Padding = new System.Windows.Forms.Padding(3);
            this.tpSubtitles.Size = new System.Drawing.Size(417, 561);
            this.tpSubtitles.TabIndex = 21;
            this.tpSubtitles.Text = "Subtitles";
            this.tpSubtitles.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox9.Controls.Add(this.cbTxtToSub);
            this.groupBox9.Controls.Add(this.label46);
            this.groupBox9.Controls.Add(this.txtSubtitleExtensions);
            this.groupBox9.Controls.Add(this.chkRetainLanguageSpecificSubtitles);
            this.groupBox9.Location = new System.Drawing.Point(6, 48);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(408, 106);
            this.groupBox9.TabIndex = 41;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Subtitles";
            // 
            // cbTxtToSub
            // 
            this.cbTxtToSub.AutoSize = true;
            this.cbTxtToSub.Location = new System.Drawing.Point(6, 42);
            this.cbTxtToSub.Name = "cbTxtToSub";
            this.cbTxtToSub.Size = new System.Drawing.Size(118, 17);
            this.cbTxtToSub.TabIndex = 32;
            this.cbTxtToSub.Text = "&Rename .txt to .sub";
            this.cbTxtToSub.UseVisualStyleBackColor = true;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(3, 70);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(98, 13);
            this.label46.TabIndex = 30;
            this.label46.Text = "&Subtitle extensions:";
            // 
            // txtSubtitleExtensions
            // 
            this.txtSubtitleExtensions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubtitleExtensions.Location = new System.Drawing.Point(107, 67);
            this.txtSubtitleExtensions.Name = "txtSubtitleExtensions";
            this.txtSubtitleExtensions.Size = new System.Drawing.Size(295, 20);
            this.txtSubtitleExtensions.TabIndex = 31;
            // 
            // chkRetainLanguageSpecificSubtitles
            // 
            this.chkRetainLanguageSpecificSubtitles.AutoSize = true;
            this.chkRetainLanguageSpecificSubtitles.Location = new System.Drawing.Point(6, 19);
            this.chkRetainLanguageSpecificSubtitles.Name = "chkRetainLanguageSpecificSubtitles";
            this.chkRetainLanguageSpecificSubtitles.Size = new System.Drawing.Size(192, 17);
            this.chkRetainLanguageSpecificSubtitles.TabIndex = 29;
            this.chkRetainLanguageSpecificSubtitles.Text = "Retain &Language Specific Subtitles";
            this.chkRetainLanguageSpecificSubtitles.UseVisualStyleBackColor = true;
            // 
            // label93
            // 
            this.label93.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label93.AutoSize = true;
            this.label93.Location = new System.Drawing.Point(3, 3);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(294, 26);
            this.label93.TabIndex = 43;
            this.label93.Text = "These preferences control how TV Rename finds and retains\r\nsubtitles and subtitle" +
    " files.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pictureBox2.InitialImage = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pictureBox2.Location = new System.Drawing.Point(365, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox29
            // 
            this.groupBox29.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox29.Controls.Add(this.label94);
            this.groupBox29.Controls.Add(this.txtSubtitleFolderNames);
            this.groupBox29.Controls.Add(this.cbCopySubsFolders);
            this.groupBox29.Location = new System.Drawing.Point(6, 160);
            this.groupBox29.Name = "groupBox29";
            this.groupBox29.Size = new System.Drawing.Size(408, 78);
            this.groupBox29.TabIndex = 44;
            this.groupBox29.TabStop = false;
            this.groupBox29.Text = "Subtitle Folders";
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Location = new System.Drawing.Point(3, 45);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(113, 13);
            this.label94.TabIndex = 30;
            this.label94.Text = "&Subtitle Folder Names:";
            // 
            // txtSubtitleFolderNames
            // 
            this.txtSubtitleFolderNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubtitleFolderNames.Location = new System.Drawing.Point(122, 42);
            this.txtSubtitleFolderNames.Name = "txtSubtitleFolderNames";
            this.txtSubtitleFolderNames.Size = new System.Drawing.Size(280, 20);
            this.txtSubtitleFolderNames.TabIndex = 31;
            // 
            // cbCopySubsFolders
            // 
            this.cbCopySubsFolders.AutoSize = true;
            this.cbCopySubsFolders.Location = new System.Drawing.Point(6, 19);
            this.cbCopySubsFolders.Name = "cbCopySubsFolders";
            this.cbCopySubsFolders.Size = new System.Drawing.Size(120, 17);
            this.cbCopySubsFolders.TabIndex = 29;
            this.cbCopySubsFolders.Text = "Copy subtitle folders";
            this.cbCopySubsFolders.UseVisualStyleBackColor = true;
            // 
            // cbFileNameCaseSensitiveMatch
            // 
            this.cbFileNameCaseSensitiveMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbFileNameCaseSensitiveMatch.AutoSize = true;
            this.cbFileNameCaseSensitiveMatch.Location = new System.Drawing.Point(3, 417);
            this.cbFileNameCaseSensitiveMatch.Name = "cbFileNameCaseSensitiveMatch";
            this.cbFileNameCaseSensitiveMatch.Size = new System.Drawing.Size(194, 17);
            this.cbFileNameCaseSensitiveMatch.TabIndex = 42;
            this.cbFileNameCaseSensitiveMatch.Text = "Case Sensitive Match for Filenames";
            this.cbFileNameCaseSensitiveMatch.UseVisualStyleBackColor = true;
            // 
            // cbAutomateAutoAddWhenOneShowFound
            // 
            this.cbAutomateAutoAddWhenOneShowFound.AutoSize = true;
            this.cbAutomateAutoAddWhenOneShowFound.Location = new System.Drawing.Point(20, 39);
            this.cbAutomateAutoAddWhenOneShowFound.Name = "cbAutomateAutoAddWhenOneShowFound";
            this.cbAutomateAutoAddWhenOneShowFound.Size = new System.Drawing.Size(200, 17);
            this.cbAutomateAutoAddWhenOneShowFound.TabIndex = 17;
            this.cbAutomateAutoAddWhenOneShowFound.Text = "Auto Add when only one show found";
            this.cbAutomateAutoAddWhenOneShowFound.UseVisualStyleBackColor = true;
            // 
            // cbAutomateAutoAddWhenOneMovieFound
            // 
            this.cbAutomateAutoAddWhenOneMovieFound.AutoSize = true;
            this.cbAutomateAutoAddWhenOneMovieFound.Location = new System.Drawing.Point(20, 58);
            this.cbAutomateAutoAddWhenOneMovieFound.Name = "cbAutomateAutoAddWhenOneMovieFound";
            this.cbAutomateAutoAddWhenOneMovieFound.Size = new System.Drawing.Size(203, 17);
            this.cbAutomateAutoAddWhenOneMovieFound.TabIndex = 18;
            this.cbAutomateAutoAddWhenOneMovieFound.Text = "Auto Add when only one movie found";
            this.cbAutomateAutoAddWhenOneMovieFound.UseVisualStyleBackColor = true;
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Location = new System.Drawing.Point(6, 102);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(127, 13);
            this.label95.TabIndex = 6;
            this.label95.Text = "Default movie folder type:";
            // 
            // cmbDefMovieFolderFormat
            // 
            this.cmbDefMovieFolderFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDefMovieFolderFormat.FormattingEnabled = true;
            this.cmbDefMovieFolderFormat.Location = new System.Drawing.Point(139, 99);
            this.cmbDefMovieFolderFormat.Name = "cmbDefMovieFolderFormat";
            this.cmbDefMovieFolderFormat.Size = new System.Drawing.Size(256, 21);
            this.cmbDefMovieFolderFormat.TabIndex = 7;
            // 
            // Preferences
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bnCancel;
            this.ClientSize = new System.Drawing.Size(584, 644);
            this.ControlBox = false;
            this.Controls.Add(this.tcTabs);
            this.Controls.Add(this.bnCancel);
            this.Controls.Add(this.OKButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 660);
            this.Name = "Preferences";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preferences";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Preferences_FormClosing);
            this.Load += new System.EventHandler(this.Preferences_Load);
            this.cmDefaults.ResumeLayout(false);
            this.tpDisplay.ResumeLayout(false);
            this.tpDisplay.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplay)).EndInit();
            this.tpRSSJSONSearch.ResumeLayout(false);
            this.tpRSSJSONSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRSSJSONSearch)).EndInit();
            this.gbJSON.ResumeLayout(false);
            this.gbJSON.PerformLayout();
            this.gbRSS.ResumeLayout(false);
            this.gbRSS.PerformLayout();
            this.tpLibraryFolders.ResumeLayout(false);
            this.tpLibraryFolders.PerformLayout();
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLibraryFolders)).EndInit();
            this.tpTorrentNZB.ResumeLayout(false);
            this.tpTorrentNZB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbuTorrentNZB)).EndInit();
            this.qBitTorrent.ResumeLayout(false);
            this.qBitTorrent.PerformLayout();
            this.gbSAB.ResumeLayout(false);
            this.gbSAB.PerformLayout();
            this.gbuTorrent.ResumeLayout(false);
            this.gbuTorrent.PerformLayout();
            this.tbSearchFolders.ResumeLayout(false);
            this.tbSearchFolders.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.gbAutoAdd.ResumeLayout(false);
            this.gbAutoAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchFolders)).EndInit();
            this.tbMediaCenter.ResumeLayout(false);
            this.tbMediaCenter.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMediaCenter)).EndInit();
            this.tbFolderDeleting.ResumeLayout(false);
            this.tbFolderDeleting.PerformLayout();
            this.groupBox28.ResumeLayout(false);
            this.groupBox28.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFolderDeleting)).EndInit();
            this.tbAutoExport.ResumeLayout(false);
            this.tbAutoExport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbuExportEpisodes)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tbFilesAndFolders.ResumeLayout(false);
            this.tbFilesAndFolders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilesAndFolders)).EndInit();
            this.tbGeneral.ResumeLayout(false);
            this.tbGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGeneral)).EndInit();
            this.tcTabs.ResumeLayout(false);
            this.tpDataSources.ResumeLayout(false);
            this.tpDataSources.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbTMDB.ResumeLayout(false);
            this.gbTMDB.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSources)).EndInit();
            this.tpMovieDefaults.ResumeLayout(false);
            this.tpMovieDefaults.PerformLayout();
            this.groupBox24.ResumeLayout(false);
            this.groupBox24.PerformLayout();
            this.groupBox25.ResumeLayout(false);
            this.groupBox25.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMovieDefaults)).EndInit();
            this.tpShowDefaults.ResumeLayout(false);
            this.tpShowDefaults.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tpScanSettings.ResumeLayout(false);
            this.tpScanSettings.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbBulkAdd.ResumeLayout(false);
            this.gbBulkAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbScanOptions)).EndInit();
            this.tpJackett.ResumeLayout(false);
            this.tpJackett.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbuJackett)).EndInit();
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            this.tpAutoExportLibrary.ResumeLayout(false);
            this.tpAutoExportLibrary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbuShowExport)).EndInit();
            this.groupBox26.ResumeLayout(false);
            this.groupBox26.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox27.ResumeLayout(false);
            this.groupBox27.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tbAppUpdate.ResumeLayout(false);
            this.tbAppUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbuUpdates)).EndInit();
            this.grpUpdateIntervalOption.ResumeLayout(false);
            this.grpUpdateIntervalOption.PerformLayout();
            this.tpSubtitles.ResumeLayout(false);
            this.tpSubtitles.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox29.ResumeLayout(false);
            this.groupBox29.PerformLayout();
            this.ResumeLayout(false);

        }
        
        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button bnCancel;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ContextMenuStrip cmDefaults;
        private System.Windows.Forms.ToolStripMenuItem KODIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pyTivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mede8erToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
        private System.Windows.Forms.TabPage tpDisplay;
        private System.Windows.Forms.CheckBox chkHideWtWSpoilers;
        private System.Windows.Forms.CheckBox chkHideMyShowsSpoilers;
        private System.Windows.Forms.RadioButton rbWTWScan;
        private System.Windows.Forms.RadioButton rbWTWSearch;
        private System.Windows.Forms.ComboBox cbStartupTab;
        private System.Windows.Forms.CheckBox cbAutoSelInMyShows;
        private System.Windows.Forms.CheckBox cbShowEpisodePictures;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkShowInTaskbar;
        private System.Windows.Forms.CheckBox cbNotificationIcon;
        private System.Windows.Forms.TabPage tpRSSJSONSearch;
        private System.Windows.Forms.GroupBox gbJSON;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBox tbJSONFilenameToken;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.TextBox tbJSONURLToken;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox tbJSONRootNode;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox tbJSONURL;
        private System.Windows.Forms.GroupBox gbRSS;
        private SourceGrid.Grid RSSGrid;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button bnRSSRemove;
        private System.Windows.Forms.Button bnRSSGo;
        private System.Windows.Forms.Button bnRSSAdd;
        private System.Windows.Forms.TabPage tpLibraryFolders;
        private System.Windows.Forms.TabPage tpTorrentNZB;
        private System.Windows.Forms.GroupBox qBitTorrent;
        private System.Windows.Forms.TextBox tbqBitTorrentHost;
        private System.Windows.Forms.TextBox tbqBitTorrentPort;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.GroupBox gbSAB;
        private System.Windows.Forms.TextBox txtSABHostPort;
        private System.Windows.Forms.TextBox txtSABAPIKey;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbuTorrent;
        private System.Windows.Forms.Button bnUTBrowseResumeDat;
        private System.Windows.Forms.TextBox txtUTResumeDatPath;
        private System.Windows.Forms.Button bnRSSBrowseuTorrent;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtRSSuTorrentPath;
        private System.Windows.Forms.TabPage tbSearchFolders;
        private System.Windows.Forms.CheckBox cbMonitorFolder;
        private System.Windows.Forms.Button bnOpenSearchFolder;
        private System.Windows.Forms.Button bnRemoveSearchFolder;
        private System.Windows.Forms.Button bnAddSearchFolder;
        private System.Windows.Forms.ListBox lbSearchFolders;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TabPage tbMediaCenter;
        private System.Windows.Forms.CheckBox cbWDLiveEpisodeFiles;
        private System.Windows.Forms.CheckBox cbNFOEpisodes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbFolderBanner;
        private System.Windows.Forms.RadioButton rbFolderPoster;
        private System.Windows.Forms.RadioButton rbFolderFanArt;
        private System.Windows.Forms.RadioButton rbFolderSeasonPoster;
        private System.Windows.Forms.CheckBox cbKODIImages;
        private System.Windows.Forms.Button bnMCPresets;
        private System.Windows.Forms.CheckBox cbShrinkLarge;
        private System.Windows.Forms.CheckBox cbEpThumbJpg;
        private System.Windows.Forms.CheckBox cbMetaSubfolder;
        private System.Windows.Forms.CheckBox cbMeta;
        private System.Windows.Forms.CheckBox cbEpTBNs;
        private System.Windows.Forms.CheckBox cbSeriesJpg;
        private System.Windows.Forms.CheckBox cbXMLFiles;
        private System.Windows.Forms.CheckBox cbNFOShows;
        private System.Windows.Forms.CheckBox cbFantArtJpg;
        private System.Windows.Forms.CheckBox cbFolderJpg;
        private System.Windows.Forms.TabPage tbFolderDeleting;
        private System.Windows.Forms.CheckBox cbCleanUpDownloadDir;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtEmptyMaxSize;
        private System.Windows.Forms.TextBox txtEmptyIgnoreWords;
        private System.Windows.Forms.TextBox txtEmptyIgnoreExtensions;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.CheckBox cbRecycleNotDelete;
        private System.Windows.Forms.CheckBox cbEmptyMaxSize;
        private System.Windows.Forms.CheckBox cbEmptyIgnoreWords;
        private System.Windows.Forms.CheckBox cbEmptyIgnoreExtensions;
        private System.Windows.Forms.CheckBox cbDeleteEmpty;
        private System.Windows.Forms.TabPage tbAutoExport;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button bnBrowseFOXML;
        private System.Windows.Forms.CheckBox cbFOXML;
        private System.Windows.Forms.TextBox txtFOXML;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bnBrowseRenamingXML;
        private System.Windows.Forms.CheckBox cbRenamingXML;
        private System.Windows.Forms.TextBox txtRenamingXML;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bnBrowseWTWICAL;
        private System.Windows.Forms.TextBox txtWTWICAL;
        private System.Windows.Forms.CheckBox cbWTWICAL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExportRSSDaysPast;
        private System.Windows.Forms.Button bnBrowseWTWXML;
        private System.Windows.Forms.TextBox txtWTWXML;
        private System.Windows.Forms.CheckBox cbWTWXML;
        private System.Windows.Forms.Button bnBrowseWTWRSS;
        private System.Windows.Forms.TextBox txtWTWRSS;
        private System.Windows.Forms.CheckBox cbWTWRSS;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtExportRSSMaxDays;
        private System.Windows.Forms.TextBox txtExportRSSMaxShows;
        private System.Windows.Forms.TabPage tbFilesAndFolders;
        private System.Windows.Forms.TextBox txtKeepTogether;
        private System.Windows.Forms.TextBox txtMaxSampleSize;
        private System.Windows.Forms.TextBox txtOtherExtensions;
        private System.Windows.Forms.TextBox txtVideoExtensions;
        private System.Windows.Forms.Button bnTags;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.ComboBox cbKeepTogetherMode;
        private System.Windows.Forms.Button bnReplaceRemove;
        private System.Windows.Forms.Button bnReplaceAdd;
        private System.Windows.Forms.Label label3;
        private SourceGrid.Grid ReplacementsGrid;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox cbKeepTogether;
        private System.Windows.Forms.CheckBox cbForceLower;
        private System.Windows.Forms.CheckBox cbIgnoreSamples;
        private System.Windows.Forms.TabPage tbGeneral;
        private System.Windows.Forms.TextBox txtWTWDays;
        private System.Windows.Forms.ComboBox cbMode;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tcTabs;
        private System.Windows.Forms.TextBox txtSeasonFolderName;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.CheckBox cbLeadingZero;
        private System.Windows.Forms.CheckBox cbDeleteShowFromDisk;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button bnBrowseASX;
        private System.Windows.Forms.TextBox txtASX;
        private System.Windows.Forms.CheckBox cbASX;
        private System.Windows.Forms.Button bnBrowseM3U;
        private System.Windows.Forms.TextBox txtM3U;
        private System.Windows.Forms.CheckBox cbM3U;
        private System.Windows.Forms.Button bnBrowseXSPF;
        private System.Windows.Forms.TextBox txtXSPF;
        private System.Windows.Forms.CheckBox cbXSPF;
        private System.Windows.Forms.Button bnBrowseWPL;
        private System.Windows.Forms.TextBox txtWPL;
        private System.Windows.Forms.CheckBox cbWPL;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox tbJSONFilesizeToken;
        private System.Windows.Forms.CheckBox cbSearchRSSManualScanOnly;
        private System.Windows.Forms.CheckBox cbSearchJSON;
        private System.Windows.Forms.CheckBox cbSearchRSS;
        private System.Windows.Forms.CheckBox cbSearchJSONManualScanOnly;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.CheckBox cbCheckqBitTorrent;
        private System.Windows.Forms.CheckBox cbCheckSABnzbd;
        private System.Windows.Forms.CheckBox cbCheckuTorrent;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.CheckBox cbHigherQuality;
        private System.Windows.Forms.CheckBox chkAutoMergeDownloadEpisodes;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Button bnOpenMonFolder;
        private System.Windows.Forms.Button bnAddMonFolder;
        private System.Windows.Forms.Button bnRemoveMonFolder;
        private System.Windows.Forms.ListBox lstFMMonitorFolders;
        private System.Windows.Forms.GroupBox gbAutoAdd;
        private System.Windows.Forms.CheckBox chkAutoSearchForDownloadedFiles;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox tbIgnoreSuffixes;
        private System.Windows.Forms.TextBox tbMovieTerms;
        private System.Windows.Forms.CheckBox cbLeaveOriginals;
        private System.Windows.Forms.CheckBox cbSearchLocally;
        private System.Windows.Forms.PictureBox pbuTorrentNZB;
        private System.Windows.Forms.PictureBox pbGeneral;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.PictureBox pbDisplay;
        private System.Windows.Forms.PictureBox pbRSSJSONSearch;
        private System.Windows.Forms.PictureBox pbLibraryFolders;
        private System.Windows.Forms.PictureBox pbSearchFolders;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.PictureBox pbMediaCenter;
        private System.Windows.Forms.PictureBox pbFolderDeleting;
        private System.Windows.Forms.PictureBox pbFilesAndFolders;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox tbPercentBetter;
        private System.Windows.Forms.TextBox tbPriorityOverrideTerms;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboShowStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtShowStatusColor;
        private System.Windows.Forms.Button btnSelectColor;
        private System.Windows.Forms.Button bnRemoveDefinedColor;
        private System.Windows.Forms.Button btnAddShowStatusColoring;
        private System.Windows.Forms.ListView lvwDefinedColors;
        private System.Windows.Forms.ColumnHeader colShowStatus;
        private System.Windows.Forms.ColumnHeader colColor;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.CheckBox cbCopyFutureDatedEps;
        private System.Windows.Forms.CheckBox chkShareCriticalLogs;
        private System.Windows.Forms.CheckBox chkPostpendThe;
        private System.Windows.Forms.CheckBox chkBasicShowDetails;
        private System.Windows.Forms.CheckBox chkUseSearchFullPathWhenMatchingShows;
        private System.Windows.Forms.CheckBox chkUseLibraryFullPathWhenMatchingShows;
        private System.Windows.Forms.CheckBox chkAutoAddAsPartOfQuickRename;
        private System.Windows.Forms.CheckBox cbJSONCloudflareProtection;
        private System.Windows.Forms.CheckBox cbDownloadTorrentBeforeDownloading;
        private System.Windows.Forms.CheckBox cbRSSCloudflareProtection;
        private System.Windows.Forms.TabPage tpShowDefaults;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.RadioButton rbDefShowUseSubFolders;
        private System.Windows.Forms.RadioButton rbDefShowUseBase;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbDefShowLocation;
        private System.Windows.Forms.CheckBox cbDefShowUseDefLocation;
        private System.Windows.Forms.CheckBox cbDefShowAutoFolders;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.CheckBox cbDefShowSpecialsCount;
        private System.Windows.Forms.CheckBox cbDefShowSequentialMatching;
        private System.Windows.Forms.CheckBox cbDefShowIncludeNoAirdate;
        private System.Windows.Forms.CheckBox cbDefShowDoMissingCheck;
        private System.Windows.Forms.CheckBox cbDefShowIncludeFuture;
        private System.Windows.Forms.CheckBox cbDefShowDoRenaming;
        private System.Windows.Forms.CheckBox cbDefShowNextAirdate;
        private System.Windows.Forms.CheckBox cbDefShowDVDOrder;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cbTimeZone;
        private System.Windows.Forms.CheckBox cbUseColoursOnWtw;
        private System.Windows.Forms.RadioButton rdoqBitTorrentAPIVersionv1;
        private System.Windows.Forms.RadioButton rdoqBitTorrentAPIVersionv0;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.RadioButton rdoqBitTorrentAPIVersionv2;
        private System.Windows.Forms.TabPage tpDataSources;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbTVDBLanguages;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.RadioButton rdoTVTVMaze;
        private System.Windows.Forms.RadioButton rdoTVTVDB;
        private System.Windows.Forms.TextBox txtParallelDownloads;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox tbPercentDirty;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.DomainUpDown domainUpDown2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSeasonFormat;
        private System.Windows.Forms.TextBox txtSpecialsFolderName;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.PictureBox pbSources;
        private System.Windows.Forms.TabPage tpScanSettings;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.CheckBox chkIgnoreAllSpecials;
        private System.Windows.Forms.CheckBox chkMoveLibraryFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.CheckBox chkScheduledScan;
        private System.Windows.Forms.CheckBox chkScanOnStartup;
        private System.Windows.Forms.Label lblScanAction;
        private System.Windows.Forms.RadioButton rdoQuickScan;
        private System.Windows.Forms.RadioButton rdoRecentScan;
        private System.Windows.Forms.RadioButton rdoFullScan;
        private System.Windows.Forms.CheckBox cbIgnorePreviouslySeen;
        private System.Windows.Forms.CheckBox chkPreventMove;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.CheckBox cbRenameCheck;
        private System.Windows.Forms.CheckBox cbMissing;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkCleanLibraryAfterActions;
        private System.Windows.Forms.CheckBox cbxUpdateAirDate;
        private System.Windows.Forms.CheckBox cbAutoCreateFolders;
        private System.Windows.Forms.CheckBox chkAutoMergeLibraryEpisodes;
        private System.Windows.Forms.CheckBox cbScanIncludesBulkAdd;
        private System.Windows.Forms.GroupBox gbBulkAdd;
        private System.Windows.Forms.TextBox tbSeasonSearchTerms;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.CheckBox chkForceBulkAddToUseSettingsOnly;
        private System.Windows.Forms.CheckBox cbIgnoreRecycleBin;
        private System.Windows.Forms.CheckBox cbIgnoreNoVideoFolders;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.PictureBox pbScanOptions;
        private System.Windows.Forms.CheckBox cbDefShowEpNameMatching;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.CheckBox cbDefShowAirdateMatching;
        private System.Windows.Forms.CheckBox chkShowAccessibilityOptions;
        private System.Windows.Forms.TabPage tpJackett;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.ComboBox cmbUnattendedDuplicateAction;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.CheckBox cbDetailedRSSJSONLogging;
        private System.Windows.Forms.PictureBox pbuJackett;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.CheckBox cbSearchJackett;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.CheckBox cbSearchJackettOnManualScansOnly;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.TextBox txtJackettIndexer;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.TextBox txtJackettAPIKey;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.TextBox txtJackettPort;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.TextBox txtJackettServer;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox tbPreferredRSSTerms;
        private System.Windows.Forms.ComboBox cmbSupervisedDuplicateAction;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.LinkLabel llJackettLink;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.TextBox tbJSONSeedersToken;
        private System.Windows.Forms.CheckBox chkRemoveCompletedTorrents;
        private System.Windows.Forms.LinkLabel llqBitTorrentLink;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.CheckBox chkSearchJackettButton;
        private System.Windows.Forms.CheckBox chkSkipJackettFullScans;
        private System.Windows.Forms.CheckBox cbAutoSaveOnExit;
        private System.Windows.Forms.CheckBox chkUseJackettTextSearch;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.RadioButton rdoMovieTMDB;
        private System.Windows.Forms.RadioButton rdoMovieTheTVDB;
        private System.Windows.Forms.GroupBox gbTMDB;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.TextBox tbTMDBPercentDirty;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.ComboBox cbTMDBLanguages;
        private System.Windows.Forms.TabPage tpMovieDefaults;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.ComboBox cbTMDBRegions;
        private System.Windows.Forms.GroupBox groupBox23;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtMovieFolderFormat;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Button bnOpenMovieMonFolder;
        private System.Windows.Forms.Button bnAddMovieMonFolder;
        private System.Windows.Forms.Button bnRemoveMovieMonFolder;
        private System.Windows.Forms.ListBox lstMovieMonitorFolders;
        private System.Windows.Forms.CheckBox cbNFOMovies;
        private System.Windows.Forms.PictureBox pbuExportEpisodes;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.GroupBox groupBox24;
        private System.Windows.Forms.ComboBox cmbDefMovieLocation;
        private System.Windows.Forms.CheckBox cbDefMovieUseDefLocation;
        private System.Windows.Forms.CheckBox cbDefMovieAutoFolders;
        private System.Windows.Forms.GroupBox groupBox25;
        private System.Windows.Forms.CheckBox cbDefMovieDoMissing;
        private System.Windows.Forms.CheckBox cbDefMovieDoRenaming;
        private System.Windows.Forms.PictureBox pbMovieDefaults;
        private System.Windows.Forms.CheckBox chkIncludeMoviesQuickRecent;
        private System.Windows.Forms.TabPage tpAutoExportLibrary;
        private System.Windows.Forms.PictureBox pbuShowExport;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.GroupBox groupBox26;
        private System.Windows.Forms.Button bnBrowseMoviesHTML;
        private System.Windows.Forms.CheckBox cbMoviesHTML;
        private System.Windows.Forms.TextBox txtMoviesHTMLTo;
        private System.Windows.Forms.Button bnBrowseMoviesTXT;
        private System.Windows.Forms.CheckBox cbMoviesTXT;
        private System.Windows.Forms.TextBox txtMoviesTXTTo;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button bnBrowseShowsHTML;
        private System.Windows.Forms.CheckBox cbShowsHTML;
        private System.Windows.Forms.TextBox txtShowsHTMLTo;
        private System.Windows.Forms.Button bnBrowseShowsTXT;
        private System.Windows.Forms.CheckBox cbShowsTXT;
        private System.Windows.Forms.TextBox txtShowsTXTTo;
        private System.Windows.Forms.GroupBox groupBox27;
        private System.Windows.Forms.Button bnBrowseMissingMoviesCSV;
        private System.Windows.Forms.Button bnBrowseMissingMoviesXML;
        private System.Windows.Forms.TextBox txtMissingMoviesCSV;
        private System.Windows.Forms.CheckBox cbMissingMoviesXML;
        private System.Windows.Forms.CheckBox cbMissingMoviesCSV;
        private System.Windows.Forms.TextBox txtMissingMoviesXML;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bnBrowseMissingCSV;
        private System.Windows.Forms.Button bnBrowseMissingXML;
        private System.Windows.Forms.TextBox txtMissingCSV;
        private System.Windows.Forms.CheckBox cbMissingXML;
        private System.Windows.Forms.CheckBox cbMissingCSV;
        private System.Windows.Forms.TextBox txtMissingXML;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtMovieFilenameFormat;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox28;
        private System.Windows.Forms.TextBox tbCleanUpDownloadDirMoviesLength;
        private System.Windows.Forms.CheckBox cbCleanUpDownloadDirMoviesLength;
        private System.Windows.Forms.CheckBox cbCleanUpDownloadDirMovies;
        private System.Windows.Forms.TabPage tbAppUpdate;
        private System.Windows.Forms.GroupBox grpUpdateIntervalOption;
        private System.Windows.Forms.CheckBox chkNoPopupOnUpdate;
        private System.Windows.Forms.ComboBox cboUpdateCheckInterval;
        private System.Windows.Forms.RadioButton optUpdateCheckInterval;
        private System.Windows.Forms.RadioButton optUpdateCheckAlways;
        private System.Windows.Forms.CheckBox chkUpdateCheckEnabled;
        private System.Windows.Forms.Button bnBrowseWTWTXT;
        private System.Windows.Forms.TextBox txtWTWTXT;
        private System.Windows.Forms.CheckBox cbWTWTXT;
        private System.Windows.Forms.RadioButton rdoTVTMDB;
        private System.Windows.Forms.CheckBox cbMovieHigherQuality;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.ComboBox cbTVDBVersion;
        private System.Windows.Forms.PictureBox pbuUpdates;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.CheckBox cbDefShowAlternateOrder;
        private System.Windows.Forms.CheckBox cbDeleteMovieFromDisk;
        private System.Windows.Forms.CheckBox cbIgnorePreviouslySeenMovies;
        private System.Windows.Forms.CheckBox cbDefMovieIncludeNoAirdate;
        private System.Windows.Forms.CheckBox cbDefMovieIncludeFuture;
        private System.Windows.Forms.CheckBox cbFileNameCaseSensitiveMatch;
        private System.Windows.Forms.TabPage tpSubtitles;
        private System.Windows.Forms.GroupBox groupBox29;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.TextBox txtSubtitleFolderNames;
        private System.Windows.Forms.CheckBox cbCopySubsFolders;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.CheckBox cbTxtToSub;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox txtSubtitleExtensions;
        private System.Windows.Forms.CheckBox chkRetainLanguageSpecificSubtitles;
        private System.Windows.Forms.CheckBox cbAutomateAutoAddWhenOneMovieFound;
        private System.Windows.Forms.CheckBox cbAutomateAutoAddWhenOneShowFound;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.ComboBox cmbDefMovieFolderFormat;
    }
}
