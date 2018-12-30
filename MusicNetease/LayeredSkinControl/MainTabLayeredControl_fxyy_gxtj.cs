using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayeredSkin;
using LayeredSkin.DirectUI;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace MusicNetease.LayeredSkinControl
{
    /// <summary>
    /// 类    名: MainTabLayeredControl_fxyy_gxtj.cs
    /// CLR 版本: 4.0.30319.42000
    /// 作    者: sunkejava 
    /// 邮    箱：declineaberdeen@foxmail.com
    /// 创建时间: 2018/12/17 15:21:34
    /// 说    明：
    /// </summary>
    public class MainTabLayeredControl_fxyy_gxtj: LayeredSkin.Controls.LayeredListBox
    {
        public MainTabLayeredControl_fxyy_gxtj()
        {
            
        }

        public new void RefreshList()
        {
            if (RefreshListed != null)
                RefreshListed(this, new EventArgs());
            base.RefreshList();
        }

        public bool addneedControl()
        {
            String[] ImgsString = new String[]{ "http://p1.music.126.net/utGm9BU68THpwEUPe0ecYQ==/109951163702692244.jpg",
                                         "http://p1.music.126.net/MxnT6B0uFfOIqmUET0Hkyg==/109951163706538300.jpg",
                                         "http://p1.music.126.net/uvBie7e5Ozxd9zXaIzl4kQ==/109951163707092059.jpg",
                                         "http://p1.music.126.net/aHr6k_A6lRdhvjZw4dZcoQ==/109951163706085420.jpg",
                                         "http://p1.music.126.net/Dk0_tclnpP2og2R0tTIHmQ==/109951163707089759.jpg",
                                         "http://p1.music.126.net/6VnvL-JGcie9lMMtQXYlrg==/109951163707206569.jpg",
                                         "http://p1.music.126.net/Vhs30rVOFjYEf5H5tQmsQg==/109951163703653548.jpg",
                                         "http://p1.music.126.net/eNUJlf-kLWdny2ZjXG-TuA==/109951163702694238.jpg" };
            string[] names = new string[] { "1", "2", "3", "4", "5", "6", "7", "8" };
            string[] ids = new string[] { "1", "2", "3", "4", "5", "6", "7", "8" };
            string[] IconsString = new string[] { "1", "2", "3", "4", "5", "6", "7", "8" };
            Entity.SwitcherImageEntity switcherImgs = new Entity.SwitcherImageEntity(ids, names, ImgsString, IconsString);
            SwitcherControl sw = new SwitcherControl();
            sw.setSize(850, 350);
            sw.Location = new Point(0, 0);
            sw.addSwitchImage(switcherImgs);
            Items.Add(sw);
            //RsscControl rsc = new RsscControl();
            //rsc.Location = new Point(0,350);
            //rsc.setSize(850, 600);
            //rsc.addRecommendSongSheet(new Entity.SongSheetEntity("tj", "每日歌曲推荐", "根据您的音乐口味生成每日更新", Properties.Resources.melog, "", ""));
            //rsc.addRecommendSongSheet(new Entity.SongSheetEntity("2522866436", "又到了起床靠爆发力的日子了", "编辑推荐：我没有赖床，我不起床是有理由的！", GetImageByUrl("http://p3.music.126.net/XIFMgvpqDqY4AO94MQBijQ==/109951163679316040.jpg?param=200y200"), "202万", ""));
            //rsc.addRecommendSongSheet(new Entity.SongSheetEntity("2514650991", "《你再不来，我要下雪了》", "编辑推荐：我是一个在黑暗中大雪纷飞的人啊", GetImageByUrl("http://p4.music.126.net/s6u3onN_JbFSikekDaHVmQ==/109951163722383797.jpg?param=200y200"), "44万", ""));
            //rsc.addRecommendSongSheet(new Entity.SongSheetEntity("1993039994", "90后回忆杀[持续更新中...]", "根据你喜欢的单曲《Go go yellow screen》推荐", GetImageByUrl("http://p4.music.126.net/2sBMF9-bT5rifngVyDKAFQ==/109951163102165084.jpg?param=200y200"), "247万", ""));
            //rsc.addRecommendSongSheet(new Entity.SongSheetEntity("2226375840", "90后流行歌曲", "根据你喜欢的单曲《Go go yellow screen》推荐", GetImageByUrl("http://p4.music.126.net/oAIdonRUGMSewYu4lYVwHQ==/109951163240609542.jpg?param=200y200"), "148万", ""));
            //rsc.addRecommendSongSheet(new Entity.SongSheetEntity("988690134", "经典老歌，久听不厌", "根据你喜欢的单曲《爱我就跟我走》推荐", GetImageByUrl("http://p3.music.126.net/VFd5cboNTbnYsWZ5DBn9bg==/18953381440004340.jpg?param=200y200"), "3314万", ""));
            //rsc.addRecommendSongSheet(new Entity.SongSheetEntity("2145434166", "「嗨爆」在宿舍御用的蹦迪歌曲", "根据你收藏的歌单《『开口脆』迷幻嗓音极致瞬间❤️》推荐", GetImageByUrl("http://p3.music.126.net/wMj_-xqpKxSjtBhAlSu7wQ==/19190875951790510.jpg?param=200y200"), "1815万", ""));
            //rsc.addRecommendSongSheet(new Entity.SongSheetEntity("10498213", "跑步！ 适合10km/h左右的节奏", "根据你收藏的歌单《【夜跑】把你的脚印留在城市的每一个角落。》推荐", GetImageByUrl("http://p3.music.126.net/0ld5m8w0S8KpJOXDDEwG3Q==/6038517859923212.jpg?param=200y200"), "35万", ""));
            //rsc.addRecommendSongSheet(new Entity.SongSheetEntity("2134203011", "一百首‖让你瞬间勾起回忆的老歌", "根据你收藏的歌单《情歌还是老的好》推荐", GetImageByUrl("http://p4.music.126.net/pAidnPdX-0fhVakVXiHMzg==/18575149441852040.jpg?param=200y200"), "695万", ""));
            //rsc.addRecommendSongSheet(new Entity.SongSheetEntity("1980964492", "『修仙』 玩游戏/晨跑'必备BGM/耳机福利Δ", "根据你喜欢的单曲《Life》推荐", GetImageByUrl("http://p4.music.126.net/li9392RV26M4XZvDTr0dNg==/109951163145944715.jpg?param=200y200"), "670万", ""));
            //Items.Add(rsc);
            RefreshList();
            //GC.Collect();
            return true;
        }
        /// <summary>
        /// 刷新列表事件
        /// </summary>
        [Description("列表刷新事件"), Category("自定义事件")]
        public event EventHandler RefreshListed;


        private Image GetImageByUrl(string url)
        {
            return Image.FromStream(System.Net.WebRequest.Create(url).GetResponse().GetResponseStream());
        }

    }
}
