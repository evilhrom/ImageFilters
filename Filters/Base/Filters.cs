using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Filters
{
    abstract class Filter
    {
        protected abstract Color calculateNewPixelColor(Bitmap sourceImage, int x, int y);
        public int Clamp(int value, int min, int max)
        {
            if (value < min)
                return min;
            if (value > max)
                return max;
            return value;
        }

        public double intensity(Color source)
        {
            return source.R * 0.36 + 0.53 * source.G + 0.11 * source.B;
        }
        public virtual Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {   
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            
            for (int i = 0; i < sourceImage.Width; i++)
			{
              worker.ReportProgress((int)((float)i/ resultImage.Width *100));
			  for (int j = 0; j < sourceImage.Height; ++j)
                   resultImage.SetPixel(i, j, calculateNewPixelColor(sourceImage, i, j)); // устанавливает пиксель
			}
            return resultImage;
        } 
    }
}
