using System;
using System.Collections.Generic;
using System.Drawing;
using MandelbrotSet.Common;
using MandelbrotSet.Contracts;

namespace MandelbrotSet
{
    public class Mandelbrot
    {

        private readonly List<Color> palette = ColorsManager.LoadPalette();


        public Bitmap RenderSet(int iterations)
        {
            int width = Constants.BitmapWidth;
            int height = Constants.BitmapHeight;

            Bitmap bm = new Bitmap(width, height);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    double a = ExtensionMethods.Remap(x, 0, width, Constants.RangeStart, Constants.RangeEnd);
                    //double a = (double) (x - (width / 2.0))/(double) (width / 4.0);
                    //double b = (double)(y - (width / 2.0)) / (double)(width / 4.0);
                    double b = ExtensionMethods.Remap(y, 0, height, Constants.RangeStart, Constants.RangeEnd);

                    ComplexPoint c = new ComplexPoint(a, b);
                    IComplexPoint z = new ComplexPoint(0, 0);

                    int it = 0;
                    do
                    {
                        it++;
                        z.GetSqrt();
                        z.Add(c);

                        if (z.GetModulus() > Constants.RangeRadius) break;

                    } while (it < iterations);

                    Color pixelColor = it == iterations ? Color.White : palette[it % palette.Count];

                    bm.SetPixel(x, y, pixelColor);
                }
            }

            return bm;
        }
    }
}
