using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;

namespace MusicNetease.Utils
{
    /// <summary>
    /// 类    名: PaintDraw.cs
    /// CLR 版本: 4.0.30319.42000
    /// 作    者: sunkejava 
    /// 邮    箱：declineaberdeen@foxmail.com
    /// 创建时间: 2018/11/23 12:51:11
    /// 说    明：重新绘制控件的方法
    /// </summary>
    public class PaintDraw
    {
        /// <summary>
        /// 画圆角及尖角
        /// </summary>
        /// <param name="rectangle">控件位置</param>
        /// <param name="g">绘制的图形</param>
        /// <param name="_radius">圆角的度数</param>
        /// <param name="cusp">是否画尖角</param>
        /// <param name="begin_color">渐变色的起始色</param>
        /// <param name="end_color">渐变色的结束色</param>
        public static void Draw(Rectangle rectangle, Graphics g, int _radius, bool cusp, Color begin_color, Color end_color)
        {
            int span = 2;
            //抗锯齿
            g.SmoothingMode = SmoothingMode.AntiAlias;
            //渐变填充
            LinearGradientBrush myLinearGradientBrush = new LinearGradientBrush(rectangle, begin_color, end_color, LinearGradientMode.Vertical);
            //画尖角
            if (cusp)
            {
                span = 10;
                PointF p1 = new PointF(rectangle.Width - 12, rectangle.Y + 10);
                PointF p2 = new PointF(rectangle.Width - 12, rectangle.Y + 30);
                PointF p3 = new PointF(rectangle.Width, rectangle.Y + 20);
                PointF[] ptsArray = { p1, p2, p3 };
                g.FillPolygon(myLinearGradientBrush, ptsArray);
            }
            //填充
            g.FillPath(myLinearGradientBrush, DrawRoundRect(rectangle.X, rectangle.Y, rectangle.Width - span, rectangle.Height - 1, _radius));
        }

        private static GraphicsPath DrawRoundRect(int x, int y, int width, int height, int radius)
        {
            //四边圆角
            GraphicsPath gp = new GraphicsPath();

            //顶端 
            gp.AddLine(x + radius - 1, y - 1, width - radius, y - 1);
            //右上角 
            gp.AddArc(width - radius, y - 1, radius, radius, 270, 90);
            //右边 
            gp.AddLine(width, y + radius, width, height - radius);
            //右下角

            gp.AddArc(width - radius, height - radius, radius, radius, 0, 90);
            //底边 
            gp.AddLine(width - radius, height, x + radius, height);
            //左下角 
            gp.AddArc(x - 1, height - radius, radius, radius, 90, 90);
            //左边 
            gp.AddLine(x - 1, y + radius, x - 1, height - radius);
            //左上角 
            gp.AddArc(x - 1, y - 1, radius, radius, 180, 90);
            ////左上角
            //gp.AddArc(x, y, radius, radius, 180, 90);
            ////右上角
            //gp.AddArc(width - radius, y, radius, radius, 270, 90);
            ////右下角
            //gp.AddArc(width - radius, height - radius, radius, radius, 0, 90);
            ////左下角
            //gp.AddArc(x, height - radius, radius, radius, 90, 90);
            //gp.CloseAllFigures();
            return gp;
        }

    }
}
