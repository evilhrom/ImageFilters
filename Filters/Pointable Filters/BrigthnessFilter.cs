using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Filters
{
    class BrigthnessFilter : Filter
       
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            int k = 100;
            //double intesity = sourceColor.R * 0.36 + sourceColor.G * 0.53 + sourceColor.B * 0.11;
            return Color.FromArgb(Clamp((int)(sourceColor.R + k), 0, 255), Clamp((int)(sourceColor.G + k), 0, 255), Clamp((int)(sourceColor.B + k), 0, 255));
        }
    }
}

