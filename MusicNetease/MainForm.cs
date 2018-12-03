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
        }
    }
}
