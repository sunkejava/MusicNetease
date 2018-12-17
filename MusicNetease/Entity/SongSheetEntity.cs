using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicNetease.Entity
{
    /// <summary>
    /// 类    名: SongSheetEntity.cs
    /// CLR 版本: 4.0.30319.42000
    /// 作    者: sunkejava 
    /// 邮    箱：declineaberdeen@foxmail.com
    /// 创建时间: 2018/12/13 14:27:45
    /// 说    明：歌单类
    /// </summary>
    public class SongSheetEntity
    {
        private string id;
        private string name;
        private string explain;
        private string backImg;
        private string count;
        private string creater;
        public SongSheetEntity() { }
        public SongSheetEntity(string _id, string _name, string _explain, string _backImg, string _count, string _creater)
        {
            id = _id;
            name = _name;
            explain = _explain;
            backImg = _backImg;
            count = _count;
            creater = _creater;

        }
        /// <summary>
        /// 歌单ID
        /// </summary>
        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        /// <summary>
        /// 歌单名称
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        /// <summary>
        /// 歌单说明
        /// </summary>
        public string Explain
        {
            get
            {
                return explain;
            }

            set
            {
                explain = value;
            }
        }
        /// <summary>
        /// 歌单背景图片
        /// </summary>
        public string BackImg
        {
            get
            {
                return backImg;
            }

            set
            {
                backImg = value;
            }
        }
        /// <summary>
        /// 歌单播放量
        /// </summary>
        public string Count
        {
            get
            {
                return count;
            }

            set
            {
                count = value;
            }
        }
        /// <summary>
        /// 创建人
        /// </summary>
        public string Creater
        {
            get
            {
                return creater;
            }

            set
            {
                creater = value;
            }
        }
    }
}
