namespace MusicNetease
{
    partial class MainForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.skinPanel3 = new CCWin.SkinControl.SkinPanel();
            this.musicPlayerButton1 = new MusicNetease.Controls.MusicPlayerButton();
            this.skinTabControl_Main = new CCWin.SkinControl.SkinTabControl();
            this.skinTabPage_fxyy = new CCWin.SkinControl.SkinTabPage();
            this.mainTabControl1 = new MusicNetease.Controls.MainTabControl_Fxyy();
            this.skinTabPage_srfm = new CCWin.SkinControl.SkinTabPage();
            this.userControl_Srfm1 = new MusicNetease.Controls.UserControl_Srfm();
            this.skinTabPage_gd = new CCWin.SkinControl.SkinTabPage();
            this.skinTabPage_tv = new CCWin.SkinControl.SkinTabPage();
            this.skinTabPage_friend = new CCWin.SkinControl.SkinTabPage();
            this.skinTabPage_bdyy = new CCWin.SkinControl.SkinTabPage();
            this.skinTabPage_xzgl = new CCWin.SkinControl.SkinTabPage();
            this.skinTabPage_yun = new CCWin.SkinControl.SkinTabPage();
            this.skinTabPage_wddt = new CCWin.SkinControl.SkinTabPage();
            this.skinTabPage_wdsc = new CCWin.SkinControl.SkinTabPage();
            this.scorllbar = new LayeredSkin.Controls.LayeredBaseControl();
            this.songSheetList1 = new MusicNetease.LayeredSkinControl.SongSheetList();
            this.skinPanel3.SuspendLayout();
            this.skinTabControl_Main.SuspendLayout();
            this.skinTabPage_fxyy.SuspendLayout();
            this.skinTabPage_srfm.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinPanel3
            // 
            this.skinPanel3.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel3.Controls.Add(this.musicPlayerButton1);
            this.skinPanel3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.skinPanel3.DownBack = null;
            this.skinPanel3.Location = new System.Drawing.Point(4, 617);
            this.skinPanel3.MouseBack = null;
            this.skinPanel3.Name = "skinPanel3";
            this.skinPanel3.NormlBack = null;
            this.skinPanel3.Size = new System.Drawing.Size(1014, 49);
            this.skinPanel3.TabIndex = 1;
            // 
            // musicPlayerButton1
            // 
            this.musicPlayerButton1.BackColor = System.Drawing.SystemColors.Control;
            this.musicPlayerButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.musicPlayerButton1.Location = new System.Drawing.Point(0, 0);
            this.musicPlayerButton1.Name = "musicPlayerButton1";
            this.musicPlayerButton1.Size = new System.Drawing.Size(1014, 49);
            this.musicPlayerButton1.TabIndex = 2;
            // 
            // skinTabControl_Main
            // 
            this.skinTabControl_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinTabControl_Main.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.skinTabControl_Main.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.skinTabControl_Main.Controls.Add(this.skinTabPage_fxyy);
            this.skinTabControl_Main.Controls.Add(this.skinTabPage_srfm);
            this.skinTabControl_Main.Controls.Add(this.skinTabPage_gd);
            this.skinTabControl_Main.Controls.Add(this.skinTabPage_tv);
            this.skinTabControl_Main.Controls.Add(this.skinTabPage_friend);
            this.skinTabControl_Main.Controls.Add(this.skinTabPage_bdyy);
            this.skinTabControl_Main.Controls.Add(this.skinTabPage_xzgl);
            this.skinTabControl_Main.Controls.Add(this.skinTabPage_yun);
            this.skinTabControl_Main.Controls.Add(this.skinTabPage_wddt);
            this.skinTabControl_Main.Controls.Add(this.skinTabPage_wdsc);
            this.skinTabControl_Main.HeadBack = null;
            this.skinTabControl_Main.HeadBackRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.skinTabControl_Main.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.skinTabControl_Main.ItemSize = new System.Drawing.Size(84, 36);
            this.skinTabControl_Main.Location = new System.Drawing.Point(192, 14);
            this.skinTabControl_Main.Name = "skinTabControl_Main";
            this.skinTabControl_Main.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl_Main.PageArrowDown")));
            this.skinTabControl_Main.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl_Main.PageArrowHover")));
            this.skinTabControl_Main.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl_Main.PageCloseHover")));
            this.skinTabControl_Main.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("skinTabControl_Main.PageCloseNormal")));
            this.skinTabControl_Main.PageDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl_Main.PageDown")));
            this.skinTabControl_Main.PageHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl_Main.PageHover")));
            this.skinTabControl_Main.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.skinTabControl_Main.PageNorml = null;
            this.skinTabControl_Main.SelectedIndex = 0;
            this.skinTabControl_Main.Size = new System.Drawing.Size(830, 602);
            this.skinTabControl_Main.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.skinTabControl_Main.TabIndex = 3;
            // 
            // skinTabPage_fxyy
            // 
            this.skinTabPage_fxyy.BackColor = System.Drawing.Color.White;
            this.skinTabPage_fxyy.Controls.Add(this.mainTabControl1);
            this.skinTabPage_fxyy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage_fxyy.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage_fxyy.Name = "skinTabPage_fxyy";
            this.skinTabPage_fxyy.Size = new System.Drawing.Size(830, 566);
            this.skinTabPage_fxyy.TabIndex = 0;
            this.skinTabPage_fxyy.TabItemImage = null;
            this.skinTabPage_fxyy.Text = "发现音乐";
            // 
            // mainTabControl1
            // 
            this.mainTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl1.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl1.Name = "mainTabControl1";
            this.mainTabControl1.SetSize = 830;
            this.mainTabControl1.Size = new System.Drawing.Size(830, 566);
            this.mainTabControl1.TabIndex = 0;
            // 
            // skinTabPage_srfm
            // 
            this.skinTabPage_srfm.BackColor = System.Drawing.Color.White;
            this.skinTabPage_srfm.Controls.Add(this.userControl_Srfm1);
            this.skinTabPage_srfm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage_srfm.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage_srfm.Name = "skinTabPage_srfm";
            this.skinTabPage_srfm.Size = new System.Drawing.Size(830, 566);
            this.skinTabPage_srfm.TabIndex = 1;
            this.skinTabPage_srfm.TabItemImage = null;
            this.skinTabPage_srfm.Text = "私人FM";
            // 
            // userControl_Srfm1
            // 
            this.userControl_Srfm1.BackColor = System.Drawing.SystemColors.Control;
            this.userControl_Srfm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Srfm1.Location = new System.Drawing.Point(0, 0);
            this.userControl_Srfm1.Name = "userControl_Srfm1";
            this.userControl_Srfm1.Size = new System.Drawing.Size(830, 566);
            this.userControl_Srfm1.TabIndex = 0;
            // 
            // skinTabPage_gd
            // 
            this.skinTabPage_gd.BackColor = System.Drawing.Color.White;
            this.skinTabPage_gd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage_gd.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage_gd.Name = "skinTabPage_gd";
            this.skinTabPage_gd.Size = new System.Drawing.Size(830, 566);
            this.skinTabPage_gd.TabIndex = 9;
            this.skinTabPage_gd.TabItemImage = null;
            this.skinTabPage_gd.Text = "歌单";
            // 
            // skinTabPage_tv
            // 
            this.skinTabPage_tv.BackColor = System.Drawing.Color.White;
            this.skinTabPage_tv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage_tv.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage_tv.Name = "skinTabPage_tv";
            this.skinTabPage_tv.Size = new System.Drawing.Size(830, 566);
            this.skinTabPage_tv.TabIndex = 2;
            this.skinTabPage_tv.TabItemImage = null;
            this.skinTabPage_tv.Text = "视频";
            // 
            // skinTabPage_friend
            // 
            this.skinTabPage_friend.BackColor = System.Drawing.Color.White;
            this.skinTabPage_friend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage_friend.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage_friend.Name = "skinTabPage_friend";
            this.skinTabPage_friend.Size = new System.Drawing.Size(830, 566);
            this.skinTabPage_friend.TabIndex = 3;
            this.skinTabPage_friend.TabItemImage = null;
            this.skinTabPage_friend.Text = "朋友";
            // 
            // skinTabPage_bdyy
            // 
            this.skinTabPage_bdyy.BackColor = System.Drawing.Color.White;
            this.skinTabPage_bdyy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage_bdyy.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage_bdyy.Name = "skinTabPage_bdyy";
            this.skinTabPage_bdyy.Size = new System.Drawing.Size(830, 566);
            this.skinTabPage_bdyy.TabIndex = 4;
            this.skinTabPage_bdyy.TabItemImage = null;
            this.skinTabPage_bdyy.Text = "本地音乐";
            // 
            // skinTabPage_xzgl
            // 
            this.skinTabPage_xzgl.BackColor = System.Drawing.Color.White;
            this.skinTabPage_xzgl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage_xzgl.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage_xzgl.Name = "skinTabPage_xzgl";
            this.skinTabPage_xzgl.Size = new System.Drawing.Size(830, 566);
            this.skinTabPage_xzgl.TabIndex = 5;
            this.skinTabPage_xzgl.TabItemImage = null;
            this.skinTabPage_xzgl.Text = "下载管理";
            // 
            // skinTabPage_yun
            // 
            this.skinTabPage_yun.BackColor = System.Drawing.Color.White;
            this.skinTabPage_yun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage_yun.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage_yun.Name = "skinTabPage_yun";
            this.skinTabPage_yun.Size = new System.Drawing.Size(830, 566);
            this.skinTabPage_yun.TabIndex = 6;
            this.skinTabPage_yun.TabItemImage = null;
            this.skinTabPage_yun.Text = "我的音乐云盘";
            // 
            // skinTabPage_wddt
            // 
            this.skinTabPage_wddt.BackColor = System.Drawing.Color.White;
            this.skinTabPage_wddt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage_wddt.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage_wddt.Name = "skinTabPage_wddt";
            this.skinTabPage_wddt.Size = new System.Drawing.Size(830, 566);
            this.skinTabPage_wddt.TabIndex = 7;
            this.skinTabPage_wddt.TabItemImage = null;
            this.skinTabPage_wddt.Text = "我的电台";
            // 
            // skinTabPage_wdsc
            // 
            this.skinTabPage_wdsc.BackColor = System.Drawing.Color.White;
            this.skinTabPage_wdsc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage_wdsc.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage_wdsc.Name = "skinTabPage_wdsc";
            this.skinTabPage_wdsc.Size = new System.Drawing.Size(830, 566);
            this.skinTabPage_wdsc.TabIndex = 8;
            this.skinTabPage_wdsc.TabItemImage = null;
            this.skinTabPage_wdsc.Text = "我的收藏";
            // 
            // scorllbar
            // 
            this.scorllbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.scorllbar.Borders.BottomColor = System.Drawing.Color.Empty;
            this.scorllbar.Borders.BottomWidth = 1;
            this.scorllbar.Borders.LeftColor = System.Drawing.Color.Empty;
            this.scorllbar.Borders.LeftWidth = 1;
            this.scorllbar.Borders.RightColor = System.Drawing.Color.Empty;
            this.scorllbar.Borders.RightWidth = 1;
            this.scorllbar.Borders.TopColor = System.Drawing.Color.Empty;
            this.scorllbar.Borders.TopWidth = 1;
            this.scorllbar.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("scorllbar.Canvas")));
            this.scorllbar.Location = new System.Drawing.Point(189, 51);
            this.scorllbar.Name = "scorllbar";
            this.scorllbar.Size = new System.Drawing.Size(5, 567);
            this.scorllbar.TabIndex = 2;
            this.scorllbar.Visible = false;
            this.scorllbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.scorllbar_MouseDown);
            this.scorllbar.MouseEnter += new System.EventHandler(this.scorllbar_MouseEnter);
            this.scorllbar.MouseLeave += new System.EventHandler(this.scorllbar_MouseLeave);
            this.scorllbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.scorllbar_MouseMove);
            this.scorllbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.scorllbar_MouseUp);
            this.scorllbar.Move += new System.EventHandler(this.scorllbar_Move);
            // 
            // songSheetList1
            // 
            this.songSheetList1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.songSheetList1.AutoFocus = false;
            this.songSheetList1.BackColor = System.Drawing.Color.Transparent;
            this.songSheetList1.Borders.BottomColor = System.Drawing.Color.Empty;
            this.songSheetList1.Borders.BottomWidth = 1;
            this.songSheetList1.Borders.LeftColor = System.Drawing.Color.Empty;
            this.songSheetList1.Borders.LeftWidth = 1;
            this.songSheetList1.Borders.RightColor = System.Drawing.Color.Empty;
            this.songSheetList1.Borders.RightWidth = 1;
            this.songSheetList1.Borders.TopColor = System.Drawing.Color.Empty;
            this.songSheetList1.Borders.TopWidth = 1;
            this.songSheetList1.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("songSheetList1.Canvas")));
            this.songSheetList1.EnabledMouseWheel = true;
            this.songSheetList1.ItemSize = new System.Drawing.Size(100, 100);
            this.songSheetList1.ListTop = 0;
            this.songSheetList1.Location = new System.Drawing.Point(0, 51);
            this.songSheetList1.Name = "songSheetList1";
            this.songSheetList1.Orientation = LayeredSkin.Controls.ListOrientation.Vertical;
            this.songSheetList1.RollSize = 5;
            this.songSheetList1.ScrollBarBackColor = System.Drawing.Color.Transparent;
            this.songSheetList1.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(227)))));
            this.songSheetList1.ScrollBarHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(177)))));
            this.songSheetList1.ScrollBarWidth = 10;
            this.songSheetList1.SetSelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
            this.songSheetList1.ShowScrollBar = false;
            this.songSheetList1.Size = new System.Drawing.Size(194, 567);
            this.songSheetList1.SmoothScroll = false;
            this.songSheetList1.TabIndex = 1;
            this.songSheetList1.Text = "songSheetList1";
            this.songSheetList1.Ulmul = false;
            this.songSheetList1.Value = 0D;
            this.songSheetList1.RefreshListed += new System.EventHandler(this.songSheetList1_RefreshListed);
            this.songSheetList1.MenuNameMouseDown += new System.EventHandler(this.songSheetList1_MenuNameMouseDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(1022, 670);
            this.Controls.Add(this.scorllbar);
            this.Controls.Add(this.songSheetList1);
            this.Controls.Add(this.skinPanel3);
            this.Controls.Add(this.skinTabControl_Main);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Controls.SetChildIndex(this.skinTabControl_Main, 0);
            this.Controls.SetChildIndex(this.skinPanel3, 0);
            this.Controls.SetChildIndex(this.songSheetList1, 0);
            this.Controls.SetChildIndex(this.scorllbar, 0);
            this.skinPanel3.ResumeLayout(false);
            this.skinTabControl_Main.ResumeLayout(false);
            this.skinTabPage_fxyy.ResumeLayout(false);
            this.skinTabPage_srfm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinPanel skinPanel3;
        private Controls.MusicPlayerButton musicPlayerButton1;
        private CCWin.SkinControl.SkinTabControl skinTabControl_Main;
        private CCWin.SkinControl.SkinTabPage skinTabPage_fxyy;
        private CCWin.SkinControl.SkinTabPage skinTabPage_srfm;
        private CCWin.SkinControl.SkinTabPage skinTabPage_tv;
        private CCWin.SkinControl.SkinTabPage skinTabPage_friend;
        private CCWin.SkinControl.SkinTabPage skinTabPage_bdyy;
        private CCWin.SkinControl.SkinTabPage skinTabPage_xzgl;
        private CCWin.SkinControl.SkinTabPage skinTabPage_yun;
        private CCWin.SkinControl.SkinTabPage skinTabPage_wddt;
        private CCWin.SkinControl.SkinTabPage skinTabPage_wdsc;
        private CCWin.SkinControl.SkinTabPage skinTabPage_gd;
        private Controls.MainTabControl_Fxyy mainTabControl1;
        private Controls.UserControl_Srfm userControl_Srfm1;
        private LayeredSkinControl.SongSheetList songSheetList1;
        private LayeredSkin.Controls.LayeredBaseControl scorllbar;
    }
}
