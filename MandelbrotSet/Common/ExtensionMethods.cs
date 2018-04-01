using System;
using System.Drawing;

namespace MandelbrotSet.Common
{
    public static class ExtensionMethods
    {
        public static double Remap(int value,
                                double fromBegin, double fromEnd,
                                double toBegin, double toEnd)
        {
            double scale = (double) (toEnd - toBegin)/(fromEnd - fromBegin);
            double result = toBegin + ((value - fromBegin)*scale);
            return result;
        }

        public static Tuple<double,double> MapPoint(Point p)
        {
            double posX = Mandelbrot.posX;
            double posY = Mandelbrot.posY;
            double rangeStart = Mandelbrot.rangeStart;
            double rangeEnd = Mandelbrot.rangeEnd;

            // TODO : Make it be less magical 
            double newPosX = posX - 0.5 * rangeStart;
            double newPosY = posY - 0.5 * rangeEnd;

            double dxf = rangeStart * p.X / Constants.BitmapWidth;
            double dyf = rangeEnd * p.Y / Constants.BitmapHeight;


            double newX = newPosX + dxf;
            double newY = newPosY + dyf;

      

            return  Tuple.Create(newX, newY);
        }


    }
}
