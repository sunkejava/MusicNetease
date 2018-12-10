using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MusicNetease
{
    public partial class MainForm : MusicNetease.BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 委托单机事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuListControl1_MenuControl_MouseDown(object sender, EventArgs e)
        {
            if (sender is CCWin.SkinControl.SkinLabel)
            {
                CCWin.SkinControl.SkinLabel mc = sender as CCWin.SkinControl.SkinLabel;
                switch (mc.Name)
                {
                    case "skinLabel_srfm":
                        skinTabControl_Main.SelectedTab = skinTabPage_srfm;
                        break;
                    case "skinLabel_fxyy":
                        skinTabControl_Main.SelectedTab = skinTabPage_fxyy;
                        break;
                    case "skinLabel_tv":
                        skinTabControl_Main.SelectedTab = skinTabPage_tv;
                        break;
                    case "skinLabel_friend":
                        skinTabControl_Main.SelectedTab = skinTabPage_friend;
                        break;
                    case "skinLabel_bdyy":
                        skinTabControl_Main.SelectedTab = skinTabPage_bdyy;
                        break;
                    case "skinLabel_xzgl":
                        skinTabControl_Main.SelectedTab = skinTabPage_xzgl;
                        break;
                    case "skinLabel_yun":
                        skinTabControl_Main.SelectedTab = skinTabPage_yun;
                        break;
                    case "skinLabel_wddt":
                        skinTabControl_Main.SelectedTab = skinTabPage_wddt;
                        break;
                    case "skinLabel_wdsc":
                        skinTabControl_Main.SelectedTab = skinTabPage_wdsc;
                        break;
                    default:
                        skinTabControl_Main.SelectedTab = skinTabPage_gd;
                        break;
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.skinTabControl_Main.SendToBack();
            Entity.MenuEntity fxyyMenu = new Entity.MenuEntity();
            fxyyMenu.MenuName = "发现音乐";
            fxyyMenu.MenuText = "fxyy";
            fxyyMenu.Icon = Properties.Resources.music0;
            fxyyMenu.HoverIcon = Properties.Resources.music1;
            fxyyMenu.IsEndLevel = true;
            songSheetList1.AddMenun(fxyyMenu);
            Entity.MenuEntity srfmMenu = new Entity.MenuEntity();
            srfmMenu.MenuName = "私人FM";
            srfmMenu.MenuText = "srfm";
            srfmMenu.Icon = Properties.Resources.FM0;
            srfmMenu.HoverIcon = Properties.Resources.FM1;
            srfmMenu.IsEndLevel = true;
            songSheetList1.AddMenun(srfmMenu);
            Entity.MenuEntity tvMenu = new Entity.MenuEntity();
            tvMenu.MenuName = "视频";
            tvMenu.MenuText = "tv";
            tvMenu.Icon = Properties.Resources.tv0;
            tvMenu.HoverIcon = Properties.Resources.tv1;
            tvMenu.IsEndLevel = true;
            songSheetList1.AddMenun(tvMenu);
            Entity.MenuEntity friendMenu = new Entity.MenuEntity();
            friendMenu.MenuName = "朋友";
            friendMenu.MenuText = "friend";
            friendMenu.Icon = Properties.Resources.lxr0;
            friendMenu.HoverIcon = Properties.Resources.lxr1;
            friendMenu.IsEndLevel = true;
            songSheetList1.AddMenun(friendMenu);


            Entity.MenuEntity bdyyMenu = new Entity.MenuEntity();
            bdyyMenu.MenuName = "本地音乐";
            bdyyMenu.MenuText = "bdyy";
            bdyyMenu.Icon = Properties.Resources.bdyy0;
            bdyyMenu.HoverIcon = Properties.Resources.bdyy1;
            bdyyMenu.IsEndLevel = true;
            songSheetList1.AddMenun(bdyyMenu);
            Entity.MenuEntity xzglMenu = new Entity.MenuEntity();
            xzglMenu.MenuName = "下载管理";
            xzglMenu.MenuText = "xzgl";
            xzglMenu.Icon = Properties.Resources.download0;
            xzglMenu.HoverIcon = Properties.Resources.download1;
            xzglMenu.IsEndLevel = true;
            songSheetList1.AddMenun(xzglMenu);
            Entity.MenuEntity yunMenu = new Entity.MenuEntity();
            yunMenu.MenuName = "我的音乐云盘";
            yunMenu.MenuText = "yun";
            yunMenu.Icon = Properties.Resources.yun0;
            yunMenu.HoverIcon = Properties.Resources.yun1;
            yunMenu.IsEndLevel = true;
            songSheetList1.AddMenun(yunMenu);
            Entity.MenuEntity wddtMenu = new Entity.MenuEntity();
            wddtMenu.MenuName = "我的电台";
            wddtMenu.MenuText = "wddt";
            wddtMenu.Icon = Properties.Resources.dt0;
            wddtMenu.HoverIcon = Properties.Resources.dt1;
            wddtMenu.IsEndLevel = true;
            songSheetList1.AddMenun(wddtMenu);
            Entity.MenuEntity wdscMenu = new Entity.MenuEntity();
            wdscMenu.MenuName = "我的收藏";
            wdscMenu.MenuText = "wdsc";
            wdscMenu.Icon = Properties.Resources.wdsc0;
            wdscMenu.HoverIcon = Properties.Resources.wdsc1;
            wdscMenu.IsEndLevel = true;
            songSheetList1.AddMenun(wdscMenu);




        }

        private void songSheetList1_RefreshListed(object sender, EventArgs e)
        {
            int allheight = 0;
            for (int i = 0; i < songSheetList1.Items.Count; i++)
            {
                if (songSheetList1.Items[i].Visible)
                    allheight = allheight + songSheetList1.Items[i].Height;
            }
            double pre = (double)songSheetList1.Height / (double)allheight;
            if (pre < 1)
            {
                if (songSheetList1.Visible)
                    songSheetList1.Show();

                scorllbar.Height = (int)(pre * (double)songSheetList1.Height);
                scorllbar.Top = (int)(songSheetList1.Value * (songSheetList1.Height - scorllbar.Height)) + songSheetList1.Top;
            }
            else
            {
                scorllbar.Hide();
            }
        }
    }
}
