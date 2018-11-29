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
        [Description("圆角度数"), Category("自定义属性")]
        public int Radius
        {
            get { return layeredButton1.Radius; }
            set
            {
                layeredButton1.Radius = value;
            }
        }
        [Description("背景颜色设置"), Category("自定义属性")]
        public Color SetBackColor
        {
            get { return layeredButton1.BaseColor; }
            set
            {
                layeredButton1.BaseColor = value;
            }
        }

        [Description("是否显示边框"), Category("自定义属性")]
        public bool IsShowBorder
        {
            get { return layeredButton1.ShowBorder; }
            set { layeredButton1.ShowBorder = value; }
        }
    }
}
