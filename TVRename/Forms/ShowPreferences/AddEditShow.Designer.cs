//
// Main website for TVRename is http://tvrename.com
//
// Source code available at https://github.com/TV-Rename/tvrename
//
// Copyright (c) TV Rename. This code is released under GPLv3 https://github.com/TV-Rename/tvrename/blob/master/LICENSE.md
//

using DaveChambers.FolderBrowserDialogEx;

namespace TVRename
{
    partial class AddEditShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditShow));
            this.txtCustomShowName = new System.Windows.Forms.TextBox();
            this.cbTimeZone = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bnCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.chkSpecialsCount = new System.Windows.Forms.CheckBox();
            this.chkShowNextAirdate = new System.Windows.Forms.CheckBox();
            this.pnlCF = new System.Windows.Forms.Panel();
            this.cbDoRenaming = new System.Windows.Forms.CheckBox();
            this.cbDoMissingCheck = new System.Windows.Forms.CheckBox();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIgnoreSeasons = new System.Windows.Forms.TextBox();
            this.chkDVDOrder = new System.Windows.Forms.CheckBox();
            this.cbSequentialMatching = new System.Windows.Forms.CheckBox();
            this.chkCustomShowName = new System.Windows.Forms.CheckBox();
            this.Folders = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkCustomRegion = new System.Windows.Forms.CheckBox();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.rdoTMDB = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.rdoTVMaze = new System.Windows.Forms.RadioButton();
            this.rdoTVDB = new System.Windows.Forms.RadioButton();
            this.rdoDefault = new System.Windows.Forms.RadioButton();
            this.label60 = new System.Windows.Forms.Label();
            this.pbBasics = new System.Windows.Forms.PictureBox();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.chkCustomLanguage = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtIgnoreList = new System.Windows.Forms.Label();
            this.btnIgnoreList = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkReplaceAutoFolders = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bnRemove = new System.Windows.Forms.Button();
            this.bnAdd = new System.Windows.Forms.Button();
            this.bnBrowseFolder = new System.Windows.Forms.Button();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.txtSeasonNumber = new System.Windows.Forms.TextBox();
            this.lvSeasonFolders = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chkAutoFolders = new System.Windows.Forms.CheckBox();
            this.gbAutoFolders = new System.Windows.Forms.GroupBox();
            this.bnQuickLocate = new System.Windows.Forms.Button();
            this.txtSeasonFormat = new System.Windows.Forms.TextBox();
            this.bnTags = new System.Windows.Forms.Button();
            this.lblSeasonWordPreview = new System.Windows.Forms.Label();
            this.rdoFolderBaseOnly = new System.Windows.Forms.RadioButton();
            this.rdoFolderCustom = new System.Windows.Forms.RadioButton();
            this.rdoFolderLibraryDefault = new System.Windows.Forms.RadioButton();
            this.txtBaseFolder = new System.Windows.Forms.TextBox();
            this.bnBrowse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pbFolders = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.lbSourceAliases = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bnRemoveAlias = new System.Windows.Forms.Button();
            this.bnAddAlias = new System.Windows.Forms.Button();
            this.tbShowAlias = new System.Windows.Forms.TextBox();
            this.pbAliases = new System.Windows.Forms.PictureBox();
            this.lbShowAlias = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.llCustomSearchPreview = new System.Windows.Forms.LinkLabel();
            this.lbSearchExample = new System.Windows.Forms.Label();
            this.txtSearchURL = new System.Windows.Forms.TextBox();
            this.txtTagList = new System.Windows.Forms.Label();
            this.lbTags = new System.Windows.Forms.Label();
            this.lbSearchURL = new System.Windows.Forms.Label();
            this.cbUseCustomSearch = new System.Windows.Forms.CheckBox();
            this.pbCustomSearch = new System.Windows.Forms.PictureBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.llLibraryDefaultFormat = new System.Windows.Forms.LinkLabel();
            this.llCustomName = new System.Windows.Forms.LinkLabel();
            this.lbLibraryDefaultNaming = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbNamingExample = new System.Windows.Forms.Label();
            this.txtCustomEpisodeNamingFormat = new System.Windows.Forms.TextBox();
            this.txtTagList2 = new System.Windows.Forms.Label();
            this.lbAvailableTags = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cbUseCustomNamingFormat = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbEpNameMatching = new System.Windows.Forms.CheckBox();
            this.label68 = new System.Windows.Forms.Label();
            this.cbAirdateMatching = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbIncludeNoAirdate = new System.Windows.Forms.CheckBox();
            this.cbIncludeFuture = new System.Windows.Forms.CheckBox();
            this.pbAdvanced = new System.Windows.Forms.PictureBox();
            this.chkAlternateOrder = new System.Windows.Forms.CheckBox();
            this.Folders.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBasics)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbAutoFolders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFolders)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAliases)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomSearch)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdvanced)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCustomShowName
            // 
            this.txtCustomShowName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCustomShowName.Location = new System.Drawing.Point(134, 333);
            this.txtCustomShowName.Name = "txtCustomShowName";
            this.txtCustomShowName.Size = new System.Drawing.Size(303, 20);
            this.txtCustomShowName.TabIndex = 2;
            // 
            // cbTimeZone
            // 
            this.cbTimeZone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbTimeZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimeZone.FormattingEnabled = true;
            this.cbTimeZone.Location = new System.Drawing.Point(102, 361);
            this.cbTimeZone.Name = "cbTimeZone";
            this.cbTimeZone.Size = new System.Drawing.Size(200, 21);
            this.cbTimeZone.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Airs in &Timezone:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bnCancel
            // 
            this.bnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bnCancel.Location = new System.Drawing.Point(367, 502);
            this.bnCancel.Name = "bnCancel";
            this.bnCancel.Size = new System.Drawing.Size(75, 23);
            this.bnCancel.TabIndex = 2;
            this.bnCancel.Text = "Cancel";
            this.bnCancel.UseVisualStyleBackColor = true;
            this.bnCancel.Click += new System.EventHandler(this.bnCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(286, 502);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // chkSpecialsCount
            // 
            this.chkSpecialsCount.AutoSize = true;
            this.chkSpecialsCount.Location = new System.Drawing.Point(8, 101);
            this.chkSpecialsCount.Name = "chkSpecialsCount";
            this.chkSpecialsCount.Size = new System.Drawing.Size(155, 17);
            this.chkSpecialsCount.TabIndex = 2;
            this.chkSpecialsCount.Text = "S&pecials count as episodes";
            this.chkSpecialsCount.UseVisualStyleBackColor = true;
            // 
            // chkShowNextAirdate
            // 
            this.chkShowNextAirdate.AutoSize = true;
            this.chkShowNextAirdate.Location = new System.Drawing.Point(8, 78);
            this.chkShowNextAirdate.Name = "chkShowNextAirdate";
            this.chkShowNextAirdate.Size = new System.Drawing.Size(174, 17);
            this.chkShowNextAirdate.TabIndex = 1;
            this.chkShowNextAirdate.Text = "Show &next airdate in \'Schedule\'";
            this.chkShowNextAirdate.UseVisualStyleBackColor = true;
            // 
            // pnlCF
            // 
            this.pnlCF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCF.Location = new System.Drawing.Point(3, 52);
            this.pnlCF.Name = "pnlCF";
            this.pnlCF.Size = new System.Drawing.Size(444, 244);
            this.pnlCF.TabIndex = 0;
            // 
            // cbDoRenaming
            // 
            this.cbDoRenaming.AutoSize = true;
            this.cbDoRenaming.Location = new System.Drawing.Point(8, 124);
            this.cbDoRenaming.Name = "cbDoRenaming";
            this.cbDoRenaming.Size = new System.Drawing.Size(86, 17);
            this.cbDoRenaming.TabIndex = 3;
            this.cbDoRenaming.Text = "Do &renaming";
            this.cbDoRenaming.UseVisualStyleBackColor = true;
            // 
            // cbDoMissingCheck
            // 
            this.cbDoMissingCheck.AutoSize = true;
            this.cbDoMissingCheck.Location = new System.Drawing.Point(8, 147);
            this.cbDoMissingCheck.Name = "cbDoMissingCheck";
            this.cbDoMissingCheck.Size = new System.Drawing.Size(110, 17);
            this.cbDoMissingCheck.TabIndex = 4;
            this.cbDoMissingCheck.Text = "Do &missing check";
            this.cbDoMissingCheck.UseVisualStyleBackColor = true;
            this.cbDoMissingCheck.CheckedChanged += new System.EventHandler(this.cbDoMissingCheck_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ign&ore Seasons:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtIgnoreSeasons
            // 
            this.txtIgnoreSeasons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIgnoreSeasons.Location = new System.Drawing.Point(102, 388);
            this.txtIgnoreSeasons.Name = "txtIgnoreSeasons";
            this.txtIgnoreSeasons.Size = new System.Drawing.Size(156, 20);
            this.txtIgnoreSeasons.TabIndex = 6;
            // 
            // chkDVDOrder
            // 
            this.chkDVDOrder.AutoSize = true;
            this.chkDVDOrder.Location = new System.Drawing.Point(8, 55);
            this.chkDVDOrder.Name = "chkDVDOrder";
            this.chkDVDOrder.Size = new System.Drawing.Size(100, 17);
            this.chkDVDOrder.TabIndex = 0;
            this.chkDVDOrder.Text = "&Use DVD Order";
            this.chkDVDOrder.UseVisualStyleBackColor = true;
            this.chkDVDOrder.CheckedChanged += new System.EventHandler(this.chkDVDOrder_CheckedChanged);
            // 
            // cbSequentialMatching
            // 
            this.cbSequentialMatching.AutoSize = true;
            this.cbSequentialMatching.Location = new System.Drawing.Point(26, 233);
            this.cbSequentialMatching.Name = "cbSequentialMatching";
            this.cbSequentialMatching.Size = new System.Drawing.Size(180, 17);
            this.cbSequentialMatching.TabIndex = 6;
            this.cbSequentialMatching.Text = "Use sequential number matching";
            this.cbSequentialMatching.UseVisualStyleBackColor = true;
            // 
            // chkCustomShowName
            // 
            this.chkCustomShowName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkCustomShowName.AutoSize = true;
            this.chkCustomShowName.Location = new System.Drawing.Point(10, 335);
            this.chkCustomShowName.Name = "chkCustomShowName";
            this.chkCustomShowName.Size = new System.Drawing.Size(121, 17);
            this.chkCustomShowName.TabIndex = 1;
            this.chkCustomShowName.Text = "Custom s&how name:";
            this.chkCustomShowName.UseVisualStyleBackColor = true;
            this.chkCustomShowName.CheckedChanged += new System.EventHandler(this.chkCustomShowName_CheckedChanged);
            // 
            // Folders
            // 
            this.Folders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Folders.Controls.Add(this.tabPage1);
            this.Folders.Controls.Add(this.tabPage5);
            this.Folders.Controls.Add(this.tabPage3);
            this.Folders.Controls.Add(this.tabPage4);
            this.Folders.Controls.Add(this.tabPage6);
            this.Folders.Controls.Add(this.tabPage2);
            this.Folders.Location = new System.Drawing.Point(-4, 2);
            this.Folders.Name = "Folders";
            this.Folders.SelectedIndex = 0;
            this.Folders.Size = new System.Drawing.Size(464, 494);
            this.Folders.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkCustomRegion);
            this.tabPage1.Controls.Add(this.cbRegion);
            this.tabPage1.Controls.Add(this.rdoTMDB);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.rdoTVMaze);
            this.tabPage1.Controls.Add(this.rdoTVDB);
            this.tabPage1.Controls.Add(this.rdoDefault);
            this.tabPage1.Controls.Add(this.label60);
            this.tabPage1.Controls.Add(this.pbBasics);
            this.tabPage1.Controls.Add(this.cbLanguage);
            this.tabPage1.Controls.Add(this.chkCustomLanguage);
            this.tabPage1.Controls.Add(this.pnlCF);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.chkCustomShowName);
            this.tabPage1.Controls.Add(this.txtCustomShowName);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.cbTimeZone);
            this.tabPage1.Controls.Add(this.txtIgnoreSeasons);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(456, 468);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basics";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkCustomRegion
            // 
            this.chkCustomRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkCustomRegion.AutoSize = true;
            this.chkCustomRegion.Location = new System.Drawing.Point(9, 439);
            this.chkCustomRegion.Name = "chkCustomRegion";
            this.chkCustomRegion.Size = new System.Drawing.Size(101, 17);
            this.chkCustomRegion.TabIndex = 48;
            this.chkCustomRegion.Text = "Custom Region:";
            this.chkCustomRegion.UseVisualStyleBackColor = true;
            this.chkCustomRegion.CheckedChanged += new System.EventHandler(this.chkCustomRegion_CheckedChanged);
            // 
            // cbRegion
            // 
            this.cbRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Location = new System.Drawing.Point(134, 439);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(146, 21);
            this.cbRegion.Sorted = true;
            this.cbRegion.TabIndex = 47;
            this.cbRegion.SelectedIndexChanged += new System.EventHandler(this.cbRegion_SelectedIndexChanged);
            // 
            // rdoTMDB
            // 
            this.rdoTMDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rdoTMDB.AutoSize = true;
            this.rdoTMDB.Location = new System.Drawing.Point(304, 302);
            this.rdoTMDB.Name = "rdoTMDB";
            this.rdoTMDB.Size = new System.Drawing.Size(56, 17);
            this.rdoTMDB.TabIndex = 45;
            this.rdoTMDB.TabStop = true;
            this.rdoTMDB.Text = "TMDB";
            this.rdoTMDB.UseVisualStyleBackColor = true;
            this.rdoTMDB.CheckedChanged += new System.EventHandler(this.rdoProvider_CheckedChanged);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 306);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 44;
            this.label13.Text = "Source:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rdoTVMaze
            // 
            this.rdoTVMaze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rdoTVMaze.AutoSize = true;
            this.rdoTVMaze.Location = new System.Drawing.Point(234, 304);
            this.rdoTVMaze.Name = "rdoTVMaze";
            this.rdoTVMaze.Size = new System.Drawing.Size(64, 17);
            this.rdoTVMaze.TabIndex = 43;
            this.rdoTVMaze.TabStop = true;
            this.rdoTVMaze.Text = "TVmaze";
            this.rdoTVMaze.UseVisualStyleBackColor = true;
            this.rdoTVMaze.CheckedChanged += new System.EventHandler(this.rdoProvider_CheckedChanged);
            // 
            // rdoTVDB
            // 
            this.rdoTVDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rdoTVDB.AutoSize = true;
            this.rdoTVDB.Location = new System.Drawing.Point(147, 304);
            this.rdoTVDB.Name = "rdoTVDB";
            this.rdoTVDB.Size = new System.Drawing.Size(76, 17);
            this.rdoTVDB.TabIndex = 42;
            this.rdoTVDB.TabStop = true;
            this.rdoTVDB.Text = "The TVDB";
            this.rdoTVDB.UseVisualStyleBackColor = true;
            this.rdoTVDB.CheckedChanged += new System.EventHandler(this.rdoProvider_CheckedChanged);
            // 
            // rdoDefault
            // 
            this.rdoDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rdoDefault.AutoSize = true;
            this.rdoDefault.Location = new System.Drawing.Point(52, 304);
            this.rdoDefault.Name = "rdoDefault";
            this.rdoDefault.Size = new System.Drawing.Size(93, 17);
            this.rdoDefault.TabIndex = 41;
            this.rdoDefault.TabStop = true;
            this.rdoDefault.Text = "Library Default";
            this.rdoDefault.UseVisualStyleBackColor = true;
            this.rdoDefault.CheckedChanged += new System.EventHandler(this.rdoProvider_CheckedChanged);
            // 
            // label60
            // 
            this.label60.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(6, 6);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(370, 13);
            this.label60.TabIndex = 40;
            this.label60.Text = "Use these settings to control the link to the show and what the show is called";
            // 
            // pbBasics
            // 
            this.pbBasics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbBasics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBasics.Image = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pbBasics.InitialImage = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pbBasics.Location = new System.Drawing.Point(401, 6);
            this.pbBasics.Name = "pbBasics";
            this.pbBasics.Size = new System.Drawing.Size(43, 40);
            this.pbBasics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbBasics.TabIndex = 39;
            this.pbBasics.TabStop = false;
            this.pbBasics.Click += new System.EventHandler(this.pbBasics_Click);
            // 
            // cbLanguage
            // 
            this.cbLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Location = new System.Drawing.Point(134, 412);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(200, 21);
            this.cbLanguage.TabIndex = 9;
            this.cbLanguage.SelectedIndexChanged += new System.EventHandler(this.cbLanguage_SelectedIndexChanged);
            // 
            // chkCustomLanguage
            // 
            this.chkCustomLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkCustomLanguage.AutoSize = true;
            this.chkCustomLanguage.Location = new System.Drawing.Point(10, 416);
            this.chkCustomLanguage.Name = "chkCustomLanguage";
            this.chkCustomLanguage.Size = new System.Drawing.Size(115, 17);
            this.chkCustomLanguage.TabIndex = 8;
            this.chkCustomLanguage.Text = "Custom Language:";
            this.chkCustomLanguage.UseVisualStyleBackColor = true;
            this.chkCustomLanguage.CheckedChanged += new System.EventHandler(this.chkCustomLanguage_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "e.g. \"1 2 4\". 0 to ignore specials.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.txtIgnoreList);
            this.tabPage5.Controls.Add(this.btnIgnoreList);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.groupBox1);
            this.tabPage5.Controls.Add(this.chkAutoFolders);
            this.tabPage5.Controls.Add(this.gbAutoFolders);
            this.tabPage5.Controls.Add(this.pbFolders);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(456, 468);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Folders";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // txtIgnoreList
            // 
            this.txtIgnoreList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIgnoreList.AutoSize = true;
            this.txtIgnoreList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIgnoreList.Location = new System.Drawing.Point(11, 447);
            this.txtIgnoreList.Name = "txtIgnoreList";
            this.txtIgnoreList.Size = new System.Drawing.Size(259, 13);
            this.txtIgnoreList.TabIndex = 50;
            this.txtIgnoreList.Text = "Note: Some files in these folders are ignored";
            this.txtIgnoreList.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnIgnoreList
            // 
            this.btnIgnoreList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIgnoreList.BackColor = System.Drawing.Color.Transparent;
            this.btnIgnoreList.Location = new System.Drawing.Point(286, 442);
            this.btnIgnoreList.Name = "btnIgnoreList";
            this.btnIgnoreList.Size = new System.Drawing.Size(153, 23);
            this.btnIgnoreList.TabIndex = 49;
            this.btnIgnoreList.Text = "See Ignore List";
            this.btnIgnoreList.UseVisualStyleBackColor = false;
            this.btnIgnoreList.Click += new System.EventHandler(this.BtnIgnoreList_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(366, 26);
            this.label12.TabIndex = 48;
            this.label12.Text = "Setup which folders the episodes for this cachedSeries should be stored in.  \r\nYo" +
    "u can choose automatic folders or maintain full manual control.";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkReplaceAutoFolders);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bnRemove);
            this.groupBox1.Controls.Add(this.bnAdd);
            this.groupBox1.Controls.Add(this.bnBrowseFolder);
            this.groupBox1.Controls.Add(this.txtFolder);
            this.groupBox1.Controls.Add(this.txtSeasonNumber);
            this.groupBox1.Controls.Add(this.lvSeasonFolders);
            this.groupBox1.Location = new System.Drawing.Point(3, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 253);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manual/Additional Folders";
            // 
            // chkReplaceAutoFolders
            // 
            this.chkReplaceAutoFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkReplaceAutoFolders.AutoSize = true;
            this.chkReplaceAutoFolders.Location = new System.Drawing.Point(276, 18);
            this.chkReplaceAutoFolders.Name = "chkReplaceAutoFolders";
            this.chkReplaceAutoFolders.Size = new System.Drawing.Size(153, 17);
            this.chkReplaceAutoFolders.TabIndex = 11;
            this.chkReplaceAutoFolders.Text = "Replace Automatic Folders";
            this.chkReplaceAutoFolders.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Folder:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Season:";
            // 
            // bnRemove
            // 
            this.bnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnRemove.Location = new System.Drawing.Point(354, 218);
            this.bnRemove.Name = "bnRemove";
            this.bnRemove.Size = new System.Drawing.Size(75, 23);
            this.bnRemove.TabIndex = 7;
            this.bnRemove.Text = "Remo&ve";
            this.bnRemove.UseVisualStyleBackColor = true;
            this.bnRemove.Click += new System.EventHandler(this.bnRemove_Click);
            // 
            // bnAdd
            // 
            this.bnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnAdd.Location = new System.Drawing.Point(354, 48);
            this.bnAdd.Name = "bnAdd";
            this.bnAdd.Size = new System.Drawing.Size(75, 23);
            this.bnAdd.TabIndex = 5;
            this.bnAdd.Text = "&Add";
            this.bnAdd.UseVisualStyleBackColor = true;
            this.bnAdd.Click += new System.EventHandler(this.bnAdd_Click);
            // 
            // bnBrowseFolder
            // 
            this.bnBrowseFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnBrowseFolder.Location = new System.Drawing.Point(273, 48);
            this.bnBrowseFolder.Name = "bnBrowseFolder";
            this.bnBrowseFolder.Size = new System.Drawing.Size(75, 23);
            this.bnBrowseFolder.TabIndex = 4;
            this.bnBrowseFolder.Text = "B&rowse...";
            this.bnBrowseFolder.UseVisualStyleBackColor = true;
            this.bnBrowseFolder.Click += new System.EventHandler(this.bnBrowseFolder_Click);
            // 
            // txtFolder
            // 
            this.txtFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolder.Location = new System.Drawing.Point(61, 50);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(206, 20);
            this.txtFolder.TabIndex = 3;
            this.txtFolder.TextChanged += new System.EventHandler(this.txtFolder_TextChanged);
            // 
            // txtSeasonNumber
            // 
            this.txtSeasonNumber.Location = new System.Drawing.Point(61, 19);
            this.txtSeasonNumber.Name = "txtSeasonNumber";
            this.txtSeasonNumber.Size = new System.Drawing.Size(52, 20);
            this.txtSeasonNumber.TabIndex = 1;
            this.txtSeasonNumber.TextChanged += new System.EventHandler(this.txtSeasonNumber_TextChanged);
            // 
            // lvSeasonFolders
            // 
            this.lvSeasonFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvSeasonFolders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvSeasonFolders.FullRowSelect = true;
            this.lvSeasonFolders.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvSeasonFolders.HideSelection = false;
            this.lvSeasonFolders.Location = new System.Drawing.Point(11, 77);
            this.lvSeasonFolders.Name = "lvSeasonFolders";
            this.lvSeasonFolders.Size = new System.Drawing.Size(337, 164);
            this.lvSeasonFolders.TabIndex = 6;
            this.lvSeasonFolders.UseCompatibleStateImageBehavior = false;
            this.lvSeasonFolders.View = System.Windows.Forms.View.Details;
            this.lvSeasonFolders.SelectedIndexChanged += new System.EventHandler(this.lvSeasonFolders_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Season";
            this.columnHeader1.Width = 52;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Folder";
            this.columnHeader2.Width = 250;
            // 
            // chkAutoFolders
            // 
            this.chkAutoFolders.AutoSize = true;
            this.chkAutoFolders.Checked = true;
            this.chkAutoFolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoFolders.Location = new System.Drawing.Point(14, 50);
            this.chkAutoFolders.Name = "chkAutoFolders";
            this.chkAutoFolders.Size = new System.Drawing.Size(110, 17);
            this.chkAutoFolders.TabIndex = 10;
            this.chkAutoFolders.Text = "&Automatic Folders";
            this.chkAutoFolders.UseVisualStyleBackColor = true;
            this.chkAutoFolders.CheckedChanged += new System.EventHandler(this.chkAutoFolders_CheckedChanged);
            // 
            // gbAutoFolders
            // 
            this.gbAutoFolders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAutoFolders.Controls.Add(this.bnQuickLocate);
            this.gbAutoFolders.Controls.Add(this.txtSeasonFormat);
            this.gbAutoFolders.Controls.Add(this.bnTags);
            this.gbAutoFolders.Controls.Add(this.lblSeasonWordPreview);
            this.gbAutoFolders.Controls.Add(this.rdoFolderBaseOnly);
            this.gbAutoFolders.Controls.Add(this.rdoFolderCustom);
            this.gbAutoFolders.Controls.Add(this.rdoFolderLibraryDefault);
            this.gbAutoFolders.Controls.Add(this.txtBaseFolder);
            this.gbAutoFolders.Controls.Add(this.bnBrowse);
            this.gbAutoFolders.Controls.Add(this.label3);
            this.gbAutoFolders.Location = new System.Drawing.Point(3, 49);
            this.gbAutoFolders.Name = "gbAutoFolders";
            this.gbAutoFolders.Size = new System.Drawing.Size(437, 134);
            this.gbAutoFolders.TabIndex = 11;
            this.gbAutoFolders.TabStop = false;
            // 
            // bnQuickLocate
            // 
            this.bnQuickLocate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnQuickLocate.Location = new System.Drawing.Point(354, 48);
            this.bnQuickLocate.Name = "bnQuickLocate";
            this.bnQuickLocate.Size = new System.Drawing.Size(75, 23);
            this.bnQuickLocate.TabIndex = 29;
            this.bnQuickLocate.Text = "&Create...";
            this.bnQuickLocate.UseVisualStyleBackColor = true;
            this.bnQuickLocate.Click += new System.EventHandler(this.bnQuickLocate_Click);
            // 
            // txtSeasonFormat
            // 
            this.txtSeasonFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSeasonFormat.Location = new System.Drawing.Point(147, 94);
            this.txtSeasonFormat.Name = "txtSeasonFormat";
            this.txtSeasonFormat.Size = new System.Drawing.Size(201, 20);
            this.txtSeasonFormat.TabIndex = 28;
            this.txtSeasonFormat.TextChanged += new System.EventHandler(this.txtSeasonFormat_TextChanged);
            // 
            // bnTags
            // 
            this.bnTags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnTags.Location = new System.Drawing.Point(354, 94);
            this.bnTags.Name = "bnTags";
            this.bnTags.Size = new System.Drawing.Size(75, 23);
            this.bnTags.TabIndex = 27;
            this.bnTags.Text = "Tags...";
            this.bnTags.UseVisualStyleBackColor = true;
            this.bnTags.Click += new System.EventHandler(this.bnTags_Click);
            // 
            // lblSeasonWordPreview
            // 
            this.lblSeasonWordPreview.AutoSize = true;
            this.lblSeasonWordPreview.Enabled = false;
            this.lblSeasonWordPreview.Location = new System.Drawing.Point(146, 79);
            this.lblSeasonWordPreview.Name = "lblSeasonWordPreview";
            this.lblSeasonWordPreview.Size = new System.Drawing.Size(41, 13);
            this.lblSeasonWordPreview.TabIndex = 11;
            this.lblSeasonWordPreview.Text = "label10";
            // 
            // rdoFolderBaseOnly
            // 
            this.rdoFolderBaseOnly.AutoSize = true;
            this.rdoFolderBaseOnly.Location = new System.Drawing.Point(11, 59);
            this.rdoFolderBaseOnly.Name = "rdoFolderBaseOnly";
            this.rdoFolderBaseOnly.Size = new System.Drawing.Size(175, 17);
            this.rdoFolderBaseOnly.TabIndex = 9;
            this.rdoFolderBaseOnly.TabStop = true;
            this.rdoFolderBaseOnly.Text = "Store all seasons in Base Folder";
            this.rdoFolderBaseOnly.UseVisualStyleBackColor = true;
            // 
            // rdoFolderCustom
            // 
            this.rdoFolderCustom.AutoSize = true;
            this.rdoFolderCustom.Location = new System.Drawing.Point(11, 96);
            this.rdoFolderCustom.Name = "rdoFolderCustom";
            this.rdoFolderCustom.Size = new System.Drawing.Size(130, 17);
            this.rdoFolderCustom.TabIndex = 7;
            this.rdoFolderCustom.TabStop = true;
            this.rdoFolderCustom.Text = "Custom Subdirectories";
            this.rdoFolderCustom.UseVisualStyleBackColor = true;
            // 
            // rdoFolderLibraryDefault
            // 
            this.rdoFolderLibraryDefault.AutoSize = true;
            this.rdoFolderLibraryDefault.Location = new System.Drawing.Point(11, 78);
            this.rdoFolderLibraryDefault.Name = "rdoFolderLibraryDefault";
            this.rdoFolderLibraryDefault.Size = new System.Drawing.Size(133, 17);
            this.rdoFolderLibraryDefault.TabIndex = 6;
            this.rdoFolderLibraryDefault.TabStop = true;
            this.rdoFolderLibraryDefault.Text = "Subdirectories (default)";
            this.rdoFolderLibraryDefault.UseVisualStyleBackColor = true;
            // 
            // txtBaseFolder
            // 
            this.txtBaseFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBaseFolder.Location = new System.Drawing.Point(79, 31);
            this.txtBaseFolder.Name = "txtBaseFolder";
            this.txtBaseFolder.Size = new System.Drawing.Size(269, 20);
            this.txtBaseFolder.TabIndex = 1;
            this.txtBaseFolder.TextChanged += new System.EventHandler(this.TxtBaseFolder_TextChanged);
            // 
            // bnBrowse
            // 
            this.bnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnBrowse.Location = new System.Drawing.Point(354, 19);
            this.bnBrowse.Name = "bnBrowse";
            this.bnBrowse.Size = new System.Drawing.Size(75, 23);
            this.bnBrowse.TabIndex = 2;
            this.bnBrowse.Text = "&Browse...";
            this.bnBrowse.UseVisualStyleBackColor = true;
            this.bnBrowse.Click += new System.EventHandler(this.bnBrowse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Base &Folder";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pbFolders
            // 
            this.pbFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFolders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFolders.Image = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pbFolders.InitialImage = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pbFolders.Location = new System.Drawing.Point(397, 6);
            this.pbFolders.Name = "pbFolders";
            this.pbFolders.Size = new System.Drawing.Size(43, 40);
            this.pbFolders.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFolders.TabIndex = 47;
            this.pbFolders.TabStop = false;
            this.pbFolders.Click += new System.EventHandler(this.pbFolders_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.lbSourceAliases);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.bnRemoveAlias);
            this.tabPage3.Controls.Add(this.bnAddAlias);
            this.tabPage3.Controls.Add(this.tbShowAlias);
            this.tabPage3.Controls.Add(this.pbAliases);
            this.tabPage3.Controls.Add(this.lbShowAlias);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(456, 468);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Show Aliases";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 46;
            this.label14.Text = "Source Aliases";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSourceAliases
            // 
            this.lbSourceAliases.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSourceAliases.FormattingEnabled = true;
            this.lbSourceAliases.Location = new System.Drawing.Point(3, 63);
            this.lbSourceAliases.Name = "lbSourceAliases";
            this.lbSourceAliases.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbSourceAliases.Size = new System.Drawing.Size(439, 82);
            this.lbSourceAliases.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(377, 39);
            this.label10.TabIndex = 44;
            this.label10.Text = "Setup other names that this show is sometimes known as or referred to. \r\nUse this" +
    " if the files of the show use an abbreviated name and not the full show \r\nname.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Custom Aliases";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Alias Text:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bnRemoveAlias
            // 
            this.bnRemoveAlias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnRemoveAlias.Enabled = false;
            this.bnRemoveAlias.Location = new System.Drawing.Point(359, 439);
            this.bnRemoveAlias.Name = "bnRemoveAlias";
            this.bnRemoveAlias.Size = new System.Drawing.Size(83, 23);
            this.bnRemoveAlias.TabIndex = 3;
            this.bnRemoveAlias.Text = "&Remove Alias";
            this.bnRemoveAlias.UseVisualStyleBackColor = true;
            this.bnRemoveAlias.Click += new System.EventHandler(this.bnRemoveAlias_Click);
            // 
            // bnAddAlias
            // 
            this.bnAddAlias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnAddAlias.Enabled = false;
            this.bnAddAlias.Location = new System.Drawing.Point(359, 162);
            this.bnAddAlias.Name = "bnAddAlias";
            this.bnAddAlias.Size = new System.Drawing.Size(83, 23);
            this.bnAddAlias.TabIndex = 2;
            this.bnAddAlias.Text = "&Add Alias";
            this.bnAddAlias.UseVisualStyleBackColor = true;
            this.bnAddAlias.Click += new System.EventHandler(this.bnAddAlias_Click);
            // 
            // tbShowAlias
            // 
            this.tbShowAlias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbShowAlias.Location = new System.Drawing.Point(68, 164);
            this.tbShowAlias.Name = "tbShowAlias";
            this.tbShowAlias.Size = new System.Drawing.Size(285, 20);
            this.tbShowAlias.TabIndex = 1;
            this.tbShowAlias.TextChanged += new System.EventHandler(this.tbShowAlias_TextChanged);
            this.tbShowAlias.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbShowAlias_KeyDown);
            // 
            // pbAliases
            // 
            this.pbAliases.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAliases.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAliases.Image = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pbAliases.InitialImage = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pbAliases.Location = new System.Drawing.Point(391, 6);
            this.pbAliases.Name = "pbAliases";
            this.pbAliases.Size = new System.Drawing.Size(43, 40);
            this.pbAliases.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAliases.TabIndex = 43;
            this.pbAliases.TabStop = false;
            this.pbAliases.Click += new System.EventHandler(this.pbAliases_Click);
            // 
            // lbShowAlias
            // 
            this.lbShowAlias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbShowAlias.FormattingEnabled = true;
            this.lbShowAlias.Location = new System.Drawing.Point(3, 208);
            this.lbShowAlias.Name = "lbShowAlias";
            this.lbShowAlias.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbShowAlias.Size = new System.Drawing.Size(439, 225);
            this.lbShowAlias.TabIndex = 0;
            this.lbShowAlias.SelectedIndexChanged += new System.EventHandler(this.lbShowAlias_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.llCustomSearchPreview);
            this.tabPage4.Controls.Add(this.lbSearchExample);
            this.tabPage4.Controls.Add(this.txtSearchURL);
            this.tabPage4.Controls.Add(this.txtTagList);
            this.tabPage4.Controls.Add(this.lbTags);
            this.tabPage4.Controls.Add(this.lbSearchURL);
            this.tabPage4.Controls.Add(this.cbUseCustomSearch);
            this.tabPage4.Controls.Add(this.pbCustomSearch);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(456, 468);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Custom Search";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(198, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "Setup a search engine just for this show.";
            // 
            // llCustomSearchPreview
            // 
            this.llCustomSearchPreview.AutoSize = true;
            this.llCustomSearchPreview.Location = new System.Drawing.Point(83, 96);
            this.llCustomSearchPreview.Name = "llCustomSearchPreview";
            this.llCustomSearchPreview.Size = new System.Drawing.Size(0, 13);
            this.llCustomSearchPreview.TabIndex = 4;
            this.llCustomSearchPreview.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llCustomSearchPreview_LinkClicked);
            // 
            // lbSearchExample
            // 
            this.lbSearchExample.AutoSize = true;
            this.lbSearchExample.Location = new System.Drawing.Point(27, 96);
            this.lbSearchExample.Name = "lbSearchExample";
            this.lbSearchExample.Size = new System.Drawing.Size(50, 13);
            this.lbSearchExample.TabIndex = 3;
            this.lbSearchExample.Text = "Example:";
            // 
            // txtSearchURL
            // 
            this.txtSearchURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchURL.Location = new System.Drawing.Point(80, 67);
            this.txtSearchURL.Name = "txtSearchURL";
            this.txtSearchURL.Size = new System.Drawing.Size(354, 20);
            this.txtSearchURL.TabIndex = 2;
            this.txtSearchURL.TextChanged += new System.EventHandler(this.txtSearchURL_TextChanged);
            // 
            // txtTagList
            // 
            this.txtTagList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTagList.Location = new System.Drawing.Point(45, 144);
            this.txtTagList.Name = "txtTagList";
            this.txtTagList.Size = new System.Drawing.Size(363, 280);
            this.txtTagList.TabIndex = 1;
            this.txtTagList.Text = "<tags>";
            // 
            // lbTags
            // 
            this.lbTags.AutoSize = true;
            this.lbTags.Location = new System.Drawing.Point(27, 123);
            this.lbTags.Name = "lbTags";
            this.lbTags.Size = new System.Drawing.Size(80, 13);
            this.lbTags.TabIndex = 1;
            this.lbTags.Tag = "";
            this.lbTags.Text = "Available Tags:";
            // 
            // lbSearchURL
            // 
            this.lbSearchURL.AutoSize = true;
            this.lbSearchURL.Location = new System.Drawing.Point(27, 70);
            this.lbSearchURL.Name = "lbSearchURL";
            this.lbSearchURL.Size = new System.Drawing.Size(32, 13);
            this.lbSearchURL.TabIndex = 1;
            this.lbSearchURL.Text = "URL:";
            // 
            // cbUseCustomSearch
            // 
            this.cbUseCustomSearch.AutoSize = true;
            this.cbUseCustomSearch.Location = new System.Drawing.Point(8, 43);
            this.cbUseCustomSearch.Name = "cbUseCustomSearch";
            this.cbUseCustomSearch.Size = new System.Drawing.Size(120, 17);
            this.cbUseCustomSearch.TabIndex = 0;
            this.cbUseCustomSearch.Text = "&Use Custom Search";
            this.cbUseCustomSearch.UseVisualStyleBackColor = true;
            this.cbUseCustomSearch.CheckedChanged += new System.EventHandler(this.cbUseCustomSearch_CheckedChanged);
            // 
            // pbCustomSearch
            // 
            this.pbCustomSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCustomSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCustomSearch.Image = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pbCustomSearch.InitialImage = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pbCustomSearch.Location = new System.Drawing.Point(391, 6);
            this.pbCustomSearch.Name = "pbCustomSearch";
            this.pbCustomSearch.Size = new System.Drawing.Size(43, 40);
            this.pbCustomSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCustomSearch.TabIndex = 45;
            this.pbCustomSearch.TabStop = false;
            this.pbCustomSearch.Click += new System.EventHandler(this.pbSearch_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.llLibraryDefaultFormat);
            this.tabPage6.Controls.Add(this.llCustomName);
            this.tabPage6.Controls.Add(this.lbLibraryDefaultNaming);
            this.tabPage6.Controls.Add(this.label15);
            this.tabPage6.Controls.Add(this.lbNamingExample);
            this.tabPage6.Controls.Add(this.txtCustomEpisodeNamingFormat);
            this.tabPage6.Controls.Add(this.txtTagList2);
            this.tabPage6.Controls.Add(this.lbAvailableTags);
            this.tabPage6.Controls.Add(this.label19);
            this.tabPage6.Controls.Add(this.cbUseCustomNamingFormat);
            this.tabPage6.Controls.Add(this.pictureBox1);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(456, 468);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Custom Episode Naming";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // llLibraryDefaultFormat
            // 
            this.llLibraryDefaultFormat.AutoSize = true;
            this.llLibraryDefaultFormat.Location = new System.Drawing.Point(104, 63);
            this.llLibraryDefaultFormat.Name = "llLibraryDefaultFormat";
            this.llLibraryDefaultFormat.Size = new System.Drawing.Size(0, 13);
            this.llLibraryDefaultFormat.TabIndex = 57;
            // 
            // llCustomName
            // 
            this.llCustomName.AutoSize = true;
            this.llCustomName.Location = new System.Drawing.Point(104, 116);
            this.llCustomName.Name = "llCustomName";
            this.llCustomName.Size = new System.Drawing.Size(0, 13);
            this.llCustomName.TabIndex = 56;
            // 
            // lbLibraryDefaultNaming
            // 
            this.lbLibraryDefaultNaming.AutoSize = true;
            this.lbLibraryDefaultNaming.Location = new System.Drawing.Point(29, 63);
            this.lbLibraryDefaultNaming.Name = "lbLibraryDefaultNaming";
            this.lbLibraryDefaultNaming.Size = new System.Drawing.Size(44, 13);
            this.lbLibraryDefaultNaming.TabIndex = 55;
            this.lbLibraryDefaultNaming.Text = "Default:";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(206, 13);
            this.label15.TabIndex = 54;
            this.label15.Text = "Setup an episode format just for this show.";
            // 
            // lbNamingExample
            // 
            this.lbNamingExample.AutoSize = true;
            this.lbNamingExample.Location = new System.Drawing.Point(29, 116);
            this.lbNamingExample.Name = "lbNamingExample";
            this.lbNamingExample.Size = new System.Drawing.Size(50, 13);
            this.lbNamingExample.TabIndex = 52;
            this.lbNamingExample.Text = "Example:";
            // 
            // txtCustomEpisodeNamingFormat
            // 
            this.txtCustomEpisodeNamingFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomEpisodeNamingFormat.Location = new System.Drawing.Point(107, 87);
            this.txtCustomEpisodeNamingFormat.Name = "txtCustomEpisodeNamingFormat";
            this.txtCustomEpisodeNamingFormat.Size = new System.Drawing.Size(329, 20);
            this.txtCustomEpisodeNamingFormat.TabIndex = 51;
            this.txtCustomEpisodeNamingFormat.TextChanged += new System.EventHandler(this.TxtCustomEpisodeNamingFormat_TextChanged);
            // 
            // txtTagList2
            // 
            this.txtTagList2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTagList2.Location = new System.Drawing.Point(49, 164);
            this.txtTagList2.Name = "txtTagList2";
            this.txtTagList2.Size = new System.Drawing.Size(361, 280);
            this.txtTagList2.TabIndex = 48;
            this.txtTagList2.Text = "<tags>";
            // 
            // lbAvailableTags
            // 
            this.lbAvailableTags.AutoSize = true;
            this.lbAvailableTags.Location = new System.Drawing.Point(29, 143);
            this.lbAvailableTags.Name = "lbAvailableTags";
            this.lbAvailableTags.Size = new System.Drawing.Size(80, 13);
            this.lbAvailableTags.TabIndex = 49;
            this.lbAvailableTags.Tag = "";
            this.lbAvailableTags.Text = "Available Tags:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(29, 90);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 13);
            this.label19.TabIndex = 50;
            this.label19.Text = "Custom Format:";
            // 
            // cbUseCustomNamingFormat
            // 
            this.cbUseCustomNamingFormat.AutoSize = true;
            this.cbUseCustomNamingFormat.Location = new System.Drawing.Point(10, 43);
            this.cbUseCustomNamingFormat.Name = "cbUseCustomNamingFormat";
            this.cbUseCustomNamingFormat.Size = new System.Drawing.Size(157, 17);
            this.cbUseCustomNamingFormat.TabIndex = 47;
            this.cbUseCustomNamingFormat.Text = "Use Custom Naming Format";
            this.cbUseCustomNamingFormat.UseVisualStyleBackColor = true;
            this.cbUseCustomNamingFormat.CheckedChanged += new System.EventHandler(this.CbUseCustomNamingFormat_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pictureBox1.InitialImage = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pictureBox1.Location = new System.Drawing.Point(393, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chkAlternateOrder);
            this.tabPage2.Controls.Add(this.cbEpNameMatching);
            this.tabPage2.Controls.Add(this.label68);
            this.tabPage2.Controls.Add(this.cbAirdateMatching);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.cbIncludeNoAirdate);
            this.tabPage2.Controls.Add(this.cbIncludeFuture);
            this.tabPage2.Controls.Add(this.chkShowNextAirdate);
            this.tabPage2.Controls.Add(this.chkDVDOrder);
            this.tabPage2.Controls.Add(this.cbDoRenaming);
            this.tabPage2.Controls.Add(this.cbDoMissingCheck);
            this.tabPage2.Controls.Add(this.cbSequentialMatching);
            this.tabPage2.Controls.Add(this.chkSpecialsCount);
            this.tabPage2.Controls.Add(this.pbAdvanced);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(456, 468);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advanced";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbEpNameMatching
            // 
            this.cbEpNameMatching.AutoSize = true;
            this.cbEpNameMatching.Location = new System.Drawing.Point(26, 279);
            this.cbEpNameMatching.Name = "cbEpNameMatching";
            this.cbEpNameMatching.Size = new System.Drawing.Size(182, 17);
            this.cbEpNameMatching.TabIndex = 62;
            this.cbEpNameMatching.Text = "Look for episode title in filenames";
            this.cbEpNameMatching.UseVisualStyleBackColor = true;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(6, 213);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(180, 13);
            this.label68.TabIndex = 61;
            this.label68.Text = "When finding missing episodes (only)";
            // 
            // cbAirdateMatching
            // 
            this.cbAirdateMatching.AutoSize = true;
            this.cbAirdateMatching.Location = new System.Drawing.Point(26, 256);
            this.cbAirdateMatching.Name = "cbAirdateMatching";
            this.cbAirdateMatching.Size = new System.Drawing.Size(158, 17);
            this.cbAirdateMatching.TabIndex = 60;
            this.cbAirdateMatching.Text = "&Look for airdate in filenames";
            this.cbAirdateMatching.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(384, 26);
            this.label9.TabIndex = 42;
            this.label9.Text = "Further details of how to setup the actions that TV Rename does for this specific" +
    "\r\nshow.";
            // 
            // cbIncludeNoAirdate
            // 
            this.cbIncludeNoAirdate.AutoSize = true;
            this.cbIncludeNoAirdate.Location = new System.Drawing.Point(174, 170);
            this.cbIncludeNoAirdate.Name = "cbIncludeNoAirdate";
            this.cbIncludeNoAirdate.Size = new System.Drawing.Size(111, 17);
            this.cbIncludeNoAirdate.TabIndex = 8;
            this.cbIncludeNoAirdate.Text = "Include no airdate";
            this.cbIncludeNoAirdate.UseVisualStyleBackColor = true;
            // 
            // cbIncludeFuture
            // 
            this.cbIncludeFuture.AutoSize = true;
            this.cbIncludeFuture.Location = new System.Drawing.Point(28, 170);
            this.cbIncludeFuture.Name = "cbIncludeFuture";
            this.cbIncludeFuture.Size = new System.Drawing.Size(136, 17);
            this.cbIncludeFuture.TabIndex = 8;
            this.cbIncludeFuture.Text = "Include future episodes";
            this.cbIncludeFuture.UseVisualStyleBackColor = true;
            // 
            // pbAdvanced
            // 
            this.pbAdvanced.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAdvanced.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAdvanced.Image = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pbAdvanced.InitialImage = global::TVRename.Properties.Resources.iconfinder_Info_Circle_Symbol_Information_Letter_1396823;
            this.pbAdvanced.Location = new System.Drawing.Point(391, 6);
            this.pbAdvanced.Name = "pbAdvanced";
            this.pbAdvanced.Size = new System.Drawing.Size(43, 40);
            this.pbAdvanced.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAdvanced.TabIndex = 41;
            this.pbAdvanced.TabStop = false;
            this.pbAdvanced.Click += new System.EventHandler(this.pbAdvanced_Click);
            // 
            // chkAlternateOrder
            // 
            this.chkAlternateOrder.AutoSize = true;
            this.chkAlternateOrder.Location = new System.Drawing.Point(114, 55);
            this.chkAlternateOrder.Name = "chkAlternateOrder";
            this.chkAlternateOrder.Size = new System.Drawing.Size(119, 17);
            this.chkAlternateOrder.TabIndex = 63;
            this.chkAlternateOrder.Text = "Use Alternate Order";
            this.chkAlternateOrder.UseVisualStyleBackColor = true;
            this.chkAlternateOrder.CheckedChanged += new System.EventHandler(this.chkAlternateOrder_CheckedChanged);
            // 
            // AddEditShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bnCancel;
            this.ClientSize = new System.Drawing.Size(462, 537);
            this.ControlBox = false;
            this.Controls.Add(this.Folders);
            this.Controls.Add(this.bnCancel);
            this.Controls.Add(this.buttonOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(460, 443);
            this.Name = "AddEditShow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/Edit TV Show";
            this.Folders.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBasics)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbAutoFolders.ResumeLayout(false);
            this.gbAutoFolders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFolders)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAliases)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomSearch)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdvanced)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCF;
        private System.Windows.Forms.CheckBox cbDoRenaming;
        private System.Windows.Forms.CheckBox cbDoMissingCheck;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkDVDOrder;
        private System.Windows.Forms.CheckBox cbSequentialMatching;
        private System.Windows.Forms.CheckBox chkCustomShowName;
        private System.Windows.Forms.TextBox txtIgnoreSeasons;
        private System.Windows.Forms.TextBox txtCustomShowName;
        private System.Windows.Forms.ComboBox cbTimeZone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bnCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.CheckBox chkSpecialsCount;
        private System.Windows.Forms.CheckBox chkShowNextAirdate;
        private System.Windows.Forms.TabControl Folders;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbIncludeNoAirdate;
        private System.Windows.Forms.CheckBox cbIncludeFuture;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button bnRemoveAlias;
        private System.Windows.Forms.Button bnAddAlias;
        private System.Windows.Forms.TextBox tbShowAlias;
        private System.Windows.Forms.ListBox lbShowAlias;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtSearchURL;
        private System.Windows.Forms.Label lbSearchURL;
        private System.Windows.Forms.CheckBox cbUseCustomSearch;
        private System.Windows.Forms.Label txtTagList;
        private System.Windows.Forms.Label lbTags;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnRemove;
        private System.Windows.Forms.Button bnAdd;
        private System.Windows.Forms.Button bnBrowseFolder;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.TextBox txtSeasonNumber;
        private System.Windows.Forms.ListView lvSeasonFolders;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.CheckBox chkAutoFolders;
        private System.Windows.Forms.GroupBox gbAutoFolders;
        private System.Windows.Forms.Label lblSeasonWordPreview;
        private System.Windows.Forms.RadioButton rdoFolderBaseOnly;
        private System.Windows.Forms.RadioButton rdoFolderCustom;
        private System.Windows.Forms.RadioButton rdoFolderLibraryDefault;
        private System.Windows.Forms.TextBox txtBaseFolder;
        private System.Windows.Forms.Button bnBrowse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSeasonFormat;
        private System.Windows.Forms.Button bnTags;
        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.CheckBox chkCustomLanguage;
        private System.Windows.Forms.Button bnQuickLocate;
        private System.Windows.Forms.CheckBox chkReplaceAutoFolders;
        private System.Windows.Forms.LinkLabel llCustomSearchPreview;
        private System.Windows.Forms.Label lbSearchExample;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.PictureBox pbBasics;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pbFolders;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pbAliases;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pbCustomSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pbAdvanced;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rdoTVMaze;
        private System.Windows.Forms.RadioButton rdoTVDB;
        private System.Windows.Forms.RadioButton rdoDefault;
        private System.Windows.Forms.Label txtIgnoreList;
        private System.Windows.Forms.Button btnIgnoreList;
        private System.Windows.Forms.CheckBox cbEpNameMatching;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.CheckBox cbAirdateMatching;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox lbSourceAliases;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label lbLibraryDefaultNaming;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbNamingExample;
        private System.Windows.Forms.TextBox txtCustomEpisodeNamingFormat;
        private System.Windows.Forms.Label txtTagList2;
        private System.Windows.Forms.Label lbAvailableTags;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox cbUseCustomNamingFormat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel llCustomName;
        private System.Windows.Forms.LinkLabel llLibraryDefaultFormat;
        private System.Windows.Forms.RadioButton rdoTMDB;
        private System.Windows.Forms.CheckBox chkCustomRegion;
        private System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.CheckBox chkAlternateOrder;
    }
}
