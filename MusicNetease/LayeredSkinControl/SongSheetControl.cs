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
        private void MenuName_MouseDown(object sender, MouseEventArgs e)
        {
            setBackColor();
            DuiBaseControl scControl = ((DuiLabel)sender).Parent as DuiBaseControl;
            scControl.BackColor = Color.FromArgb(230, 231, 234);
            DuiBaseControl bControl = scControl.Parent as DuiBaseControl;
            bControl.BackColor = _SelectColor;
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
            int xHeight = 0;
            foreach (MenuEntity item in Groups)
            {
                if (item == thisMenu)
                {
                    isExists = true;
                }
            }
            xHeight = ((Groups.Count - 1) <=0 ? 28 : (Groups.Count - 1) * 28);
            if (!isExists)
            {
                //菜单名称
                DuiBaseControl baseControl = new DuiBaseControl();
                baseControl.Size = new Size(Width, 28);
                baseControl.BackColor = Color.FromArgb(245, 245, 247);

                //边框
                //Borders baseBorder = new Borders(baseControl);
                //baseBorder.BottomWidth = 2;
                //baseBorder.BottomColor = Color.FromArgb(50, 0, 0, 0);
                //baseControl.Borders = baseBorder;

                //菜单名称
                DuiLabel menuName = new DuiLabel();
                menuName.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                menuName.Location = new Point(43, 5);
                menuName.AutoSize = true;
                menuName.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
                menuName.ForeColor = Color.DimGray;
                menuName.Text = thisMenu.MenuName;
                menuName.Name = "list_" +thisMenu.MenuText;
                DuiButton menuIcon = new DuiButton();
                menuIcon.BackgroundImage = thisMenu.Icon;
                menuIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                menuIcon.NormalImage = thisMenu.Icon;
                menuIcon.HoverImage = thisMenu.HoverIcon;
                menuIcon.PressedImage = thisMenu.HoverIcon;
                menuIcon.Size = new Size(10, 10);
                menuIcon.Location = new Point(15, 5);
                DuiBaseControl scControl = new DuiBaseControl();
                scControl.BackColor = Color.FromArgb(245, 245, 247);
                //通过控制上下层Control背景色实现菜单样式
                //dcControl.Size = new Size(Width, 28);
                scControl.Size = new Size(Width - 3, 28);
                scControl.Location = new Point(3,0);
                //添加菜单名控件到上层控件
                scControl.Controls.Add(menuIcon);
                scControl.Controls.Add(menuName);
                scControl.Name = "scControl";
                //dcControl.Controls.Add(scControl);
                baseControl.Controls.Add(scControl);
                baseControl.Name = "list_"+thisMenu.MenuText;

                menuName.MouseDown += MenuName_MouseDown;
                menuIcon.MouseDown += MenuName_MouseDown;

                Items.Add(baseControl);
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
        public event EventHandler RefreshListed;
        #endregion

    }
}
