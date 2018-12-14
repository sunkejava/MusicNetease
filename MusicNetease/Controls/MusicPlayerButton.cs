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
    public partial class MusicPlayerButton : UserControl
    {
        public MusicPlayerButton()
        {
            InitializeComponent();
        }

        private void skinButton_MouseEnter(object sender, EventArgs e)
        {
            if (sender is CCWin.SkinControl.SkinLabel)
            {
                CCWin.SkinControl.SkinLabel btn = sender as CCWin.SkinControl.SkinLabel;
                skinToolTip1.ShowAlways = true;
                skinToolTip1.SetToolTip(btn, btn.Tag.ToString());
            }
            if (sender is CCWin.SkinControl.SkinButton)
            {
                CCWin.SkinControl.SkinButton btn = sender as CCWin.SkinControl.SkinButton;
                skinToolTip1.ShowAlways = true;
                skinToolTip1.SetToolTip(btn, btn.Tag.ToString());
            }
            
        }

        private void skinButton_volume_Click(object sender, EventArgs e)
        {
            CCWin.SkinControl.SkinButton btn = sender as CCWin.SkinControl.SkinButton;
            if (btn.Tag.ToString() == "静音")
            {
                btn.Tag = "恢复音量";
                btn.BackgroundImage = global::MusicNetease.Properties.Resources.novolume0;
                btn.NormlBack = global::MusicNetease.Properties.Resources.novolume0;
                btn.MouseBack = global::MusicNetease.Properties.Resources.novolume1;
                btn.DownBack = global::MusicNetease.Properties.Resources.novolume1;
            }
            else
            {
                btn.Tag = "静音";
                btn.BackgroundImage = global::MusicNetease.Properties.Resources.volume0;
                btn.NormlBack = global::MusicNetease.Properties.Resources.volume0;
                btn.MouseBack = global::MusicNetease.Properties.Resources.volume1;
                btn.DownBack = global::MusicNetease.Properties.Resources.volume1;
            }
        }

        private void skinButton_bfsx_Click(object sender, EventArgs e)
        {
            CCWin.SkinControl.SkinButton btn = sender as CCWin.SkinControl.SkinButton;
            switch (btn.Tag.ToString())
            {
                case "顺序播放":
                    btn.Tag = "列表循环";
                    btn.BackgroundImage = global::MusicNetease.Properties.Resources.lbxh0;
                    btn.NormlBack = global::MusicNetease.Properties.Resources.lbxh0;
                    btn.MouseBack = global::MusicNetease.Properties.Resources.lbxh1;
                    btn.DownBack = global::MusicNetease.Properties.Resources.lbxh1;
                    break;
                case "列表循环":
                    btn.Tag = "单曲循环";
                    btn.BackgroundImage = global::MusicNetease.Properties.Resources.dqxh0;
                    btn.NormlBack = global::MusicNetease.Properties.Resources.dqxh0;
                    btn.MouseBack = global::MusicNetease.Properties.Resources.dqxh1;
                    btn.DownBack = global::MusicNetease.Properties.Resources.dqxh1;
                    break;
                case "单曲循环":
                    btn.Tag = "随机播放";
                    btn.BackgroundImage = global::MusicNetease.Properties.Resources.sjbf0;
                    btn.NormlBack = global::MusicNetease.Properties.Resources.sjbf0;
                    btn.MouseBack = global::MusicNetease.Properties.Resources.sjbf1;
                    btn.DownBack = global::MusicNetease.Properties.Resources.sjbf1;
                    break;
                case "随机播放":
                    btn.Tag = "顺序播放";
                    btn.BackgroundImage = global::MusicNetease.Properties.Resources.sxbf0;
                    btn.NormlBack = global::MusicNetease.Properties.Resources.sxbf0;
                    btn.MouseBack = global::MusicNetease.Properties.Resources.sxbf1;
                    btn.DownBack = global::MusicNetease.Properties.Resources.sxbf1;
                    break;
                default:
                    break;
            }
        }

        private void skinButton_Lyric_Click(object sender, EventArgs e)
        {
            CCWin.SkinControl.SkinButton btn = sender as CCWin.SkinControl.SkinButton;
            if (btn.Tag.ToString() == "打开歌词")
            {
                btn.Tag = "关闭歌词";
                btn.BackgroundImage = global::MusicNetease.Properties.Resources.music_lyrics0;
                btn.NormlBack = global::MusicNetease.Properties.Resources.music_lyrics0;
                btn.MouseBack = global::MusicNetease.Properties.Resources.music_lyrics1;
                btn.DownBack = global::MusicNetease.Properties.Resources.music_lyrics1;
            }
            else
            {
                btn.Tag = "打开歌词";
                btn.BackgroundImage = global::MusicNetease.Properties.Resources.lyric0;
                btn.NormlBack = global::MusicNetease.Properties.Resources.lyric0;
                btn.MouseBack = global::MusicNetease.Properties.Resources.lyric1;
                btn.DownBack = global::MusicNetease.Properties.Resources.lyric1;
            }
        }

        private void skinButton_bfsx_MouseHover(object sender, EventArgs e)
        {
            CCWin.SkinControl.SkinButton btn = sender as CCWin.SkinControl.SkinButton;
            switch (btn.Tag.ToString())
            {
                case "顺序播放":
                    btn.BackgroundImage = global::MusicNetease.Properties.Resources.sxbf1;
                    break;
                case "列表循环":
                    btn.BackgroundImage = global::MusicNetease.Properties.Resources.lbxh1;
                    break;
                case "单曲循环":
                    btn.BackgroundImage = global::MusicNetease.Properties.Resources.dqxh1;
                    break;
                case "随机播放":
                    btn.BackgroundImage = global::MusicNetease.Properties.Resources.sjbf1;
                    break;
                default:
                    break;
            }
        }

        private void skinButton_bfsx_MouseLeave(object sender, EventArgs e)
        {
            CCWin.SkinControl.SkinButton btn = sender as CCWin.SkinControl.SkinButton;
            switch (btn.Tag.ToString())
            {
                case "顺序播放":
                    btn.BackgroundImage = global::MusicNetease.Properties.Resources.sxbf0;
                    break;
                case "列表循环":
                    btn.BackgroundImage = global::MusicNetease.Properties.Resources.lbxh0;
                    break;
                case "单曲循环":
                    btn.BackgroundImage = global::MusicNetease.Properties.Resources.dqxh0;
                    break;
                case "随机播放":
                    btn.BackgroundImage = global::MusicNetease.Properties.Resources.sjbf0;
                    break;
                default:
                    break;
            }
        }

        private void skinButton_Lyric_MouseHover(object sender, EventArgs e)
        {
            CCWin.SkinControl.SkinButton btn = sender as CCWin.SkinControl.SkinButton;
            if (btn.Tag.ToString() == "打开歌词")
            {
                btn.BackgroundImage = global::MusicNetease.Properties.Resources.lyric1;
            }
            else
            {
                btn.BackgroundImage = global::MusicNetease.Properties.Resources.music_lyrics1;
            }
                
        }

        private void skinButton_Lyric_MouseLeave(object sender, EventArgs e)
        {
            CCWin.SkinControl.SkinButton btn = sender as CCWin.SkinControl.SkinButton;
            if (btn.Tag.ToString() == "打开歌词")
            {
                btn.BackgroundImage = global::MusicNetease.Properties.Resources.lyric0;
            }
            else
            {
                btn.BackgroundImage = global::MusicNetease.Properties.Resources.music_lyrics0;
            }
        }

        private void skinButton_openPlayList_MouseHover(object sender, EventArgs e)
        {
            this.skinButton_openPlayList.BackgroundImage = global::MusicNetease.Properties.Resources.playList1;
        }

        private void skinButton_openPlayList_MouseLeave(object sender, EventArgs e)
        {
            this.skinButton_openPlayList.BackgroundImage = global::MusicNetease.Properties.Resources.playList0;
        }

        private void skinButton_openPlayList_Click(object sender, EventArgs e)
        {
            if (sender is CCWin.SkinControl.SkinButton)
            {
                CCWin.SkinControl.SkinButton btn = sender as CCWin.SkinControl.SkinButton;
                if (btn.Tag.ToString() == "打开播放列表")
                {
                    btn.Tag = "关闭播放列表";
                }
                else
                {
                    btn.Tag = "打开播放列表";
                }
            }
            else
            {
                CCWin.SkinControl.SkinLabel btn = sender as CCWin.SkinControl.SkinLabel;
                if (btn.Tag.ToString() == "打开播放列表")
                {
                    btn.Tag = "关闭播放列表";
                }
                else
                {
                    btn.Tag = "打开播放列表";
                }
            }
            
        }

        private void radiusControlButton_play_Click(object sender, EventArgs e)
        {
            RadiusControlButton btn = sender as RadiusControlButton;
            if (btn.Tag.ToString() == "播放")
            {
               btn.IsSelect = true;
                btn.Tag = "暂停";
            }
            else
            {
                btn.IsSelect = false;
                btn.Tag = "播放";
            }
        }
    }
}
