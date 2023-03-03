using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;


namespace Filters
{
    class Sinus : Filter

    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            
            int k = 7;
            int x1 = Clamp((int)(sourceImage.Width / 2 + 20 * Math.Sin(2 * Math.PI * y / 200)), 0, sourceImage.Width - 1);
            if (x <=x1)
            {
                Color sourceColor = sourceImage.GetPixel(x, y);
                double intesity = sourceColor.R * 0.36 + sourceColor.G * 0.53 + sourceColor.B * 0.11;
                return Color.FromArgb(Clamp((int)(intesity + 2 * k), 0, 255), Clamp((int)(intesity + 0.5 * k), 0, 255), Clamp((int)(intesity - 1 * k), 0, 255));
            }
            else
            {
                Color sourceColor = sourceImage.GetPixel(x, y);
                return Color.FromArgb(Clamp((int)(sourceColor.R), 0, 255), Clamp((int)(sourceColor.G), 0, 255), Clamp((int)(sourceColor.B), 0, 255));
            }

        }
     
        
    }

}

