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
        /// 图标
        /// </summary>
        private Image icon;
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
        public string MenuName { get => menuName; set => menuName = value; }
        /// <summary>
        /// 菜单图标
        /// </summary>
        public Image Icon { get => icon; set => icon = value; }
        /// <summary>
        /// 是否末级菜单
        /// </summary>
        public bool IsEndLevel { get => isEndLevel; set => isEndLevel = value; }
        /// <summary>
        /// 下级菜单集合
        /// </summary>
        public MenuEntity[] Menus { get => menus; set => menus = value; }
    }
}
