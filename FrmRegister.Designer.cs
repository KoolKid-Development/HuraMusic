
namespace HuraMusic
{
    partial class FrmMain
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
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation2 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidemenu = new Bunifu.UI.WinForms.BunifuPages();
            this.Main = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnlogin = new Guna.UI2.WinForms.Guna2Button();
            this.Settings = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Pages = new Bunifu.UI.WinForms.BunifuPages();
            this.Player = new System.Windows.Forms.TabPage();
            this.Playlist = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.WinPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pause = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.mute = new System.Windows.Forms.PictureBox();
            this.bunifuHSlider1 = new Bunifu.UI.WinForms.BunifuHSlider();
            this.NoMute = new System.Windows.Forms.PictureBox();
            this.Play = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuHSlider2 = new Bunifu.UI.WinForms.BunifuHSlider();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.sidemenu.SuspendLayout();
            this.Main.SuspendLayout();
            this.Settings.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Pages.SuspendLayout();
            this.Player.SuspendLayout();
            this.Playlist.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WinPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoMute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.panel1.Controls.Add(this.sidemenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 443);
            this.panel1.TabIndex = 0;
            // 
            // sidemenu
            // 
            this.sidemenu.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.sidemenu.AllowTransitions = false;
            this.sidemenu.Controls.Add(this.Main);
            this.sidemenu.Controls.Add(this.Settings);
            this.sidemenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidemenu.Location = new System.Drawing.Point(0, 0);
            this.sidemenu.Multiline = true;
            this.sidemenu.Name = "sidemenu";
            this.sidemenu.Page = this.Main;
            this.sidemenu.PageIndex = 0;
            this.sidemenu.PageName = "Main";
            this.sidemenu.PageTitle = "Main";
            this.sidemenu.SelectedIndex = 0;
            this.sidemenu.Size = new System.Drawing.Size(183, 443);
            this.sidemenu.TabIndex = 0;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.sidemenu.Transition = animation1;
            this.sidemenu.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.Main.Controls.Add(this.pictureBox1);
            this.Main.Controls.Add(this.label2);
            this.Main.Controls.Add(this.guna2Button2);
            this.Main.Controls.Add(this.guna2Button3);
            this.Main.Controls.Add(this.guna2Button1);
            this.Main.Controls.Add(this.btnlogin);
            this.Main.Location = new System.Drawing.Point(4, 4);
            this.Main.Name = "Main";
            this.Main.Padding = new System.Windows.Forms.Padding(3);
            this.Main.Size = new System.Drawing.Size(175, 417);
            this.Main.TabIndex = 0;
            this.Main.Text = "Main";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            this.label2.Location = new System.Drawing.Point(15, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "HuraMusic";
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 15;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(193)))), ((int)(((byte)(66)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(-29, 262);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(198, 26);
            this.guna2Button2.TabIndex = 11;
            this.guna2Button2.Text = "Exit";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 15;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(193)))), ((int)(((byte)(66)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(-29, 230);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(198, 26);
            this.guna2Button3.TabIndex = 10;
            this.guna2Button3.Text = "Settings";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(193)))), ((int)(((byte)(66)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(-29, 198);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(198, 26);
            this.guna2Button1.TabIndex = 9;
            this.guna2Button1.Text = "Playlist";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.BorderRadius = 15;
            this.btnlogin.CheckedState.Parent = this.btnlogin;
            this.btnlogin.CustomImages.Parent = this.btnlogin;
            this.btnlogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(193)))), ((int)(((byte)(66)))));
            this.btnlogin.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.HoverState.Parent = this.btnlogin;
            this.btnlogin.Location = new System.Drawing.Point(-29, 166);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.ShadowDecoration.Parent = this.btnlogin;
            this.btnlogin.Size = new System.Drawing.Size(198, 26);
            this.btnlogin.TabIndex = 8;
            this.btnlogin.Text = "Player";
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.Settings.Controls.Add(this.button1);
            this.Settings.Location = new System.Drawing.Point(4, 4);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(175, 417);
            this.Settings.TabIndex = 1;
            this.Settings.Text = "Settings";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(183, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 23);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            this.label1.Location = new System.Drawing.Point(636, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "-";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            this.label6.Location = new System.Drawing.Point(662, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Pages
            // 
            this.Pages.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.Pages.AllowTransitions = false;
            this.Pages.Controls.Add(this.Player);
            this.Pages.Controls.Add(this.Playlist);
            this.Pages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pages.Location = new System.Drawing.Point(183, 23);
            this.Pages.Multiline = true;
            this.Pages.Name = "Pages";
            this.Pages.Page = this.Player;
            this.Pages.PageIndex = 0;
            this.Pages.PageName = "Player";
            this.Pages.PageTitle = "Player";
            this.Pages.SelectedIndex = 0;
            this.Pages.Size = new System.Drawing.Size(686, 420);
            this.Pages.TabIndex = 2;
            animation2.AnimateOnlyDifferences = false;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.Pages.Transition = animation2;
            this.Pages.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.Player.Controls.Add(this.panel3);
            this.Player.Controls.Add(this.panel4);
            this.Player.Location = new System.Drawing.Point(4, 4);
            this.Player.Name = "Player";
            this.Player.Padding = new System.Windows.Forms.Padding(3);
            this.Player.Size = new System.Drawing.Size(678, 394);
            this.Player.TabIndex = 0;
            this.Player.Text = "Player";
            // 
            // Playlist
            // 
            this.Playlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.Playlist.Controls.Add(this.guna2GroupBox1);
            this.Playlist.Location = new System.Drawing.Point(4, 4);
            this.Playlist.Name = "Playlist";
            this.Playlist.Padding = new System.Windows.Forms.Padding(3);
            this.Playlist.Size = new System.Drawing.Size(678, 394);
            this.Playlist.TabIndex = 1;
            this.Playlist.Text = "Playlist";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.WinPlayer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(672, 295);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.bunifuHSlider2);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.Play);
            this.panel4.Controls.Add(this.NoMute);
            this.panel4.Controls.Add(this.bunifuHSlider1);
            this.panel4.Controls.Add(this.mute);
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.pause);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 298);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(672, 93);
            this.panel4.TabIndex = 1;
            // 
            // WinPlayer
            // 
            this.WinPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WinPlayer.Enabled = true;
            this.WinPlayer.Location = new System.Drawing.Point(0, 0);
            this.WinPlayer.Name = "WinPlayer";
            this.WinPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WinPlayer.OcxState")));
            this.WinPlayer.Size = new System.Drawing.Size(672, 295);
            this.WinPlayer.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HuraMusic.Properties.Resources.backsettings;
            this.pictureBox2.Location = new System.Drawing.Point(95, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HuraMusic.Properties.Resources.hurawatchlogo;
            this.pictureBox1.Location = new System.Drawing.Point(21, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pause
            // 
            this.pause.Image = global::HuraMusic.Properties.Resources.pause;
            this.pause.Location = new System.Drawing.Point(-1, 37);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(52, 43);
            this.pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pause.TabIndex = 0;
            this.pause.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::HuraMusic.Properties.Resources.next;
            this.pictureBox4.Location = new System.Drawing.Point(181, 43);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::HuraMusic.Properties.Resources.stop;
            this.pictureBox5.Location = new System.Drawing.Point(138, 43);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(37, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // mute
            // 
            this.mute.Image = global::HuraMusic.Properties.Resources.mute;
            this.mute.Location = new System.Drawing.Point(444, 43);
            this.mute.Name = "mute";
            this.mute.Size = new System.Drawing.Size(37, 30);
            this.mute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mute.TabIndex = 3;
            this.mute.TabStop = false;
            // 
            // bunifuHSlider1
            // 
            this.bunifuHSlider1.AllowCursorChanges = true;
            this.bunifuHSlider1.AllowHomeEndKeysDetection = false;
            this.bunifuHSlider1.AllowIncrementalClickMoves = true;
            this.bunifuHSlider1.AllowMouseDownEffects = false;
            this.bunifuHSlider1.AllowMouseHoverEffects = false;
            this.bunifuHSlider1.AllowScrollingAnimations = true;
            this.bunifuHSlider1.AllowScrollKeysDetection = true;
            this.bunifuHSlider1.AllowScrollOptionsMenu = true;
            this.bunifuHSlider1.AllowShrinkingOnFocusLost = false;
            this.bunifuHSlider1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuHSlider1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuHSlider1.BackgroundImage")));
            this.bunifuHSlider1.BindingContainer = null;
            this.bunifuHSlider1.BorderRadius = 1;
            this.bunifuHSlider1.BorderThickness = 1;
            this.bunifuHSlider1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuHSlider1.DrawThickBorder = false;
            this.bunifuHSlider1.DurationBeforeShrink = 2000;
            this.bunifuHSlider1.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(193)))), ((int)(((byte)(66)))));
            this.bunifuHSlider1.LargeChange = 10;
            this.bunifuHSlider1.Location = new System.Drawing.Point(50, -3);
            this.bunifuHSlider1.Maximum = 100;
            this.bunifuHSlider1.Minimum = 0;
            this.bunifuHSlider1.MinimumSize = new System.Drawing.Size(0, 31);
            this.bunifuHSlider1.MinimumThumbLength = 18;
            this.bunifuHSlider1.Name = "bunifuHSlider1";
            this.bunifuHSlider1.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.bunifuHSlider1.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.bunifuHSlider1.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.bunifuHSlider1.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuHSlider1.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuHSlider1.ShrinkSizeLimit = 3;
            this.bunifuHSlider1.Size = new System.Drawing.Size(572, 31);
            this.bunifuHSlider1.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuHSlider1.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.bunifuHSlider1.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.bunifuHSlider1.SmallChange = 1;
            this.bunifuHSlider1.TabIndex = 4;
            this.bunifuHSlider1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(193)))), ((int)(((byte)(66)))));
            this.bunifuHSlider1.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.bunifuHSlider1.ThumbLength = 56;
            this.bunifuHSlider1.ThumbMargin = 1;
            this.bunifuHSlider1.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.bunifuHSlider1.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.bunifuHSlider1.Value = 0;
            // 
            // NoMute
            // 
            this.NoMute.Image = global::HuraMusic.Properties.Resources.nomute;
            this.NoMute.Location = new System.Drawing.Point(444, 43);
            this.NoMute.Name = "NoMute";
            this.NoMute.Size = new System.Drawing.Size(37, 30);
            this.NoMute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NoMute.TabIndex = 5;
            this.NoMute.TabStop = false;
            this.NoMute.Click += new System.EventHandler(this.NoMute_Click);
            // 
            // Play
            // 
            this.Play.Image = global::HuraMusic.Properties.Resources.play;
            this.Play.Location = new System.Drawing.Point(3, 37);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(52, 43);
            this.Play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Play.TabIndex = 6;
            this.Play.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            this.label3.Location = new System.Drawing.Point(0, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "00:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            this.label4.Location = new System.Drawing.Point(625, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "00:00";
            // 
            // bunifuHSlider2
            // 
            this.bunifuHSlider2.AllowCursorChanges = true;
            this.bunifuHSlider2.AllowHomeEndKeysDetection = false;
            this.bunifuHSlider2.AllowIncrementalClickMoves = true;
            this.bunifuHSlider2.AllowMouseDownEffects = false;
            this.bunifuHSlider2.AllowMouseHoverEffects = false;
            this.bunifuHSlider2.AllowScrollingAnimations = true;
            this.bunifuHSlider2.AllowScrollKeysDetection = true;
            this.bunifuHSlider2.AllowScrollOptionsMenu = true;
            this.bunifuHSlider2.AllowShrinkingOnFocusLost = false;
            this.bunifuHSlider2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuHSlider2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuHSlider2.BackgroundImage")));
            this.bunifuHSlider2.BindingContainer = null;
            this.bunifuHSlider2.BorderRadius = 2;
            this.bunifuHSlider2.BorderThickness = 1;
            this.bunifuHSlider2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuHSlider2.DrawThickBorder = false;
            this.bunifuHSlider2.DurationBeforeShrink = 2000;
            this.bunifuHSlider2.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(193)))), ((int)(((byte)(66)))));
            this.bunifuHSlider2.LargeChange = 10;
            this.bunifuHSlider2.Location = new System.Drawing.Point(487, 43);
            this.bunifuHSlider2.Maximum = 100;
            this.bunifuHSlider2.Minimum = 0;
            this.bunifuHSlider2.MinimumSize = new System.Drawing.Size(0, 31);
            this.bunifuHSlider2.MinimumThumbLength = 18;
            this.bunifuHSlider2.Name = "bunifuHSlider2";
            this.bunifuHSlider2.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.bunifuHSlider2.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.bunifuHSlider2.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.bunifuHSlider2.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuHSlider2.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuHSlider2.ShrinkSizeLimit = 3;
            this.bunifuHSlider2.Size = new System.Drawing.Size(135, 31);
            this.bunifuHSlider2.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuHSlider2.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.bunifuHSlider2.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.bunifuHSlider2.SmallChange = 1;
            this.bunifuHSlider2.TabIndex = 17;
            this.bunifuHSlider2.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(193)))), ((int)(((byte)(66)))));
            this.bunifuHSlider2.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.bunifuHSlider2.ThumbLength = 18;
            this.bunifuHSlider2.ThumbMargin = 1;
            this.bunifuHSlider2.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.bunifuHSlider2.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.bunifuHSlider2.Value = 50;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Controls.Add(this.pictureBox3);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(193)))), ((int)(((byte)(66)))));
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(3, 3);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(672, 388);
            this.guna2GroupBox1.TabIndex = 0;
            this.guna2GroupBox1.Text = "Playlist";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::HuraMusic.Properties.Resources.folder;
            this.pictureBox3.Location = new System.Drawing.Point(630, 355);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(869, 443);
            this.Controls.Add(this.Pages);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.panel1.ResumeLayout(false);
            this.sidemenu.ResumeLayout(false);
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.Settings.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Pages.ResumeLayout(false);
            this.Player.ResumeLayout(false);
            this.Playlist.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WinPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoMute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuPages sidemenu;
        private System.Windows.Forms.TabPage Main;
        private System.Windows.Forms.TabPage Settings;
        private Bunifu.UI.WinForms.BunifuPages Pages;
        private System.Windows.Forms.TabPage Player;
        private System.Windows.Forms.TabPage Playlist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnlogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private AxWMPLib.AxWindowsMediaPlayer WinPlayer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.UI.WinForms.BunifuHSlider bunifuHSlider2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Play;
        private System.Windows.Forms.PictureBox NoMute;
        private Bunifu.UI.WinForms.BunifuHSlider bunifuHSlider1;
        private System.Windows.Forms.PictureBox mute;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pause;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
