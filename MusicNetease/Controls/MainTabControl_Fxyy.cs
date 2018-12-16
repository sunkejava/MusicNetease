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
        DuiLabel dLabel1 = new DuiLabel();
        DuiLabel dLabel2 = new DuiLabel();
        DuiLabel dLabel3 = new DuiLabel();
        DuiLabel dLabel4 = new DuiLabel();
        DuiLabel dLabel5 = new DuiLabel();
        DuiLabel dLabel6 = new DuiLabel();
        DuiLabel dLabel7 = new DuiLabel();
        DuiLabel dLabel8 = new DuiLabel();
        int NowNum = 0;
        String[] ImgsString = new String[]{ "http://p1.music.126.net/utGm9BU68THpwEUPe0ecYQ==/109951163702692244.jpg",
                                         "http://p1.music.126.net/MxnT6B0uFfOIqmUET0Hkyg==/109951163706538300.jpg",
                                         "http://p1.music.126.net/uvBie7e5Ozxd9zXaIzl4kQ==/109951163707092059.jpg",
                                         "http://p1.music.126.net/aHr6k_A6lRdhvjZw4dZcoQ==/109951163706085420.jpg",
                                         "http://p1.music.126.net/Dk0_tclnpP2og2R0tTIHmQ==/109951163707089759.jpg",
                                         "http://p1.music.126.net/6VnvL-JGcie9lMMtQXYlrg==/109951163707206569.jpg",
                                         "http://p1.music.126.net/Vhs30rVOFjYEf5H5tQmsQg==/109951163703653548.jpg",
                                         "http://p1.music.126.net/eNUJlf-kLWdny2ZjXG-TuA==/109951163702694238.jpg" };
        private bool scorlling = false;
        private int mousetop = 0;
        public MainTabControl_Fxyy()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 首次加载需要初始赋值的信息
        /// </summary>
        private void userControlLoad()
        {
            #region 发现音乐----个性推荐
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
            if (layeredPanel_gxtj.Width > 1020)
            {
                lwidth = (layeredPanel_gxtj.Width - 1040) / 2;
            }
            else
            {
                lwidth = 30;
            }
            PictureBox_Left.Location = new Point(lwidth, 30);
            PictureBox_Main.Location = new Point((layeredPanel_gxtj.Width - 540) / 2, 20);
            PictureBox_Right.Location = new Point(layeredPanel_gxtj.Width - 520 - lwidth, 30);
            btn_ImgLeft.Location = new Point(lwidth + 20, 110);
            btn_ImgRight.Location = new Point(layeredPanel_gxtj.Width - lwidth - 20, 110);

            PictureBox_Left.Cursor = Cursors.Hand;
            PictureBox_Main.Cursor = PictureBox_Left.Cursor;
            PictureBox_Right.Cursor = PictureBox_Left.Cursor;
            btn_ImgLeft.Cursor = PictureBox_Left.Cursor;
            btn_ImgRight.Cursor = PictureBox_Left.Cursor;

            PictureBox_Left.MouseEnter += PictureBox_main_MouseEnter;
            PictureBox_Left.MouseLeave += PictureBox_main_MouseLeave;
            PictureBox_Main.MouseEnter += PictureBox_main_MouseEnter;
            PictureBox_Main.MouseLeave += PictureBox_main_MouseLeave;
            PictureBox_Right.MouseEnter += PictureBox_main_MouseEnter;
            PictureBox_Right.MouseLeave += PictureBox_main_MouseLeave;



            btn_ImgLeft.Size = new Size(20, 20);
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

            dLabel1.Size = new Size(20, 10);
            dLabel2.Size = dLabel1.Size;
            dLabel3.Size = dLabel1.Size;
            dLabel4.Size = dLabel1.Size;
            dLabel5.Size = dLabel1.Size;
            dLabel6.Size = dLabel1.Size;
            dLabel7.Size = dLabel1.Size;
            dLabel8.Size = dLabel1.Size;
            dLabel1.BackColor = System.Drawing.Color.Silver;
            dLabel1.Height = 2;
            dLabel1.MouseEnter += new System.EventHandler(this.skinLine_MouseEnter);
            dLabel1.Tag = "0";
            dLabel2.Height = dLabel1.Height;
            dLabel2.BackColor = dLabel1.BackColor;
            dLabel2.MouseEnter += new System.EventHandler(this.skinLine_MouseEnter);
            dLabel2.Tag = "1";
            dLabel3.Height = dLabel1.Height;
            dLabel3.BackColor = dLabel1.BackColor;
            dLabel3.MouseEnter += new System.EventHandler(this.skinLine_MouseEnter);
            dLabel3.Tag = "2";
            dLabel4.Height = dLabel1.Height;
            dLabel4.BackColor = dLabel1.BackColor;
            dLabel4.MouseEnter += new System.EventHandler(this.skinLine_MouseEnter);
            dLabel4.Tag = "3";
            dLabel5.Height = dLabel1.Height;
            dLabel5.BackColor = dLabel1.BackColor;
            dLabel5.MouseEnter += new System.EventHandler(this.skinLine_MouseEnter);
            dLabel5.Tag = "4";
            dLabel6.Height = dLabel1.Height;
            dLabel6.BackColor = dLabel1.BackColor;
            dLabel6.MouseEnter += new System.EventHandler(this.skinLine_MouseEnter);
            dLabel6.Tag = "5";
            dLabel7.Height = dLabel1.Height;
            dLabel7.BackColor = dLabel1.BackColor;
            dLabel7.MouseEnter += new System.EventHandler(this.skinLine_MouseEnter);
            dLabel7.Tag = "6";
            dLabel8.Height = dLabel1.Height;
            dLabel8.BackColor = dLabel1.BackColor;
            dLabel8.MouseEnter += new System.EventHandler(this.skinLine_MouseEnter);
            dLabel8.Tag = "7";
            dLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
            int lcountWidth = ((Width / 3)-(dLabel1.Width*8))/9;//各个下标间距
            int lbeginLeft = Width / 3 * 1;//下标占位左边距
            dLabel1.Location = new Point(lbeginLeft+lcountWidth, 234);
            dLabel2.Location = new Point(lbeginLeft + lcountWidth * 2 + dLabel1.Width, 234);
            dLabel3.Location = new Point(lbeginLeft + lcountWidth * 3 + dLabel1.Width * 2, 234);
            dLabel4.Location = new Point(lbeginLeft + lcountWidth * 4 + dLabel1.Width * 3, 234);
            dLabel5.Location = new Point(lbeginLeft + lcountWidth * 5 + dLabel1.Width * 4, 234);
            dLabel6.Location = new Point(lbeginLeft + lcountWidth * 6 + dLabel1.Width * 5, 234);
            dLabel7.Location = new Point(lbeginLeft + lcountWidth * 7 + dLabel1.Width * 6, 234);
            dLabel8.Location = new Point(lbeginLeft + lcountWidth * 8 + dLabel1.Width * 7, 234);
            this.layeredPanel_gxtj.DUIControls.Add(PictureBox_Left);
            this.layeredPanel_gxtj.DUIControls.Add(PictureBox_Right);
            this.layeredPanel_gxtj.DUIControls.Add(PictureBox_Main);
            this.layeredPanel_gxtj.DUIControls.Add(btn_ImgLeft);
            this.layeredPanel_gxtj.DUIControls.Add(btn_ImgRight);
            this.layeredPanel_gxtj.DUIControls.Add(dLabel1);
            this.layeredPanel_gxtj.DUIControls.Add(dLabel2);
            this.layeredPanel_gxtj.DUIControls.Add(dLabel3);
            this.layeredPanel_gxtj.DUIControls.Add(dLabel4);
            this.layeredPanel_gxtj.DUIControls.Add(dLabel5);
            this.layeredPanel_gxtj.DUIControls.Add(dLabel6);
            this.layeredPanel_gxtj.DUIControls.Add(dLabel7);
            this.layeredPanel_gxtj.DUIControls.Add(dLabel8);
            btn_ImgLeft.Visible = false;
            btn_ImgRight.Visible = false;
            layeredPanel_gxtj.Cursor = Cursors.Default;
            recommendSongSheetControl1.Location = new Point(lwidth, recommendSongSheetControl1.Location.Y);
            recommendSongSheetControl1.Size = new Size(Width, 350);
            recommendSongSheetControl1.ItemSize = new Size(155, 175);
            recommendSongSheetControl1.addRecommendSongSheet(new Entity.SongSheetEntity("tj", "每日歌曲推荐", "根据您的音乐口味生成每日更新", Properties.Resources.melog, "", ""));
            recommendSongSheetControl1.addRecommendSongSheet(new Entity.SongSheetEntity("2522866436", "又到了起床靠爆发力的日子了", "编辑推荐：我没有赖床，我不起床是有理由的！", GetImageByUrl("http://p3.music.126.net/XIFMgvpqDqY4AO94MQBijQ==/109951163679316040.jpg?param=200y200"), "202万", ""));
            recommendSongSheetControl1.addRecommendSongSheet(new Entity.SongSheetEntity("2514650991", "《你再不来，我要下雪了》", "编辑推荐：我是一个在黑暗中大雪纷飞的人啊", GetImageByUrl("http://p4.music.126.net/s6u3onN_JbFSikekDaHVmQ==/109951163722383797.jpg?param=200y200"), "44万", ""));
            recommendSongSheetControl1.addRecommendSongSheet(new Entity.SongSheetEntity("1993039994", "90后回忆杀[持续更新中...]", "根据你喜欢的单曲《Go go yellow screen》推荐", GetImageByUrl("http://p4.music.126.net/2sBMF9-bT5rifngVyDKAFQ==/109951163102165084.jpg?param=200y200"), "247万", ""));
            recommendSongSheetControl1.addRecommendSongSheet(new Entity.SongSheetEntity("2226375840", "90后流行歌曲", "根据你喜欢的单曲《Go go yellow screen》推荐", GetImageByUrl("http://p4.music.126.net/oAIdonRUGMSewYu4lYVwHQ==/109951163240609542.jpg?param=200y200"), "148万", ""));
            recommendSongSheetControl1.addRecommendSongSheet(new Entity.SongSheetEntity("988690134", "经典老歌，久听不厌", "根据你喜欢的单曲《爱我就跟我走》推荐", GetImageByUrl("http://p3.music.126.net/VFd5cboNTbnYsWZ5DBn9bg==/18953381440004340.jpg?param=200y200"), "3314万", ""));
            recommendSongSheetControl1.addRecommendSongSheet(new Entity.SongSheetEntity("2145434166", "「嗨爆」在宿舍御用的蹦迪歌曲", "根据你收藏的歌单《『开口脆』迷幻嗓音极致瞬间❤️》推荐", GetImageByUrl("http://p3.music.126.net/wMj_-xqpKxSjtBhAlSu7wQ==/19190875951790510.jpg?param=200y200"), "1815万", ""));
            recommendSongSheetControl1.addRecommendSongSheet(new Entity.SongSheetEntity("10498213", "跑步！ 适合10km/h左右的节奏", "根据你收藏的歌单《【夜跑】把你的脚印留在城市的每一个角落。》推荐", GetImageByUrl("http://p3.music.126.net/0ld5m8w0S8KpJOXDDEwG3Q==/6038517859923212.jpg?param=200y200"), "35万", ""));
            recommendSongSheetControl1.addRecommendSongSheet(new Entity.SongSheetEntity("2134203011", "一百首‖让你瞬间勾起回忆的老歌", "根据你收藏的歌单《情歌还是老的好》推荐", GetImageByUrl("http://p4.music.126.net/pAidnPdX-0fhVakVXiHMzg==/18575149441852040.jpg?param=200y200"), "695万", ""));
            recommendSongSheetControl1.addRecommendSongSheet(new Entity.SongSheetEntity("1980964492", "『修仙』 玩游戏/晨跑'必备BGM/耳机福利Δ", "根据你喜欢的单曲《Life》推荐", GetImageByUrl("http://p4.music.126.net/li9392RV26M4XZvDTr0dNg==/109951163145944715.jpg?param=200y200"), "670万", ""));
            #endregion

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
            int prevNum = ((Num - 1) < 0 ? count - 1 : Num -1);
            int nextNum = ((Num + 1) >= count ? 0 : Num + 1);
            PictureBox_Left.BackgroundImage = Image.FromStream(System.Net.WebRequest.Create(ImgsString[prevNum]).GetResponse().GetResponseStream());
            PictureBox_Main.BackgroundImage = Image.FromStream(System.Net.WebRequest.Create(ImgsString[Num]).GetResponse().GetResponseStream());
            PictureBox_Right.BackgroundImage = Image.FromStream(System.Net.WebRequest.Create(ImgsString[nextNum]).GetResponse().GetResponseStream());
        }

        private Image GetImageByUrl(string url)
        {
            return Image.FromStream(System.Net.WebRequest.Create(url).GetResponse().GetResponseStream());
        }
        /// <summary>
        /// 设置控件大小
        /// </summary>
        [Description("设置控件大小"), Category("自定义属性")]
        public int SetSize
        {
            get { return layeredPanel_gxtj.Width; }
            set { layeredPanel_gxtj.Width = value; }
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
            dLabel1.BackColor = Color.Silver;
            dLabel2.BackColor = dLabel1.BackColor;
            dLabel3.BackColor = dLabel1.BackColor;
            dLabel4.BackColor = dLabel1.BackColor;
            dLabel5.BackColor = dLabel1.BackColor;
            dLabel6.BackColor = dLabel1.BackColor;
            dLabel7.BackColor = dLabel1.BackColor;
            dLabel8.BackColor = dLabel1.BackColor;
        }

        private void setSelectLineColor()
        {
            skinLine_Update();
            switch (NowNum)
            {
                case 0:
                    dLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
                    break;
                case 1:
                    dLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
                    break;
                case 2:
                    dLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
                    break;
                case 3:
                    dLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
                    break;
                case 4:
                    dLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
                    break;
                case 5:
                    dLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
                    break;
                case 6:
                    dLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
                    break;
                default:
                    dLabel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
                    break;
            }
        }

        private void skinLine_MouseEnter(object sender, EventArgs e)
        {
            skinLine_Update();
            DuiLabel btn = sender as DuiLabel;
            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
            NowNum = int.Parse(btn.Tag.ToString());
            LoadSliderImg(NowNum);
        }

        private void recommendSongSheetControl1_RecommendSongSheetMouseDown(object sender, EventArgs e)
        {

        }

        private void recommendSongSheetControl1_RefreshListed(object sender, EventArgs e)
        {
            int allheight = 0;
            for (int i = 0; i < recommendSongSheetControl1.Items.Count; i++)
            {
                if (recommendSongSheetControl1.Items[i].Visible)
                    allheight = allheight + recommendSongSheetControl1.Items[i].Height;
            }
            allheight += this.layeredPanel_gxtj.Height;
            double pre = (double)(recommendSongSheetControl1.Height + this.layeredPanel_gxtj.Height) / (double)allheight;
            if (pre < 1)
            {
                if (recommendSongSheetControl1.Visible)
                    scorllbar.Show();
                scorllbar.Height = (int)(pre * (double)(recommendSongSheetControl1.Height+ this.layeredPanel_gxtj.Height));
                scorllbar.Top = (int)(recommendSongSheetControl1.Value * (recommendSongSheetControl1.Height + this.layeredPanel_gxtj.Height - scorllbar.Height)) + recommendSongSheetControl1.Top;
            }
            else
            {
                scorllbar.Hide();
            }
        }

        private void scorllbar_Move(object sender, EventArgs e)
        {
            if (scorlling)
                layeredPanel_gxtj.VerticalScroll.Value = (scorllbar.Top - layeredPanel_gxtj.Top) / (layeredPanel_gxtj.Height - scorllbar.Height);
            }

        private void scorllbar_MouseDown(object sender, MouseEventArgs e)
        {
            mousetop = scorllbar.PointToClient(MousePosition).Y;
            scorlling = true;
            scorllbar.BackColor = Color.FromArgb(80, 55, 55, 55);
        }

        private void scorllbar_MouseEnter(object sender, EventArgs e)
        {
            if (scorllbar.Top < layeredPanel_gxtj.Top)
                scorllbar.Top = layeredPanel_gxtj.Top + 2;
            if (scorllbar.Top > (layeredPanel_gxtj.Top + layeredPanel_gxtj.Height - scorllbar.Height))
                scorllbar.Top = (layeredPanel_gxtj.Top + layeredPanel_gxtj.Height - scorllbar.Height);
            scorllbar.BackColor = Color.FromArgb(100, 55, 55, 55);
        }

        private void scorllbar_MouseLeave(object sender, EventArgs e)
        {
            scorllbar.BackColor = Color.FromArgb(100, 205, 205, 205);
        }

        private void scorllbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (scorlling)
            {
                if (scorllbar.Top >= layeredPanel_gxtj.Top && scorllbar.Top <= (layeredPanel_gxtj.Top + layeredPanel_gxtj.Height - scorllbar.Height))
                    scorllbar.Top = PointToClient(MousePosition).Y - mousetop;
            }
        }

        private void scorllbar_MouseUp(object sender, MouseEventArgs e)
        {
            mousetop = e.Y; scorlling = false;
            scorllbar.BackColor = Color.FromArgb(100, 205, 205, 205);
        }
    }
}
