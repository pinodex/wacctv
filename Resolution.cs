using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WACCTV
{
    public class Resolution
    {
        public Resolution(string resolutionString)
        {
            string[] resolutionStringArr = resolutionString.Split('x');

            try
            {
                Width = Convert.ToInt32(resolutionStringArr[0]);
                Height = Convert.ToInt32(resolutionStringArr[1]);
            } catch
            {
                Width = 640;
                Height = 480;
            }
        }

        public Resolution(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Height
        {
            get; private set;
        }

        public int Width
        {
            get; private set;
        }

        public double AspectRatio
        {
            get
            {
                return Width / Height;
            }
        }
    }
}
