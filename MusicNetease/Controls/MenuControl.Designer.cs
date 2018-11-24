namespace MusicNetease.Controls
{
    partial class MenuControl
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
            this.skinPanel_dc = new CCWin.SkinControl.SkinPanel();
            this.skinPanel_sc = new CCWin.SkinControl.SkinPanel();
            this.skinButton_icon = new CCWin.SkinControl.SkinButton();
            this.skinLabel_name = new CCWin.SkinControl.SkinLabel();
            this.skinPanel_dc.SuspendLayout();
            this.skinPanel_sc.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinPanel_dc
            // 
            this.skinPanel_dc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.skinPanel_dc.Controls.Add(this.skinPanel_sc);
            this.skinPanel_dc.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel_dc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinPanel_dc.DownBack = null;
            this.skinPanel_dc.Location = new System.Drawing.Point(0, 0);
            this.skinPanel_dc.MouseBack = null;
            this.skinPanel_dc.Name = "skinPanel_dc";
            this.skinPanel_dc.NormlBack = null;
            this.skinPanel_dc.Size = new System.Drawing.Size(165, 28);
            this.skinPanel_dc.TabIndex = 0;
            this.skinPanel_dc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.skinPanel_sc_MouseDown);
            // 
            // skinPanel_sc
            // 
            this.skinPanel_sc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinPanel_sc.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel_sc.Controls.Add(this.skinButton_icon);
            this.skinPanel_sc.Controls.Add(this.skinLabel_name);
            this.skinPanel_sc.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel_sc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinPanel_sc.DownBack = null;
            this.skinPanel_sc.Location = new System.Drawing.Point(6, 0);
            this.skinPanel_sc.MouseBack = null;
            this.skinPanel_sc.Name = "skinPanel_sc";
            this.skinPanel_sc.NormlBack = null;
            this.skinPanel_sc.Size = new System.Drawing.Size(159, 28);
            this.skinPanel_sc.TabIndex = 0;
            this.skinPanel_sc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.skinPanel_sc_MouseDown);
            // 
            // skinButton_icon
            // 
            this.skinButton_icon.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_icon.BackgroundImage = global::MusicNetease.Properties.Resources.music0;
            this.skinButton_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.skinButton_icon.BackRectangle = new System.Drawing.Rectangle(10, 10, 16, 16);
            this.skinButton_icon.BaseColor = System.Drawing.Color.Transparent;
            this.skinButton_icon.BorderColor = System.Drawing.Color.Transparent;
            this.skinButton_icon.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinButton_icon.DownBack = null;
            this.skinButton_icon.DownBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_icon.GlowColor = System.Drawing.Color.Transparent;
            this.skinButton_icon.ImageSize = new System.Drawing.Size(16, 16);
            this.skinButton_icon.InnerBorderColor = System.Drawing.Color.Transparent;
            this.skinButton_icon.IsDrawBorder = false;
            this.skinButton_icon.IsDrawGlass = false;
            this.skinButton_icon.Location = new System.Drawing.Point(15, 5);
            this.skinButton_icon.MouseBack = global::MusicNetease.Properties.Resources.music1;
            this.skinButton_icon.MouseBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_icon.Name = "skinButton_icon";
            this.skinButton_icon.NormlBack = global::MusicNetease.Properties.Resources.music0;
            this.skinButton_icon.Size = new System.Drawing.Size(16, 16);
            this.skinButton_icon.TabIndex = 7;
            this.skinButton_icon.Tag = "换肤";
            this.skinButton_icon.UseVisualStyleBackColor = false;
            this.skinButton_icon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.skinPanel_sc_MouseDown);
            this.skinButton_icon.MouseLeave += new System.EventHandler(this.skinButton_icon_MouseLeave);
            this.skinButton_icon.MouseHover += new System.EventHandler(this.skinButton_icon_MouseHover);
            // 
            // skinLabel_name
            // 
            this.skinLabel_name.AutoSize = true;
            this.skinLabel_name.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel_name.BorderColor = System.Drawing.Color.White;
            this.skinLabel_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinLabel_name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel_name.Location = new System.Drawing.Point(43, 5);
            this.skinLabel_name.Name = "skinLabel_name";
            this.skinLabel_name.Size = new System.Drawing.Size(56, 17);
            this.skinLabel_name.TabIndex = 0;
            this.skinLabel_name.Text = "我的音乐";
            this.skinLabel_name.MouseDown += new System.Windows.Forms.MouseEventHandler(this.skinPanel_sc_MouseDown);
            // 
            // MenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skinPanel_dc);
            this.Name = "MenuControl";
            this.Size = new System.Drawing.Size(165, 28);
            this.skinPanel_dc.ResumeLayout(false);
            this.skinPanel_sc.ResumeLayout(false);
            this.skinPanel_sc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public CCWin.SkinControl.SkinLabel skinLabel_name;
        public CCWin.SkinControl.SkinButton skinButton_icon;
        public CCWin.SkinControl.SkinPanel skinPanel_sc;
        public CCWin.SkinControl.SkinPanel skinPanel_dc;
    }
}
