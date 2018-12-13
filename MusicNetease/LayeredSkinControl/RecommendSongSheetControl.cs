﻿using System;
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
            DuiPictureBox dp = sender as DuiPictureBox;
            DuiLabel dl = (DuiLabel)dp.FindControl("songSheetExplain")[0];
            dl.Visible = false;
        }

        /// <summary>
        /// 图片控件获取焦点事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dp_MouseEnter(object sender, EventArgs e)
        {
            DuiPictureBox dp = sender as DuiPictureBox;
            DuiLabel dl = (DuiLabel)dp.FindControl("songSheetExplain")[0];
            dl.Visible = true;
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
                dp.Size = new Size(195, 195);
                dp.Location = new Point(0, 0);
                dp.BackgroundImage = se.BackImg;
                dp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                dp.Name = "songSheetBackImg_"+se.Id;
                dp.MouseEnter += Dp_MouseEnter;
                dp.MouseLeave += Dp_MouseLeave;
                //说明
                DuiLabel songSheetExplain = new DuiLabel();
                songSheetExplain.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                songSheetExplain.Location = new Point(0, 195);
                songSheetExplain.Size = new Size(195, 32);
                songSheetExplain.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
                songSheetExplain.ForeColor = Color.DimGray;
                songSheetExplain.Text = se.Explain;
                songSheetExplain.Name = "songSheetExplain_"+se.Id;
                songSheetExplain.Visible = false;
                dp.Controls.Add(songSheetExplain);
                //标题
                DuiButton songSheetName = new DuiButton();
                songSheetName.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                songSheetName.Location = new Point(0, 195);
                songSheetName.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
                songSheetName.ForeColor = Color.Black;
                songSheetName.Text = se.Name;
                songSheetName.Name = "songSheetName_"+se.Id;

                baseControl.Controls.Add(dp);
                baseControl.Controls.Add(songSheetName);
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