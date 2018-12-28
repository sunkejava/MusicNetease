using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayeredSkin.DirectUI;
using System.Drawing;
using System.ComponentModel;
using MusicNetease.Entity;
using System.Net;
using System.IO;

namespace MusicNetease.LayeredSkinControl
{
    /// <summary>
    /// 类    名: RecommendSongSheetControl.cs
    /// CLR 版本: 4.0.30319.42000
    /// 作    者: sunkejava 
    /// 邮    箱：declineaberdeen@foxmail.com
    /// 创建时间: 2018/12/13 12:40:51
    /// 说    明：推荐歌单控件
    /// </summary>
    public class RecommendSongSheetControl : LayeredSkin.Controls.LayeredListBox
    {
        public RecommendSongSheetControl()
        {
            //底层控件
            DuiBaseControl baseControl = new DuiBaseControl();
            baseControl.Size = new Size(195, 230);
            baseControl.BackColor = Color.FromArgb(245, 245, 247);
            //边框
            Borders baseBorder = new Borders(baseControl);
            baseBorder.BottomWidth = 1;
            baseBorder.TopWidth = 1;
            baseBorder.LeftWidth = 1;
            baseBorder.RightWidth = 1;
            baseBorder.BottomColor = Color.FromArgb(50, 0, 0, 0);
            baseControl.Borders = baseBorder;
            //背景图
            DuiPictureBox dp = new DuiPictureBox();
            dp.Size = new Size(195,195);
            dp.Location = new Point(0, 0);
            dp.BackgroundImage = Properties.Resources.melog;
            dp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            dp.MouseEnter += Dp_MouseEnter;
            dp.MouseLeave += Dp_MouseLeave;
            //说明
            DuiLabel songSheetExplain = new DuiLabel();
            songSheetExplain.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            songSheetExplain.Location = new Point(0, 195);
            songSheetExplain.Size = new Size(195,32);
            songSheetExplain.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            songSheetExplain.ForeColor = Color.DimGray;
            songSheetExplain.Text = "根据您的音乐口味生成每日更新";
            songSheetExplain.Name = "songSheetExplain";
            songSheetExplain.Visible = false;
            dp.Controls.Add(songSheetExplain);
            //标题
            DuiButton songSheetName = new DuiButton();
            songSheetName.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            songSheetName.Location = new Point(0, 195);
            songSheetName.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            songSheetName.ForeColor = Color.Black;
            songSheetName.Text = "每日歌曲推荐";
            songSheetName.Name = "songSheetName";

            baseControl.Controls.Add(dp);
            baseControl.Controls.Add(songSheetName);
            
        }
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
        public List<SongSheetTitle> tGroups = new List<SongSheetTitle>();
        public List<SongSheetEntity> Groups = new List<SongSheetEntity>();
        
        #region 自定义公开属性

        #endregion


        #region 控件事件
        /// <summary>
        /// 图片控件焦点离开事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dp_MouseLeave(object sender, EventArgs e)
        {
            DuiBaseControl dp = null;
            if (sender is DuiBaseControl)
            {
                dp = sender as DuiBaseControl;
            }
            if (sender is DuiLabel)
            {
                dp = (sender as DuiLabel).Parent as DuiBaseControl;
            }
            if (sender is DuiPictureBox)
            {
                dp = (sender as DuiPictureBox).Parent as DuiBaseControl;
            }
            //隐藏说明
            if (dp.FindControl("songSheetExplain").Count > 0)
            {
                DuiLabel dl = (DuiLabel)dp.FindControl("songSheetExplain")[0];
                dl.Visible = false;
            }
            //显示收听量
            if (dp.FindControl("lisentInCount").Count > 0)
            {
                DuiLabel ldl = (DuiLabel)dp.FindControl("lisentInCount")[0];
                ldl.Visible = true;
            }
            if (dp.FindControl("lisentInIcon").Count > 0)
            {
                DuiButton ldb = (DuiButton)dp.FindControl("lisentInIcon")[0];
                ldb.Visible = true;
            }
        }

        /// <summary>
        /// 图片控件获取焦点事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dp_MouseEnter(object sender, EventArgs e)
        {
            DuiBaseControl dp = null;
            if (sender is DuiBaseControl)
            {
                dp = sender as DuiBaseControl;
            }
            if (sender is DuiLabel)
            {
                dp = (sender as DuiLabel).Parent as DuiBaseControl;
            }
            if (sender is DuiPictureBox)
            {
                dp = (sender as DuiPictureBox).Parent as DuiBaseControl;
            }
            //显示说明
            if (dp.FindControl("songSheetExplain").Count > 0)
            {
                DuiLabel dl = (DuiLabel)dp.FindControl("songSheetExplain")[0];
                dl.Visible = true;
            }
            //隐藏收听量
            if (dp.FindControl("lisentInCount").Count > 0)
            {
                DuiLabel ldl = (DuiLabel)dp.FindControl("lisentInCount")[0];
                ldl.Visible = false;
            }
            if (dp.FindControl("lisentInIcon").Count > 0)
            {
                DuiButton ldb = (DuiButton)dp.FindControl("lisentInIcon")[0];
                ldb.Visible = false;
            }
        }

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

        #region 自定义事件
        /// <summary>
        /// 添加滚动图控件
        /// </summary>
        /// <param name="se"></param>
        /// <returns></returns>
        public bool addSwitchImage(SwitcherImageEntity se)
        {
            switcherImgsEntity = se;
            DuiBaseControl baseControl = new DuiBaseControl();
            baseControl.Size = ItemSize;
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
            dLabel1.Cursor = imgLeft.Cursor;
            dLabel2.Cursor = imgLeft.Cursor;
            dLabel3.Cursor = imgLeft.Cursor;
            dLabel4.Cursor = imgLeft.Cursor;
            dLabel5.Cursor = imgLeft.Cursor;
            dLabel6.Cursor = imgLeft.Cursor;
            dLabel7.Cursor = imgLeft.Cursor;
            dLabel8.Cursor = imgLeft.Cursor;
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
            Items.Add(getDuiBase());
            Items.Add(getDuiBase());
            Items.Add(getDuiBase());
            Items.Add(getDuiBase());
            Items.Add(getDuiBase());
            Items.Add(getDuiBase());
            Items.Add(getDuiBase());
            Items.Add(getDuiBase());
            Items.Add(getDuiBase());
            Items.Add(baseControl);
            //添加歌单标头
            addRecommendSongTitle(baseControl,new Entity.SongSheetTitle("推荐歌单", "12306"));
            //更新列表
            RefreshList();
            GC.Collect();
            return true;
        }

        public bool addRecommendSongTitle(DuiBaseControl dbase,SongSheetTitle st)
        {
            //是否已存在
            bool isExists = false;
            foreach (SongSheetTitle item in tGroups)
            {
                if (item == st)
                {
                    isExists = true;
                }
            }
            //如果不存在则添加
            if (!isExists)
            {
                //底层控件
                DuiBaseControl baseControl = new DuiBaseControl();
                baseControl.Size = new Size(this.Width, 30);
                //baseControl.BackColor = Color.FromArgb(245, 245, 247);
                baseControl.Location = new Point(0, 250);
                //标题
                DuiLabel lTitle = new DuiLabel();
                lTitle.Size = new Size(80, 30);
                lTitle.Text = st.Name;
                lTitle.Font = new Font("微软雅黑", 12F, FontStyle.Regular);
                lTitle.ForeColor = Color.DimGray;
                lTitle.Location = new Point(0,0);
                //更多按钮
                DuiButton dbutton = new DuiButton();
                dbutton.Size = new Size(40,20);
                dbutton.Text = "更多";
                dbutton.BaseColor = Color.Transparent;
                dbutton.Location = new Point(this.Width-60,5);
                dbutton.AdaptImage = false;
                dbutton.Cursor = System.Windows.Forms.Cursors.Hand;

                //更多图标
                DuiButton dInIcon = new DuiButton();
                dInIcon.Location = new Point(this.Width-23, 2);
                dInIcon.Size = new Size(10, 10);
                dInIcon.NormalImage = Properties.Resources.Arrowright0;
                dInIcon.AdaptImage = false;
                dInIcon.Cursor = System.Windows.Forms.Cursors.Hand;
                //下划线
                DuiLabel lLine = new DuiLabel();
                lLine.Size = new Size(this.Width, 30);
                lLine.ForeColor = Color.Red;
                lLine.BackColor = Color.Red;
                lLine.Location = new Point(0, 40);
                baseControl.Controls.Add(dbutton);
                baseControl.Controls.Add(dInIcon);
                baseControl.Controls.Add(lTitle);
                baseControl.Controls.Add(lLine);
                dbase.Controls.Add(baseControl);
                //Items.Add(baseControl);
                //更新列表
                //RefreshList();
                //tGroups.Add(st);
            }
            GC.Collect();
            return !isExists;
        }

        /// <summary>
        /// 添加歌单
        /// </summary>
        /// <param name="se"></param>
        /// <returns></returns>
        public bool addRecommendSongSheet(SongSheetEntity se)
        {

            //是否已存在
            bool isExists = false;
            foreach (SongSheetEntity item in Groups)
            {
                if (item == se)
                {
                    isExists = true;
                }
            }
            //如果不存在则添加
            if (!isExists)
            {
                //底层控件
                DuiBaseControl baseControl = new DuiBaseControl();
                baseControl.Size = ItemSize;
                baseControl.BackColor = Color.FromArgb(245, 245, 247);
                //边框
                Borders baseBorder = new Borders(baseControl);
                baseBorder.BottomWidth = 10;
                baseBorder.TopWidth = 10;
                baseBorder.LeftWidth = 10;
                baseBorder.RightWidth = 10;
                //baseBorder.BottomColor = Color.FromArgb(50, 0, 0, 0);
                baseControl.Borders = baseBorder;
                if (se.Id == "tj")
                {
                    string[] Day = new string[] { "星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };
                    string week = Day[Convert.ToInt32(DateTime.Now.DayOfWeek.ToString("d"))].ToString();
                    //星期标签
                    DuiLabel weekName = new DuiLabel();
                    weekName.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                    weekName.Location = new Point(37, 30);
                    weekName.Size = new Size(65, 30);
                    weekName.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
                    weekName.ForeColor = Color.Black;
                    weekName.TextAlign = ContentAlignment.TopCenter;
                    weekName.Text = week;
                    weekName.Name = "weekName";
                    //日期标签
                    DuiLabel dateName = new DuiLabel();
                    dateName.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                    dateName.Location = new Point(22, 50);
                    dateName.Size = new Size(95, 95);
                    dateName.Font = new Font("微软雅黑", 45F, FontStyle.Bold);
                    dateName.ForeColor = Color.FromArgb(255, 92, 138);
                    dateName.TextAlign = ContentAlignment.TopCenter;
                    dateName.Text = DateTime.Now.Day.ToString();
                    dateName.Name = "dateName";
                    baseControl.Controls.Add(weekName);
                    baseControl.Controls.Add(dateName);
                    baseControl.MouseEnter += Dp_MouseEnter;
                    baseControl.MouseLeave += Dp_MouseLeave;
                    weekName.MouseEnter += Dp_MouseEnter;
                    weekName.MouseLeave += Dp_MouseLeave;
                    dateName.MouseEnter += Dp_MouseEnter;
                    dateName.MouseLeave += Dp_MouseLeave;
                }
                else
                {
                    //背景图
                    DuiPictureBox dp = new DuiPictureBox();
                    dp.Size = new Size(140, 140);
                    dp.Location = new Point(0, 0);
                    dp.BackgroundImage = GetImageByUrl(se.BackImg);
                    dp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    dp.Name = "songSheetBackImg";
                    dp.MouseEnter += Dp_MouseEnter;
                    dp.MouseLeave += Dp_MouseLeave;
                    baseControl.Controls.Add(dp);
                    //收听量
                    DuiLabel lisentInCount = new DuiLabel();
                    lisentInCount.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                    lisentInCount.Location = new Point(0, 0);
                    lisentInCount.Size = new Size(140, 20);
                    lisentInCount.Font = new Font("微软雅黑", 9F, FontStyle.Regular);
                    lisentInCount.ForeColor = Color.White;
                    lisentInCount.TextAlign = ContentAlignment.TopRight;
                    lisentInCount.BackColor = Color.FromArgb(100, 0, 0, 0);
                    lisentInCount.Text = se.Count;
                    lisentInCount.Name = "lisentInCount";
                    //收听图标
                    DuiButton lisentInIcon = new DuiButton();
                    lisentInIcon.Location = new Point(90, 0);
                    lisentInIcon.Size = new Size(14, 14);
                    lisentInIcon.NormalImage = Properties.Resources.ej;
                    lisentInIcon.AdaptImage = false;
                    lisentInIcon.Name = "lisentInIcon";
                    baseControl.Controls.Add(lisentInCount);
                    baseControl.Controls.Add(lisentInIcon);
                }
                //说明
                DuiLabel songSheetExplain = new DuiLabel();
                songSheetExplain.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                songSheetExplain.Location = new Point(0, 0);
                songSheetExplain.Size = new Size(140, 40);
                songSheetExplain.Font = new Font("微软雅黑", 9F, FontStyle.Regular);
                songSheetExplain.ForeColor = Color.White;
                songSheetExplain.TextPadding = 5;
                songSheetExplain.TextAlign = ContentAlignment.TopCenter;
                songSheetExplain.BackColor = Color.FromArgb(100, 0, 0, 0);
                songSheetExplain.Text = se.Explain;
                songSheetExplain.Name = "songSheetExplain";
                songSheetExplain.Visible = false;
                
                //标题
                DuiLabel songSheetName = new DuiLabel();
                songSheetName.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                songSheetName.Location = new Point(0, 140);
                songSheetName.Size = new Size(140, 30);
                songSheetName.Font = new Font("微软雅黑", 9F, FontStyle.Regular);
                songSheetName.ForeColor = Color.Black;
                songSheetName.TextAlign = ContentAlignment.TopCenter;
                songSheetName.Text = se.Name;
                songSheetName.BackColor = Color.White;
                songSheetName.Name = "songSheetName_"+se.Id;

                baseControl.Controls.Add(songSheetName);
                baseControl.Controls.Add(songSheetExplain);
                Items.Add(baseControl);
                
                //更新列表
                RefreshList();
                Groups.Add(se);
            }
            GC.Collect();
            return !isExists;
        }
        /// <summary>
        /// 列表刷新
        /// </summary>
        public new void RefreshList()
        {
            if (RefreshListed != null)
                RefreshListed(this, new EventArgs());
            base.RefreshList();
        }


        public void RecommendSongSheet_MouseDown()
        {
            if (RecommendSongSheetMouseDown != null)
                RecommendSongSheetMouseDown(this, new EventArgs());
        }

        private DuiBaseControl getDuiBase()
        {
            DuiBaseControl dbbase = new DuiBaseControl();
            dbbase.Size = new Size(ItemSize.Width,10);
            dbbase.Top = ItemSize.Height;
            dbbase.Location = new Point(0, ItemSize.Height);
            return dbbase;
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
            System.Drawing.Image image = null;
            try
            {
                WebRequest webreq = WebRequest.Create(url);
                //红色部分为文件URL地址，这里是一张图片
                WebResponse webres = webreq.GetResponse();
                Stream stream = webres.GetResponseStream();                
                image = System.Drawing.Image.FromStream(stream);
                stream.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return image;
            //return Image.FromStream(System.Net.WebRequest.Create(url).GetResponse().GetResponseStream());
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


        #region 委托事件
        /// <summary>
        /// 刷新列表事件
        /// </summary>
        [Description("列表刷新事件"), Category("自定义事件")]
        public event EventHandler RefreshListed;
        /// <summary>
        /// 控件点击事件
        /// </summary>
        [Description("控件点击事件"), Category("自定义事件")]
        public event EventHandler RecommendSongSheetMouseDown;
        #endregion

    }
}
