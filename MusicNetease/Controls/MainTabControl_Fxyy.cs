using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin.SkinControl;
using LayeredSkin.DirectUI;

namespace MusicNetease.Controls
{
    public partial class MainTabControl_Fxyy : UserControl
    {
        DuiButton btn_ImgLeft = new DuiButton();
        DuiButton btn_ImgRight = new DuiButton();
        public MainTabControl_Fxyy()
        {
            InitializeComponent();
            userControlLoad();
        }
        /// <summary>
        /// 首次加载需要初始赋值的信息
        /// </summary>
        private void userControlLoad()
        {
            skinLabel_tag_Update();
            skinLabel_gxtj.Tag = true;
            skinLabel_gxtj.ForeColor = Color.FromArgb(255, 92, 138);
            skinPictureBox_left.BackgroundImage = Image.FromStream(System.Net.WebRequest.Create("http://p1.music.126.net/Vhs30rVOFjYEf5H5tQmsQg==/109951163703653548.jpg").GetResponse().GetResponseStream());
            skinPictureBox_main.BackgroundImage = Image.FromStream(System.Net.WebRequest.Create("http://p1.music.126.net/eNUJlf-kLWdny2ZjXG-TuA==/109951163702694238.jpg").GetResponse().GetResponseStream());
            skinPictureBox_right.BackgroundImage = Image.FromStream(System.Net.WebRequest.Create("http://p1.music.126.net/utGm9BU68THpwEUPe0ecYQ==/109951163702692244.jpg").GetResponse().GetResponseStream());
            
            btn_ImgLeft.Location = new Point(23,110);
            btn_ImgRight.Location = new Point(848, 110);

            btn_ImgLeft.NormalImage = Properties.Resources.Img_left0;
            btn_ImgLeft.HoverImage = Properties.Resources.Img_left1;
            btn_ImgLeft.PressedImage = Properties.Resources.Img_left1;
            btn_ImgRight.NormalImage = Properties.Resources.Img_right0;
            btn_ImgRight.HoverImage = Properties.Resources.Img_right1;
            btn_ImgRight.PressedImage = Properties.Resources.Img_right1;
            this.layeredPanel1.DUIControls.Add(btn_ImgLeft);
            this.layeredPanel1.DUIControls.Add(btn_ImgRight);
            btn_ImgLeft.Visible = false;
            btn_ImgRight.Visible = false;
        }

        /// <summary>
        /// 在选择夹获取焦点后自动变色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinLabel_gxtj_MouseEnter(object sender, EventArgs e)
        {
            CCWin.SkinControl.SkinLabel skLabel = sender as CCWin.SkinControl.SkinLabel;
            skLabel.ForeColor = Color.FromArgb(255, 92, 138);
        }
        /// <summary>
        ///  在选择夹失去焦点后自动变色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinLabel_gq_MouseLeave(object sender, EventArgs e)
        {
            
            CCWin.SkinControl.SkinLabel skLabel = sender as CCWin.SkinControl.SkinLabel;
            if (!(bool)skLabel.Tag)
            {
                skLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            }
        }
        /// <summary>
        /// 在选择夹上单机鼠标后的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinLabel_gxtj_MouseDown(object sender, MouseEventArgs e)
        {
            skinLabel_tag_Update();
            CCWin.SkinControl.SkinLabel skLabel = sender as CCWin.SkinControl.SkinLabel;
            skLabel.ForeColor = Color.FromArgb(255, 92, 138);
            skinLine_xz.Width = skLabel.Width - 8;
            skinLine_xz.Location = new Point(skLabel.Location.X,skinLine_xz.Location.Y);
            skLabel.Tag = true;//用tag属性表示是否选中该标签。
            switch (skLabel.Name)
            {
                case "skinLabel_gxtj":
                    skinTabControl1.SelectedIndex = 0;
                    break;
                case "skinLabel_gq":
                    skinTabControl1.SelectedIndex = 1;
                    break;
                case "skinLabel_zbdt":
                    skinTabControl1.SelectedIndex = 2;
                    break;
                case "skinLabel_phb":
                    skinTabControl1.SelectedIndex = 3;
                    break;
                case "skinLabel_gs":
                    skinTabControl1.SelectedIndex = 4;
                    break;
                case "skinLabel_zxyy":
                    skinTabControl1.SelectedIndex = 5;
                    break;
                default:
                    break;
            }

        }
        /// <summary>
        /// 更新所有选择夹为初始颜色并非选择状态
        /// </summary>
        private void skinLabel_tag_Update()
        {
            skinLabel_gxtj.Tag = false;
            skinLabel_gq.Tag = false;
            skinLabel_zbdt.Tag = false;
            skinLabel_phb.Tag = false;
            skinLabel_gs.Tag = false;
            skinLabel_zxyy.Tag = false;
            skinLabel_gxtj.ForeColor = System.Drawing.SystemColors.ControlText;
            skinLabel_gq.ForeColor = System.Drawing.SystemColors.ControlText;
            skinLabel_zbdt.ForeColor = System.Drawing.SystemColors.ControlText;
            skinLabel_phb.ForeColor = System.Drawing.SystemColors.ControlText;
            skinLabel_gs.ForeColor = System.Drawing.SystemColors.ControlText;
            skinLabel_zxyy.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void DoAnimation()
        {
            //等到所有的动画将完成
            animator.WaitAllAnimations();
            animator.DefaultAnimation = Animation.ScaleAndHorizSlide;
            animator.Show(skinPictureBox_main);
        }

        private void skinPictureBox_main_MouseEnter(object sender, EventArgs e)
        {
            btn_ImgLeft.Visible = true;
            btn_ImgRight.Visible = true;
        }

        private void skinPictureBox_main_MouseLeave(object sender, EventArgs e)
        {
            btn_ImgLeft.Visible = false;
            btn_ImgRight.Visible = false;
        }
    }
}
