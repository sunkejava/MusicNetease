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
    public partial class MenuControl : UserControl
    {
        public MenuControl()
        {
            InitializeComponent();
        }

        private void skinPanel_sc_MouseDown(object sender, MouseEventArgs e)
        {
            //原色  245, 245, 247
            skinPanel_dc.BackColor = Color.FromArgb( 255, 92, 138);
            skinPanel_sc.BackColor = Color.FromArgb(230, 231, 234);
        }

        private void skinButton_icon_MouseHover(object sender, EventArgs e)
        {
            CCWin.SkinControl.SkinButton btn = sender as CCWin.SkinControl.SkinButton;
            btn.BackgroundImage = btn.MouseBack;
        }

        private void skinButton_icon_MouseLeave(object sender, EventArgs e)
        {
            CCWin.SkinControl.SkinButton btn = sender as CCWin.SkinControl.SkinButton;
            btn.BackgroundImage = btn.NormlBack;
        }
        /// <summary>
        /// 恢复原色
        /// </summary>
        public void setBackColor()
        {
            skinPanel_dc.BackColor = Color.FromArgb(245, 245, 247);
            skinPanel_sc.BackColor = Color.FromArgb(245, 245, 247);
        }
    }
}
