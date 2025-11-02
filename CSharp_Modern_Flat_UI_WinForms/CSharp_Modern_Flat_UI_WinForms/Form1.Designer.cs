namespace CSharp_Modern_Flat_UI_WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelLogo = new Panel();
            pictureBox2 = new PictureBox();
            btnMedia = new Button();
            panelMediaSubmenu = new Panel();
            btnMediaOpenRecent = new Button();
            btnMediaOpenDisk = new Button();
            btnMediaOpenFolder = new Button();
            btnMediaOpenFiles = new Button();
            button1 = new Button();
            panelPlaylistSubMenu = new Panel();
            btnExportPlaylist = new Button();
            btnImportPlaylist = new Button();
            btnManagingPlaylist = new Button();
            btnNewPlaylist = new Button();
            btnEqualizer = new Button();
            panelSideMenu = new Panel();
            btnHelp = new Button();
            btnExit = new Button();
            panelToolsSubMenu = new Panel();
            btnToolsPreferences = new Button();
            btnToolsEffectsandFilters = new Button();
            btnToolsMediaConverter = new Button();
            btnTools = new Button();
            panelPlayer = new Panel();
            panelChildForm = new Panel();
            pictureBox1 = new PictureBox();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelMediaSubmenu.SuspendLayout();
            panelPlaylistSubMenu.SuspendLayout();
            panelSideMenu.SuspendLayout();
            panelToolsSubMenu.SuspendLayout();
            panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBox2);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(233, 120);
            panelLogo.TabIndex = 0;
            panelLogo.Paint += panelLogo_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(35, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(154, 111);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // btnMedia
            // 
            btnMedia.BackgroundImageLayout = ImageLayout.None;
            btnMedia.Dock = DockStyle.Top;
            btnMedia.FlatAppearance.BorderSize = 0;
            btnMedia.FlatStyle = FlatStyle.Flat;
            btnMedia.ForeColor = Color.LightGray;
            btnMedia.Image = (Image)resources.GetObject("btnMedia.Image");
            btnMedia.ImageAlign = ContentAlignment.MiddleLeft;
            btnMedia.Location = new Point(0, 120);
            btnMedia.Name = "btnMedia";
            btnMedia.Size = new Size(233, 45);
            btnMedia.TabIndex = 1;
            btnMedia.Text = "Media";
            btnMedia.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMedia.UseVisualStyleBackColor = true;
            btnMedia.Click += btnMedia_Click;
            // 
            // panelMediaSubmenu
            // 
            panelMediaSubmenu.BackColor = Color.FromArgb(64, 64, 64);
            panelMediaSubmenu.Controls.Add(btnMediaOpenRecent);
            panelMediaSubmenu.Controls.Add(btnMediaOpenDisk);
            panelMediaSubmenu.Controls.Add(btnMediaOpenFolder);
            panelMediaSubmenu.Controls.Add(btnMediaOpenFiles);
            panelMediaSubmenu.Dock = DockStyle.Top;
            panelMediaSubmenu.Location = new Point(0, 165);
            panelMediaSubmenu.Name = "panelMediaSubmenu";
            panelMediaSubmenu.Size = new Size(233, 165);
            panelMediaSubmenu.TabIndex = 2;
            // 
            // btnMediaOpenRecent
            // 
            btnMediaOpenRecent.Dock = DockStyle.Top;
            btnMediaOpenRecent.FlatAppearance.BorderSize = 0;
            btnMediaOpenRecent.FlatStyle = FlatStyle.Flat;
            btnMediaOpenRecent.ForeColor = Color.LightGray;
            btnMediaOpenRecent.Location = new Point(0, 120);
            btnMediaOpenRecent.Name = "btnMediaOpenRecent";
            btnMediaOpenRecent.Padding = new Padding(20, 0, 0, 0);
            btnMediaOpenRecent.Size = new Size(233, 40);
            btnMediaOpenRecent.TabIndex = 3;
            btnMediaOpenRecent.Text = "Open Recent Media";
            btnMediaOpenRecent.TextAlign = ContentAlignment.MiddleLeft;
            btnMediaOpenRecent.UseVisualStyleBackColor = true;
            btnMediaOpenRecent.Click += button5_Click;
            // 
            // btnMediaOpenDisk
            // 
            btnMediaOpenDisk.Dock = DockStyle.Top;
            btnMediaOpenDisk.FlatAppearance.BorderSize = 0;
            btnMediaOpenDisk.FlatStyle = FlatStyle.Flat;
            btnMediaOpenDisk.ForeColor = Color.LightGray;
            btnMediaOpenDisk.Location = new Point(0, 80);
            btnMediaOpenDisk.Name = "btnMediaOpenDisk";
            btnMediaOpenDisk.Padding = new Padding(20, 0, 0, 0);
            btnMediaOpenDisk.Size = new Size(233, 40);
            btnMediaOpenDisk.TabIndex = 2;
            btnMediaOpenDisk.Text = "Open Disk";
            btnMediaOpenDisk.TextAlign = ContentAlignment.MiddleLeft;
            btnMediaOpenDisk.UseVisualStyleBackColor = true;
            btnMediaOpenDisk.Click += button4_Click;
            // 
            // btnMediaOpenFolder
            // 
            btnMediaOpenFolder.Dock = DockStyle.Top;
            btnMediaOpenFolder.FlatAppearance.BorderSize = 0;
            btnMediaOpenFolder.FlatStyle = FlatStyle.Flat;
            btnMediaOpenFolder.ForeColor = Color.LightGray;
            btnMediaOpenFolder.Location = new Point(0, 40);
            btnMediaOpenFolder.Name = "btnMediaOpenFolder";
            btnMediaOpenFolder.Padding = new Padding(20, 0, 0, 0);
            btnMediaOpenFolder.Size = new Size(233, 40);
            btnMediaOpenFolder.TabIndex = 1;
            btnMediaOpenFolder.Text = "Open Folder";
            btnMediaOpenFolder.TextAlign = ContentAlignment.MiddleLeft;
            btnMediaOpenFolder.UseVisualStyleBackColor = true;
            btnMediaOpenFolder.Click += button3_Click;
            // 
            // btnMediaOpenFiles
            // 
            btnMediaOpenFiles.Dock = DockStyle.Top;
            btnMediaOpenFiles.FlatAppearance.BorderSize = 0;
            btnMediaOpenFiles.FlatStyle = FlatStyle.Flat;
            btnMediaOpenFiles.ForeColor = Color.LightGray;
            btnMediaOpenFiles.Location = new Point(0, 0);
            btnMediaOpenFiles.Name = "btnMediaOpenFiles";
            btnMediaOpenFiles.Padding = new Padding(20, 0, 0, 0);
            btnMediaOpenFiles.Size = new Size(233, 40);
            btnMediaOpenFiles.TabIndex = 0;
            btnMediaOpenFiles.Text = "Open Files";
            btnMediaOpenFiles.TextAlign = ContentAlignment.MiddleLeft;
            btnMediaOpenFiles.UseVisualStyleBackColor = true;
            btnMediaOpenFiles.Click += button2_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.LightGray;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 330);
            button1.Name = "button1";
            button1.Size = new Size(233, 45);
            button1.TabIndex = 3;
            button1.Text = "Playlist Managentment";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panelPlaylistSubMenu
            // 
            panelPlaylistSubMenu.BackColor = Color.FromArgb(64, 64, 64);
            panelPlaylistSubMenu.Controls.Add(btnExportPlaylist);
            panelPlaylistSubMenu.Controls.Add(btnImportPlaylist);
            panelPlaylistSubMenu.Controls.Add(btnManagingPlaylist);
            panelPlaylistSubMenu.Controls.Add(btnNewPlaylist);
            panelPlaylistSubMenu.Dock = DockStyle.Top;
            panelPlaylistSubMenu.Location = new Point(0, 375);
            panelPlaylistSubMenu.Name = "panelPlaylistSubMenu";
            panelPlaylistSubMenu.Size = new Size(233, 165);
            panelPlaylistSubMenu.TabIndex = 4;
            // 
            // btnExportPlaylist
            // 
            btnExportPlaylist.Dock = DockStyle.Top;
            btnExportPlaylist.FlatAppearance.BorderSize = 0;
            btnExportPlaylist.FlatStyle = FlatStyle.Flat;
            btnExportPlaylist.ForeColor = Color.LightGray;
            btnExportPlaylist.Location = new Point(0, 120);
            btnExportPlaylist.Name = "btnExportPlaylist";
            btnExportPlaylist.Padding = new Padding(20, 0, 0, 0);
            btnExportPlaylist.Size = new Size(233, 40);
            btnExportPlaylist.TabIndex = 3;
            btnExportPlaylist.Text = "Export Playlist";
            btnExportPlaylist.TextAlign = ContentAlignment.MiddleLeft;
            btnExportPlaylist.UseVisualStyleBackColor = true;
            btnExportPlaylist.Click += button6_Click;
            // 
            // btnImportPlaylist
            // 
            btnImportPlaylist.Dock = DockStyle.Top;
            btnImportPlaylist.FlatAppearance.BorderSize = 0;
            btnImportPlaylist.FlatStyle = FlatStyle.Flat;
            btnImportPlaylist.ForeColor = Color.LightGray;
            btnImportPlaylist.Location = new Point(0, 80);
            btnImportPlaylist.Name = "btnImportPlaylist";
            btnImportPlaylist.Padding = new Padding(20, 0, 0, 0);
            btnImportPlaylist.Size = new Size(233, 40);
            btnImportPlaylist.TabIndex = 2;
            btnImportPlaylist.Text = "Import Playlist";
            btnImportPlaylist.TextAlign = ContentAlignment.MiddleLeft;
            btnImportPlaylist.UseVisualStyleBackColor = true;
            btnImportPlaylist.Click += button7_Click;
            // 
            // btnManagingPlaylist
            // 
            btnManagingPlaylist.Dock = DockStyle.Top;
            btnManagingPlaylist.FlatAppearance.BorderSize = 0;
            btnManagingPlaylist.FlatStyle = FlatStyle.Flat;
            btnManagingPlaylist.ForeColor = Color.LightGray;
            btnManagingPlaylist.Location = new Point(0, 40);
            btnManagingPlaylist.Name = "btnManagingPlaylist";
            btnManagingPlaylist.Padding = new Padding(20, 0, 0, 0);
            btnManagingPlaylist.Size = new Size(233, 40);
            btnManagingPlaylist.TabIndex = 1;
            btnManagingPlaylist.Text = "Managing Playlist";
            btnManagingPlaylist.TextAlign = ContentAlignment.MiddleLeft;
            btnManagingPlaylist.UseVisualStyleBackColor = true;
            btnManagingPlaylist.Click += button8_Click;
            // 
            // btnNewPlaylist
            // 
            btnNewPlaylist.Dock = DockStyle.Top;
            btnNewPlaylist.FlatAppearance.BorderSize = 0;
            btnNewPlaylist.FlatStyle = FlatStyle.Flat;
            btnNewPlaylist.ForeColor = Color.LightGray;
            btnNewPlaylist.Location = new Point(0, 0);
            btnNewPlaylist.Name = "btnNewPlaylist";
            btnNewPlaylist.Padding = new Padding(20, 0, 0, 0);
            btnNewPlaylist.Size = new Size(233, 40);
            btnNewPlaylist.TabIndex = 0;
            btnNewPlaylist.Text = "New Playlist";
            btnNewPlaylist.TextAlign = ContentAlignment.MiddleLeft;
            btnNewPlaylist.UseVisualStyleBackColor = true;
            btnNewPlaylist.Click += button9_Click;
            // 
            // btnEqualizer
            // 
            btnEqualizer.Dock = DockStyle.Top;
            btnEqualizer.FlatAppearance.BorderSize = 0;
            btnEqualizer.FlatStyle = FlatStyle.Flat;
            btnEqualizer.ForeColor = Color.LightGray;
            btnEqualizer.Image = (Image)resources.GetObject("btnEqualizer.Image");
            btnEqualizer.ImageAlign = ContentAlignment.MiddleLeft;
            btnEqualizer.Location = new Point(0, 540);
            btnEqualizer.Name = "btnEqualizer";
            btnEqualizer.Size = new Size(233, 45);
            btnEqualizer.TabIndex = 5;
            btnEqualizer.Text = "Equalizer";
            btnEqualizer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEqualizer.UseVisualStyleBackColor = true;
            btnEqualizer.Click += btnEqualizer_Click;
            // 
            // panelSideMenu
            // 
            panelSideMenu.AutoScroll = true;
            panelSideMenu.BackColor = SystemColors.ActiveCaptionText;
            panelSideMenu.Controls.Add(btnHelp);
            panelSideMenu.Controls.Add(btnExit);
            panelSideMenu.Controls.Add(panelToolsSubMenu);
            panelSideMenu.Controls.Add(btnTools);
            panelSideMenu.Controls.Add(btnEqualizer);
            panelSideMenu.Controls.Add(panelPlaylistSubMenu);
            panelSideMenu.Controls.Add(button1);
            panelSideMenu.Controls.Add(panelMediaSubmenu);
            panelSideMenu.Controls.Add(btnMedia);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(250, 556);
            panelSideMenu.TabIndex = 0;
            // 
            // btnHelp
            // 
            btnHelp.Dock = DockStyle.Top;
            btnHelp.FlatAppearance.BorderSize = 0;
            btnHelp.FlatStyle = FlatStyle.Flat;
            btnHelp.ForeColor = Color.LightGray;
            btnHelp.Image = (Image)resources.GetObject("btnHelp.Image");
            btnHelp.ImageAlign = ContentAlignment.MiddleLeft;
            btnHelp.Location = new Point(0, 754);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(233, 45);
            btnHelp.TabIndex = 9;
            btnHelp.Text = "Help";
            btnHelp.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Bottom;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.LightGray;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(0, 799);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(233, 45);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += Help_Click;
            // 
            // panelToolsSubMenu
            // 
            panelToolsSubMenu.BackColor = Color.FromArgb(64, 64, 64);
            panelToolsSubMenu.Controls.Add(btnToolsPreferences);
            panelToolsSubMenu.Controls.Add(btnToolsEffectsandFilters);
            panelToolsSubMenu.Controls.Add(btnToolsMediaConverter);
            panelToolsSubMenu.Dock = DockStyle.Top;
            panelToolsSubMenu.Location = new Point(0, 630);
            panelToolsSubMenu.Name = "panelToolsSubMenu";
            panelToolsSubMenu.Size = new Size(233, 124);
            panelToolsSubMenu.TabIndex = 7;
            // 
            // btnToolsPreferences
            // 
            btnToolsPreferences.Dock = DockStyle.Top;
            btnToolsPreferences.FlatAppearance.BorderSize = 0;
            btnToolsPreferences.FlatStyle = FlatStyle.Flat;
            btnToolsPreferences.ForeColor = Color.LightGray;
            btnToolsPreferences.Location = new Point(0, 80);
            btnToolsPreferences.Name = "btnToolsPreferences";
            btnToolsPreferences.Padding = new Padding(20, 0, 0, 0);
            btnToolsPreferences.Size = new Size(233, 40);
            btnToolsPreferences.TabIndex = 2;
            btnToolsPreferences.Text = "Preferences";
            btnToolsPreferences.TextAlign = ContentAlignment.MiddleLeft;
            btnToolsPreferences.UseVisualStyleBackColor = true;
            btnToolsPreferences.Click += button13_Click;
            // 
            // btnToolsEffectsandFilters
            // 
            btnToolsEffectsandFilters.Dock = DockStyle.Top;
            btnToolsEffectsandFilters.FlatAppearance.BorderSize = 0;
            btnToolsEffectsandFilters.FlatStyle = FlatStyle.Flat;
            btnToolsEffectsandFilters.ForeColor = Color.LightGray;
            btnToolsEffectsandFilters.Location = new Point(0, 40);
            btnToolsEffectsandFilters.Name = "btnToolsEffectsandFilters";
            btnToolsEffectsandFilters.Padding = new Padding(20, 0, 0, 0);
            btnToolsEffectsandFilters.Size = new Size(233, 40);
            btnToolsEffectsandFilters.TabIndex = 1;
            btnToolsEffectsandFilters.Text = "Effects and Filters";
            btnToolsEffectsandFilters.TextAlign = ContentAlignment.MiddleLeft;
            btnToolsEffectsandFilters.UseVisualStyleBackColor = true;
            btnToolsEffectsandFilters.Click += button14_Click;
            // 
            // btnToolsMediaConverter
            // 
            btnToolsMediaConverter.Dock = DockStyle.Top;
            btnToolsMediaConverter.FlatAppearance.BorderSize = 0;
            btnToolsMediaConverter.FlatStyle = FlatStyle.Flat;
            btnToolsMediaConverter.ForeColor = Color.LightGray;
            btnToolsMediaConverter.Location = new Point(0, 0);
            btnToolsMediaConverter.Name = "btnToolsMediaConverter";
            btnToolsMediaConverter.Padding = new Padding(20, 0, 0, 0);
            btnToolsMediaConverter.Size = new Size(233, 40);
            btnToolsMediaConverter.TabIndex = 0;
            btnToolsMediaConverter.Text = "Media Converter";
            btnToolsMediaConverter.TextAlign = ContentAlignment.MiddleLeft;
            btnToolsMediaConverter.UseVisualStyleBackColor = true;
            btnToolsMediaConverter.Click += button15_Click;
            // 
            // btnTools
            // 
            btnTools.Dock = DockStyle.Top;
            btnTools.FlatAppearance.BorderSize = 0;
            btnTools.FlatStyle = FlatStyle.Flat;
            btnTools.ForeColor = Color.LightGray;
            btnTools.Image = (Image)resources.GetObject("btnTools.Image");
            btnTools.ImageAlign = ContentAlignment.MiddleLeft;
            btnTools.Location = new Point(0, 585);
            btnTools.Name = "btnTools";
            btnTools.Size = new Size(233, 45);
            btnTools.TabIndex = 6;
            btnTools.Text = "Tools";
            btnTools.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTools.UseVisualStyleBackColor = true;
            btnTools.Click += btnTools_Click;
            // 
            // panelPlayer
            // 
            panelPlayer.BackColor = Color.FromArgb(23, 21, 32);
            panelPlayer.Dock = DockStyle.Bottom;
            panelPlayer.Location = new Point(250, 456);
            panelPlayer.Name = "panelPlayer";
            panelPlayer.Size = new Size(494, 100);
            panelPlayer.TabIndex = 1;
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.FromArgb(64, 64, 64);
            panelChildForm.Controls.Add(pictureBox1);
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(250, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(494, 456);
            panelChildForm.TabIndex = 2;
            panelChildForm.Paint += panelChildForm_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(88, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(347, 347);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 556);
            Controls.Add(panelChildForm);
            Controls.Add(panelPlayer);
            Controls.Add(panelSideMenu);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelMediaSubmenu.ResumeLayout(false);
            panelPlaylistSubMenu.ResumeLayout(false);
            panelSideMenu.ResumeLayout(false);
            panelToolsSubMenu.ResumeLayout(false);
            panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogo;
        private Button btnMedia;
        private Panel panelMediaSubmenu;
        private Button btnMediaOpenRecent;
        private Button btnMediaOpenDisk;
        private Button btnMediaOpenFolder;
        private Button btnMediaOpenFiles;
        private Button button1;
        private Panel panelPlaylistSubMenu;
        private Button btnExportPlaylist;
        private Button btnImportPlaylist;
        private Button btnManagingPlaylist;
        private Button btnNewPlaylist;
        private Button btnEqualizer;
        private Panel panelSideMenu;
        private Panel panelToolsSubMenu;
        private Button btnToolsPreferences;
        private Button btnToolsEffectsandFilters;
        private Button btnToolsMediaConverter;
        private Button btnTools;
        private Button btnExit;
        private Panel panelPlayer;
        private Panel panelChildForm;
        private PictureBox pictureBox1;
        private Button btnHelp;
        private PictureBox pictureBox2;
    }
}
