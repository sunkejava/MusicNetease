namespace MusicNetease
{
    partial class BaseForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.skinPanel_top = new CCWin.SkinControl.SkinPanel();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.skinButton_skin = new CCWin.SkinControl.SkinButton();
            this.skinButton_email = new CCWin.SkinControl.SkinButton();
            this.skinButton_Set = new CCWin.SkinControl.SkinButton();
            this.skinButton_minimize = new CCWin.SkinControl.SkinButton();
            this.skinButton_mix = new CCWin.SkinControl.SkinButton();
            this.skinButton_max = new CCWin.SkinControl.SkinButton();
            this.skinButton_close = new CCWin.SkinControl.SkinButton();
            this.skinPictureBox1 = new CCWin.SkinControl.SkinPictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.skinContextMenuStrip1 = new CCWin.SkinControl.SkinContextMenuStrip();
            this.toolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Set = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_lock = new System.Windows.Forms.ToolStripMenuItem();
            this.skinPanel_top.SuspendLayout();
            this.skinPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).BeginInit();
            this.skinContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinPanel_top
            // 
            this.skinPanel_top.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinPanel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
            this.skinPanel_top.Controls.Add(this.skinPanel1);
            this.skinPanel_top.Controls.Add(this.skinPictureBox1);
            this.skinPanel_top.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel_top.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.skinPanel_top.DownBack = null;
            this.skinPanel_top.Location = new System.Drawing.Point(0, 0);
            this.skinPanel_top.MouseBack = null;
            this.skinPanel_top.Name = "skinPanel_top";
            this.skinPanel_top.NormlBack = null;
            this.skinPanel_top.Size = new System.Drawing.Size(1022, 50);
            this.skinPanel_top.TabIndex = 0;
            this.skinPanel_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.skinPanel_top_MouseDown);
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.skinButton_skin);
            this.skinPanel1.Controls.Add(this.skinButton_email);
            this.skinPanel1.Controls.Add(this.skinButton_Set);
            this.skinPanel1.Controls.Add(this.skinButton_minimize);
            this.skinPanel1.Controls.Add(this.skinButton_mix);
            this.skinPanel1.Controls.Add(this.skinButton_max);
            this.skinPanel1.Controls.Add(this.skinButton_close);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(783, 0);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(239, 50);
            this.skinPanel1.TabIndex = 1;
            this.skinPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.skinPanel_top_MouseDown);
            // 
            // skinButton_skin
            // 
            this.skinButton_skin.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_skin.BackgroundImage = global::MusicNetease.Properties.Resources.skin0;
            this.skinButton_skin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.skinButton_skin.BackRectangle = new System.Drawing.Rectangle(10, 10, 16, 16);
            this.skinButton_skin.BaseColor = System.Drawing.Color.Transparent;
            this.skinButton_skin.BorderColor = System.Drawing.Color.Transparent;
            this.skinButton_skin.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_skin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinButton_skin.DownBack = null;
            this.skinButton_skin.DownBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_skin.GlowColor = System.Drawing.Color.Transparent;
            this.skinButton_skin.ImageSize = new System.Drawing.Size(20, 20);
            this.skinButton_skin.InnerBorderColor = System.Drawing.Color.Transparent;
            this.skinButton_skin.IsDrawBorder = false;
            this.skinButton_skin.IsDrawGlass = false;
            this.skinButton_skin.Location = new System.Drawing.Point(22, 16);
            this.skinButton_skin.MouseBack = null;
            this.skinButton_skin.MouseBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_skin.Name = "skinButton_skin";
            this.skinButton_skin.NormlBack = null;
            this.skinButton_skin.Size = new System.Drawing.Size(16, 16);
            this.skinButton_skin.TabIndex = 6;
            this.skinButton_skin.Tag = "换肤";
            this.skinButton_skin.UseVisualStyleBackColor = false;
            this.skinButton_skin.Click += new System.EventHandler(this.skinButton_skin_Click);
            this.skinButton_skin.MouseLeave += new System.EventHandler(this.skinButton_skin_MouseLeave);
            this.skinButton_skin.MouseHover += new System.EventHandler(this.skinButton_skin_MouseHover);
            // 
            // skinButton_email
            // 
            this.skinButton_email.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_email.BackgroundImage = global::MusicNetease.Properties.Resources.email0;
            this.skinButton_email.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.skinButton_email.BackRectangle = new System.Drawing.Rectangle(10, 10, 20, 20);
            this.skinButton_email.BaseColor = System.Drawing.Color.Transparent;
            this.skinButton_email.BorderColor = System.Drawing.Color.Transparent;
            this.skinButton_email.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_email.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinButton_email.DownBack = null;
            this.skinButton_email.DownBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_email.GlowColor = System.Drawing.Color.Transparent;
            this.skinButton_email.ImageSize = new System.Drawing.Size(16, 16);
            this.skinButton_email.InnerBorderColor = System.Drawing.Color.Transparent;
            this.skinButton_email.IsDrawBorder = false;
            this.skinButton_email.IsDrawGlass = false;
            this.skinButton_email.Location = new System.Drawing.Point(53, 16);
            this.skinButton_email.MouseBack = null;
            this.skinButton_email.MouseBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_email.Name = "skinButton_email";
            this.skinButton_email.NormlBack = null;
            this.skinButton_email.Size = new System.Drawing.Size(16, 16);
            this.skinButton_email.TabIndex = 5;
            this.skinButton_email.UseVisualStyleBackColor = false;
            this.skinButton_email.Click += new System.EventHandler(this.skinButton_email_Click);
            this.skinButton_email.MouseLeave += new System.EventHandler(this.skinButton_email_MouseLeave);
            this.skinButton_email.MouseHover += new System.EventHandler(this.skinButton_email_MouseHover);
            // 
            // skinButton_Set
            // 
            this.skinButton_Set.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_Set.BackgroundImage = global::MusicNetease.Properties.Resources.set0;
            this.skinButton_Set.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.skinButton_Set.BackRectangle = new System.Drawing.Rectangle(10, 10, 20, 20);
            this.skinButton_Set.BaseColor = System.Drawing.Color.Transparent;
            this.skinButton_Set.BorderColor = System.Drawing.Color.Transparent;
            this.skinButton_Set.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_Set.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinButton_Set.DownBack = null;
            this.skinButton_Set.DownBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_Set.GlowColor = System.Drawing.Color.Transparent;
            this.skinButton_Set.ImageSize = new System.Drawing.Size(20, 20);
            this.skinButton_Set.InnerBorderColor = System.Drawing.Color.Transparent;
            this.skinButton_Set.IsDrawBorder = false;
            this.skinButton_Set.IsDrawGlass = false;
            this.skinButton_Set.Location = new System.Drawing.Point(86, 16);
            this.skinButton_Set.MouseBack = null;
            this.skinButton_Set.MouseBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_Set.Name = "skinButton_Set";
            this.skinButton_Set.NormlBack = null;
            this.skinButton_Set.Size = new System.Drawing.Size(16, 16);
            this.skinButton_Set.TabIndex = 4;
            this.skinButton_Set.Tag = "设置";
            this.skinButton_Set.UseVisualStyleBackColor = false;
            this.skinButton_Set.Click += new System.EventHandler(this.skinButton_Set_Click);
            this.skinButton_Set.MouseLeave += new System.EventHandler(this.skinButton_Set_MouseLeave);
            this.skinButton_Set.MouseHover += new System.EventHandler(this.skinButton_Set_MouseHover);
            // 
            // skinButton_minimize
            // 
            this.skinButton_minimize.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_minimize.BackgroundImage = global::MusicNetease.Properties.Resources.minimize0;
            this.skinButton_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.skinButton_minimize.BackRectangle = new System.Drawing.Rectangle(10, 10, 16, 16);
            this.skinButton_minimize.BaseColor = System.Drawing.Color.Transparent;
            this.skinButton_minimize.BorderColor = System.Drawing.Color.Transparent;
            this.skinButton_minimize.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinButton_minimize.DownBack = null;
            this.skinButton_minimize.DownBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_minimize.GlowColor = System.Drawing.Color.Transparent;
            this.skinButton_minimize.ImageSize = new System.Drawing.Size(16, 16);
            this.skinButton_minimize.InnerBorderColor = System.Drawing.Color.Transparent;
            this.skinButton_minimize.IsDrawBorder = false;
            this.skinButton_minimize.IsDrawGlass = false;
            this.skinButton_minimize.Location = new System.Drawing.Point(126, 16);
            this.skinButton_minimize.MouseBack = null;
            this.skinButton_minimize.MouseBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_minimize.Name = "skinButton_minimize";
            this.skinButton_minimize.NormlBack = null;
            this.skinButton_minimize.Size = new System.Drawing.Size(16, 16);
            this.skinButton_minimize.TabIndex = 3;
            this.skinButton_minimize.Tag = "mini模式";
            this.skinButton_minimize.UseVisualStyleBackColor = false;
            this.skinButton_minimize.Click += new System.EventHandler(this.skinButton_minimize_Click);
            this.skinButton_minimize.MouseLeave += new System.EventHandler(this.skinButton_minimize_MouseLeave);
            this.skinButton_minimize.MouseHover += new System.EventHandler(this.skinButton_minimize_MouseHover);
            // 
            // skinButton_mix
            // 
            this.skinButton_mix.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_mix.BackgroundImage = global::MusicNetease.Properties.Resources.min0;
            this.skinButton_mix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.skinButton_mix.BackRectangle = new System.Drawing.Rectangle(10, 10, 16, 16);
            this.skinButton_mix.BaseColor = System.Drawing.Color.Transparent;
            this.skinButton_mix.BorderColor = System.Drawing.Color.Transparent;
            this.skinButton_mix.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_mix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinButton_mix.DownBack = null;
            this.skinButton_mix.DownBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_mix.GlowColor = System.Drawing.Color.Transparent;
            this.skinButton_mix.ImageSize = new System.Drawing.Size(16, 16);
            this.skinButton_mix.InnerBorderColor = System.Drawing.Color.Transparent;
            this.skinButton_mix.IsDrawBorder = false;
            this.skinButton_mix.IsDrawGlass = false;
            this.skinButton_mix.Location = new System.Drawing.Point(152, 16);
            this.skinButton_mix.MouseBack = null;
            this.skinButton_mix.MouseBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_mix.Name = "skinButton_mix";
            this.skinButton_mix.NormlBack = null;
            this.skinButton_mix.Size = new System.Drawing.Size(16, 16);
            this.skinButton_mix.TabIndex = 2;
            this.skinButton_mix.Tag = "最小化";
            this.skinButton_mix.UseVisualStyleBackColor = false;
            this.skinButton_mix.Click += new System.EventHandler(this.skinButton_mix_Click);
            this.skinButton_mix.MouseLeave += new System.EventHandler(this.skinButton_mix_MouseLeave);
            this.skinButton_mix.MouseHover += new System.EventHandler(this.skinButton_mix_MouseHover);
            // 
            // skinButton_max
            // 
            this.skinButton_max.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_max.BackgroundImage = global::MusicNetease.Properties.Resources.max0;
            this.skinButton_max.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.skinButton_max.BackRectangle = new System.Drawing.Rectangle(10, 10, 16, 16);
            this.skinButton_max.BaseColor = System.Drawing.Color.Transparent;
            this.skinButton_max.BorderColor = System.Drawing.Color.Transparent;
            this.skinButton_max.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_max.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinButton_max.DownBack = null;
            this.skinButton_max.DownBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_max.GlowColor = System.Drawing.Color.Transparent;
            this.skinButton_max.ImageSize = new System.Drawing.Size(16, 16);
            this.skinButton_max.InnerBorderColor = System.Drawing.Color.Transparent;
            this.skinButton_max.IsDrawBorder = false;
            this.skinButton_max.IsDrawGlass = false;
            this.skinButton_max.Location = new System.Drawing.Point(177, 16);
            this.skinButton_max.MouseBack = null;
            this.skinButton_max.MouseBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_max.Name = "skinButton_max";
            this.skinButton_max.NormlBack = null;
            this.skinButton_max.Size = new System.Drawing.Size(16, 16);
            this.skinButton_max.TabIndex = 1;
            this.skinButton_max.Tag = "最大化";
            this.skinButton_max.UseVisualStyleBackColor = false;
            this.skinButton_max.Click += new System.EventHandler(this.skinButton_max_Click);
            this.skinButton_max.MouseLeave += new System.EventHandler(this.skinButton_max_MouseLeave);
            this.skinButton_max.MouseHover += new System.EventHandler(this.skinButton_max_MouseHover);
            // 
            // skinButton_close
            // 
            this.skinButton_close.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_close.BackgroundImage = global::MusicNetease.Properties.Resources.close0;
            this.skinButton_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.skinButton_close.BackRectangle = new System.Drawing.Rectangle(10, 10, 16, 16);
            this.skinButton_close.BaseColor = System.Drawing.Color.Transparent;
            this.skinButton_close.BorderColor = System.Drawing.Color.Transparent;
            this.skinButton_close.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinButton_close.DownBack = null;
            this.skinButton_close.DownBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_close.GlowColor = System.Drawing.Color.Transparent;
            this.skinButton_close.ImageSize = new System.Drawing.Size(16, 16);
            this.skinButton_close.InnerBorderColor = System.Drawing.Color.Transparent;
            this.skinButton_close.IsDrawBorder = false;
            this.skinButton_close.IsDrawGlass = false;
            this.skinButton_close.Location = new System.Drawing.Point(205, 16);
            this.skinButton_close.MouseBack = null;
            this.skinButton_close.MouseBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_close.Name = "skinButton_close";
            this.skinButton_close.NormlBack = null;
            this.skinButton_close.Size = new System.Drawing.Size(16, 16);
            this.skinButton_close.TabIndex = 0;
            this.skinButton_close.Tag = "关闭";
            this.skinButton_close.UseVisualStyleBackColor = false;
            this.skinButton_close.Click += new System.EventHandler(this.skinButton_close_Click);
            this.skinButton_close.MouseLeave += new System.EventHandler(this.skinButton_close_MouseLeave);
            this.skinButton_close.MouseHover += new System.EventHandler(this.skinButton_close_MouseHover);
            // 
            // skinPictureBox1
            // 
            this.skinPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox1.BackgroundImage = global::MusicNetease.Properties.Resources.NeteaseLogo;
            this.skinPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.skinPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinPictureBox1.Location = new System.Drawing.Point(5, 9);
            this.skinPictureBox1.Name = "skinPictureBox1";
            this.skinPictureBox1.Size = new System.Drawing.Size(137, 30);
            this.skinPictureBox1.TabIndex = 0;
            this.skinPictureBox1.TabStop = false;
            this.skinPictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.skinPanel_top_MouseDown);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.skinContextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "网易云音乐";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // skinContextMenuStrip1
            // 
            this.skinContextMenuStrip1.Arrow = System.Drawing.Color.Black;
            this.skinContextMenuStrip1.Back = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
            this.skinContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
            this.skinContextMenuStrip1.BackRadius = 4;
            this.skinContextMenuStrip1.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.skinContextMenuStrip1.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinContextMenuStrip1.Fore = System.Drawing.Color.Black;
            this.skinContextMenuStrip1.HoverFore = System.Drawing.Color.White;
            this.skinContextMenuStrip1.ItemAnamorphosis = true;
            this.skinContextMenuStrip1.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinContextMenuStrip1.ItemBorderShow = true;
            this.skinContextMenuStrip1.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinContextMenuStrip1.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinContextMenuStrip1.ItemRadius = 4;
            this.skinContextMenuStrip1.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Exit,
            this.toolStripMenuItem_Set,
            this.toolStripMenuItem_lock});
            this.skinContextMenuStrip1.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinContextMenuStrip1.Name = "skinContextMenuStrip1";
            this.skinContextMenuStrip1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinContextMenuStrip1.Size = new System.Drawing.Size(149, 70);
            this.skinContextMenuStrip1.SkinAllColor = true;
            this.skinContextMenuStrip1.TitleAnamorphosis = true;
            this.skinContextMenuStrip1.TitleColor = System.Drawing.Color.Transparent;
            this.skinContextMenuStrip1.TitleRadius = 4;
            this.skinContextMenuStrip1.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // toolStripMenuItem_Exit
            // 
            this.toolStripMenuItem_Exit.Image = global::MusicNetease.Properties.Resources.exit;
            this.toolStripMenuItem_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem_Exit.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem_Exit.Name = "toolStripMenuItem_Exit";
            this.toolStripMenuItem_Exit.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem_Exit.Text = "退出";
            this.toolStripMenuItem_Exit.Click += new System.EventHandler(this.toolStripMenuItem_Exit_Click);
            // 
            // toolStripMenuItem_Set
            // 
            this.toolStripMenuItem_Set.Image = global::MusicNetease.Properties.Resources.set;
            this.toolStripMenuItem_Set.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem_Set.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem_Set.Name = "toolStripMenuItem_Set";
            this.toolStripMenuItem_Set.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem_Set.Text = "设置";
            this.toolStripMenuItem_Set.Click += new System.EventHandler(this.toolStripMenuItem_Set_Click);
            // 
            // toolStripMenuItem_lock
            // 
            this.toolStripMenuItem_lock.Image = global::MusicNetease.Properties.Resources._lock;
            this.toolStripMenuItem_lock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem_lock.Name = "toolStripMenuItem_lock";
            this.toolStripMenuItem_lock.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem_lock.Text = "锁定桌面歌词";
            this.toolStripMenuItem_lock.Click += new System.EventHandler(this.toolStripMenuItem_lock_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1022, 670);
            this.ControlBox = false;
            this.Controls.Add(this.skinPanel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MdiBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1022, 670);
            this.Name = "BaseForm";
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.ShowSystemMenu = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.ClientSizeChanged += new System.EventHandler(this.BaseForm_ClientSizeChanged);
            this.skinPanel_top.ResumeLayout(false);
            this.skinPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).EndInit();
            this.skinContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinPanel skinPanel_top;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox1;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinButton skinButton_close;
        private CCWin.SkinControl.SkinButton skinButton_max;
        private CCWin.SkinControl.SkinButton skinButton_mix;
        private CCWin.SkinControl.SkinContextMenuStrip skinContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Exit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Set;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_lock;
        private CCWin.SkinControl.SkinButton skinButton_minimize;
        private CCWin.SkinControl.SkinButton skinButton_skin;
        private CCWin.SkinControl.SkinButton skinButton_email;
        private CCWin.SkinControl.SkinButton skinButton_Set;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

