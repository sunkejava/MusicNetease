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
            this.skinPanel_buttons = new CCWin.SkinControl.SkinPanel();
            this.skinPanel_xys = new CCWin.SkinControl.SkinPanel();
            this.skinButton_xys = new CCWin.SkinControl.SkinButton();
            this.skinPanel_play = new CCWin.SkinControl.SkinPanel();
            this.skinButton_play = new CCWin.SkinControl.SkinButton();
            this.skinPanel_sys = new CCWin.SkinControl.SkinPanel();
            this.skinButton_sys = new CCWin.SkinControl.SkinButton();
            this.skinToolTip1 = new CCWin.SkinToolTip(this.components);
            this.skinPanel_bfjdt = new CCWin.SkinControl.SkinPanel();
            this.skinProgressBar_yyjdt = new CCWin.SkinControl.SkinProgressBar();
            this.skinLabel_yycd = new CCWin.SkinControl.SkinLabel();
            this.skinLabel_ybfcd = new CCWin.SkinControl.SkinLabel();
            this.skinPanel_otherButtons = new CCWin.SkinControl.SkinPanel();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.skinLabel_playListCount = new CCWin.SkinControl.SkinLabel();
            this.skinButton_openPlayList = new CCWin.SkinControl.SkinButton();
            this.skinButton_Lyric = new CCWin.SkinControl.SkinButton();
            this.skinButton_bfsx = new CCWin.SkinControl.SkinButton();
            this.skinProgressBar_volume = new CCWin.SkinControl.SkinProgressBar();
            this.skinButton_volume = new CCWin.SkinControl.SkinButton();
            this.skinPanel_buttons.SuspendLayout();
            this.skinPanel_xys.SuspendLayout();
            this.skinPanel_play.SuspendLayout();
            this.skinPanel_sys.SuspendLayout();
            this.skinPanel_bfjdt.SuspendLayout();
            this.skinPanel_otherButtons.SuspendLayout();
            this.skinPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinPanel_buttons
            // 
            this.skinPanel_buttons.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel_buttons.Controls.Add(this.skinPanel_xys);
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
            // skinPanel_xys
            // 
            this.skinPanel_xys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
            this.skinPanel_xys.Controls.Add(this.skinButton_xys);
            this.skinPanel_xys.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel_xys.DownBack = null;
            this.skinPanel_xys.Location = new System.Drawing.Point(150, 5);
            this.skinPanel_xys.MouseBack = null;
            this.skinPanel_xys.Name = "skinPanel_xys";
            this.skinPanel_xys.NormlBack = null;
            this.skinPanel_xys.Radius = 40;
            this.skinPanel_xys.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinPanel_xys.Size = new System.Drawing.Size(40, 40);
            this.skinPanel_xys.TabIndex = 2;
            this.skinPanel_xys.MouseEnter += new System.EventHandler(this.skinButton_MouseEnter);
            // 
            // skinButton_xys
            // 
            this.skinButton_xys.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_xys.BackgroundImage = global::MusicNetease.Properties.Resources.xys;
            this.skinButton_xys.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.skinButton_xys.BackRectangle = new System.Drawing.Rectangle(10, 10, 40, 40);
            this.skinButton_xys.BaseColor = System.Drawing.Color.Transparent;
            this.skinButton_xys.BorderColor = System.Drawing.Color.Transparent;
            this.skinButton_xys.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_xys.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinButton_xys.DownBack = null;
            this.skinButton_xys.DownBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_xys.GlowColor = System.Drawing.Color.Transparent;
            this.skinButton_xys.ImageSize = new System.Drawing.Size(40, 40);
            this.skinButton_xys.InnerBorderColor = System.Drawing.Color.Transparent;
            this.skinButton_xys.IsDrawBorder = false;
            this.skinButton_xys.IsDrawGlass = false;
            this.skinButton_xys.Location = new System.Drawing.Point(0, 0);
            this.skinButton_xys.MouseBack = null;
            this.skinButton_xys.MouseBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_xys.Name = "skinButton_xys";
            this.skinButton_xys.NormlBack = null;
            this.skinButton_xys.Size = new System.Drawing.Size(40, 40);
            this.skinButton_xys.TabIndex = 7;
            this.skinButton_xys.Tag = "下一首";
            this.skinButton_xys.UseVisualStyleBackColor = false;
            this.skinButton_xys.MouseEnter += new System.EventHandler(this.skinButton_MouseEnter);
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
            this.skinPanel_bfjdt.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel_bfjdt.Controls.Add(this.skinProgressBar_yyjdt);
            this.skinPanel_bfjdt.Controls.Add(this.skinLabel_yycd);
            this.skinPanel_bfjdt.Controls.Add(this.skinLabel_ybfcd);
            this.skinPanel_bfjdt.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel_bfjdt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinPanel_bfjdt.DownBack = null;
            this.skinPanel_bfjdt.Location = new System.Drawing.Point(206, 0);
            this.skinPanel_bfjdt.MouseBack = null;
            this.skinPanel_bfjdt.Name = "skinPanel_bfjdt";
            this.skinPanel_bfjdt.NormlBack = null;
            this.skinPanel_bfjdt.Size = new System.Drawing.Size(748, 49);
            this.skinPanel_bfjdt.TabIndex = 1;
            // 
            // skinProgressBar_yyjdt
            // 
            this.skinProgressBar_yyjdt.Back = null;
            this.skinProgressBar_yyjdt.BackColor = System.Drawing.Color.Transparent;
            this.skinProgressBar_yyjdt.BarBack = null;
            this.skinProgressBar_yyjdt.BarRadius = 6;
            this.skinProgressBar_yyjdt.BarRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinProgressBar_yyjdt.Border = System.Drawing.Color.DarkGray;
            this.skinProgressBar_yyjdt.ForeColor = System.Drawing.Color.Transparent;
            this.skinProgressBar_yyjdt.InnerBorder = System.Drawing.Color.DarkGray;
            this.skinProgressBar_yyjdt.Location = new System.Drawing.Point(51, 22);
            this.skinProgressBar_yyjdt.Name = "skinProgressBar_yyjdt";
            this.skinProgressBar_yyjdt.Radius = 6;
            this.skinProgressBar_yyjdt.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinProgressBar_yyjdt.Size = new System.Drawing.Size(380, 6);
            this.skinProgressBar_yyjdt.Step = 1;
            this.skinProgressBar_yyjdt.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.skinProgressBar_yyjdt.TabIndex = 2;
            this.skinProgressBar_yyjdt.TextFormat = CCWin.SkinControl.SkinProgressBar.TxtFormat.None;
            this.skinProgressBar_yyjdt.TrackBack = System.Drawing.Color.DarkGray;
            this.skinProgressBar_yyjdt.TrackFore = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
            this.skinProgressBar_yyjdt.Value = 50;
            // 
            // skinLabel_yycd
            // 
            this.skinLabel_yycd.AutoSize = true;
            this.skinLabel_yycd.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel_yycd.BorderColor = System.Drawing.Color.White;
            this.skinLabel_yycd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel_yycd.Location = new System.Drawing.Point(439, 16);
            this.skinLabel_yycd.Name = "skinLabel_yycd";
            this.skinLabel_yycd.Size = new System.Drawing.Size(39, 17);
            this.skinLabel_yycd.TabIndex = 1;
            this.skinLabel_yycd.Tag = "音乐长度";
            this.skinLabel_yycd.Text = "02:59";
            // 
            // skinLabel_ybfcd
            // 
            this.skinLabel_ybfcd.AutoSize = true;
            this.skinLabel_ybfcd.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel_ybfcd.BorderColor = System.Drawing.Color.White;
            this.skinLabel_ybfcd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel_ybfcd.Location = new System.Drawing.Point(9, 16);
            this.skinLabel_ybfcd.Name = "skinLabel_ybfcd";
            this.skinLabel_ybfcd.Size = new System.Drawing.Size(39, 17);
            this.skinLabel_ybfcd.TabIndex = 0;
            this.skinLabel_ybfcd.Tag = "已播放长度";
            this.skinLabel_ybfcd.Text = "01:30";
            this.skinLabel_ybfcd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skinPanel_otherButtons
            // 
            this.skinPanel_otherButtons.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel_otherButtons.Controls.Add(this.skinPanel1);
            this.skinPanel_otherButtons.Controls.Add(this.skinButton_openPlayList);
            this.skinPanel_otherButtons.Controls.Add(this.skinButton_Lyric);
            this.skinPanel_otherButtons.Controls.Add(this.skinButton_bfsx);
            this.skinPanel_otherButtons.Controls.Add(this.skinProgressBar_volume);
            this.skinPanel_otherButtons.Controls.Add(this.skinButton_volume);
            this.skinPanel_otherButtons.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel_otherButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.skinPanel_otherButtons.DownBack = null;
            this.skinPanel_otherButtons.Location = new System.Drawing.Point(687, 0);
            this.skinPanel_otherButtons.MouseBack = null;
            this.skinPanel_otherButtons.Name = "skinPanel_otherButtons";
            this.skinPanel_otherButtons.NormlBack = null;
            this.skinPanel_otherButtons.Size = new System.Drawing.Size(267, 49);
            this.skinPanel_otherButtons.TabIndex = 2;
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
            this.skinLabel_playListCount.Text = "25";
            this.skinLabel_playListCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // skinButton_openPlayList
            // 
            this.skinButton_openPlayList.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_openPlayList.BackgroundImage = global::MusicNetease.Properties.Resources.playList0;
            this.skinButton_openPlayList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.skinButton_openPlayList.BackRectangle = new System.Drawing.Rectangle(10, 10, 20, 20);
            this.skinButton_openPlayList.BaseColor = System.Drawing.Color.Transparent;
            this.skinButton_openPlayList.BorderColor = System.Drawing.Color.Transparent;
            this.skinButton_openPlayList.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_openPlayList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinButton_openPlayList.DownBack = global::MusicNetease.Properties.Resources.playList1;
            this.skinButton_openPlayList.DownBaseColor = System.Drawing.Color.Transparent;
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
            this.skinButton_openPlayList.MouseEnter += new System.EventHandler(this.skinButton_MouseEnter);
            // 
            // skinButton_Lyric
            // 
            this.skinButton_Lyric.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_Lyric.BackgroundImage = global::MusicNetease.Properties.Resources.lyric0;
            this.skinButton_Lyric.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.skinButton_Lyric.BackRectangle = new System.Drawing.Rectangle(10, 10, 20, 20);
            this.skinButton_Lyric.BaseColor = System.Drawing.Color.Transparent;
            this.skinButton_Lyric.BorderColor = System.Drawing.Color.Transparent;
            this.skinButton_Lyric.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_Lyric.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinButton_Lyric.DownBack = global::MusicNetease.Properties.Resources.lyric1;
            this.skinButton_Lyric.DownBaseColor = System.Drawing.Color.Transparent;
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
            // 
            // skinButton_bfsx
            // 
            this.skinButton_bfsx.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_bfsx.BackgroundImage = global::MusicNetease.Properties.Resources.sxbf0;
            this.skinButton_bfsx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.skinButton_bfsx.BackRectangle = new System.Drawing.Rectangle(10, 10, 20, 20);
            this.skinButton_bfsx.BaseColor = System.Drawing.Color.Transparent;
            this.skinButton_bfsx.BorderColor = System.Drawing.Color.Transparent;
            this.skinButton_bfsx.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_bfsx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinButton_bfsx.DownBack = global::MusicNetease.Properties.Resources.sxbf1;
            this.skinButton_bfsx.DownBaseColor = System.Drawing.Color.Transparent;
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
            // 
            // skinProgressBar_volume
            // 
            this.skinProgressBar_volume.Back = null;
            this.skinProgressBar_volume.BackColor = System.Drawing.Color.Transparent;
            this.skinProgressBar_volume.BarBack = null;
            this.skinProgressBar_volume.BarRadius = 6;
            this.skinProgressBar_volume.BarRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinProgressBar_volume.Border = System.Drawing.Color.DarkGray;
            this.skinProgressBar_volume.ForeColor = System.Drawing.Color.Transparent;
            this.skinProgressBar_volume.InnerBorder = System.Drawing.Color.DarkGray;
            this.skinProgressBar_volume.Location = new System.Drawing.Point(23, 22);
            this.skinProgressBar_volume.Name = "skinProgressBar_volume";
            this.skinProgressBar_volume.Radius = 6;
            this.skinProgressBar_volume.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinProgressBar_volume.Size = new System.Drawing.Size(100, 6);
            this.skinProgressBar_volume.Step = 1;
            this.skinProgressBar_volume.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.skinProgressBar_volume.TabIndex = 8;
            this.skinProgressBar_volume.TextFormat = CCWin.SkinControl.SkinProgressBar.TxtFormat.None;
            this.skinProgressBar_volume.TrackBack = System.Drawing.Color.DarkGray;
            this.skinProgressBar_volume.TrackFore = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
            this.skinProgressBar_volume.Value = 50;
            // 
            // skinButton_volume
            // 
            this.skinButton_volume.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_volume.BackgroundImage = global::MusicNetease.Properties.Resources.volume0;
            this.skinButton_volume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.skinButton_volume.BackRectangle = new System.Drawing.Rectangle(10, 10, 16, 16);
            this.skinButton_volume.BaseColor = System.Drawing.Color.Transparent;
            this.skinButton_volume.BorderColor = System.Drawing.Color.Transparent;
            this.skinButton_volume.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_volume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinButton_volume.DownBack = global::MusicNetease.Properties.Resources.volume1;
            this.skinButton_volume.DownBaseColor = System.Drawing.Color.Transparent;
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
            this.skinPanel_xys.ResumeLayout(false);
            this.skinPanel_play.ResumeLayout(false);
            this.skinPanel_sys.ResumeLayout(false);
            this.skinPanel_bfjdt.ResumeLayout(false);
            this.skinPanel_bfjdt.PerformLayout();
            this.skinPanel_otherButtons.ResumeLayout(false);
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinPanel skinPanel_buttons;
        private CCWin.SkinControl.SkinPanel skinPanel_xys;
        private CCWin.SkinControl.SkinPanel skinPanel_play;
        private CCWin.SkinControl.SkinPanel skinPanel_sys;
        private CCWin.SkinControl.SkinButton skinButton_xys;
        private CCWin.SkinControl.SkinButton skinButton_play;
        private CCWin.SkinControl.SkinButton skinButton_sys;
        private CCWin.SkinToolTip skinToolTip1;
        private CCWin.SkinControl.SkinPanel skinPanel_bfjdt;
        private CCWin.SkinControl.SkinLabel skinLabel_ybfcd;
        private CCWin.SkinControl.SkinLabel skinLabel_yycd;
        private CCWin.SkinControl.SkinProgressBar skinProgressBar_yyjdt;
        private CCWin.SkinControl.SkinPanel skinPanel_otherButtons;
        private CCWin.SkinControl.SkinButton skinButton_volume;
        private CCWin.SkinControl.SkinProgressBar skinProgressBar_volume;
        private CCWin.SkinControl.SkinButton skinButton_bfsx;
        private CCWin.SkinControl.SkinButton skinButton_Lyric;
        private CCWin.SkinControl.SkinButton skinButton_openPlayList;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinLabel skinLabel_playListCount;
    }
}
