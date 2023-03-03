using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Filters
{
    class MedianFilter:MatrixFilter
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radius = 1;
            int size = (2*radius + 1)* (2 * radius + 1);
            double [] arr = new double[size];
            double[] sortarr = new double[size];
            int idX = 0;
            int idY = 0;
            
            for (int i = x - radius; i <= x + radius; i++)
            { 
                for (int j = y - radius; j <= y + radius; j++)
                {
                    Color sourceColor = sourceImage.GetPixel(Clamp(i, 0, sourceImage.Width - 1), Clamp(j, 0, sourceImage.Height -1));
                    arr[i - x + j - y + 2*radius] = sortarr[i - x + j - y + 2 * radius] = (sourceColor.GetBrightness());
                }
            }
            Array.Sort(sortarr, 0, size);
            for (int i = -radius; i <= radius; i++)
            {
                for (int j = -radius; j <= radius; j++)
                {
                    if (arr[i + j + 2 * radius] == sortarr[size / 2])
                    {
                        idX = Clamp(x + i, 0, sourceImage.Width - 1);
                        idY = Clamp(y + j, 0, sourceImage.Height - 1);
                    }
                }
            }
            return sourceImage.GetPixel(idX, idY);
        }
    }
}
