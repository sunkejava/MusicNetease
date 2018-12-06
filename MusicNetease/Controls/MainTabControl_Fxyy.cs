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
        int NowNum = 0;
        String[] ImgsString = new String[]{ "http://p1.music.126.net/utGm9BU68THpwEUPe0ecYQ==/109951163702692244.jpg",
                                         "http://p1.music.126.net/MxnT6B0uFfOIqmUET0Hkyg==/109951163706538300.jpg",
                                         "http://p1.music.126.net/uvBie7e5Ozxd9zXaIzl4kQ==/109951163707092059.jpg",
                                         "http://p1.music.126.net/aHr6k_A6lRdhvjZw4dZcoQ==/109951163706085420.jpg",
                                         "http://p1.music.126.net/Dk0_tclnpP2og2R0tTIHmQ==/109951163707089759.jpg",
                                         "http://p1.music.126.net/6VnvL-JGcie9lMMtQXYlrg==/109951163707206569.jpg",
                                         "http://p1.music.126.net/Vhs30rVOFjYEf5H5tQmsQg==/109951163703653548.jpg",
                                         "http://p1.music.126.net/eNUJlf-kLWdny2ZjXG-TuA==/109951163702694238.jpg" };
        public MainTabControl_Fxyy()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 首次加载需要初始赋值的信息
        /// </summary>
        private void userControlLoad()
        {
            skinLabel_tag_Update();
            skinLabel_gxtj.Tag = true;
            skinLabel_gxtj.ForeColor = Color.FromArgb(255, 92, 138);

            LoadSliderImg(NowNum);

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
            btn_ImgLeft.Location = new Point(lwidth+20,110);
            btn_ImgRight.Location = new Point(layeredPanel1.Width-lwidth-20, 110);

            PictureBox_Left.Cursor = Cursors.Hand;
            PictureBox_Main.Cursor = PictureBox_Left.Cursor;
            PictureBox_Right.Cursor = PictureBox_Left.Cursor;
            btn_ImgLeft.Cursor = PictureBox_Left.Cursor;
            btn_ImgLeft.Cursor = PictureBox_Left.Cursor;

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
            btn_ImgLeft.AdaptImage = false;
            btn_ImgRight.AdaptImage = false;
            btn_ImgLeft.Name = "btn_Left";
            btn_ImgRight.Name = "btn_Right";

            btn_ImgLeft.MouseClick += Btn_ImgLeft_MouseClick;
            btn_ImgRight.MouseClick += Btn_ImgLeft_MouseClick;

            this.layeredPanel1.DUIControls.Add(PictureBox_Left);
            this.layeredPanel1.DUIControls.Add(PictureBox_Right);
            this.layeredPanel1.DUIControls.Add(PictureBox_Main);
            this.layeredPanel1.DUIControls.Add(btn_ImgLeft);
            this.layeredPanel1.DUIControls.Add(btn_ImgRight);
            btn_ImgLeft.Visible = false;
            btn_ImgRight.Visible = false;
        }

        private void Btn_ImgLeft_MouseClick(object sender, DuiMouseEventArgs e)
        {

            DuiButton btn = sender as DuiButton;
            if (btn.Name == "btn_Left")
            {
                NowNum = ((NowNum - 1) < 0 ? ImgsString.Length - 1 : NowNum - 1);
            }
            else
            {
                NowNum = ((NowNum + 1) >= ImgsString.Length ? 0 : NowNum + 1);
            }
            LoadSliderImg(NowNum);
            setSelectLineColor();
        }

        /// <summary>
        /// 加载滚动图
        /// </summary>
        /// <param name="x"></param>
        private void LoadSliderImg(int Num)
        {
            int count = ImgsString.Length;
            int prevNum = ((Num - 1) < 0 ? count - 1 : Num - 1);
            int nextNum = ((Num + 1) >= count ? 0 : Num + 1);
            PictureBox_Left.BackgroundImage = Image.FromStream(System.Net.WebRequest.Create(ImgsString[prevNum]).GetResponse().GetResponseStream());
            PictureBox_Main.BackgroundImage = Image.FromStream(System.Net.WebRequest.Create(ImgsString[Num]).GetResponse().GetResponseStream());
            PictureBox_Right.BackgroundImage = Image.FromStream(System.Net.WebRequest.Create(ImgsString[nextNum]).GetResponse().GetResponseStream());
        }

        /// <summary>
        /// 设置控件大小
        /// </summary>
        [Description("设置控件大小"), Category("自定义属性")]
        public int SetSize
        {
            get { return layeredPanel1.Width; }
            set { layeredPanel1.Width = value; }
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

        private void MainTabControl_Fxyy_Load(object sender, EventArgs e)
        {
            userControlLoad();
        }

        /// <summary>
        /// 更新选择线条颜色为初始颜色
        /// </summary>
        private void skinLine_Update()
        {
            skinLine_1.LineColor = Color.Silver;
            skinLine_2.LineColor = skinLine_1.LineColor;
            skinLine_3.LineColor = skinLine_1.LineColor;
            skinLine_4.LineColor = skinLine_1.LineColor;
            skinLine_5.LineColor = skinLine_1.LineColor;
            skinLine_6.LineColor = skinLine_1.LineColor;
            skinLine_7.LineColor = skinLine_1.LineColor;
            skinLine_8.LineColor = skinLine_1.LineColor;
        }

        private void setSelectLineColor()
        {
            skinLine_Update();
            switch (NowNum)
            {
                case 0:
                    skinLine_1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
                    break;
                case 1:
                    skinLine_2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
                    break;
                case 3:
                    skinLine_3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
                    break;
                case 4:
                    skinLine_4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
                    break;
                case 5:
                    skinLine_5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
                    break;
                case 6:
                    skinLine_6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
                    break;
                case 7:
                    skinLine_7.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
                    break;
                default:
                    break;
            }
        }

        private void skinLine_MouseEnter(object sender, EventArgs e)
        {
            skinLine_Update();
            SkinLine btn = sender as SkinLine;
            btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
            NowNum = int.Parse(btn.Tag.ToString());
            LoadSliderImg(NowNum);
        }
    }
}
