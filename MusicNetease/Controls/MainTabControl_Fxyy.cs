using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin.SkinControl;
using LayeredSkin.DirectUI;

namespace MusicNetease.Controls
{
    public partial class MainTabControl_Fxyy : UserControl
    {
        String[] ImgsString = new String[]{ "http://p1.music.126.net/utGm9BU68THpwEUPe0ecYQ==/109951163702692244.jpg",
                                         "http://p1.music.126.net/MxnT6B0uFfOIqmUET0Hkyg==/109951163706538300.jpg",
                                         "http://p1.music.126.net/uvBie7e5Ozxd9zXaIzl4kQ==/109951163707092059.jpg",
                                         "http://p1.music.126.net/aHr6k_A6lRdhvjZw4dZcoQ==/109951163706085420.jpg",
                                         "http://p1.music.126.net/Dk0_tclnpP2og2R0tTIHmQ==/109951163707089759.jpg",
                                         "http://p1.music.126.net/6VnvL-JGcie9lMMtQXYlrg==/109951163707206569.jpg",
                                         "http://p1.music.126.net/Vhs30rVOFjYEf5H5tQmsQg==/109951163703653548.jpg",
                                         "http://p1.music.126.net/eNUJlf-kLWdny2ZjXG-TuA==/109951163702694238.jpg" };
        string[] names = new string[] { "1","2","3","4","5","6","7","8"};
        string[] ids = new string[] { "1", "2", "3", "4", "5", "6", "7", "8" };
        string[] IconsString = new string[] { "1", "2", "3", "4", "5", "6", "7", "8" };
        private bool scorlling = false;
        private int mousetop = 0;
        public MainTabControl_Fxyy()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 首次加载需要初始赋值的信息
        /// </summary>
        private void userControlLoad()
        {
            #region 发现音乐----个性推荐
            skinLabel_tag_Update();
            skinLabel_gxtj.Tag = true;
            skinLabel_gxtj.ForeColor = Color.FromArgb(255, 92, 138);
            int lwidth = 0;
            scorllbar.BackColor = Color.FromArgb(100, 205, 205, 205);
            if (this.Width > 1020)
            {
                lwidth = (this.Width - 1040) / 2;
            }
            else
            {
                lwidth = 30;
            }
            //recommendSongSheetControl1.Location = new Point(lwidth, recommendSongSheetControl1.Location.Y);
            //recommendSongSheetControl1.Size = new Size(Width, 350);
            recommendSongSheetControl1.ItemSize = new Size(791, 520);
            Entity.SwitcherImageEntity switcherImgs = new Entity.SwitcherImageEntity(ids,names,ImgsString,IconsString);
            recommendSongSheetControl1.addSwitchImage(switcherImgs);
            recommendSongSheetControl1.addRecommendSongTitle(new Entity.SongSheetTitle("推荐歌单","12306"));
            recommendSongSheetControl1.ItemSize = new Size(150, 175);
            recommendSongSheetControl1.addRecommendSongSheet(new Entity.SongSheetEntity("tj", "每日歌曲推荐", "根据您的音乐口味生成每日更新", "", "", ""));
            recommendSongSheetControl1.addRecommendSongSheet(new Entity.SongSheetEntity("2522866436", "又到了起床靠爆发力的日子了", "编辑推荐：我没有赖床，我不起床是有理由的！", "http://p3.music.126.net/XIFMgvpqDqY4AO94MQBijQ==/109951163679316040.jpg?param=200y200", "202万", ""));
            recommendSongSheetControl1.addRecommendSongSheet(new Entity.SongSheetEntity("2514650991", "《你再不来，我要下雪了》", "编辑推荐：我是一个在黑暗中大雪纷飞的人啊", "http://p4.music.126.net/s6u3onN_JbFSikekDaHVmQ==/109951163722383797.jpg?param=200y200", "44万", ""));
            recommendSongSheetControl1.addRecommendSongSheet(new Entity.SongSheetEntity("1993039994", "90后回忆杀[持续更新中...]", "根据你喜欢的单曲《Go go yellow screen》推荐", "http://p4.music.126.net/2sBMF9-bT5rifngVyDKAFQ==/109951163102165084.jpg?param=200y200", "247万", ""));
            recommendSongSheetControl1.addRecommendSongSheet(new Entity.SongSheetEntity("2226375840", "90后流行歌曲", "根据你喜欢的单曲《Go go yellow screen》推荐", "http://p4.music.126.net/oAIdonRUGMSewYu4lYVwHQ==/109951163240609542.jpg?param=200y200", "148万", ""));
            recommendSongSheetControl1.addRecommendSongSheet(new Entity.SongSheetEntity("988690134", "经典老歌，久听不厌", "根据你喜欢的单曲《爱我就跟我走》推荐", "http://p3.music.126.net/VFd5cboNTbnYsWZ5DBn9bg==/18953381440004340.jpg?param=200y200", "3314万", ""));
            recommendSongSheetControl1.addRecommendSongSheet(new Entity.SongSheetEntity("2145434166", "「嗨爆」在宿舍御用的蹦迪歌曲", "根据你收藏的歌单《『开口脆』迷幻嗓音极致瞬间❤️》推荐", "http://p3.music.126.net/wMj_-xqpKxSjtBhAlSu7wQ==/19190875951790510.jpg?param=200y200", "1815万", ""));
            recommendSongSheetControl1.addRecommendSongSheet(new Entity.SongSheetEntity("10498213", "跑步！ 适合10km/h左右的节奏", "根据你收藏的歌单《【夜跑】把你的脚印留在城市的每一个角落。》推荐", "http://p3.music.126.net/0ld5m8w0S8KpJOXDDEwG3Q==/6038517859923212.jpg?param=200y200", "35万", ""));
            recommendSongSheetControl1.addRecommendSongSheet(new Entity.SongSheetEntity("2134203011", "一百首‖让你瞬间勾起回忆的老歌", "根据你收藏的歌单《情歌还是老的好》推荐", "http://p4.music.126.net/pAidnPdX-0fhVakVXiHMzg==/18575149441852040.jpg?param=200y200", "695万", ""));
            recommendSongSheetControl1.addRecommendSongSheet(new Entity.SongSheetEntity("1980964492", "『修仙』 玩游戏/晨跑'必备BGM/耳机福利Δ", "根据你喜欢的单曲《Life》推荐", "http://p4.music.126.net/li9392RV26M4XZvDTr0dNg==/109951163145944715.jpg?param=200y200", "670万", ""));
            #endregion

        }
        /// <summary>
        /// 设置控件大小
        /// </summary>
        [Description("设置控件大小"), Category("自定义属性")]
        public int SetSize
        {
            get { return layeredPanel_gxtj.Width; }
            set { layeredPanel_gxtj.Width = value; }
        }

        /// <summary>
        /// 在选择夹获取焦点后自动变色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinLabel_gxtj_MouseEnter(object sender, EventArgs e)
        {
            CCWin.SkinControl.SkinLabel skLabel = sender as CCWin.SkinControl.SkinLabel;
            skLabel.ForeColor = Color.FromArgb(255, 92, 138);
        }
        /// <summary>
        ///  在选择夹失去焦点后自动变色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinLabel_gq_MouseLeave(object sender, EventArgs e)
        {
            
            CCWin.SkinControl.SkinLabel skLabel = sender as CCWin.SkinControl.SkinLabel;
            if (!(bool)skLabel.Tag)
            {
                skLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            }
        }
        /// <summary>
        /// 在选择夹上单机鼠标后的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinLabel_gxtj_MouseDown(object sender, MouseEventArgs e)
        {
            skinLabel_tag_Update();
            CCWin.SkinControl.SkinLabel skLabel = sender as CCWin.SkinControl.SkinLabel;
            skLabel.ForeColor = Color.FromArgb(255, 92, 138);
            skinLine_xz.Width = skLabel.Width - 8;
            skinLine_xz.Location = new Point(skLabel.Location.X,skinLine_xz.Location.Y);
            skLabel.Tag = true;//用tag属性表示是否选中该标签。
            switch (skLabel.Name)
            {
                case "skinLabel_gxtj":
                    skinTabControl1.SelectedIndex = 0;
                    break;
                case "skinLabel_gq":
                    skinTabControl1.SelectedIndex = 1;
                    break;
                case "skinLabel_zbdt":
                    skinTabControl1.SelectedIndex = 2;
                    break;
                case "skinLabel_phb":
                    skinTabControl1.SelectedIndex = 3;
                    break;
                case "skinLabel_gs":
                    skinTabControl1.SelectedIndex = 4;
                    break;
                case "skinLabel_zxyy":
                    skinTabControl1.SelectedIndex = 5;
                    break;
                default:
                    break;
            }

        }
        /// <summary>
        /// 更新所有选择夹为初始颜色并非选择状态
        /// </summary>
        private void skinLabel_tag_Update()
        {
            skinLabel_gxtj.Tag = false;
            skinLabel_gq.Tag = false;
            skinLabel_zbdt.Tag = false;
            skinLabel_phb.Tag = false;
            skinLabel_gs.Tag = false;
            skinLabel_zxyy.Tag = false;
            skinLabel_gxtj.ForeColor = System.Drawing.SystemColors.ControlText;
            skinLabel_gq.ForeColor = System.Drawing.SystemColors.ControlText;
            skinLabel_zbdt.ForeColor = System.Drawing.SystemColors.ControlText;
            skinLabel_phb.ForeColor = System.Drawing.SystemColors.ControlText;
            skinLabel_gs.ForeColor = System.Drawing.SystemColors.ControlText;
            skinLabel_zxyy.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void DoAnimation()
        {
            //等到所有的动画将完成
            animator.WaitAllAnimations();
            animator.DefaultAnimation = Animation.ScaleAndHorizSlide;
            //animator.Show(PictureBox_Main.Controls);
        }

        private void MainTabControl_Fxyy_Load(object sender, EventArgs e)
        {
            userControlLoad();
        }
        private void recommendSongSheetControl1_RecommendSongSheetMouseDown(object sender, EventArgs e)
        {

        }

        private void recommendSongSheetControl1_RefreshListed(object sender, EventArgs e)
        {
            int allheight = 0;
            for (int i = 0; i < recommendSongSheetControl1.Items.Count; i++)
            {
                if (recommendSongSheetControl1.Items[i].Visible)
                    allheight = allheight + recommendSongSheetControl1.Items[i].Height;
            }
            double pre = (double)recommendSongSheetControl1.Height / (double)allheight;
            if (pre < 1)
            {
                if (recommendSongSheetControl1.Visible)
                    scorllbar.Show();

                scorllbar.Height = (int)(pre * (double)recommendSongSheetControl1.Height);
                scorllbar.Top = (int)(recommendSongSheetControl1.Value * (recommendSongSheetControl1.Height - scorllbar.Height)) + recommendSongSheetControl1.Top;
            }
            else
            {
                scorllbar.Hide();
            }
        }

        private void scorllbar_Move(object sender, EventArgs e)
        {
            if (scorlling)
            {
                recommendSongSheetControl1.Value = (double)(scorllbar.Top - recommendSongSheetControl1.Top) / (double)(recommendSongSheetControl1.Height - scorllbar.Height);
            }   
        }

        private void scorllbar_MouseDown(object sender, MouseEventArgs e)
        {
            mousetop = scorllbar.PointToClient(MousePosition).Y;
            scorlling = true;
            scorllbar.BackColor = Color.FromArgb(80, 55, 55, 55);
        }

        private void scorllbar_MouseEnter(object sender, EventArgs e)
        {
            if (scorllbar.Top < recommendSongSheetControl1.Top)
                scorllbar.Top = recommendSongSheetControl1.Top + 2;
            if (scorllbar.Top > (recommendSongSheetControl1.Top + recommendSongSheetControl1.Height - scorllbar.Height))
                scorllbar.Top = (recommendSongSheetControl1.Top + recommendSongSheetControl1.Height - scorllbar.Height);
            scorllbar.BackColor = Color.FromArgb(100, 55, 55, 55);
        }

        private void scorllbar_MouseLeave(object sender, EventArgs e)
        {
            scorllbar.BackColor = Color.FromArgb(100, 205, 205, 205);
        }

        private void scorllbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (scorlling)
            {
                if (scorllbar.Top >= recommendSongSheetControl1.Top && scorllbar.Top <= (recommendSongSheetControl1.Top + recommendSongSheetControl1.Height - scorllbar.Height))
                    scorllbar.Top = PointToClient(MousePosition).Y - mousetop;
            }
        }

        private void scorllbar_MouseUp(object sender, MouseEventArgs e)
        {
            mousetop = e.Y; scorlling = false;
            scorllbar.BackColor = Color.FromArgb(100, 205, 205, 205);
        }
    }
}
