using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;
using static MusicNetease.decline.Enums;
using System.Runtime.InteropServices;

namespace MusicNetease
{
    public partial class BaseForm : CCSkinMain
    {
        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        private static extern int SendMessage(int hwnd, int wMsg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern int ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0XA1;   //.定义鼠標左鍵按下
        private const int HTCAPTION = 2;

        public BaseForm()
        {
            InitializeComponent();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }

        private void skinButton_close_MouseHover(object sender, EventArgs e)
        {
            CCWin.SkinControl.SkinButton btn = sender as CCWin.SkinControl.SkinButton;
            btn.BackgroundImage = global::MusicNetease.Properties.Resources.close1;
        }

        private void skinButton_close_MouseLeave(object sender, EventArgs e)
        {
            CCWin.SkinControl.SkinButton btn = sender as CCWin.SkinControl.SkinButton;
            btn.BackgroundImage = global::MusicNetease.Properties.Resources.close0;
        }

        private void skinButton_close_Click(object sender, EventArgs e)
        {
            if (FormMessage.Show("是否关闭软件", InformationBoxIcon.Question) == DialogResult.OK)
            {
                this.Dispose();
                this.Close();
            }

        }

        private void skinPanel_top_MouseDown(object sender, MouseEventArgs e)
        {
            //为当前的应用程序释放鼠标捕获
            ReleaseCapture();
            //发送消息﹐让系統误以为在标题栏上按下鼠标
            SendMessage((int)this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        private void skinButton_max_Click(object sender, EventArgs e)
        {
            if (this.Width == Screen.GetWorkingArea(this).Width)
            {
                //还原窗体显示    
                this.WindowState = FormWindowState.Normal;
                //this.Width = 1022;
                //this.Height = 670;
                //this.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                //this.Width = Screen.GetWorkingArea(this).Width;
                //this.Height = Screen.GetWorkingArea(this).Height;
            }
            
        }

        private void skinButton_max_MouseHover(object sender, EventArgs e)
        {
            CCWin.SkinControl.SkinButton btn = sender as CCWin.SkinControl.SkinButton;
            btn.BackgroundImage = global::MusicNetease.Properties.Resources.max1;
        }

        private void skinButton_max_MouseLeave(object sender, EventArgs e)
        {
            CCWin.SkinControl.SkinButton btn = sender as CCWin.SkinControl.SkinButton;
            btn.BackgroundImage = global::MusicNetease.Properties.Resources.max0;
        }

        private void skinButton_mix_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void skinButton_mix_MouseHover(object sender, EventArgs e)
        {
            CCWin.SkinControl.SkinButton btn = sender as CCWin.SkinControl.SkinButton;
            btn.BackgroundImage = global::MusicNetease.Properties.Resources.min1;
        }

        private void skinButton_mix_MouseLeave(object sender, EventArgs e)
        {
            CCWin.SkinControl.SkinButton btn = sender as CCWin.SkinControl.SkinButton;
            btn.BackgroundImage = global::MusicNetease.Properties.Resources.min0;
        }

        private void toolStripMenuItem_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void toolStripMenuItem_Set_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem_lock_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                //还原窗体显示    
                this.WindowState = FormWindowState.Normal;
                //激活窗体并给予它焦点
                this.Activate();
                //任务栏区显示图标
                this.ShowInTaskbar = true;
                //托盘区图标隐藏
                //notifyIcon1.Visible = false;
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                skinContextMenuStrip1.Show();
            }
        }

        private void BaseForm_ClientSizeChanged(object sender, EventArgs e)
        {
            this.skinPanel_top.Width = this.Width;
            this.skinPanel_top.Left = 0;
            this.skinPanel_top.Top = 0;
        }

        private void skinButton_minimize_Click(object sender, EventArgs e)
        {

        }

        private void skinButton_minimize_MouseHover(object sender, EventArgs e)
        {
            CCWin.SkinControl.SkinButton btn = sender as CCWin.SkinControl.SkinButton;
            btn.BackgroundImage = global::MusicNetease.Properties.Resources.minimize1;
        }

        private void skinButton_minimize_MouseLeave(object sender, EventArgs e)
        {
            CCWin.SkinControl.SkinButton btn = sender as CCWin.SkinControl.SkinButton;
            btn.BackgroundImage = global::MusicNetease.Properties.Resources.minimize0;
        }

        private void skinButton_Set_Click(object sender, EventArgs e)
        {

        }

        private void skinButton_Set_MouseHover(object sender, EventArgs e)
        {
            CCWin.SkinControl.SkinButton btn = sender as CCWin.SkinControl.SkinButton;
            btn.BackgroundImage = global::MusicNetease.Properties.Resources.set1;
        }

        private void skinButton_Set_MouseLeave(object sender, EventArgs e)
        {
            CCWin.SkinControl.SkinButton btn = sender as CCWin.SkinControl.SkinButton;
            btn.BackgroundImage = global::MusicNetease.Properties.Resources.set0;
        }

        private void skinButton_email_Click(object sender, EventArgs e)
        {

        }

        private void skinButton_email_MouseHover(object sender, EventArgs e)
        {
            CCWin.SkinControl.SkinButton btn = sender as CCWin.SkinControl.SkinButton;
            btn.BackgroundImage = global::MusicNetease.Properties.Resources.email1;
        }

        private void skinButton_email_MouseLeave(object sender, EventArgs e)
        {
            CCWin.SkinControl.SkinButton btn = sender as CCWin.SkinControl.SkinButton;
            btn.BackgroundImage = global::MusicNetease.Properties.Resources.email0;
        }

        private void skinButton_skin_Click(object sender, EventArgs e)
        {

        }

        private void skinButton_skin_MouseHover(object sender, EventArgs e)
        {
            CCWin.SkinControl.SkinButton btn = sender as CCWin.SkinControl.SkinButton;
            btn.BackgroundImage = global::MusicNetease.Properties.Resources.skin1;
        }

        private void skinButton_skin_MouseLeave(object sender, EventArgs e)
        {
            CCWin.SkinControl.SkinButton btn = sender as CCWin.SkinControl.SkinButton;
            btn.BackgroundImage = global::MusicNetease.Properties.Resources.skin0;
        }

        private void skinButton_close_MouseEnter(object sender, EventArgs e)
        {
            CCWin.SkinControl.SkinButton btn = sender as CCWin.SkinControl.SkinButton;
            skinToolTip1.ShowAlways = true;
            skinToolTip1.SetToolTip(btn, btn.Tag.ToString());
        }

        private void skinButton_forward_Click(object sender, EventArgs e)
        {

        }

        private void skinButton_back_Click(object sender, EventArgs e)
        {

        }

        private void skinButton_back_MouseHover(object sender, EventArgs e)
        {
            CCWin.SkinControl.SkinButton btn = sender as CCWin.SkinControl.SkinButton;
            btn.BackgroundImage = global::MusicNetease.Properties.Resources.back1;
        }

        private void skinButton_back_MouseLeave(object sender, EventArgs e)
        {
            CCWin.SkinControl.SkinButton btn = sender as CCWin.SkinControl.SkinButton;
            btn.BackgroundImage = global::MusicNetease.Properties.Resources.back0;
        }

        private void skinButton_forward_MouseHover(object sender, EventArgs e)
        {
            CCWin.SkinControl.SkinButton btn = sender as CCWin.SkinControl.SkinButton;
            btn.BackgroundImage = global::MusicNetease.Properties.Resources.forward1;
        }

        private void skinButton_forward_MouseLeave(object sender, EventArgs e)
        {
            CCWin.SkinControl.SkinButton btn = sender as CCWin.SkinControl.SkinButton;
            btn.BackgroundImage = global::MusicNetease.Properties.Resources.forward0;
        }

        private void skinButton_User_Click(object sender, EventArgs e)
        {

        }

        private void skinButton_User_MouseHover(object sender, EventArgs e)
        {
            this.skinButton_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skinButton_userDown.BackgroundImage = global::MusicNetease.Properties.Resources.icon_down1;
        }

        private void skinButton_User_MouseLeave(object sender, EventArgs e)
        {
            this.skinButton_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.skinButton_userDown.BackgroundImage = global::MusicNetease.Properties.Resources.icon_down0;
        }

        private void skinPanel3_Paint(object sender, PaintEventArgs e)
        {
            CCWin.SkinControl.SkinPanel skinPanel = sender as CCWin.SkinControl.SkinPanel;
            Utils.PaintDraw.Draw(e.ClipRectangle, e.Graphics, skinPanel.Width, false, skinPanel.BackColor, skinPanel.BackColor);
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.DrawString("其实我是个Panel", new Font("微软雅黑", 9, FontStyle.Regular), new SolidBrush(Color.White), new PointF(10, 10));
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            Utils.RoundPanel rpnel = new Utils.RoundPanel();
            rpnel.Back = Color.FromArgb(0, 255, 92, 138);
            rpnel.MatrixRound = 50;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
