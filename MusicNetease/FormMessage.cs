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
using System.Runtime.InteropServices;
using static MusicNetease.decline.Enums;

namespace MusicNetease
{
    public partial class FormMessage : CCSkinMain
    {

        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        private static extern int SendMessage(int hwnd, int wMsg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern int ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0XA1;   //.定义鼠標左鍵按下
        private const int HTCAPTION = 2;

        private  FormMessage() : this("这是提示信息","温馨提示：", InformationBoxIcon.Information) { }

        /// <summary>
        /// 系统提示
        /// </summary>
        /// <param name="conText">提示内容</param>
        private FormMessage(string conText) : this(conText, "温馨提示：", InformationBoxIcon.Information) { }

        /// <summary>
        /// 系统提示
        /// </summary>
        /// <param name="context">提示内容</param>
        /// <param name="title">提示标题</param>
        /// <param name="icon">消息类型</param>
        private FormMessage(string context, string title, InformationBoxIcon icon)
        {
            InitializeComponent();
            skinLabel_Name.Text = title;
            skinTextBox_Context.Text = context;
            switch (icon)
            {
                case InformationBoxIcon.Error:
                    skinPictureBox_icon.BackgroundImage = Properties.Resources.error;
                    skinButton_No.Visible = false;
                    skinButton_ok.Location = new Point((this.Width - skinButton_ok.Width) / 2, 3);
                    break;
                case InformationBoxIcon.Information:
                    skinPictureBox_icon.BackgroundImage = Properties.Resources.Information;
                    skinButton_No.Visible = false;
                    skinButton_ok.Location = new Point((this.Width - skinButton_ok.Width) / 2, 3);
                    break;
                case InformationBoxIcon.Question:
                    skinPictureBox_icon.BackgroundImage = Properties.Resources.Question;
                    break;
                case InformationBoxIcon.Warning:
                    skinPictureBox_icon.BackgroundImage = Properties.Resources.warning;
                    skinButton_No.Visible = false;
                    skinButton_ok.Location = new Point((this.Width - skinButton_ok.Width) / 2, 3);
                    break;
                default:
                    break;
            }
        }
        
        /// <summary>
        /// 显示提示信息
        /// </summary>
        /// <param name="context"></param>
        /// <param name="title"></param>
        /// <param name="isYn"></param>
        /// <returns></returns>
        public static DialogResult Show(string context, string title, InformationBoxIcon isYn)
        {
            FormMessage msg = new FormMessage(context,title, isYn);
            return msg.ShowDialog();
        }

        public static DialogResult Show(string context)
        {
            FormMessage msg = new FormMessage(context, "温馨提示", InformationBoxIcon.Information);
            return msg.ShowDialog();
        }

        public static DialogResult Show(string context, string title)
        {
            FormMessage msg = new FormMessage(context, title, InformationBoxIcon.Information);
            return msg.ShowDialog();
        }
        public static DialogResult Show(string context, InformationBoxIcon isYn)
        {
            FormMessage msg = new FormMessage(context, "温馨提示", isYn);
            return msg.ShowDialog();
        }

        private void skinButton_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void skinButton_Close_MouseHover(object sender, EventArgs e)
        {
            CCWin.SkinControl.SkinButton btn = sender as CCWin.SkinControl.SkinButton;
            btn.BackgroundImage = global::MusicNetease.Properties.Resources.close1;
        }

        private void skinButton_Close_MouseLeave(object sender, EventArgs e)
        {
            CCWin.SkinControl.SkinButton btn = sender as CCWin.SkinControl.SkinButton;
            btn.BackgroundImage = global::MusicNetease.Properties.Resources.close0;
        }

        private void skinButton_ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void skinButton_No_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void skinPanel_Top_MouseDown(object sender, MouseEventArgs e)
        {
            //为当前的应用程序释放鼠标捕获
            ReleaseCapture();
            //发送消息﹐让系統误以为在标题栏上按下鼠标
            SendMessage((int)this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }
    }
}
