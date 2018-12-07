using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;

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

        private void skinButton_MusicList_Click(object sender, EventArgs e)
        {
            CCWin.SkinControl.SkinButton btn = sender as CCWin.SkinControl.SkinButton;
            String[] menuStrings = new String[] { "WCTF 2018", "口哨系｜学会就可以撩妹了ΘˍΘ", "『开口脆』迷幻嗓音极致瞬间❤️", "华语百首 | 回忆伤人无声，唱不尽世间遗憾",
            "90后的回忆杀 - 『持续更新』", "床前的催眠曲 - 八音盒系列", "【夜跑】把你的脚印留在城市的每一个角落。", "华语励志 | 吹灭读书灯，一身都是月", "Thug Life系列背景音乐", "天气渐凉，才觉一年将尽。", "加速燃脂，健身运动BGM" };
            var i = 0;
            var ny = 0;
            CCWin.SkinControl.SkinPanel sp = (btn.Name == "skinButton_MusicList" ? skinPanel_newMusicList : skinPanel_MyFavorite);
            if (btn.Tag.ToString() == "展开")
            {
                btn.BackgroundImage = global::MusicNetease.Properties.Resources.todown0;
                btn.NormlBack = global::MusicNetease.Properties.Resources.todown0;
                btn.MouseBack = global::MusicNetease.Properties.Resources.todown1;
                btn.DownBack = global::MusicNetease.Properties.Resources.todown1;
                btn.Tag = "收起";
                //循环增加菜单
                foreach (var item in menuStrings)
                {
                    MenuControl mc = new MenuControl();
                    mc.Size = new Size(this.Width, 28);
                    mc.menuText = item;
                    mc.setBackgroundIcon = global::MusicNetease.Properties.Resources.bflb0;
                    mc.setNormlIcon = global::MusicNetease.Properties.Resources.bflb0;
                    mc.setMouseBack = global::MusicNetease.Properties.Resources.bflb1;
                    mc.Name = btn.Name+i.ToString();
                    mc.Location = new Point(0, (i+1) * 28 + sp.Location.Y);
                    ny = mc.Location.Y;
                    skinPanel1.Controls.Add(mc);
                    i++;
                }
                if (btn.Name == "skinButton_MusicList")
                {
                    skinPanel_MyFavorite.Location = new Point(0, ny);
                }
            }
            else
            {
                btn.BackgroundImage = global::MusicNetease.Properties.Resources.Arrowright0;
                btn.NormlBack = global::MusicNetease.Properties.Resources.Arrowright0;
                btn.MouseBack = global::MusicNetease.Properties.Resources.Arrowright1;
                btn.DownBack = global::MusicNetease.Properties.Resources.Arrowright1;
                btn.Tag = "展开";
                

                //循环删除之前展开的菜单
                foreach (Control item in skinPanel1.Controls)
                {
                    if (item.Name == btn.Name+i.ToString())
                    {
                        ny = item.Location.Y;
                        this.Controls.Remove(item);
                        i++;
                    }
                }
                if (btn.Name == "skinButton_MusicList")
                {
                    skinPanel_MyFavorite.Location = new Point(0, ny);
                }
            }
            
        }
    }
}
