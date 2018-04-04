using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Threading.Tasks;
using MandelbrotSet.Contracts;

namespace MandelbrotSet.Common
{
    /// <summary>
    /// Class responsible for rendering the Mandelbrot set 
    /// and getting information about its parameters
    /// </summary>
    public class Renderer : IRenderer
    {

        public Bitmap MyBitmap;

        private readonly List<Color> palette;
        private readonly IFractal mandel;
        private readonly Stopwatch renderTimer;

        public Renderer()
        {
            this.palette = ColorsManager.LoadPalette();
            this.MyBitmap = new Bitmap(Constants.BitmapWidth, Constants.BitmapHeight);
            this.mandel = new Mandelbrot();
            this.renderTimer = new Stopwatch();
        }
        
        /// <summary>
        /// Multithreading rendering of the Mandelbrot set
        /// </summary>
        public Bitmap RenderMandelbrot(Point start, Point end, int iterations)
        {
            this.renderTimer.Start();

            // If the points are not empty the fractal is zoom and adjustment of the parameters is needed
            if (start != Point.Empty && end != Point.Empty)
            {
                mandel.AdjustParameters(start, end);
            }


            unsafe
            {
                BitmapData data = MyBitmap.LockBits(new Rectangle(0, 0, MyBitmap.Width, MyBitmap.Height),
                                                    ImageLockMode.ReadWrite, MyBitmap.PixelFormat);

                int bytesPerPixel = Bitmap.GetPixelFormatSize(MyBitmap.PixelFormat) / 8; // The default is 32 bits
                int heightInPixels = data.Height; 
                int widthInBytes = data.Width * bytesPerPixel;
                byte* PtrFirstPixel = (byte*)data.Scan0; // pointer to the first pixel of the bitmap


                var options = new ParallelOptions {MaxDegreeOfParallelism = Environment.ProcessorCount - 1};

                Parallel.For(0, heightInPixels, options, y =>
                {
                    byte* line = PtrFirstPixel + (y * data.Stride); // pointer to the current line first pixel
                    int xInPixels = 0;

                    for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
                    {
                        int iter = mandel.GetNextPixel(xInPixels, y, iterations);
                        Color pixelColor = iter == iterations ? Color.White : palette[iter%palette.Count];

                        line[x + 0] = pixelColor.B;
                        line[x + 1] = pixelColor.G;
                        line[x + 2] = pixelColor.R;
                        line[x + 3] = pixelColor.A;

                        xInPixels++;
                    }
                });
                MyBitmap.UnlockBits(data);
            }

            this.renderTimer.Stop();

            return MyBitmap;
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
