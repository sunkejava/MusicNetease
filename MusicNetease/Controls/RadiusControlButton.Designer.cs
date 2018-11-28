namespace MusicNetease.Controls
{
    partial class RadiusControlButton
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
            this.radiusControl1 = new MusicNetease.Controls.RadiusControl();
            this.skinButton_play = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // radiusControl1
            // 
            this.radiusControl1.BackColor = System.Drawing.Color.Transparent;
            this.radiusControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radiusControl1.Location = new System.Drawing.Point(0, 0);
            this.radiusControl1.Name = "radiusControl1";
            this.radiusControl1.Radius = 80;
            this.radiusControl1.SetBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
            this.radiusControl1.Size = new System.Drawing.Size(80, 80);
            this.radiusControl1.TabIndex = 0;
            // 
            // skinButton_play
            // 
            this.skinButton_play.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinButton_play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
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
            this.skinButton_play.Location = new System.Drawing.Point(20, 20);
            this.skinButton_play.MouseBack = null;
            this.skinButton_play.MouseBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_play.Name = "skinButton_play";
            this.skinButton_play.NormlBack = null;
            this.skinButton_play.Size = new System.Drawing.Size(40, 40);
            this.skinButton_play.TabIndex = 8;
            this.skinButton_play.Tag = "播放";
            this.skinButton_play.UseVisualStyleBackColor = false;
            // 
            // RadiusControlButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.skinButton_play);
            this.Controls.Add(this.radiusControl1);
            this.Name = "RadiusControlButton";
            this.Size = new System.Drawing.Size(80, 80);
            this.ResumeLayout(false);

        }

        #endregion

        private RadiusControl radiusControl1;
        private CCWin.SkinControl.SkinButton skinButton_play;
    }
}
