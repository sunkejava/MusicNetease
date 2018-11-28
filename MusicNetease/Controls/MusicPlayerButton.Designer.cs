namespace MusicNetease.Controls
{
    partial class MusicPlayerButton
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayerButton));
            this.skinPanel_buttons = new CCWin.SkinControl.SkinPanel();
            this.skinPanel_play = new CCWin.SkinControl.SkinPanel();
            this.skinButton_play = new CCWin.SkinControl.SkinButton();
            this.skinPanel_sys = new CCWin.SkinControl.SkinPanel();
            this.skinButton_sys = new CCWin.SkinControl.SkinButton();
            this.skinToolTip1 = new CCWin.SkinToolTip(this.components);
            this.skinPanel_bfjdt = new CCWin.SkinControl.SkinPanel();
            this.skinPanel_jdt = new CCWin.SkinControl.SkinPanel();
            this.layeredTrackBar_yyjdt = new LayeredSkin.Controls.LayeredTrackBar();
            this.skinPanel_yycd = new CCWin.SkinControl.SkinPanel();
            this.skinLabel_yycd = new CCWin.SkinControl.SkinLabel();
            this.skinPanel_dqjd = new CCWin.SkinControl.SkinPanel();
            this.skinLabel_ybfcd = new CCWin.SkinControl.SkinLabel();
            this.skinPanel_otherButtons = new CCWin.SkinControl.SkinPanel();
            this.skinButton_volume = new CCWin.SkinControl.SkinButton();
            this.layeredTrackBar_yljdt = new LayeredSkin.Controls.LayeredTrackBar();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.skinLabel_playListCount = new CCWin.SkinControl.SkinLabel();
            this.skinButton_openPlayList = new CCWin.SkinControl.SkinButton();
            this.skinButton_Lyric = new CCWin.SkinControl.SkinButton();
            this.skinButton_bfsx = new CCWin.SkinControl.SkinButton();
            this.radiusControlButton1 = new MusicNetease.Controls.RadiusControlButton();
            this.skinPanel_buttons.SuspendLayout();
            this.skinPanel_play.SuspendLayout();
            this.skinPanel_sys.SuspendLayout();
            this.skinPanel_bfjdt.SuspendLayout();
            this.skinPanel_jdt.SuspendLayout();
            this.skinPanel_yycd.SuspendLayout();
            this.skinPanel_dqjd.SuspendLayout();
            this.skinPanel_otherButtons.SuspendLayout();
            this.skinPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinPanel_buttons
            // 
            this.skinPanel_buttons.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel_buttons.Controls.Add(this.radiusControlButton1);
            this.skinPanel_buttons.Controls.Add(this.skinPanel_play);
            this.skinPanel_buttons.Controls.Add(this.skinPanel_sys);
            this.skinPanel_buttons.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel_buttons.Dock = System.Windows.Forms.DockStyle.Left;
            this.skinPanel_buttons.DownBack = null;
            this.skinPanel_buttons.Location = new System.Drawing.Point(0, 0);
            this.skinPanel_buttons.MouseBack = null;
            this.skinPanel_buttons.Name = "skinPanel_buttons";
            this.skinPanel_buttons.NormlBack = null;
            this.skinPanel_buttons.Size = new System.Drawing.Size(206, 49);
            this.skinPanel_buttons.TabIndex = 0;
            // 
            // skinPanel_play
            // 
            this.skinPanel_play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
            this.skinPanel_play.Controls.Add(this.skinButton_play);
            this.skinPanel_play.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel_play.DownBack = null;
            this.skinPanel_play.Location = new System.Drawing.Point(82, 5);
            this.skinPanel_play.MouseBack = null;
            this.skinPanel_play.Name = "skinPanel_play";
            this.skinPanel_play.NormlBack = null;
            this.skinPanel_play.Radius = 40;
            this.skinPanel_play.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinPanel_play.Size = new System.Drawing.Size(40, 40);
            this.skinPanel_play.TabIndex = 1;
            this.skinPanel_play.MouseEnter += new System.EventHandler(this.skinButton_MouseEnter);
            // 
            // skinButton_play
            // 
            this.skinButton_play.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_play.BackgroundImage = global::MusicNetease.Properties.Resources.play;
            this.skinButton_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.skinButton_play.BackRectangle = new System.Drawing.Rectangle(10, 10, 40, 40);
            this.skinButton_play.BaseColor = System.Drawing.Color.Transparent;
            this.skinButton_play.BorderColor = System.Drawing.Color.Transparent;
            this.skinButton_play.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinButton_play.DownBack = null;
            this.skinButton_play.DownBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_play.FadeGlow = false;
            this.skinButton_play.GlowColor = System.Drawing.Color.Transparent;
            this.skinButton_play.ImageSize = new System.Drawing.Size(40, 40);
            this.skinButton_play.InnerBorderColor = System.Drawing.Color.Transparent;
            this.skinButton_play.IsDrawBorder = false;
            this.skinButton_play.IsDrawGlass = false;
            this.skinButton_play.Location = new System.Drawing.Point(0, 0);
            this.skinButton_play.MouseBack = null;
            this.skinButton_play.MouseBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_play.Name = "skinButton_play";
            this.skinButton_play.NormlBack = null;
            this.skinButton_play.Size = new System.Drawing.Size(40, 40);
            this.skinButton_play.TabIndex = 7;
            this.skinButton_play.Tag = "播放";
            this.skinButton_play.UseVisualStyleBackColor = false;
            this.skinButton_play.Click += new System.EventHandler(this.skinButton_play_Click);
            this.skinButton_play.MouseEnter += new System.EventHandler(this.skinButton_MouseEnter);
            // 
            // skinPanel_sys
            // 
            this.skinPanel_sys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
            this.skinPanel_sys.Controls.Add(this.skinButton_sys);
            this.skinPanel_sys.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel_sys.DownBack = null;
            this.skinPanel_sys.Location = new System.Drawing.Point(15, 5);
            this.skinPanel_sys.MouseBack = null;
            this.skinPanel_sys.Name = "skinPanel_sys";
            this.skinPanel_sys.NormlBack = null;
            this.skinPanel_sys.Radius = 40;
            this.skinPanel_sys.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinPanel_sys.Size = new System.Drawing.Size(40, 40);
            this.skinPanel_sys.TabIndex = 0;
            this.skinPanel_sys.MouseEnter += new System.EventHandler(this.skinButton_MouseEnter);
            // 
            // skinButton_sys
            // 
            this.skinButton_sys.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_sys.BackgroundImage = global::MusicNetease.Properties.Resources.sys;
            this.skinButton_sys.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.skinButton_sys.BackRectangle = new System.Drawing.Rectangle(10, 10, 40, 40);
            this.skinButton_sys.BaseColor = System.Drawing.Color.Transparent;
            this.skinButton_sys.BorderColor = System.Drawing.Color.Transparent;
            this.skinButton_sys.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_sys.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinButton_sys.DownBack = null;
            this.skinButton_sys.DownBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_sys.FadeGlow = false;
            this.skinButton_sys.GlowColor = System.Drawing.Color.Transparent;
            this.skinButton_sys.ImageSize = new System.Drawing.Size(20, 20);
            this.skinButton_sys.InnerBorderColor = System.Drawing.Color.Transparent;
            this.skinButton_sys.IsDrawBorder = false;
            this.skinButton_sys.IsDrawGlass = false;
            this.skinButton_sys.Location = new System.Drawing.Point(0, 0);
            this.skinButton_sys.MouseBack = null;
            this.skinButton_sys.MouseBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_sys.Name = "skinButton_sys";
            this.skinButton_sys.NormlBack = null;
            this.skinButton_sys.Size = new System.Drawing.Size(40, 40);
            this.skinButton_sys.TabIndex = 7;
            this.skinButton_sys.Tag = "上一首";
            this.skinButton_sys.UseVisualStyleBackColor = false;
            this.skinButton_sys.MouseEnter += new System.EventHandler(this.skinButton_MouseEnter);
            // 
            // skinToolTip1
            // 
            this.skinToolTip1.AutoPopDelay = 5000;
            this.skinToolTip1.InitialDelay = 500;
            this.skinToolTip1.OwnerDraw = true;
            this.skinToolTip1.ReshowDelay = 800;
            // 
            // skinPanel_bfjdt
            // 
            this.skinPanel_bfjdt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinPanel_bfjdt.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel_bfjdt.Controls.Add(this.skinPanel_jdt);
            this.skinPanel_bfjdt.Controls.Add(this.skinPanel_yycd);
            this.skinPanel_bfjdt.Controls.Add(this.skinPanel_dqjd);
            this.skinPanel_bfjdt.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel_bfjdt.DownBack = null;
            this.skinPanel_bfjdt.Location = new System.Drawing.Point(206, 0);
            this.skinPanel_bfjdt.MouseBack = null;
            this.skinPanel_bfjdt.Name = "skinPanel_bfjdt";
            this.skinPanel_bfjdt.NormlBack = null;
            this.skinPanel_bfjdt.Size = new System.Drawing.Size(485, 49);
            this.skinPanel_bfjdt.TabIndex = 1;
            // 
            // skinPanel_jdt
            // 
            this.skinPanel_jdt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinPanel_jdt.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel_jdt.Controls.Add(this.layeredTrackBar_yyjdt);
            this.skinPanel_jdt.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel_jdt.DownBack = null;
            this.skinPanel_jdt.Location = new System.Drawing.Point(45, 0);
            this.skinPanel_jdt.MouseBack = null;
            this.skinPanel_jdt.Name = "skinPanel_jdt";
            this.skinPanel_jdt.NormlBack = null;
            this.skinPanel_jdt.Size = new System.Drawing.Size(388, 49);
            this.skinPanel_jdt.TabIndex = 4;
            // 
            // layeredTrackBar_yyjdt
            // 
            this.layeredTrackBar_yyjdt.AdaptImage = true;
            this.layeredTrackBar_yyjdt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layeredTrackBar_yyjdt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.layeredTrackBar_yyjdt.BackImage = null;
            this.layeredTrackBar_yyjdt.BackLineColor = System.Drawing.Color.Gray;
            this.layeredTrackBar_yyjdt.Borders.BottomColor = System.Drawing.Color.Empty;
            this.layeredTrackBar_yyjdt.Borders.BottomWidth = 0;
            this.layeredTrackBar_yyjdt.Borders.LeftColor = System.Drawing.Color.Empty;
            this.layeredTrackBar_yyjdt.Borders.LeftWidth = 0;
            this.layeredTrackBar_yyjdt.Borders.RightColor = System.Drawing.Color.Empty;
            this.layeredTrackBar_yyjdt.Borders.RightWidth = 0;
            this.layeredTrackBar_yyjdt.Borders.TopColor = System.Drawing.Color.Empty;
            this.layeredTrackBar_yyjdt.Borders.TopWidth = 0;
            this.layeredTrackBar_yyjdt.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("layeredTrackBar_yyjdt.Canvas")));
            this.layeredTrackBar_yyjdt.ControlRectangle = new System.Drawing.Rectangle(5, 5, 380, 5);
            this.layeredTrackBar_yyjdt.LineWidth = 3;
            this.layeredTrackBar_yyjdt.Location = new System.Drawing.Point(0, 18);
            this.layeredTrackBar_yyjdt.Margin = new System.Windows.Forms.Padding(0);
            this.layeredTrackBar_yyjdt.MouseCanControl = true;
            this.layeredTrackBar_yyjdt.Name = "layeredTrackBar_yyjdt";
            this.layeredTrackBar_yyjdt.Orientation = LayeredSkin.Controls.Orientations.Horizontal;
            this.layeredTrackBar_yyjdt.PointImage = global::MusicNetease.Properties.Resources.layeredTrackBar1_PointImage;
            this.layeredTrackBar_yyjdt.PointImageHover = global::MusicNetease.Properties.Resources.layeredTrackBar1_PointImageHover;
            this.layeredTrackBar_yyjdt.PointImagePressed = global::MusicNetease.Properties.Resources.layeredTrackBar1_PointImagePressed;
            this.layeredTrackBar_yyjdt.PointState = LayeredSkin.Controls.ControlStates.Normal;
            this.layeredTrackBar_yyjdt.Size = new System.Drawing.Size(390, 15);
            this.layeredTrackBar_yyjdt.SurfaceImage = null;
            this.layeredTrackBar_yyjdt.SurfaceLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
            this.layeredTrackBar_yyjdt.TabIndex = 3;
            this.layeredTrackBar_yyjdt.Value = 0.7563D;
            // 
            // skinPanel_yycd
            // 
            this.skinPanel_yycd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinPanel_yycd.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel_yycd.Controls.Add(this.skinLabel_yycd);
            this.skinPanel_yycd.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel_yycd.DownBack = null;
            this.skinPanel_yycd.Location = new System.Drawing.Point(434, 0);
            this.skinPanel_yycd.MouseBack = null;
            this.skinPanel_yycd.Name = "skinPanel_yycd";
            this.skinPanel_yycd.NormlBack = null;
            this.skinPanel_yycd.Size = new System.Drawing.Size(51, 49);
            this.skinPanel_yycd.TabIndex = 5;
            // 
            // skinLabel_yycd
            // 
            this.skinLabel_yycd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinLabel_yycd.AutoSize = true;
            this.skinLabel_yycd.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel_yycd.BorderColor = System.Drawing.Color.White;
            this.skinLabel_yycd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel_yycd.Location = new System.Drawing.Point(5, 16);
            this.skinLabel_yycd.Name = "skinLabel_yycd";
            this.skinLabel_yycd.Size = new System.Drawing.Size(39, 17);
            this.skinLabel_yycd.TabIndex = 1;
            this.skinLabel_yycd.Tag = "音乐长度";
            this.skinLabel_yycd.Text = "02:59";
            // 
            // skinPanel_dqjd
            // 
            this.skinPanel_dqjd.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel_dqjd.Controls.Add(this.skinLabel_ybfcd);
            this.skinPanel_dqjd.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel_dqjd.Dock = System.Windows.Forms.DockStyle.Left;
            this.skinPanel_dqjd.DownBack = null;
            this.skinPanel_dqjd.Location = new System.Drawing.Point(0, 0);
            this.skinPanel_dqjd.MouseBack = null;
            this.skinPanel_dqjd.Name = "skinPanel_dqjd";
            this.skinPanel_dqjd.NormlBack = null;
            this.skinPanel_dqjd.Size = new System.Drawing.Size(45, 49);
            this.skinPanel_dqjd.TabIndex = 3;
            // 
            // skinLabel_ybfcd
            // 
            this.skinLabel_ybfcd.AutoSize = true;
            this.skinLabel_ybfcd.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel_ybfcd.BorderColor = System.Drawing.Color.White;
            this.skinLabel_ybfcd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel_ybfcd.Location = new System.Drawing.Point(4, 16);
            this.skinLabel_ybfcd.Name = "skinLabel_ybfcd";
            this.skinLabel_ybfcd.Size = new System.Drawing.Size(39, 17);
            this.skinLabel_ybfcd.TabIndex = 0;
            this.skinLabel_ybfcd.Tag = "已播放长度";
            this.skinLabel_ybfcd.Text = "01:30";
            this.skinLabel_ybfcd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skinPanel_otherButtons
            // 
            this.skinPanel_otherButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinPanel_otherButtons.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel_otherButtons.Controls.Add(this.skinButton_volume);
            this.skinPanel_otherButtons.Controls.Add(this.layeredTrackBar_yljdt);
            this.skinPanel_otherButtons.Controls.Add(this.skinPanel1);
            this.skinPanel_otherButtons.Controls.Add(this.skinButton_openPlayList);
            this.skinPanel_otherButtons.Controls.Add(this.skinButton_Lyric);
            this.skinPanel_otherButtons.Controls.Add(this.skinButton_bfsx);
            this.skinPanel_otherButtons.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel_otherButtons.DownBack = null;
            this.skinPanel_otherButtons.Location = new System.Drawing.Point(687, 0);
            this.skinPanel_otherButtons.MouseBack = null;
            this.skinPanel_otherButtons.Name = "skinPanel_otherButtons";
            this.skinPanel_otherButtons.NormlBack = null;
            this.skinPanel_otherButtons.Size = new System.Drawing.Size(267, 49);
            this.skinPanel_otherButtons.TabIndex = 2;
            // 
            // skinButton_volume
            // 
            this.skinButton_volume.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_volume.BackgroundImage = global::MusicNetease.Properties.Resources.volume0;
            this.skinButton_volume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.skinButton_volume.BackRectangle = new System.Drawing.Rectangle(10, 10, 16, 16);
            this.skinButton_volume.BaseColor = System.Drawing.Color.Transparent;
            this.skinButton_volume.BorderColor = System.Drawing.Color.Transparent;
            this.skinButton_volume.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_volume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinButton_volume.DownBack = global::MusicNetease.Properties.Resources.volume1;
            this.skinButton_volume.DownBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_volume.FadeGlow = false;
            this.skinButton_volume.GlowColor = System.Drawing.Color.Transparent;
            this.skinButton_volume.ImageSize = new System.Drawing.Size(20, 20);
            this.skinButton_volume.InnerBorderColor = System.Drawing.Color.Transparent;
            this.skinButton_volume.IsDrawBorder = false;
            this.skinButton_volume.IsDrawGlass = false;
            this.skinButton_volume.Location = new System.Drawing.Point(3, 17);
            this.skinButton_volume.MouseBack = global::MusicNetease.Properties.Resources.volume1;
            this.skinButton_volume.MouseBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_volume.Name = "skinButton_volume";
            this.skinButton_volume.NormlBack = global::MusicNetease.Properties.Resources.volume0;
            this.skinButton_volume.Size = new System.Drawing.Size(16, 16);
            this.skinButton_volume.TabIndex = 7;
            this.skinButton_volume.Tag = "音量";
            this.skinButton_volume.UseVisualStyleBackColor = false;
            this.skinButton_volume.Click += new System.EventHandler(this.skinButton_volume_Click);
            this.skinButton_volume.MouseEnter += new System.EventHandler(this.skinButton_MouseEnter);
            // 
            // layeredTrackBar_yljdt
            // 
            this.layeredTrackBar_yljdt.AdaptImage = true;
            this.layeredTrackBar_yljdt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layeredTrackBar_yljdt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.layeredTrackBar_yljdt.BackImage = null;
            this.layeredTrackBar_yljdt.BackLineColor = System.Drawing.Color.Gray;
            this.layeredTrackBar_yljdt.Borders.BottomColor = System.Drawing.Color.Empty;
            this.layeredTrackBar_yljdt.Borders.BottomWidth = 0;
            this.layeredTrackBar_yljdt.Borders.LeftColor = System.Drawing.Color.Empty;
            this.layeredTrackBar_yljdt.Borders.LeftWidth = 0;
            this.layeredTrackBar_yljdt.Borders.RightColor = System.Drawing.Color.Empty;
            this.layeredTrackBar_yljdt.Borders.RightWidth = 0;
            this.layeredTrackBar_yljdt.Borders.TopColor = System.Drawing.Color.Empty;
            this.layeredTrackBar_yljdt.Borders.TopWidth = 0;
            this.layeredTrackBar_yljdt.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("layeredTrackBar_yljdt.Canvas")));
            this.layeredTrackBar_yljdt.ControlRectangle = new System.Drawing.Rectangle(5, 5, 105, 5);
            this.layeredTrackBar_yljdt.LineWidth = 3;
            this.layeredTrackBar_yljdt.Location = new System.Drawing.Point(16, 17);
            this.layeredTrackBar_yljdt.Margin = new System.Windows.Forms.Padding(0);
            this.layeredTrackBar_yljdt.MouseCanControl = true;
            this.layeredTrackBar_yljdt.Name = "layeredTrackBar_yljdt";
            this.layeredTrackBar_yljdt.Orientation = LayeredSkin.Controls.Orientations.Horizontal;
            this.layeredTrackBar_yljdt.PointImage = global::MusicNetease.Properties.Resources.layeredTrackBar1_PointImage;
            this.layeredTrackBar_yljdt.PointImageHover = global::MusicNetease.Properties.Resources.layeredTrackBar1_PointImageHover;
            this.layeredTrackBar_yljdt.PointImagePressed = global::MusicNetease.Properties.Resources.layeredTrackBar1_PointImagePressed;
            this.layeredTrackBar_yljdt.PointState = LayeredSkin.Controls.ControlStates.Normal;
            this.layeredTrackBar_yljdt.Size = new System.Drawing.Size(115, 15);
            this.layeredTrackBar_yljdt.SurfaceImage = null;
            this.layeredTrackBar_yljdt.SurfaceLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
            this.layeredTrackBar_yljdt.TabIndex = 13;
            this.layeredTrackBar_yljdt.Value = 0.7563D;
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.skinLabel_playListCount);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = global::MusicNetease.Properties.Resources.skinPanel1_NormlBack;
            this.skinPanel1.Location = new System.Drawing.Point(226, 16);
            this.skinPanel1.MouseBack = global::MusicNetease.Properties.Resources.skinPanel1_NormlBack;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = global::MusicNetease.Properties.Resources.skinPanel1_NormlBack;
            this.skinPanel1.Radius = 20;
            this.skinPanel1.RoundStyle = CCWin.SkinClass.RoundStyle.Right;
            this.skinPanel1.Size = new System.Drawing.Size(25, 20);
            this.skinPanel1.TabIndex = 12;
            // 
            // skinLabel_playListCount
            // 
            this.skinLabel_playListCount.AutoSize = true;
            this.skinLabel_playListCount.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel_playListCount.BorderColor = System.Drawing.Color.White;
            this.skinLabel_playListCount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinLabel_playListCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinLabel_playListCount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel_playListCount.Location = new System.Drawing.Point(0, 0);
            this.skinLabel_playListCount.Name = "skinLabel_playListCount";
            this.skinLabel_playListCount.Size = new System.Drawing.Size(22, 17);
            this.skinLabel_playListCount.TabIndex = 0;
            this.skinLabel_playListCount.Tag = "打开播放列表";
            this.skinLabel_playListCount.Text = "25";
            this.skinLabel_playListCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.skinLabel_playListCount.MouseEnter += new System.EventHandler(this.skinButton_MouseEnter);
            this.skinLabel_playListCount.MouseLeave += new System.EventHandler(this.skinButton_openPlayList_MouseLeave);
            this.skinLabel_playListCount.MouseHover += new System.EventHandler(this.skinButton_openPlayList_MouseHover);
            // 
            // skinButton_openPlayList
            // 
            this.skinButton_openPlayList.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_openPlayList.BackgroundImage = global::MusicNetease.Properties.Resources.playList0;
            this.skinButton_openPlayList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.skinButton_openPlayList.BackRectangle = new System.Drawing.Rectangle(10, 10, 20, 20);
            this.skinButton_openPlayList.BaseColor = System.Drawing.Color.Transparent;
            this.skinButton_openPlayList.BorderColor = System.Drawing.Color.Transparent;
            this.skinButton_openPlayList.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_openPlayList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinButton_openPlayList.DownBack = global::MusicNetease.Properties.Resources.playList1;
            this.skinButton_openPlayList.DownBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_openPlayList.FadeGlow = false;
            this.skinButton_openPlayList.GlowColor = System.Drawing.Color.Transparent;
            this.skinButton_openPlayList.ImageSize = new System.Drawing.Size(20, 20);
            this.skinButton_openPlayList.InnerBorderColor = System.Drawing.Color.Transparent;
            this.skinButton_openPlayList.IsDrawBorder = false;
            this.skinButton_openPlayList.IsDrawGlass = false;
            this.skinButton_openPlayList.Location = new System.Drawing.Point(208, 16);
            this.skinButton_openPlayList.MouseBack = global::MusicNetease.Properties.Resources.playList1;
            this.skinButton_openPlayList.MouseBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_openPlayList.Name = "skinButton_openPlayList";
            this.skinButton_openPlayList.NormlBack = global::MusicNetease.Properties.Resources.playList0;
            this.skinButton_openPlayList.Size = new System.Drawing.Size(20, 20);
            this.skinButton_openPlayList.TabIndex = 11;
            this.skinButton_openPlayList.Tag = "打开播放列表";
            this.skinButton_openPlayList.UseVisualStyleBackColor = false;
            this.skinButton_openPlayList.Click += new System.EventHandler(this.skinButton_openPlayList_Click);
            this.skinButton_openPlayList.MouseEnter += new System.EventHandler(this.skinButton_MouseEnter);
            this.skinButton_openPlayList.MouseLeave += new System.EventHandler(this.skinButton_openPlayList_MouseLeave);
            this.skinButton_openPlayList.MouseHover += new System.EventHandler(this.skinButton_openPlayList_MouseHover);
            // 
            // skinButton_Lyric
            // 
            this.skinButton_Lyric.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_Lyric.BackgroundImage = global::MusicNetease.Properties.Resources.lyric0;
            this.skinButton_Lyric.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.skinButton_Lyric.BackRectangle = new System.Drawing.Rectangle(10, 10, 20, 20);
            this.skinButton_Lyric.BaseColor = System.Drawing.Color.Transparent;
            this.skinButton_Lyric.BorderColor = System.Drawing.Color.Transparent;
            this.skinButton_Lyric.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_Lyric.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinButton_Lyric.DownBack = global::MusicNetease.Properties.Resources.lyric1;
            this.skinButton_Lyric.DownBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_Lyric.FadeGlow = false;
            this.skinButton_Lyric.GlowColor = System.Drawing.Color.Transparent;
            this.skinButton_Lyric.ImageSize = new System.Drawing.Size(20, 20);
            this.skinButton_Lyric.InnerBorderColor = System.Drawing.Color.Transparent;
            this.skinButton_Lyric.IsDrawBorder = false;
            this.skinButton_Lyric.IsDrawGlass = false;
            this.skinButton_Lyric.Location = new System.Drawing.Point(175, 16);
            this.skinButton_Lyric.MouseBack = global::MusicNetease.Properties.Resources.lyric1;
            this.skinButton_Lyric.MouseBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_Lyric.Name = "skinButton_Lyric";
            this.skinButton_Lyric.NormlBack = global::MusicNetease.Properties.Resources.lyric0;
            this.skinButton_Lyric.Size = new System.Drawing.Size(20, 20);
            this.skinButton_Lyric.TabIndex = 10;
            this.skinButton_Lyric.Tag = "打开歌词";
            this.skinButton_Lyric.UseVisualStyleBackColor = false;
            this.skinButton_Lyric.Click += new System.EventHandler(this.skinButton_Lyric_Click);
            this.skinButton_Lyric.MouseEnter += new System.EventHandler(this.skinButton_MouseEnter);
            this.skinButton_Lyric.MouseLeave += new System.EventHandler(this.skinButton_Lyric_MouseLeave);
            this.skinButton_Lyric.MouseHover += new System.EventHandler(this.skinButton_Lyric_MouseHover);
            // 
            // skinButton_bfsx
            // 
            this.skinButton_bfsx.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_bfsx.BackgroundImage = global::MusicNetease.Properties.Resources.sxbf0;
            this.skinButton_bfsx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.skinButton_bfsx.BackRectangle = new System.Drawing.Rectangle(10, 10, 20, 20);
            this.skinButton_bfsx.BaseColor = System.Drawing.Color.Transparent;
            this.skinButton_bfsx.BorderColor = System.Drawing.Color.Transparent;
            this.skinButton_bfsx.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_bfsx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinButton_bfsx.DownBack = global::MusicNetease.Properties.Resources.sxbf1;
            this.skinButton_bfsx.DownBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_bfsx.FadeGlow = false;
            this.skinButton_bfsx.GlowColor = System.Drawing.Color.Transparent;
            this.skinButton_bfsx.ImageSize = new System.Drawing.Size(20, 20);
            this.skinButton_bfsx.InnerBorderColor = System.Drawing.Color.Transparent;
            this.skinButton_bfsx.IsDrawBorder = false;
            this.skinButton_bfsx.IsDrawGlass = false;
            this.skinButton_bfsx.Location = new System.Drawing.Point(142, 16);
            this.skinButton_bfsx.MouseBack = global::MusicNetease.Properties.Resources.sxbf1;
            this.skinButton_bfsx.MouseBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_bfsx.Name = "skinButton_bfsx";
            this.skinButton_bfsx.NormlBack = global::MusicNetease.Properties.Resources.sxbf0;
            this.skinButton_bfsx.Size = new System.Drawing.Size(20, 20);
            this.skinButton_bfsx.TabIndex = 9;
            this.skinButton_bfsx.Tag = "顺序播放";
            this.skinButton_bfsx.UseVisualStyleBackColor = false;
            this.skinButton_bfsx.Click += new System.EventHandler(this.skinButton_bfsx_Click);
            this.skinButton_bfsx.MouseEnter += new System.EventHandler(this.skinButton_MouseEnter);
            this.skinButton_bfsx.MouseLeave += new System.EventHandler(this.skinButton_bfsx_MouseLeave);
            this.skinButton_bfsx.MouseHover += new System.EventHandler(this.skinButton_bfsx_MouseHover);
            // 
            // radiusControlButton1
            // 
            this.radiusControlButton1.BackColor = System.Drawing.Color.Transparent;
            this.radiusControlButton1.Location = new System.Drawing.Point(144, 5);
            this.radiusControlButton1.Name = "radiusControlButton1";
            this.radiusControlButton1.Radius = 40;
            this.radiusControlButton1.SetBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
            this.radiusControlButton1.Size = new System.Drawing.Size(40, 40);
            this.radiusControlButton1.TabIndex = 2;
            // 
            // MusicPlayerButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.skinPanel_otherButtons);
            this.Controls.Add(this.skinPanel_bfjdt);
            this.Controls.Add(this.skinPanel_buttons);
            this.Name = "MusicPlayerButton";
            this.Size = new System.Drawing.Size(954, 49);
            this.skinPanel_buttons.ResumeLayout(false);
            this.skinPanel_play.ResumeLayout(false);
            this.skinPanel_sys.ResumeLayout(false);
            this.skinPanel_bfjdt.ResumeLayout(false);
            this.skinPanel_jdt.ResumeLayout(false);
            this.skinPanel_yycd.ResumeLayout(false);
            this.skinPanel_yycd.PerformLayout();
            this.skinPanel_dqjd.ResumeLayout(false);
            this.skinPanel_dqjd.PerformLayout();
            this.skinPanel_otherButtons.ResumeLayout(false);
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinPanel skinPanel_buttons;
        private CCWin.SkinControl.SkinPanel skinPanel_play;
        private CCWin.SkinControl.SkinPanel skinPanel_sys;
        private CCWin.SkinControl.SkinButton skinButton_play;
        private CCWin.SkinControl.SkinButton skinButton_sys;
        private CCWin.SkinToolTip skinToolTip1;
        private CCWin.SkinControl.SkinPanel skinPanel_bfjdt;
        private CCWin.SkinControl.SkinLabel skinLabel_ybfcd;
        private CCWin.SkinControl.SkinLabel skinLabel_yycd;
        private CCWin.SkinControl.SkinPanel skinPanel_otherButtons;
        private CCWin.SkinControl.SkinButton skinButton_volume;
        private CCWin.SkinControl.SkinButton skinButton_bfsx;
        private CCWin.SkinControl.SkinButton skinButton_Lyric;
        private CCWin.SkinControl.SkinButton skinButton_openPlayList;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinLabel skinLabel_playListCount;
        private CCWin.SkinControl.SkinPanel skinPanel_jdt;
        private CCWin.SkinControl.SkinPanel skinPanel_dqjd;
        private CCWin.SkinControl.SkinPanel skinPanel_yycd;
        private LayeredSkin.Controls.LayeredTrackBar layeredTrackBar_yyjdt;
        private LayeredSkin.Controls.LayeredTrackBar layeredTrackBar_yljdt;
        private RadiusControlButton radiusControlButton1;
    }
}
