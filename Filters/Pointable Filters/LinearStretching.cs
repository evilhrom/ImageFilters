using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    class LinearStretching : Filter
    {
        double max = -1;
        double min = 256;
        void maxminIntensity(Bitmap sourceImage)
        {
            for (int i = 0; i < sourceImage.Height; i++)
                for (int j = 0; j < sourceImage.Width; j++)
                {
                    if (intensity(sourceImage.GetPixel(j, i)) > max)
                        max = intensity(sourceImage.GetPixel(j, i));
                    else if (intensity(sourceImage.GetPixel(j, i)) < min)
                        min = intensity(sourceImage.GetPixel(j, i));
                }
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            if (max < 0 && min > 255)
                maxminIntensity(sourceImage);
            Color neighborColor = sourceImage.GetPixel(x, y);
            double intens = intensity(neighborColor);
            double newIntes = (intens - min) * (255 - 0) / (max - min);
            return Color.FromArgb(Clamp(neighborColor.R + (int)newIntes, 0, 255), Clamp(neighborColor.B + (int)newIntes, 0, 255), Clamp(neighborColor.B + (int)newIntes, 0, 255));
            //return Color.FromArgb(Clamp((int)newIntes, 0, 255), Clamp((int)newIntes, 0, 255), Clamp((int)newIntes, 0, 255));
        }
    }
}
