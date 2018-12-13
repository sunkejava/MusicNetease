using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayeredSkin.DirectUI;
using System.Drawing;
using System.ComponentModel;
using MusicNetease.Entity;

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
        

        #endregion

        #region 自定义事件
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
                baseControl.Size = new Size(140, 180);
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
                    dp.BackgroundImage = se.BackImg;
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
