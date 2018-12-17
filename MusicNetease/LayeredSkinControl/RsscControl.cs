using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayeredSkin;

namespace MusicNetease.LayeredSkinControl
{
    /// <summary>
    /// 类    名: RsscControl.cs
    /// CLR 版本: 4.0.30319.42000
    /// 作    者: sunkejava 
    /// 邮    箱：declineaberdeen@foxmail.com
    /// 创建时间: 2018/12/17 15:52:10
    /// 说    明：
    /// </summary>
    public class RsscControl:LayeredSkin.DirectUI.DuiBaseControl
    {
        RecommendSongSheetControl rsc = new RecommendSongSheetControl();
        public RsscControl()
        {
            rsc.Size = new System.Drawing.Size(this.Width, 400);
            rsc.Ulmul = true;
            rsc.EnabledMouseWheel = true;
            rsc.ItemSize = new System.Drawing.Size(150, 175);
        }
        public void setSize(int width,int height)
        {
            this.Width = width;
            this.Height = height;
        }
        public bool addRecommendSongSheet(Entity.SongSheetEntity se)
        {
            rsc.addRecommendSongSheet(se);
            //rsc.RefreshList();
            //GC.Collect();
            return true;
        }
    }
}
