using System;
using System.Collections.Generic;
using System.Drawing;
using MandelbrotSet.Common;
using MandelbrotSet.Contracts;

namespace MandelbrotSet
{
    public static class Mandelbrot
    {

        public static double posX = Constants.PositionX;
        public static double posY = Constants.PositionY;
        public static double rangeStart = Constants.RangeStart;
        public static double rangeEnd = Constants.RangeEnd;
        public static int iterations = Constants.DefaultIterations;

        private static readonly List<Color> palette = ColorsManager.LoadPalette();



        public static Bitmap RenderSet()
        {
            int width = Constants.BitmapWidth;
            int height = Constants.BitmapHeight;

            Bitmap bm = new Bitmap(width, height);



            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    //double a = ExtensionMethods.Remap(x, 0, width, Constants.RangeStart, Constants.RangeEnd);
                    //double b = ExtensionMethods.Remap(y, 0, height, Constants.RangeStart, Constants.RangeEnd);

                    double a = ExtensionMethods.Remap(x, posX, width, rangeStart, rangeEnd);
                    double b = ExtensionMethods.Remap(y, posY, height, rangeStart, rangeEnd);

                    //double a = ExtensionMethods.Remap(x, 0, dX, Constants.RangeStart, Constants.RangeEnd);
                    //double b = ExtensionMethods.Remap(y, 0, dY, Constants.RangeStart, Constants.RangeEnd);

                    ComplexPoint c = new ComplexPoint(a, b);
                    IComplexPoint z = new ComplexPoint(0, 0);
                    //IComplexPoint z = new ComplexPoint(0, 0);

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

        public static Bitmap ZoomFractal(Point zoomStart, Point zoomEnd)
        {

            var mappedStartPoint = ExtensionMethods.MapPoint(zoomStart);
            var mappedEndPont = ExtensionMethods.MapPoint(zoomEnd);

            double startX = mappedStartPoint.Item1;
            double startY = mappedStartPoint.Item2;

            double endX = mappedEndPont.Item1;
            double endY = mappedEndPont.Item2;

            Mandelbrot.posX = (startX + endX) / 2.0;
            Mandelbrot.posY = (startY + endY) / 2.0;
            Mandelbrot.rangeStart = endX - startX;
            Mandelbrot.rangeEnd = endY - startY;

            int width = Constants.BitmapWidth;
            int height = Constants.BitmapHeight;

            Bitmap bm = new Bitmap(width, height);

            bm = Mandelbrot.RenderSet();
            return bm;
        }
    }
}
