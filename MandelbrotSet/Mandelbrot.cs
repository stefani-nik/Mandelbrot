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


            double xs = (posX - rangeStart / 2.0);
            double ys = (posY - rangeEnd / 2.0);
            double xd = rangeStart / (double)width;
            double yd = rangeEnd / (double)height;

            double y1 = ys + yd;

            for (int y = 0; y < height; y++)
            {
                double x1 = xs;

                for (int x = 0; x < width; x++)
                {
                    //double a = ExtensionMethods.Remap(x, 0, width, Constants.RangeStart, Constants.RangeEnd);
                    //double b = ExtensionMethods.Remap(y, 0, height, Constants.RangeStart, Constants.RangeEnd);

                    //double a = ExtensionMethods.Remap(x1, 0, width, rangeStart, rangeEnd);
                    //double b = ExtensionMethods.Remap(y1, 0, height, rangeStart, rangeEnd);

                    //double a = ExtensionMethods.Remap(x, 0, dX, Constants.RangeStart, Constants.RangeEnd);
                    //double b = ExtensionMethods.Remap(y, 0, dY, Constants.RangeStart, Constants.RangeEnd);

                    ComplexPoint c = new ComplexPoint(x1, y1);
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

                    x1 += xd;
                }

                y1 += yd;
            }

            return bm;
        }

        public static Bitmap ZoomFractal(Point zoomStart, Point zoomEnd)
        {

            //  TRY ANOTHER APPROACH

            //double lFactorX = (Mandelbrot.posX - Mandelbrot.rangeStart)/(zoomEnd.X - zoomStart.X);
            //double lFactorY = (Mandelbrot.posX - Mandelbrot.posY) / (zoomEnd.X - zoomStart.X);


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
