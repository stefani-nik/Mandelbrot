using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using MandelbrotSet.Contracts;

namespace MandelbrotSet.Common
{
    public class Renderer : IRenderer
    {

        public Bitmap Bitmap;

        private readonly List<Color> palette;
        private readonly IFractal mandel;
        private readonly Stopwatch renderTimer;

        public Renderer()
        {
            this.palette = ColorsManager.LoadPalette();
            this.Bitmap = new Bitmap(Constants.BitmapWidth, Constants.BitmapHeight);
            this.mandel = new Mandelbrot();
            this.renderTimer = new Stopwatch();
        }
        

        public Bitmap RenderMandelbrot(Point start, Point end, int iterations)
        {
            this.renderTimer.Start();

            if (start != Point.Empty && end != Point.Empty)
            {
                mandel.AdjustParameters(start, end);
            }


            //for (int y = 0; y < Constants.BitmapHeight; y++)
            //{
            //    for (int x = 0; x < Constants.BitmapWidth; x++)
            //    {
            //        int iter = mandel.GetNextPixel(x, y, iterations);

            //        Color pixelColor = iter == iterations ? Color.White : palette[iter % palette.Count];

            //        Bitmap.SetPixel(x, y, pixelColor);
            //    }
            //}

            for (int y = 0; y < Constants.BitmapHeight; y++)
            {
                for (int x = 0; x < Constants.BitmapWidth; x++)
                {
                    int iter = mandel.GetNextPixel(x, y, iterations);

                    Color pixelColor = iter == iterations ? Color.White : palette[iter % palette.Count];

                    Bitmap.SetPixel(x, y, pixelColor);
                }
            }

            this.renderTimer.Stop();

            return Bitmap;
        }

        public string GetCurrentX()
        {
            return this.mandel.PosX.ToString(CultureInfo.InvariantCulture);
        }
        public string GetCurrentY()
        {
            return this.mandel.PosY.ToString(CultureInfo.InvariantCulture);
        }
        public string GetCurrentRangeStart()
        {
            return this.mandel.RangeStart.ToString(CultureInfo.InvariantCulture);
        }
        public string GetCurrentRangeEnd()
        {
            return this.mandel.RangeEnd.ToString(CultureInfo.InvariantCulture);
        }

        public string GetRenderingTime()
        {
            TimeSpan ts = renderTimer.Elapsed;
            renderTimer.Reset();
            return $"{ts.Seconds:D2}:{ts.Milliseconds:D2}";
        }
    }
}
