using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayeredSkin;
using LayeredSkin.DirectUI;
using MusicNetease.Entity;
using System.Drawing;

namespace MusicNetease.LayeredSkinControl
{
    /// <summary>
    /// 类    名: SwitcherControl.cs
    /// CLR 版本: 4.0.30319.42000
    /// 作    者: sunkejava 
    /// 邮    箱：declineaberdeen@foxmail.com
    /// 创建时间: 2018/12/17 14:58:07
    /// 说    明：网易云音乐滚动条控件
    /// </summary>
    public class SwitcherControl: DuiBaseControl
    {
        DuiButton btn_ImgLeft = new DuiButton();
        DuiButton btn_ImgRight = new DuiButton();
        DuiPictureBox imgLeft = new DuiPictureBox();
        DuiPictureBox imgMain = new DuiPictureBox();
        DuiPictureBox imgRight = new DuiPictureBox();
        DuiLabel dLabel1 = new DuiLabel();
        DuiLabel dLabel2 = new DuiLabel();
        DuiLabel dLabel3 = new DuiLabel();
        DuiLabel dLabel4 = new DuiLabel();
        DuiLabel dLabel5 = new DuiLabel();
        DuiLabel dLabel6 = new DuiLabel();
        DuiLabel dLabel7 = new DuiLabel();
        DuiLabel dLabel8 = new DuiLabel();
        int NowNum = 0;
        public SwitcherImageEntity switcherImgsEntity = new SwitcherImageEntity();
        #region 控件事件
        private void Btn_ImgLeft_MouseClick(object sender, DuiMouseEventArgs e)
        {
            DuiButton btn = sender as DuiButton;
            if (btn.Name == "btn_Left")
            {
                NowNum = ((NowNum - 1) < 0 ? switcherImgsEntity.Imgs.Length - 1 : NowNum - 1);
            }
            else
            {
                NowNum = ((NowNum + 1) >= switcherImgsEntity.Imgs.Length ? 0 : NowNum + 1);
            }
            LoadSliderImg(NowNum);
            setSelectLineColor();
        }

        private void ImgLeft_MouseLeave(object sender, EventArgs e)
        {
            btn_ImgLeft.Visible = true;
            btn_ImgRight.Visible = true;
        }

        private void ImgLeft_MouseEnter(object sender, EventArgs e)
        {
            btn_ImgLeft.Visible = true;
            btn_ImgRight.Visible = true;
        }

        private void skinLine_MouseEnter(object sender, EventArgs e)
        {
            skinLine_Update();
            DuiLabel btn = sender as DuiLabel;
            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
            NowNum = int.Parse(btn.Tag.ToString());
            LoadSliderImg(NowNum);
        }
        #endregion


        #region 自定义函数
        /// <summary>
        /// 添加滚动图控件
        /// </summary>
        /// <param name="se"></param>
        /// <returns></returns>
        public bool addSwitchImage(SwitcherImageEntity se)
        {
            switcherImgsEntity = se;
            DuiBaseControl baseControl = new DuiBaseControl();
            baseControl.Size = new Size(Width, 350);
            LoadSliderImg(NowNum);
            imgMain.Size = new Size(540, 200);
            imgLeft.Size = new Size(520, 190);
            imgRight.Size = new Size(520, 190);
            imgLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            imgMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            imgRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            imgLeft.Location = new Point(0, 30);
            imgMain.Location = new Point((this.Width - 540) / 2, 20);
            imgRight.Location = new Point(this.Width - 520 - 0, 30);
            btn_ImgLeft.Location = new Point(0 + 20, 110);
            btn_ImgRight.Location = new Point(this.Width - 0 - 20, 110);

            imgLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            imgMain.Cursor = imgLeft.Cursor;
            imgRight.Cursor = imgLeft.Cursor;
            btn_ImgLeft.Cursor = imgLeft.Cursor;
            btn_ImgRight.Cursor = imgLeft.Cursor;

            imgLeft.MouseEnter += ImgLeft_MouseEnter;
            imgLeft.MouseLeave += ImgLeft_MouseLeave;
            imgMain.MouseEnter += ImgLeft_MouseEnter;
            imgMain.MouseLeave += ImgLeft_MouseLeave;
            imgRight.MouseEnter += ImgLeft_MouseEnter;
            imgRight.MouseLeave += ImgLeft_MouseLeave;



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
            int lcountWidth = ((Width / 3) - (dLabel1.Width * 8)) / 9;//各个下标间距
            int lbeginLeft = Width / 3 * 1;//下标占位左边距
            dLabel1.Location = new Point(lbeginLeft + lcountWidth, 234);
            dLabel2.Location = new Point(lbeginLeft + lcountWidth * 2 + dLabel1.Width, 234);
            dLabel3.Location = new Point(lbeginLeft + lcountWidth * 3 + dLabel1.Width * 2, 234);
            dLabel4.Location = new Point(lbeginLeft + lcountWidth * 4 + dLabel1.Width * 3, 234);
            dLabel5.Location = new Point(lbeginLeft + lcountWidth * 5 + dLabel1.Width * 4, 234);
            dLabel6.Location = new Point(lbeginLeft + lcountWidth * 6 + dLabel1.Width * 5, 234);
            dLabel7.Location = new Point(lbeginLeft + lcountWidth * 7 + dLabel1.Width * 6, 234);
            dLabel8.Location = new Point(lbeginLeft + lcountWidth * 8 + dLabel1.Width * 7, 234);
            baseControl.Controls.Add(imgLeft);
            baseControl.Controls.Add(imgRight);
            baseControl.Controls.Add(imgMain);
            baseControl.Controls.Add(btn_ImgLeft);
            baseControl.Controls.Add(btn_ImgRight);
            baseControl.Controls.Add(dLabel1);
            baseControl.Controls.Add(dLabel2);
            baseControl.Controls.Add(dLabel3);
            baseControl.Controls.Add(dLabel4);
            baseControl.Controls.Add(dLabel5);
            baseControl.Controls.Add(dLabel6);
            baseControl.Controls.Add(dLabel7);
            baseControl.Controls.Add(dLabel8);
            btn_ImgLeft.Visible = false;
            btn_ImgRight.Visible = false;
            GC.Collect();
            return true;
        }

        /// <summary>
        /// 加载滚动图
        /// </summary>
        /// <param name="x"></param>
        private void LoadSliderImg(int Num)
        {
            int count = switcherImgsEntity.Imgs.Length;
            int prevNum = ((Num - 1) < 0 ? count - 1 : Num - 1);
            int nextNum = ((Num + 1) >= count ? 0 : Num + 1);
            imgLeft.BackgroundImage = GetImageByUrl(switcherImgsEntity.Imgs[prevNum]);
            imgMain.BackgroundImage = GetImageByUrl(switcherImgsEntity.Imgs[Num]);
            imgRight.BackgroundImage = GetImageByUrl(switcherImgsEntity.Imgs[nextNum]);
        }

        private Image GetImageByUrl(string url)
        {
            return Image.FromStream(System.Net.WebRequest.Create(url).GetResponse().GetResponseStream());
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

        #endregion
        /// <summary>
        /// 默认构造方法
        /// </summary>
        public SwitcherControl()
        {

        }

        public void setSize(int width,int height)
        {
            this.Width = width;
            this.Height = height;
        }

    }
}
