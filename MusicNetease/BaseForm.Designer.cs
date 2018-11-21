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
            this.skinPanel_top = new CCWin.SkinControl.SkinPanel();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.skinButton_close = new CCWin.SkinControl.SkinButton();
            this.skinPictureBox1 = new CCWin.SkinControl.SkinPictureBox();
            this.skinPanel_top.SuspendLayout();
            this.skinPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).BeginInit();
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
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.skinButton_close);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(732, 3);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(287, 44);
            this.skinPanel1.TabIndex = 1;
            // 
            // skinButton_close
            // 
            this.skinButton_close.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_close.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_close.DownBack = null;
            this.skinButton_close.Location = new System.Drawing.Point(110, 10);
            this.skinButton_close.MouseBack = null;
            this.skinButton_close.Name = "skinButton_close";
            this.skinButton_close.NormlBack = null;
            this.skinButton_close.Size = new System.Drawing.Size(25, 25);
            this.skinButton_close.TabIndex = 0;
            this.skinButton_close.UseVisualStyleBackColor = false;
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
            this.skinPanel_top.ResumeLayout(false);
            this.skinPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinPanel skinPanel_top;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox1;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinButton skinButton_close;
    }
}

