using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Drawing;

namespace Filters
{
    class SobelFilter : MatrixFilter
    {
        protected float[,] kernelX;
        protected float[,] kernelY;
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
         {
             float[,] kernelX = { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
             float[,] kernelY = { { -1, -2, -1 }, { 0, 0, 0 }, { 1, 2, 1 } };
             int radiusX = kernelX.GetLength(0) / 2;//радиус по ширине
             int radiusY = kernelX.GetLength(1) / 2;//радиус по высоте
             float resultRx = 0;//цветовые компоненты результирующего цвета
             float resultGx = 0;
             float resultBx = 0;

             float resultRy = 0;
             float resultGy = 0;
             float resultBy = 0;
            // цикл перебирает окрестность пиксела
             for (int k = -radiusY; k <= radiusY; k++)
             {
                 for (int l = -radiusX; l <= radiusX; l++)
                 {
                     int idX = Clamp(l + x, 0, sourceImage.Width - 1);//вычисляем значение координаты соседа каждой точки
                     int idY = Clamp(k + y, 0, sourceImage.Height - 1);//clamp- не выйти за границы
                     Color neighborColor = sourceImage.GetPixel(idX, idY);

                     resultRx += neighborColor.R * kernelX[l + radiusX, k + radiusY];
                     resultGx += neighborColor.G * kernelX[l + radiusX, k + radiusY];
                     resultBx += neighborColor.B * kernelX[l + radiusX, k + radiusY];

                     resultRy += neighborColor.R * kernelY[l + radiusX, k + radiusY];
                     resultGy += neighborColor.G * kernelY[l + radiusX, k + radiusY];
                     resultBy += neighborColor.B * kernelY[l + radiusX, k + radiusY];
                 }
             }


             return Color.FromArgb(Clamp((int)Math.Sqrt(resultRx * resultRx + resultRy * resultRy), 0, 255),
                                   Clamp((int)Math.Sqrt(resultGx * resultGx + resultGy * resultGy), 0, 255),
                                   Clamp((int)Math.Sqrt(resultRx * resultBx + resultBy * resultBy), 0, 255));

         }
     }
       

}
