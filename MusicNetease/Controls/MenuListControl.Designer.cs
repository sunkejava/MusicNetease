namespace MusicNetease.Controls
{
    partial class MenuListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuListControl));
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel_MyFavorite = new CCWin.SkinControl.SkinPanel();
            this.skinPanel_newMusicList = new CCWin.SkinControl.SkinPanel();
            this.skinButton_MusicList = new CCWin.SkinControl.SkinButton();
            this.skinButton_icon = new CCWin.SkinControl.SkinButton();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinButton_MyFavoriteList = new CCWin.SkinControl.SkinButton();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.menuControl_wddt = new MusicNetease.Controls.MenuControl();
            this.menuControl_wdsc = new MusicNetease.Controls.MenuControl();
            this.menuControl_xzgl = new MusicNetease.Controls.MenuControl();
            this.menuControl_yun = new MusicNetease.Controls.MenuControl();
            this.menuControl_bdyy = new MusicNetease.Controls.MenuControl();
            this.menuControl_tv = new MusicNetease.Controls.MenuControl();
            this.menuControl_friend = new MusicNetease.Controls.MenuControl();
            this.menuControl_srFm = new MusicNetease.Controls.MenuControl();
            this.menuControl_fxyy = new MusicNetease.Controls.MenuControl();
            this.skinPanel1.SuspendLayout();
            this.skinPanel_MyFavorite.SuspendLayout();
            this.skinPanel_newMusicList.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinPanel1
            // 
            this.skinPanel1.AutoScroll = true;
            this.skinPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.skinPanel1.Controls.Add(this.skinPanel_newMusicList);
            this.skinPanel1.Controls.Add(this.skinPanel_MyFavorite);
            this.skinPanel1.Controls.Add(this.menuControl_wddt);
            this.skinPanel1.Controls.Add(this.menuControl_wdsc);
            this.skinPanel1.Controls.Add(this.menuControl_xzgl);
            this.skinPanel1.Controls.Add(this.menuControl_yun);
            this.skinPanel1.Controls.Add(this.menuControl_bdyy);
            this.skinPanel1.Controls.Add(this.skinLabel2);
            this.skinPanel1.Controls.Add(this.menuControl_tv);
            this.skinPanel1.Controls.Add(this.menuControl_friend);
            this.skinPanel1.Controls.Add(this.menuControl_srFm);
            this.skinPanel1.Controls.Add(this.menuControl_fxyy);
            this.skinPanel1.Controls.Add(this.skinLabel1);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(177, 574);
            this.skinPanel1.TabIndex = 0;
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.skinLabel2.Location = new System.Drawing.Point(10, 169);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(56, 17);
            this.skinLabel2.TabIndex = 5;
            this.skinLabel2.Text = "我的音乐";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.skinLabel1.Location = new System.Drawing.Point(10, 8);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(32, 17);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "推荐";
            // 
            // skinPanel_MyFavorite
            // 
            this.skinPanel_MyFavorite.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel_MyFavorite.Controls.Add(this.skinButton_MyFavoriteList);
            this.skinPanel_MyFavorite.Controls.Add(this.skinLabel4);
            this.skinPanel_MyFavorite.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel_MyFavorite.DownBack = null;
            this.skinPanel_MyFavorite.Location = new System.Drawing.Point(0, 384);
            this.skinPanel_MyFavorite.MouseBack = null;
            this.skinPanel_MyFavorite.Name = "skinPanel_MyFavorite";
            this.skinPanel_MyFavorite.NormlBack = null;
            this.skinPanel_MyFavorite.Size = new System.Drawing.Size(177, 38);
            this.skinPanel_MyFavorite.TabIndex = 16;
            // 
            // skinPanel_newMusicList
            // 
            this.skinPanel_newMusicList.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel_newMusicList.Controls.Add(this.skinButton_MusicList);
            this.skinPanel_newMusicList.Controls.Add(this.skinButton_icon);
            this.skinPanel_newMusicList.Controls.Add(this.skinLabel3);
            this.skinPanel_newMusicList.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel_newMusicList.DownBack = null;
            this.skinPanel_newMusicList.Location = new System.Drawing.Point(0, 346);
            this.skinPanel_newMusicList.MouseBack = null;
            this.skinPanel_newMusicList.Name = "skinPanel_newMusicList";
            this.skinPanel_newMusicList.NormlBack = null;
            this.skinPanel_newMusicList.Size = new System.Drawing.Size(177, 38);
            this.skinPanel_newMusicList.TabIndex = 17;
            // 
            // skinButton_MusicList
            // 
            this.skinButton_MusicList.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_MusicList.BackgroundImage = global::MusicNetease.Properties.Resources.Arrowright0;
            this.skinButton_MusicList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.skinButton_MusicList.BackRectangle = new System.Drawing.Rectangle(10, 10, 16, 16);
            this.skinButton_MusicList.BaseColor = System.Drawing.Color.Transparent;
            this.skinButton_MusicList.BorderColor = System.Drawing.Color.Transparent;
            this.skinButton_MusicList.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_MusicList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinButton_MusicList.DownBack = global::MusicNetease.Properties.Resources.Arrowright1;
            this.skinButton_MusicList.DownBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_MusicList.GlowColor = System.Drawing.Color.Transparent;
            this.skinButton_MusicList.ImageSize = new System.Drawing.Size(16, 16);
            this.skinButton_MusicList.InnerBorderColor = System.Drawing.Color.Transparent;
            this.skinButton_MusicList.IsDrawBorder = false;
            this.skinButton_MusicList.IsDrawGlass = false;
            this.skinButton_MusicList.Location = new System.Drawing.Point(155, 14);
            this.skinButton_MusicList.MouseBack = global::MusicNetease.Properties.Resources.Arrowright1;
            this.skinButton_MusicList.MouseBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_MusicList.Name = "skinButton_MusicList";
            this.skinButton_MusicList.NormlBack = global::MusicNetease.Properties.Resources.Arrowright0;
            this.skinButton_MusicList.Size = new System.Drawing.Size(12, 12);
            this.skinButton_MusicList.TabIndex = 16;
            this.skinButton_MusicList.Tag = "展开";
            this.skinButton_MusicList.UseVisualStyleBackColor = false;
            this.skinButton_MusicList.Click += new System.EventHandler(this.skinButton_MusicList_Click);
            // 
            // skinButton_icon
            // 
            this.skinButton_icon.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_icon.BackgroundImage = global::MusicNetease.Properties.Resources.add0;
            this.skinButton_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.skinButton_icon.BackRectangle = new System.Drawing.Rectangle(10, 10, 16, 16);
            this.skinButton_icon.BaseColor = System.Drawing.Color.Transparent;
            this.skinButton_icon.BorderColor = System.Drawing.Color.Transparent;
            this.skinButton_icon.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinButton_icon.DownBack = global::MusicNetease.Properties.Resources.add1;
            this.skinButton_icon.DownBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_icon.GlowColor = System.Drawing.Color.Transparent;
            this.skinButton_icon.ImageSize = new System.Drawing.Size(16, 16);
            this.skinButton_icon.InnerBorderColor = System.Drawing.Color.Transparent;
            this.skinButton_icon.IsDrawBorder = false;
            this.skinButton_icon.IsDrawGlass = false;
            this.skinButton_icon.Location = new System.Drawing.Point(126, 12);
            this.skinButton_icon.MouseBack = global::MusicNetease.Properties.Resources.add1;
            this.skinButton_icon.MouseBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_icon.Name = "skinButton_icon";
            this.skinButton_icon.NormlBack = global::MusicNetease.Properties.Resources.add0;
            this.skinButton_icon.Size = new System.Drawing.Size(16, 16);
            this.skinButton_icon.TabIndex = 15;
            this.skinButton_icon.Tag = "新建歌单";
            this.skinButton_icon.UseVisualStyleBackColor = false;
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.skinLabel3.Location = new System.Drawing.Point(9, 11);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(68, 17);
            this.skinLabel3.TabIndex = 14;
            this.skinLabel3.Text = "创建的歌单";
            // 
            // skinButton_MyFavoriteList
            // 
            this.skinButton_MyFavoriteList.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_MyFavoriteList.BackgroundImage = global::MusicNetease.Properties.Resources.Arrowright0;
            this.skinButton_MyFavoriteList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.skinButton_MyFavoriteList.BackRectangle = new System.Drawing.Rectangle(10, 10, 16, 16);
            this.skinButton_MyFavoriteList.BaseColor = System.Drawing.Color.Transparent;
            this.skinButton_MyFavoriteList.BorderColor = System.Drawing.Color.Transparent;
            this.skinButton_MyFavoriteList.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_MyFavoriteList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinButton_MyFavoriteList.DownBack = global::MusicNetease.Properties.Resources.Arrowright1;
            this.skinButton_MyFavoriteList.DownBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_MyFavoriteList.GlowColor = System.Drawing.Color.Transparent;
            this.skinButton_MyFavoriteList.ImageSize = new System.Drawing.Size(16, 16);
            this.skinButton_MyFavoriteList.InnerBorderColor = System.Drawing.Color.Transparent;
            this.skinButton_MyFavoriteList.IsDrawBorder = false;
            this.skinButton_MyFavoriteList.IsDrawGlass = false;
            this.skinButton_MyFavoriteList.Location = new System.Drawing.Point(155, 14);
            this.skinButton_MyFavoriteList.MouseBack = global::MusicNetease.Properties.Resources.Arrowright1;
            this.skinButton_MyFavoriteList.MouseBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_MyFavoriteList.Name = "skinButton_MyFavoriteList";
            this.skinButton_MyFavoriteList.NormlBack = global::MusicNetease.Properties.Resources.Arrowright0;
            this.skinButton_MyFavoriteList.Size = new System.Drawing.Size(12, 12);
            this.skinButton_MyFavoriteList.TabIndex = 17;
            this.skinButton_MyFavoriteList.Tag = "展开";
            this.skinButton_MyFavoriteList.UseVisualStyleBackColor = false;
            this.skinButton_MyFavoriteList.Click += new System.EventHandler(this.skinButton_MusicList_Click);
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.skinLabel4.Location = new System.Drawing.Point(9, 11);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(68, 17);
            this.skinLabel4.TabIndex = 16;
            this.skinLabel4.Text = "收藏的歌单";
            // 
            // menuControl_wddt
            // 
            this.menuControl_wddt.isSelect = false;
            this.menuControl_wddt.Location = new System.Drawing.Point(0, 287);
            this.menuControl_wddt.menuName = "skinLabel_wddt";
            this.menuControl_wddt.menuText = "我的电台";
            this.menuControl_wddt.Name = "menuControl_wddt";
            this.menuControl_wddt.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
            this.menuControl_wddt.setBackgroundIcon = global::MusicNetease.Properties.Resources.dt0;
            this.menuControl_wddt.setDcColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.menuControl_wddt.setMouseBack = global::MusicNetease.Properties.Resources.dt1;
            this.menuControl_wddt.setNormlIcon = global::MusicNetease.Properties.Resources.dt0;
            this.menuControl_wddt.setScColor = System.Drawing.Color.Transparent;
            this.menuControl_wddt.Size = new System.Drawing.Size(177, 28);
            this.menuControl_wddt.TabIndex = 10;
            this.menuControl_wddt.skinPanelMouseDown += new MusicNetease.Controls.MenuControl.PanelMouseDown(this.menuControl_srFm_skinPanelMouseDown);
            // 
            // menuControl_wdsc
            // 
            this.menuControl_wdsc.isSelect = false;
            this.menuControl_wdsc.Location = new System.Drawing.Point(0, 319);
            this.menuControl_wdsc.menuName = "skinLabel_wdsc";
            this.menuControl_wdsc.menuText = "我的收藏";
            this.menuControl_wdsc.Name = "menuControl_wdsc";
            this.menuControl_wdsc.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
            this.menuControl_wdsc.setBackgroundIcon = global::MusicNetease.Properties.Resources.wdsc0;
            this.menuControl_wdsc.setDcColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.menuControl_wdsc.setMouseBack = global::MusicNetease.Properties.Resources.wdsc1;
            this.menuControl_wdsc.setNormlIcon = global::MusicNetease.Properties.Resources.wdsc0;
            this.menuControl_wdsc.setScColor = System.Drawing.Color.Transparent;
            this.menuControl_wdsc.Size = new System.Drawing.Size(177, 28);
            this.menuControl_wdsc.TabIndex = 9;
            this.menuControl_wdsc.skinPanelMouseDown += new MusicNetease.Controls.MenuControl.PanelMouseDown(this.menuControl_srFm_skinPanelMouseDown);
            // 
            // menuControl_xzgl
            // 
            this.menuControl_xzgl.isSelect = false;
            this.menuControl_xzgl.Location = new System.Drawing.Point(0, 224);
            this.menuControl_xzgl.menuName = "skinLabel_xzgl";
            this.menuControl_xzgl.menuText = "下载管理";
            this.menuControl_xzgl.Name = "menuControl_xzgl";
            this.menuControl_xzgl.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
            this.menuControl_xzgl.setBackgroundIcon = global::MusicNetease.Properties.Resources.download0;
            this.menuControl_xzgl.setDcColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.menuControl_xzgl.setMouseBack = global::MusicNetease.Properties.Resources.download1;
            this.menuControl_xzgl.setNormlIcon = global::MusicNetease.Properties.Resources.download0;
            this.menuControl_xzgl.setScColor = System.Drawing.Color.Transparent;
            this.menuControl_xzgl.Size = new System.Drawing.Size(177, 28);
            this.menuControl_xzgl.TabIndex = 8;
            this.menuControl_xzgl.skinPanelMouseDown += new MusicNetease.Controls.MenuControl.PanelMouseDown(this.menuControl_srFm_skinPanelMouseDown);
            // 
            // menuControl_yun
            // 
            this.menuControl_yun.isSelect = false;
            this.menuControl_yun.Location = new System.Drawing.Point(0, 256);
            this.menuControl_yun.menuName = "skinLabel_yun";
            this.menuControl_yun.menuText = "我的音乐云盘";
            this.menuControl_yun.Name = "menuControl_yun";
            this.menuControl_yun.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
            this.menuControl_yun.setBackgroundIcon = global::MusicNetease.Properties.Resources.yun0;
            this.menuControl_yun.setDcColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.menuControl_yun.setMouseBack = global::MusicNetease.Properties.Resources.yun1;
            this.menuControl_yun.setNormlIcon = global::MusicNetease.Properties.Resources.yun0;
            this.menuControl_yun.setScColor = System.Drawing.Color.Transparent;
            this.menuControl_yun.Size = new System.Drawing.Size(177, 28);
            this.menuControl_yun.TabIndex = 7;
            this.menuControl_yun.skinPanelMouseDown += new MusicNetease.Controls.MenuControl.PanelMouseDown(this.menuControl_srFm_skinPanelMouseDown);
            // 
            // menuControl_bdyy
            // 
            this.menuControl_bdyy.isSelect = false;
            this.menuControl_bdyy.Location = new System.Drawing.Point(0, 193);
            this.menuControl_bdyy.menuName = "skinLabel_bdyy";
            this.menuControl_bdyy.menuText = "本地音乐";
            this.menuControl_bdyy.Name = "menuControl_bdyy";
            this.menuControl_bdyy.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
            this.menuControl_bdyy.setBackgroundIcon = global::MusicNetease.Properties.Resources.bdyy0;
            this.menuControl_bdyy.setDcColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.menuControl_bdyy.setMouseBack = global::MusicNetease.Properties.Resources.bdyy1;
            this.menuControl_bdyy.setNormlIcon = global::MusicNetease.Properties.Resources.bdyy0;
            this.menuControl_bdyy.setScColor = System.Drawing.Color.Transparent;
            this.menuControl_bdyy.Size = new System.Drawing.Size(177, 28);
            this.menuControl_bdyy.TabIndex = 6;
            this.menuControl_bdyy.skinPanelMouseDown += new MusicNetease.Controls.MenuControl.PanelMouseDown(this.menuControl_srFm_skinPanelMouseDown);
            // 
            // menuControl_tv
            // 
            this.menuControl_tv.isSelect = false;
            this.menuControl_tv.Location = new System.Drawing.Point(0, 95);
            this.menuControl_tv.menuName = "skinLabel_tv";
            this.menuControl_tv.menuText = "视频";
            this.menuControl_tv.Name = "menuControl_tv";
            this.menuControl_tv.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
            this.menuControl_tv.setBackgroundIcon = global::MusicNetease.Properties.Resources.tv0;
            this.menuControl_tv.setDcColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.menuControl_tv.setMouseBack = global::MusicNetease.Properties.Resources.tv1;
            this.menuControl_tv.setNormlIcon = global::MusicNetease.Properties.Resources.tv0;
            this.menuControl_tv.setScColor = System.Drawing.Color.Transparent;
            this.menuControl_tv.Size = new System.Drawing.Size(177, 28);
            this.menuControl_tv.TabIndex = 4;
            this.menuControl_tv.skinPanelMouseDown += new MusicNetease.Controls.MenuControl.PanelMouseDown(this.menuControl_srFm_skinPanelMouseDown);
            // 
            // menuControl_friend
            // 
            this.menuControl_friend.isSelect = false;
            this.menuControl_friend.Location = new System.Drawing.Point(0, 127);
            this.menuControl_friend.menuName = "skinLabel_friend";
            this.menuControl_friend.menuText = "朋友";
            this.menuControl_friend.Name = "menuControl_friend";
            this.menuControl_friend.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
            this.menuControl_friend.setBackgroundIcon = global::MusicNetease.Properties.Resources.lxr0;
            this.menuControl_friend.setDcColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.menuControl_friend.setMouseBack = global::MusicNetease.Properties.Resources.lxr1;
            this.menuControl_friend.setNormlIcon = global::MusicNetease.Properties.Resources.lxr0;
            this.menuControl_friend.setScColor = System.Drawing.Color.Transparent;
            this.menuControl_friend.Size = new System.Drawing.Size(177, 28);
            this.menuControl_friend.TabIndex = 3;
            this.menuControl_friend.skinPanelMouseDown += new MusicNetease.Controls.MenuControl.PanelMouseDown(this.menuControl_srFm_skinPanelMouseDown);
            // 
            // menuControl_srFm
            // 
            this.menuControl_srFm.isSelect = false;
            this.menuControl_srFm.Location = new System.Drawing.Point(0, 64);
            this.menuControl_srFm.menuName = "skinLabel_srfm";
            this.menuControl_srFm.menuText = "私人FM";
            this.menuControl_srFm.Name = "menuControl_srFm";
            this.menuControl_srFm.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
            this.menuControl_srFm.setBackgroundIcon = global::MusicNetease.Properties.Resources.FM0;
            this.menuControl_srFm.setDcColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.menuControl_srFm.setMouseBack = global::MusicNetease.Properties.Resources.FM1;
            this.menuControl_srFm.setNormlIcon = global::MusicNetease.Properties.Resources.FM0;
            this.menuControl_srFm.setScColor = System.Drawing.Color.Transparent;
            this.menuControl_srFm.Size = new System.Drawing.Size(177, 28);
            this.menuControl_srFm.TabIndex = 2;
            this.menuControl_srFm.skinPanelMouseDown += new MusicNetease.Controls.MenuControl.PanelMouseDown(this.menuControl_srFm_skinPanelMouseDown);
            // 
            // menuControl_fxyy
            // 
            this.menuControl_fxyy.isSelect = true;
            this.menuControl_fxyy.Location = new System.Drawing.Point(0, 34);
            this.menuControl_fxyy.menuName = "skinLabel_fxyy";
            this.menuControl_fxyy.menuText = "发现音乐";
            this.menuControl_fxyy.Name = "menuControl_fxyy";
            this.menuControl_fxyy.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
            this.menuControl_fxyy.setBackgroundIcon = ((System.Drawing.Image)(resources.GetObject("menuControl_fxyy.setBackgroundIcon")));
            this.menuControl_fxyy.setDcColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
            this.menuControl_fxyy.setMouseBack = ((System.Drawing.Image)(resources.GetObject("menuControl_fxyy.setMouseBack")));
            this.menuControl_fxyy.setNormlIcon = ((System.Drawing.Image)(resources.GetObject("menuControl_fxyy.setNormlIcon")));
            this.menuControl_fxyy.setScColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(234)))));
            this.menuControl_fxyy.Size = new System.Drawing.Size(177, 28);
            this.menuControl_fxyy.TabIndex = 1;
            this.menuControl_fxyy.skinPanelMouseDown += new MusicNetease.Controls.MenuControl.PanelMouseDown(this.menuControl_srFm_skinPanelMouseDown);
            // 
            // MenuListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.skinPanel1);
            this.Name = "MenuListControl";
            this.Size = new System.Drawing.Size(177, 574);
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.skinPanel_MyFavorite.ResumeLayout(false);
            this.skinPanel_MyFavorite.PerformLayout();
            this.skinPanel_newMusicList.ResumeLayout(false);
            this.skinPanel_newMusicList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private MenuControl menuControl_fxyy;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        public MenuControl menuControl_srFm;
        public MenuControl menuControl_tv;
        public MenuControl menuControl_friend;
        public MenuControl menuControl_bdyy;
        public MenuControl menuControl_xzgl;
        public MenuControl menuControl_yun;
        public MenuControl menuControl_wddt;
        public MenuControl menuControl_wdsc;
        private CCWin.SkinControl.SkinPanel skinPanel_newMusicList;
        public CCWin.SkinControl.SkinButton skinButton_MusicList;
        public CCWin.SkinControl.SkinButton skinButton_icon;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinPanel skinPanel_MyFavorite;
        public CCWin.SkinControl.SkinButton skinButton_MyFavoriteList;
        private CCWin.SkinControl.SkinLabel skinLabel4;
    }
}
