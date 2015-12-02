using System.Drawing;
using System.Drawing.Drawing2D;

namespace WACCTV
{
    public class Overlays
    {
        public static FontFamily FONT_FAMILY = new FontFamily("Tahoma");
        public static Pen PEN = new Pen(Brushes.Black, 1);
        public static Point POINT = new Point(5, 5);

        public static void Draw(ref Bitmap bitmap, string text)
        {
            float FontSize = (float)(bitmap.Height * 0.075);

            Graphics graphics = Graphics.FromImage(bitmap);
            GraphicsPath graphicsPath = new GraphicsPath();

            graphicsPath.AddString(text, FONT_FAMILY, (int)FontStyle.Bold, FontSize, POINT, StringFormat.GenericDefault);
            graphics.FillPath(Brushes.LightGreen, graphicsPath);

            if (FontSize > 10)
            {
                graphics.DrawPath(PEN, graphicsPath);
            }

            graphics.Flush();
        }
    }
}
