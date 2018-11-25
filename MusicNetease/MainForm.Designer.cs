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
            this.skinPanel3 = new CCWin.SkinControl.SkinPanel();
            this.musicPlayerButton1 = new MusicNetease.Controls.MusicPlayerButton();
            this.menuListControl1 = new MusicNetease.Controls.MenuListControl();
            this.skinPanel3.SuspendLayout();
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
            // menuListControl1
            // 
            this.menuListControl1.BackColor = System.Drawing.Color.Transparent;
            this.menuListControl1.Location = new System.Drawing.Point(0, 50);
            this.menuListControl1.Name = "menuListControl1";
            this.menuListControl1.Size = new System.Drawing.Size(175, 568);
            this.menuListControl1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(1022, 670);
            this.Controls.Add(this.menuListControl1);
            this.Controls.Add(this.skinPanel3);
            this.Name = "MainForm";
            this.Controls.SetChildIndex(this.skinPanel3, 0);
            this.Controls.SetChildIndex(this.menuListControl1, 0);
            this.skinPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinPanel skinPanel3;
        private Controls.MusicPlayerButton musicPlayerButton1;
        private Controls.MenuListControl menuListControl1;
    }
}
