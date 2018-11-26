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
        /// <summary>
        /// 菜单按钮按下事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuControl_fxyy_MouseDown(object sender, MouseEventArgs e)
        {
            menuControl_fxyy.skinPanel_sc_MouseDown(sender, e);
        }
        private void setMenuControlDefault()
        {
            menuControl_fxyy.isSelect = false;
            
        }
    }
}
