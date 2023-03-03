using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Filters
{
    class Expansion : MatrixFilter
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radius = 1;
            int size = (2 * radius + 1) * (2 * radius + 1);
            Color[] arr = new Color[size];
            double[] intarr = new double[size];
            int idX = 0;
            int idY = 0;
            double max = 0;
            Color maxColor = sourceImage.GetPixel(x, y);

            for (int i = x - radius; i <= x + radius; i++)
            {
                for (int j = y - radius; j <= y + radius; j++)
                {
                    arr[i - x + j - y + 2 * radius] = sourceImage.GetPixel(Clamp(i, 0, sourceImage.Width - 1), Clamp(j, 0, sourceImage.Height - 1));
                    intarr[i - x + j - y + 2 * radius] = intensity(arr[i - x + j - y + 2 * radius]);
                    if (intarr[i - x + j - y + 2 * radius] > max)
                    {
                        max = intarr[i - x + j - y + 2 * radius];
                        maxColor = arr[i - x + j - y + 2 * radius];
                    }
                }
            }
            return maxColor;
        }

    }
}
