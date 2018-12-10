using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicNetease.Entity
{
    public class MenuEntity
    {
        /// <summary>
        /// 菜单名称
        /// </summary>
        private string menuName;
        /// <summary>
        /// 菜单控件名称
        /// </summary>
        private string menuText;
        /// <summary>
        /// 图标
        /// </summary>
        private Image icon;
        /// <summary>
        /// 选中后的图标
        /// </summary>
        private Image hoverIcon;
        /// <summary>
        /// 是否包含下级
        /// </summary>
        private bool isEndLevel;
        /// <summary>
        /// 下级菜单集合
        /// </summary>
        private MenuEntity[] menus;
        /// <summary>
        /// 菜单名称
        /// </summary>
        public string MenuName {
            get { return menuName; }
            set { menuName = value; }
        }
        /// <summary>
        /// 菜单控件名称
        /// </summary>
        public string MenuText
        {
            get { return menuText; }
            set { menuText = value; }
        }
        /// <summary>
        /// 菜单图标
        /// </summary>
        public Image Icon {
            get { return icon; }
            set { icon = value; }
        }
        /// <summary>
        /// 选中图标
        /// </summary>
        public Image HoverIcon {
            get { return hoverIcon; }
            set { hoverIcon = value; }
        }
        /// <summary>
        /// 是否末级菜单
        /// </summary>
        public bool IsEndLevel {
            get { return isEndLevel; }
            set { isEndLevel = value; }
        }
        /// <summary>
        /// 下级菜单集合
        /// </summary>
        public MenuEntity[] Menus
        {
            get { return menus; }
            set { menus = value; }
        }
    }
}
