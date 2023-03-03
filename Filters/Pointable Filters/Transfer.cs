using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Filters
{
    class Transfer : Filter
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            if (x + 50 <= sourceImage.Width - 1)
            {
                Color sourceColor = sourceImage.GetPixel(Clamp(x + 50, 0, sourceImage.Width - 1), y);
                return Color.FromArgb(Clamp((int)(sourceColor.R), 0, 255), Clamp((int)(sourceColor.G), 0, 255), Clamp((int)(sourceColor.B), 0, 255));
            }
            else
            {
                return Color.FromArgb(0, 0, 0);
            }
        }
    }
}
