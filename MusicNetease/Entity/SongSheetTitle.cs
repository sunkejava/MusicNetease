using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicNetease.Entity
{
    /// <summary>
    /// 类    名: SongSheetTitle.cs
    /// CLR 版本: 4.0.30319.42000
    /// 作    者: sunkejava 
    /// 邮    箱：declineaberdeen@foxmail.com
    /// 创建时间: 2018/12/18 10:50:05
    /// 说    明：歌单标题抬头---个性推荐中的标头
    /// </summary>
    public class SongSheetTitle
    {
        public SongSheetTitle(string _name,string _url)
        {
            name = _name;
            url = _url;
        }
        private string name;
        private string url;
        /// <summary>
        /// 名称
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
        /// 地址或ID
        /// </summary>
        public string Url
        {
            get
            {
                return url;
            }

            set
            {
                url = value;
            }
        }
    }
}
