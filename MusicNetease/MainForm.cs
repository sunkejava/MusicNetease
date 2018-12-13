using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LayeredSkin.DirectUI;

namespace MusicNetease
{
    public partial class MainForm : MusicNetease.BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.skinTabControl_Main.SendToBack();
            Entity.MenuEntity tjMenu = new Entity.MenuEntity();
            tjMenu.MenuName = "推荐";
            tjMenu.MenuText = "tjlb";
            tjMenu.Icon = null;
            tjMenu.HoverIcon = null;
            tjMenu.IsEndLevel = true;
            tjMenu.IsTopLevel = true;
            songSheetList1.AddMenun(tjMenu);
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

            Entity.MenuEntity myMusicMenu = new Entity.MenuEntity();
            myMusicMenu.MenuName = "我的音乐";
            myMusicMenu.MenuText = "wdyylb";
            myMusicMenu.Icon = null;
            myMusicMenu.HoverIcon = null;
            myMusicMenu.IsEndLevel = true;
            myMusicMenu.IsTopLevel = true;
            songSheetList1.AddMenun(myMusicMenu);
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

            
            Entity.MenuEntity createdSongListMenu = new Entity.MenuEntity();
            createdSongListMenu.MenuName = "创建的歌单";
            createdSongListMenu.MenuText = "createdsongListlb";
            createdSongListMenu.Icon = Properties.Resources.add0;
            createdSongListMenu.HoverIcon = Properties.Resources.add1;
            createdSongListMenu.IsEndLevel = false;
            createdSongListMenu.IsTopLevel = true;
            songSheetList1.AddMenun(createdSongListMenu);
            Entity.MenuEntity iLikeMusicMenu = new Entity.MenuEntity();
            iLikeMusicMenu.MenuName = "我喜欢的音乐";
            iLikeMusicMenu.MenuText = "createdsongListlb_ilike";
            iLikeMusicMenu.Icon = Properties.Resources.ilike0;
            iLikeMusicMenu.HoverIcon = Properties.Resources.ilike1;
            iLikeMusicMenu.IsEndLevel = true;
            songSheetList1.AddMenun(iLikeMusicMenu);

            Entity.MenuEntity collectionSongListMenu = new Entity.MenuEntity();
            collectionSongListMenu.MenuName = "收藏的歌单";
            collectionSongListMenu.MenuText = "collectionSongListlb";
            collectionSongListMenu.Icon = Properties.Resources.add0;
            collectionSongListMenu.HoverIcon = Properties.Resources.add1;
            collectionSongListMenu.IsEndLevel = false;
            collectionSongListMenu.IsTopLevel = true;
            songSheetList1.AddMenun(collectionSongListMenu);

            String[] menuStrings = new String[] { "WCTF 2018", "口哨系｜学会就可以撩妹了ΘˍΘ", "『开口脆』迷幻嗓音极致瞬间❤️", "华语百首 | 回忆伤人无声，唱不尽世间遗憾",
            "90后的回忆杀 - 『持续更新』", "床前的催眠曲 - 八音盒系列", "【夜跑】把你的脚印留在城市的每一个角落。", "华语励志 | 吹灭读书灯，一身都是月", "Thug Life系列背景音乐", "天气渐凉，才觉一年将尽。", "加速燃脂，健身运动BGM" };
            int i = 0;
            foreach (var item in menuStrings)
            {
                Entity.MenuEntity MyMusicListMenu = new Entity.MenuEntity();
                MyMusicListMenu.MenuName = item;
                MyMusicListMenu.MenuText = "collectionSongListlb" + (i + 1).ToString();
                MyMusicListMenu.Icon = Properties.Resources.bflb0;
                MyMusicListMenu.HoverIcon = Properties.Resources.bflb1;
                MyMusicListMenu.IsEndLevel = true;
                songSheetList1.AddMenun(MyMusicListMenu);
                i++;
            }



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
        /// <summary>
        /// 委托单机事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void songSheetList1_MenuNameMouseDown(object sender, EventArgs e)
        {
            if (sender is DuiButton || sender is DuiLabel)
            {
                DuiBaseControl db = sender as DuiBaseControl;
                switch (db.Tag.ToString())
                {
                    case "srfm":
                        skinTabControl_Main.SelectedTab = skinTabPage_srfm;
                        break;
                    case "fxyy":
                        skinTabControl_Main.SelectedTab = skinTabPage_fxyy;
                        break;
                    case "tv":
                        skinTabControl_Main.SelectedTab = skinTabPage_tv;
                        break;
                    case "friend":
                        skinTabControl_Main.SelectedTab = skinTabPage_friend;
                        break;
                    case "bdyy":
                        skinTabControl_Main.SelectedTab = skinTabPage_bdyy;
                        break;
                    case "xzgl":
                        skinTabControl_Main.SelectedTab = skinTabPage_xzgl;
                        break;
                    case "yun":
                        skinTabControl_Main.SelectedTab = skinTabPage_yun;
                        break;
                    case "wddt":
                        skinTabControl_Main.SelectedTab = skinTabPage_wddt;
                        break;
                    case "wdsc":
                        skinTabControl_Main.SelectedTab = skinTabPage_wdsc;
                        break;
                    default:
                        skinTabControl_Main.SelectedTab = skinTabPage_gd;
                        break;
                }
            }
        }
    }
}
