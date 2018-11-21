namespace MusicNetease
{
    partial class FormMessage
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
            this.components = new System.ComponentModel.Container();
            this.skinPanel_Top = new CCWin.SkinControl.SkinPanel();
            this.skinLabel_Name = new CCWin.SkinControl.SkinLabel();
            this.skinButton_Close = new CCWin.SkinControl.SkinButton();
            this.skinPanel_context = new CCWin.SkinControl.SkinPanel();
            this.skinTextBox_Context = new CCWin.SkinControl.SkinLabel();
            this.skinPictureBox_icon = new CCWin.SkinControl.SkinPictureBox();
            this.skinPanel_Bottom = new CCWin.SkinControl.SkinPanel();
            this.skinButton_No = new CCWin.SkinControl.SkinButton();
            this.skinButton_ok = new CCWin.SkinControl.SkinButton();
            this.skinPanel_Top.SuspendLayout();
            this.skinPanel_context.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox_icon)).BeginInit();
            this.skinPanel_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinPanel_Top
            // 
            this.skinPanel_Top.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinPanel_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
            this.skinPanel_Top.Controls.Add(this.skinLabel_Name);
            this.skinPanel_Top.Controls.Add(this.skinButton_Close);
            this.skinPanel_Top.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel_Top.DownBack = null;
            this.skinPanel_Top.Location = new System.Drawing.Point(0, 0);
            this.skinPanel_Top.MouseBack = null;
            this.skinPanel_Top.Name = "skinPanel_Top";
            this.skinPanel_Top.NormlBack = null;
            this.skinPanel_Top.Size = new System.Drawing.Size(336, 30);
            this.skinPanel_Top.TabIndex = 0;
            this.skinPanel_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.skinPanel_Top_MouseDown);
            // 
            // skinLabel_Name
            // 
            this.skinLabel_Name.AutoSize = true;
            this.skinLabel_Name.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel_Name.BorderColor = System.Drawing.Color.White;
            this.skinLabel_Name.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(135)));
            this.skinLabel_Name.ForeColor = System.Drawing.Color.White;
            this.skinLabel_Name.Location = new System.Drawing.Point(7, 7);
            this.skinLabel_Name.Name = "skinLabel_Name";
            this.skinLabel_Name.Size = new System.Drawing.Size(37, 20);
            this.skinLabel_Name.TabIndex = 1;
            this.skinLabel_Name.Text = "标题";
            this.skinLabel_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skinButton_Close
            // 
            this.skinButton_Close.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_Close.BackgroundImage = global::MusicNetease.Properties.Resources.close0;
            this.skinButton_Close.BaseColor = System.Drawing.Color.Transparent;
            this.skinButton_Close.BorderColor = System.Drawing.Color.Transparent;
            this.skinButton_Close.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinButton_Close.DownBack = null;
            this.skinButton_Close.DownBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_Close.ForeColor = System.Drawing.Color.Transparent;
            this.skinButton_Close.ForeColorSuit = true;
            this.skinButton_Close.IsDrawBorder = false;
            this.skinButton_Close.IsDrawGlass = false;
            this.skinButton_Close.Location = new System.Drawing.Point(309, 8);
            this.skinButton_Close.MouseBack = null;
            this.skinButton_Close.MouseBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_Close.Name = "skinButton_Close";
            this.skinButton_Close.NormlBack = null;
            this.skinButton_Close.Size = new System.Drawing.Size(16, 16);
            this.skinButton_Close.TabIndex = 0;
            this.skinButton_Close.UseVisualStyleBackColor = false;
            this.skinButton_Close.Click += new System.EventHandler(this.skinButton_Close_Click);
            this.skinButton_Close.MouseLeave += new System.EventHandler(this.skinButton_Close_MouseLeave);
            this.skinButton_Close.MouseHover += new System.EventHandler(this.skinButton_Close_MouseHover);
            // 
            // skinPanel_context
            // 
            this.skinPanel_context.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel_context.Controls.Add(this.skinTextBox_Context);
            this.skinPanel_context.Controls.Add(this.skinPictureBox_icon);
            this.skinPanel_context.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel_context.DownBack = null;
            this.skinPanel_context.Location = new System.Drawing.Point(0, 30);
            this.skinPanel_context.MouseBack = null;
            this.skinPanel_context.Name = "skinPanel_context";
            this.skinPanel_context.NormlBack = null;
            this.skinPanel_context.Size = new System.Drawing.Size(336, 125);
            this.skinPanel_context.TabIndex = 1;
            // 
            // skinTextBox_Context
            // 
            this.skinTextBox_Context.AutoSize = true;
            this.skinTextBox_Context.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox_Context.BorderColor = System.Drawing.Color.White;
            this.skinTextBox_Context.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinTextBox_Context.Location = new System.Drawing.Point(71, 41);
            this.skinTextBox_Context.Name = "skinTextBox_Context";
            this.skinTextBox_Context.Size = new System.Drawing.Size(26, 17);
            this.skinTextBox_Context.TabIndex = 3;
            this.skinTextBox_Context.Text = "......";
            this.skinTextBox_Context.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skinPictureBox_icon
            // 
            this.skinPictureBox_icon.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox_icon.Location = new System.Drawing.Point(15, 28);
            this.skinPictureBox_icon.Name = "skinPictureBox_icon";
            this.skinPictureBox_icon.Size = new System.Drawing.Size(50, 50);
            this.skinPictureBox_icon.TabIndex = 2;
            this.skinPictureBox_icon.TabStop = false;
            // 
            // skinPanel_Bottom
            // 
            this.skinPanel_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
            this.skinPanel_Bottom.Controls.Add(this.skinButton_No);
            this.skinPanel_Bottom.Controls.Add(this.skinButton_ok);
            this.skinPanel_Bottom.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel_Bottom.DownBack = null;
            this.skinPanel_Bottom.Location = new System.Drawing.Point(0, 155);
            this.skinPanel_Bottom.MouseBack = null;
            this.skinPanel_Bottom.Name = "skinPanel_Bottom";
            this.skinPanel_Bottom.NormlBack = null;
            this.skinPanel_Bottom.Size = new System.Drawing.Size(336, 30);
            this.skinPanel_Bottom.TabIndex = 2;
            // 
            // skinButton_No
            // 
            this.skinButton_No.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_No.BaseColor = System.Drawing.Color.Transparent;
            this.skinButton_No.BorderColor = System.Drawing.Color.Transparent;
            this.skinButton_No.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_No.DownBack = null;
            this.skinButton_No.DownBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_No.Location = new System.Drawing.Point(216, 3);
            this.skinButton_No.MouseBack = null;
            this.skinButton_No.MouseBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_No.Name = "skinButton_No";
            this.skinButton_No.NormlBack = null;
            this.skinButton_No.Size = new System.Drawing.Size(55, 23);
            this.skinButton_No.TabIndex = 1;
            this.skinButton_No.Text = "取消";
            this.skinButton_No.UseVisualStyleBackColor = false;
            this.skinButton_No.Click += new System.EventHandler(this.skinButton_No_Click);
            // 
            // skinButton_ok
            // 
            this.skinButton_ok.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_ok.BaseColor = System.Drawing.Color.Transparent;
            this.skinButton_ok.BorderColor = System.Drawing.Color.Transparent;
            this.skinButton_ok.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_ok.DownBack = null;
            this.skinButton_ok.DownBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_ok.Location = new System.Drawing.Point(58, 3);
            this.skinButton_ok.MouseBack = null;
            this.skinButton_ok.MouseBaseColor = System.Drawing.Color.Transparent;
            this.skinButton_ok.Name = "skinButton_ok";
            this.skinButton_ok.NormlBack = null;
            this.skinButton_ok.Size = new System.Drawing.Size(55, 23);
            this.skinButton_ok.TabIndex = 0;
            this.skinButton_ok.Text = "确认";
            this.skinButton_ok.UseVisualStyleBackColor = false;
            this.skinButton_ok.Click += new System.EventHandler(this.skinButton_ok_Click);
            // 
            // FormMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(336, 185);
            this.ControlBox = false;
            this.Controls.Add(this.skinPanel_Bottom);
            this.Controls.Add(this.skinPanel_context);
            this.Controls.Add(this.skinPanel_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMessage";
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.skinPanel_Top.ResumeLayout(false);
            this.skinPanel_Top.PerformLayout();
            this.skinPanel_context.ResumeLayout(false);
            this.skinPanel_context.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox_icon)).EndInit();
            this.skinPanel_Bottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinPanel skinPanel_Top;
        private CCWin.SkinControl.SkinButton skinButton_Close;
        private CCWin.SkinControl.SkinLabel skinLabel_Name;
        private CCWin.SkinControl.SkinPanel skinPanel_context;
        private CCWin.SkinControl.SkinPanel skinPanel_Bottom;
        private CCWin.SkinControl.SkinButton skinButton_ok;
        private CCWin.SkinControl.SkinButton skinButton_No;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox_icon;
        private CCWin.SkinControl.SkinLabel skinTextBox_Context;
    }
}