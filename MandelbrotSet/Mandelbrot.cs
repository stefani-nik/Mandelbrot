using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Threading.Tasks;
using MandelbrotSet.Common;
using MandelbrotSet.Contracts;

namespace MandelbrotSet
{
    public class Mandelbrot : IFractal
    {
        public int Iterations { get; set; } = Constants.DefaultIterations;

        public double PosX { get; set; } = Constants.PositionX;

        public double PosY { get; set; } = Constants.PositionY;

        public double RangeStart { get; set; } = Constants.RangeStart;

        public double RangeEnd { get; set; } = Constants.RangeEnd;


        private static readonly List<Color> palette = ColorsManager.LoadPalette();



        public Bitmap RenderFractal()
        {
            int width = Constants.BitmapWidth;
            int height = Constants.BitmapHeight;

            Bitmap bm = new Bitmap(width, height);


            double xStartPos = (this.PosX - this.RangeStart / 2.0);
            double yStartPos = (this.PosY - this.RangeEnd / 2.0);
            double xOffset = this.RangeStart / (double)width;
            double yOffset = this.RangeEnd / (double)height;

            double coordY = yStartPos + yOffset;

            for (int y = 0; y < height; y++)
            {
                double coordX = xStartPos;

                for (int x = 0; x < width; x++)
                {
                    ComplexPoint c = new ComplexPoint(coordX, coordY);
                    ComplexPoint z = new ComplexPoint(0, 0);

                    int it = 0;
                    do
                    {
                        it++;
                        z.GetSqrt();
                        z += c;

                        if (z.GetModulus() > Constants.RangeRadius) break;

                    } while (it < this.Iterations);

                    Color pixelColor = it == this.Iterations ? Color.White : palette[it % palette.Count];

                    bm.SetPixel(x, y, pixelColor);

                    coordX += xOffset;
                }

                coordY += yOffset;
            }

            return bm;
        }


        // TODO: Implement getting each pixel at a time so that the Mandelbrot class does not have access to Bitmap
  
        //public int GetNextPixel()
        //{
            
        //}

        public Bitmap ZoomFractal(Point zoomStart, Point zoomEnd)
        {
            IPointMapper mapper = new PointMapper();
            var mappedStartPoint = mapper.MapPoint(zoomStart, PosX, PosY, RangeStart, RangeEnd);
            var mappedEndPont = mapper.MapPoint(zoomEnd, PosX, PosY, RangeStart, RangeEnd);

            double startX = mappedStartPoint.Item1;
            double startY = mappedStartPoint.Item2;

            double endX = mappedEndPont.Item1;
            double endY = mappedEndPont.Item2;

            this.PosX = (startX + endX) / 2.0;
            this.PosY = (startY + endY) / 2.0;
            this.RangeStart = endX - startX;
            this.RangeEnd = endY - startY;

            int width = Constants.BitmapWidth;
            int height = Constants.BitmapHeight;

            Bitmap bm = new Bitmap(width, height);

            bm = RenderFractal();
           return bm;
        }
    }
}
