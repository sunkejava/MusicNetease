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
        DuiPictureBox PictureBox_Left = new DuiPictureBox();
        DuiPictureBox PictureBox_Right = new DuiPictureBox();
        DuiPictureBox PictureBox_Main = new DuiPictureBox();
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
            PictureBox_Left.BackgroundImage = Image.FromStream(System.Net.WebRequest.Create("http://p1.music.126.net/Vhs30rVOFjYEf5H5tQmsQg==/109951163703653548.jpg").GetResponse().GetResponseStream());
            PictureBox_Main.BackgroundImage = Image.FromStream(System.Net.WebRequest.Create("http://p1.music.126.net/eNUJlf-kLWdny2ZjXG-TuA==/109951163702694238.jpg").GetResponse().GetResponseStream());
            PictureBox_Right.BackgroundImage = Image.FromStream(System.Net.WebRequest.Create("http://p1.music.126.net/utGm9BU68THpwEUPe0ecYQ==/109951163702692244.jpg").GetResponse().GetResponseStream());

            PictureBox_Left.BackgroundImageLayout = ImageLayout.Stretch;
            PictureBox_Main.BackgroundImageLayout = ImageLayout.Stretch;
            PictureBox_Right.BackgroundImageLayout = ImageLayout.Stretch;

            PictureBox_Main.Size = new Size(540, 200);
            PictureBox_Left.Size = new Size(520, 190);
            PictureBox_Right.Size = new Size(520, 190);

            int lwidth = 0;
            if (layeredPanel1.Width > 1020)
            {
                lwidth = (layeredPanel1.Width - 1040) / 2;
            }
            else
            {
                lwidth = 30;
            }
            PictureBox_Left.Location = new Point(lwidth,30);
            PictureBox_Main.Location = new Point((layeredPanel1.Width-540)/2,20);
            PictureBox_Right.Location = new Point(layeredPanel1.Width-520-lwidth,30);
            btn_ImgLeft.Location = new Point(lwidth+10,125);
            btn_ImgRight.Location = new Point(layeredPanel1.Width-lwidth-10, 125);

            PictureBox_Left.MouseEnter += PictureBox_main_MouseEnter;
            PictureBox_Left.MouseLeave += PictureBox_main_MouseLeave;
            PictureBox_Main.MouseEnter += PictureBox_main_MouseEnter;
            PictureBox_Main.MouseLeave += PictureBox_main_MouseLeave;
            PictureBox_Right.MouseEnter += PictureBox_main_MouseEnter;
            PictureBox_Right.MouseLeave += PictureBox_main_MouseLeave;


            btn_ImgLeft.Size = new Size(20,20);
            btn_ImgRight.Size = btn_ImgLeft.Size;
            btn_ImgLeft.NormalImage = Properties.Resources.Img_left0;
            btn_ImgLeft.HoverImage = Properties.Resources.Img_left1;
            btn_ImgLeft.PressedImage = Properties.Resources.Img_left1;
            btn_ImgRight.NormalImage = Properties.Resources.Img_right0;
            btn_ImgRight.HoverImage = Properties.Resources.Img_right1;
            btn_ImgRight.PressedImage = Properties.Resources.Img_right1;
            this.layeredPanel1.DUIControls.Add(PictureBox_Left);
            this.layeredPanel1.DUIControls.Add(PictureBox_Right);
            this.layeredPanel1.DUIControls.Add(PictureBox_Main);
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
            //animator.Show(PictureBox_Main.Controls);
        }

        private void PictureBox_main_MouseEnter(object sender, EventArgs e)
        {
            btn_ImgLeft.Visible = true;
            btn_ImgRight.Visible = true;
        }

        private void PictureBox_main_MouseLeave(object sender, EventArgs e)
        {
            btn_ImgLeft.Visible = false;
            btn_ImgRight.Visible = false;
        }
    }
}
