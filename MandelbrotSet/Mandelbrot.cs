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


            double xStartPos = (posX - rangeStart / 2.0);
            double yStartPos = (posY - rangeEnd / 2.0);
            double xOffset = rangeStart / (double)width;
            double yOffset = rangeEnd / (double)height;

            double coordY = yStartPos + yOffset;

            for (int y = 0; y < height; y++)
            {
                double coordX = xStartPos;

                for (int x = 0; x < width; x++)
                {
                    ComplexPoint c = new ComplexPoint(coordX, coordY);
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

                    coordX += xOffset;
                }

                coordY += yOffset;
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
