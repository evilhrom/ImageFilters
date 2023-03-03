using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;

namespace Filters
{
    class Openning : Filter
    {
     
        private Dilation dilationFilter;
        private Erosion erosionFilter;

        public Openning(int w, int h, int[,] k)
        {

            dilationFilter = new Dilation(w, h, k);
            erosionFilter = new Erosion(w, h, k);
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            if (sourceImage == null)
            {
                throw new ArgumentNullException(nameof(sourceImage));
            }

            return Color.White;
        }

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker bgWorker)
        {
            Bitmap res = erosionFilter.processImage(sourceImage, bgWorker);
            Bitmap finalRes = dilationFilter.processImage(res, bgWorker);

            return finalRes;
        }
    }
}
