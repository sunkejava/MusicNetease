using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicNetease.Entity
{
    /// <summary>
    /// 类    名: SwitcherImage.cs
    /// CLR 版本: 4.0.30319.42000
    /// 作    者: sunkejava 
    /// 邮    箱：declineaberdeen@foxmail.com
    /// 创建时间: 2018/12/17 10:36:27
    /// 说    明：滚动图实体
    /// </summary>
    public class SwitcherImageEntity
    {
        private string[] ids;
        private string[] names;
        private string[] imgs;
        private string[] ficons;
        public SwitcherImageEntity() { }
        public SwitcherImageEntity(string[] idsv,string[] namesv,string[] imgsv,string[] ficonsv) {
            ids = idsv;
            names = namesv;
            imgs = imgsv;
            ficons = ficonsv;
        }
        /// <summary>
        /// 歌曲或歌单ID集合
        /// </summary>
        public string[] Ids
        {
            get
            {
                return ids;
            }

            set
            {
                ids = value;
            }
        }
        /// <summary>
        /// 歌曲或歌单名称集合
        /// </summary>
        public string[] Names
        {
            get
            {
                return names;
            }

            set
            {
                names = value;
            }
        }
        /// <summary>
        /// 歌曲或歌单图片集合
        /// </summary>
        public string[] Imgs
        {
            get
            {
                return imgs;
            }

            set
            {
                imgs = value;
            }
        }
        /// <summary>
        /// 歌曲或歌单图标
        /// </summary>
        public string[] Ficons
        {
            get
            {
                return ficons;
            }

            set
            {
                ficons = value;
            }
        }
    }
}
