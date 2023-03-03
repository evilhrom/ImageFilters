using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    class SepiaFilter : Filter
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            int k = 7;
            double intesity = sourceColor.R * 0.36 + sourceColor.G * 0.53 + sourceColor.B * 0.11;
            return Color.FromArgb(Clamp((int)(intesity + 2 * k), 0, 255), Clamp((int)(intesity + 0.5 * k), 0, 255), Clamp((int)(intesity - 1 * k), 0, 255));
        }
    }
}
