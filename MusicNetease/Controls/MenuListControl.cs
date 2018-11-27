using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicNetease.Controls
{
    public partial class MenuListControl : UserControl
    {
        public MenuListControl()
        {
            InitializeComponent();

        }
        //定义委托
        public delegate void MenuControlMouseDown(object sender, EventArgs e);
        //定义事件
        public event MenuControlMouseDown MenuControl_MouseDown;

        /// <summary>
        /// 恢复所有控件为原始状态，包括颜色状态等信息
        /// </summary>
        private void setMenuControlDefault()
        {
            foreach (Control control in this.Controls)
            {
                foreach (Control item in control.Controls)
                {
                    //如果是菜单控件
                    if (item is MenuControl)
                    {
                        MenuControl mc = item as MenuControl;
                        mc.setBackColor();
                        mc.isSelect = false;
                    }
                } 
            }    
        }
        /// <summary>
        /// 设置按钮选择后的颜色
        /// </summary>
        /// <param name="color"></param>
        private void setMenuControlSelectColor(Color color)
        {
            foreach (Control control in this.Controls)
            {
                foreach (Control item in control.Controls)
                {
                    //如果是菜单控件
                    if (item is MenuControl)
                    {
                        MenuControl mc = item as MenuControl;
                        mc.SelectColor = color;
                    }
                }
            }
        }

        private void menuControl_srFm_skinPanelMouseDown(object sender, EventArgs e)
        {
            if (MenuControl_MouseDown != null)
            {
                MenuControl_MouseDown(sender, e);
            }
            setMenuControlDefault();
        }

        
    }
}
