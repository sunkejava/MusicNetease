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
        private bool _isSelect = false;
        public MenuControl()
        {
            InitializeComponent();
        }

        public void skinPanel_sc_MouseDown(object sender, MouseEventArgs e)
        {
            //原色  245, 245, 247
            skinPanel_dc.BackColor = Color.FromArgb(255, 92, 138);
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

        /// <summary>
        /// 菜单Name
        /// </summary>
        public string menuName
        {
            get { return skinLabel_name.Name; }
            set { skinLabel_name.Name = value; }
        }

        /// <summary>
        /// 菜单名称
        /// </summary>
        public string menuText
        {
            get { return skinLabel_name.Text; }
            set { skinLabel_name.Text = value; }
        }

        /// <summary>
        /// 底层颜色
        /// </summary>
        public Color setDcColor
        {
            get { return skinPanel_dc.BackColor; }
            set { skinPanel_dc.BackColor = value; }
        }
        /// <summary>
        /// 上层颜色
        /// </summary>
        public Color setScColor
        {
            get { return skinPanel_sc.BackColor; }
            set { skinPanel_sc.BackColor = value; }
        }
        /// <summary>
        /// 设置默认背景图
        /// </summary>
        public Image setNormlIcon
        {
            get { return skinButton_icon.NormlBack; }
            set { skinButton_icon.NormlBack = value; }
        }
        /// <summary>
        /// 设置背景图
        /// </summary>
        public Image setBackgroundIcon
        {
            get { return skinButton_icon.BackgroundImage; }
            set { skinButton_icon.BackgroundImage = value; }
        }
        /// <summary>
        /// 设置悬浮时背景
        /// </summary>
        public Image setMouseBack
        {
            get { return skinButton_icon.MouseBack; }
            set { skinButton_icon.MouseBack = value; }
        }
        /// <summary>
        /// 是否选择
        /// </summary>
        public bool isSelect
        {
            get { return _isSelect; }
            set { _isSelect = value; }
        }








    }
}
