using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class GrayScale : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            Color resultColor = Color.FromArgb((int)(double)(sourceColor.R * 0.299),
                                                (int)(double)(sourceColor.G * 0.299),
                                                (int)(double)(sourceColor.B * 0.299));
            return resultColor;
        }

    }
}
