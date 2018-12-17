using LayeredSkin.DirectUI;
using MusicNetease.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MusicNetease.LayeredSkinControl
{
    /// <summary>
    /// 类    名: SongSheetList.cs
    /// CLR 版本: 4.0.30319.42000
    /// 作    者: sunkejava 
    /// 邮    箱：declineaberdeen@foxmail.com
    /// 创建时间: 2018/11/17 14:55:51
    /// 说    明：网易云音乐树形菜单控件
    /// </summary>
    public class SongSheetList : LayeredSkin.Controls.LayeredListBox
    {
        
        //选择后的颜色
        Color _SelectColor = Color.FromArgb(255, 92, 138);

        public List<MenuEntity> Groups = new List<MenuEntity>();
        public SongSheetList()
        {
            DuiBaseControl baseControl = new DuiBaseControl();
            baseControl.Size = new Size(Width, 28);
            baseControl.BackColor = Color.FromArgb(245, 245, 247);

            Borders baseBorder = new Borders(baseControl);
            baseBorder.BottomWidth = 1;
            baseBorder.BottomColor = Color.FromArgb(50, 0, 0, 0);

            baseControl.Borders = baseBorder;

            //菜单名称
            DuiLabel menuName = new DuiLabel();
            menuName.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            menuName.Location = new Point(43, 5);
            menuName.AutoSize = true;
            menuName.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            menuName.ForeColor = Color.DimGray;
            menuName.Text = "发现音乐";
            menuName.Name = "MenuName";

            //菜单图标
            DuiButton menuIcon = new DuiButton();
            menuIcon.BackgroundImage = Properties.Resources.music0;
            menuIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            menuIcon.NormalImage = Properties.Resources.music0;
            menuIcon.HoverImage = Properties.Resources.music1;
            menuIcon.PressedImage = Properties.Resources.music1;
            menuIcon.Size = new Size(16, 16);
            menuIcon.Location = new Point(15,5);

            //底层Control
            //DuiBaseControl dcControl = new DuiBaseControl();
            //dcControl.BackColor = Color.FromArgb(230, 231, 234);

            //上层Control
            DuiBaseControl scControl = new DuiBaseControl();
            scControl.BackColor = Color.FromArgb(245, 245, 247);
            scControl.Name = "scControl";
            //通过控制上下层Control背景色实现菜单样式
            //dcControl.Size = new Size(Width, 28);
            scControl.Size = new Size(Width-3,28);
            //添加菜单名控件到上层控件
            scControl.Controls.Add(menuIcon);
            scControl.Controls.Add(menuName);
            //dcControl.Controls.Add(scControl);
            baseControl.Controls.Add(scControl);
            baseControl.Name = "baseControl";

            menuName.MouseDown += MenuName_MouseDown;
            menuIcon.MouseDown += MenuName_MouseDown;

        }

        #region 自定义公开属性
        /// <summary>
        /// 设置底层背景色
        /// </summary>
        /// <returns></returns>
        [Description("设置底层背景色"), Category("自定义属性")]
        public Color SetSelectColor
        {
            get { return _SelectColor; }
            set { _SelectColor = value; }
        }
        #endregion


        #region 控件事件
        /// <summary>
        /// 菜单或图标点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void MenuName_MouseDown(object sender, MouseEventArgs e)
        {
            setBackColor();
            DuiBaseControl scControl = ((DuiLabel)sender).Parent as DuiBaseControl;
            scControl.BackColor = Color.FromArgb(230, 231, 234);
            DuiBaseControl bControl = scControl.Parent as DuiBaseControl;
            bControl.BackColor = _SelectColor;
            if (MenuNameMouseDown != null)
                MenuNameMouseDown(sender, e);
            
            
        }
        /// <summary>
        /// 顶级菜单下级显示或隐藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TopMenuName_MouseDown(object sender, MouseEventArgs e)
        {
            DuiBaseControl bControl = ((DuiLabel)sender).Parent as DuiBaseControl;
            if (bControl.Tag.ToString() == "openList")
            {
                bControl.Tag = "closeList";
                foreach (DuiBaseControl item in Items)
                {
                    if (item.Name.Replace("list_", "").Contains(bControl.Name.Replace("list_", "")) && item.Name.Replace("list_", "").Length > bControl.Name.Replace("list_", "").Length)
                    {
                        item.Visible = true;
                    }
                }
            }
            else
            {
                bControl.Tag = "openList";
                foreach (DuiBaseControl item in Items)
                {
                    if (item.Name.Replace("list_", "").Contains(bControl.Name.Replace("list_", "")) && item.Name.Replace("list_", "").Length > bControl.Name.Replace("list_", "").Length)
                    {
                        item.Visible = false;
                    }
                }
            }
            RefreshList();
        }
        /// <summary>
        /// 新增歌单事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addMenuIcon_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        #endregion

        #region 自定义事件
        /// <summary>
        /// 还原菜单背景为原色
        /// </summary>
        private void setBackColor()
        {
            foreach (DuiBaseControl item in Items)
            {
                item.BackColor = Color.FromArgb(245, 245, 247);
                foreach (DuiBaseControl aitem in item.FindControl("scControl"))
                {
                    aitem.BackColor = Color.FromArgb(245, 245, 247);
                }
            }
        }
        /// <summary>
        /// 添加菜单
        /// </summary>
        /// <param name="thisMenu"></param>
        /// <returns></returns>
        public bool AddMenun(MenuEntity thisMenu)
        {
            //是否已存在
            bool isExists = false;
            foreach (MenuEntity item in Groups)
            {
                if (item == thisMenu)
                {
                    isExists = true;
                }
            }
            //如果不存在则添加
            if (!isExists)
            {
                //创建顶级菜单
                if (thisMenu.IsTopLevel)
                {
                    //底层控件
                    DuiBaseControl baseControl = new DuiBaseControl();
                    baseControl.Size = new Size(Width, 35);
                    baseControl.BackColor = Color.FromArgb(245, 245, 247);
                    //边框
                    Borders baseBorder = new Borders(baseControl);
                    baseBorder.BottomWidth = 5;
                    baseBorder.TopWidth = 5;
                    baseBorder.BottomColor = Color.FromArgb(245, 245, 247);
                    baseControl.Borders = baseBorder;
                    //菜单名称
                    DuiLabel menuName = new DuiLabel();
                    menuName.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                    menuName.Location = new Point(10, 10);
                    menuName.AutoSize = true;
                    menuName.Font = new Font("微软雅黑", 9F, FontStyle.Bold);
                    menuName.ForeColor = Color.DimGray;
                    menuName.Text = thisMenu.MenuName;
                    menuName.Name = "list_" + thisMenu.MenuText;

                    //新增图标
                    DuiButton addMenuIcon = null;
                    //收起展开图标
                    DuiButton menuIcon = null;
                    //如果不是底层菜单，增加图标
                    if (!thisMenu.IsEndLevel)
                    {
                        //如果是创建的歌单增加新增图标按钮
                        if (thisMenu.MenuName == "创建的歌单")
                        {
                            //新增图标
                            addMenuIcon = new DuiButton();
                            addMenuIcon.BackgroundImage = thisMenu.Icon;
                            addMenuIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                            addMenuIcon.NormalImage = thisMenu.Icon;
                            addMenuIcon.HoverImage = thisMenu.HoverIcon;
                            addMenuIcon.PressedImage = thisMenu.HoverIcon;
                            addMenuIcon.AdaptImage = false;
                            addMenuIcon.Size = new Size(16, 16);
                            addMenuIcon.Location = new Point(126, 12);
                            addMenuIcon.Cursor = Cursors.Hand;
                            //新增事件搬绑定
                            addMenuIcon.MouseDown += addMenuIcon_MouseDown;
                        }
                        //收起展开图标
                        menuIcon = new DuiButton();
                        menuIcon.AdaptImage = false;
                        menuIcon.NormalImage = Properties.Resources.Arrowright0;
                        menuIcon.HoverImage = Properties.Resources.Arrowright1;
                        menuIcon.PressedImage = Properties.Resources.Arrowright1;                        
                        menuIcon.Size = new Size(16, 16);
                        menuIcon.Cursor = Cursors.Hand;
                        baseControl.Tag = "openList";
                        menuIcon.Location = new Point(155, 12);
                        menuName.Cursor = Cursors.Hand;
                        //菜单名称及收起展开图标事件绑定
                        menuName.MouseDown += TopMenuName_MouseDown;
                        menuIcon.MouseDown += TopMenuName_MouseDown;
                    }
                    //添加菜单名控件到上层控件
                    baseControl.Controls.Add(menuName);
                    if (addMenuIcon != null)
                    {
                        baseControl.Controls.Add(addMenuIcon);
                    }
                    if (menuIcon != null)
                    {
                        baseControl.Controls.Add(menuIcon);
                    }
                    baseControl.Name = "list_" + thisMenu.MenuText;
                    Items.Add(baseControl);
                }
                else
                {
                    //底层控件
                    DuiBaseControl baseControl = new DuiBaseControl();
                    baseControl.Size = new Size(Width, 28);
                    baseControl.BackColor = Color.FromArgb(245, 245, 247);
                    //菜单名称
                    DuiLabel menuName = new DuiLabel();
                    menuName.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                    menuName.Location = new Point(43, 5);
                    menuName.AutoSize = true;
                    menuName.Font = new Font("微软雅黑", 9F, FontStyle.Regular);
                    menuName.ForeColor = Color.DimGray;
                    menuName.Text = thisMenu.MenuName;
                    menuName.Name = "listDl_" + thisMenu.MenuText;
                    menuName.Tag = thisMenu.MenuText;
                    menuName.Cursor = Cursors.Hand;
                    //菜单图标
                    DuiButton menuIcon = new DuiButton();
                    menuIcon.BackgroundImage = thisMenu.Icon;
                    menuIcon.AdaptImage = false;
                    menuIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    menuIcon.NormalImage = thisMenu.Icon;
                    menuIcon.HoverImage = thisMenu.HoverIcon;
                    menuIcon.PressedImage = thisMenu.HoverIcon;
                    menuIcon.Size = new Size(16, 16);
                    menuIcon.Location = new Point(15, 5);
                    menuIcon.Name = "listDb_" + thisMenu.MenuText;
                    menuIcon.Tag = thisMenu.MenuText;
                    menuIcon.Cursor = Cursors.Hand;
                    //上层控件
                    DuiBaseControl scControl = new DuiBaseControl();
                    scControl.BackColor = Color.FromArgb(245, 245, 247);
                    //通过控制上下层Control背景色实现菜单样式
                    //dcControl.Size = new Size(Width, 28);
                    scControl.Size = new Size(Width - 3, 28);
                    scControl.Location = new Point(3, 0);
                    //添加菜单名控件到上层控件
                    scControl.Controls.Add(menuIcon);
                    scControl.Controls.Add(menuName);
                    scControl.Name = "scControl";
                    //dcControl.Controls.Add(scControl);
                    baseControl.Controls.Add(scControl);
                    baseControl.Name = "list_" + thisMenu.MenuText;
                    if (thisMenu.MenuText.Contains("createdsongListlb") && thisMenu.MenuText.Length > "createdsongListlb".Length)
                    {
                        baseControl.Visible = false;
                    }
                    if (thisMenu.MenuText.Contains("collectionSongListlb") && thisMenu.MenuText.Length > "collectionSongListlb".Length)
                    {
                        baseControl.Visible = false;
                    }
                    menuName.MouseDown += MenuName_MouseDown;
                    menuIcon.MouseDown += MenuName_MouseDown;

                    Items.Add(baseControl);
                }
               
                RefreshList();
                Groups.Add(thisMenu);
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
        [Description("列表刷新事件"),Category("自定义事件")]
        public event EventHandler RefreshListed;
        [Description("菜单点击事件"), Category("自定义事件")]
        public event EventHandler MenuNameMouseDown;
        #endregion

    }
}
