using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    class Wave:Filter
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            x = Clamp((int)(x + 20 * Math.Sin(2 * Math.PI * x / 200)), 0, sourceImage.Width-1);
            Color sourceColor = sourceImage.GetPixel(x, y);
            return Color.FromArgb(Clamp((int)(sourceColor.R), 0, 255), Clamp((int)(sourceColor.G), 0, 255), Clamp((int)(sourceColor.B), 0, 255));
        }
    }
}
