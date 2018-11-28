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
    public partial class RadiusControl : UserControl
    {
        public RadiusControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 圆角度数
        /// </summary>
        public int Radius
        {
            get { return layeredButton1.Radius; }
            set
            {
                layeredButton1.Radius = value;
            }
        }
        /// <summary>
        /// 背景颜色设置
        /// </summary>
        public Color SetBackColor
        {
            get { return layeredButton1.BaseColor; }
            set
            {
                layeredButton1.BaseColor = value;
            }
        }
    }
}
