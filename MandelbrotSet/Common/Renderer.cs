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

            //        MyBitmap.SetPixel(x, y, pixelColor);
            //    }
            //}


            unsafe
            {
                BitmapData data = MyBitmap.LockBits(new Rectangle(0, 0, MyBitmap.Width, MyBitmap.Height),
                                                    ImageLockMode.ReadWrite, MyBitmap.PixelFormat);

                int bytesPerPixel = Bitmap.GetPixelFormatSize(MyBitmap.PixelFormat) / 8;
                int heightInPixels = data.Height;
                int widthInBytes = data.Width * bytesPerPixel;
                byte* PtrFirstPixel = (byte*)data.Scan0;


                Parallel.For(0, heightInPixels, y =>
                {
                    byte* line = PtrFirstPixel + (y * data.Stride);
                    int xPos = 0;

                    for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
                    {
                        int iter = mandel.GetNextPixel(xPos, y, iterations);
                        Color pixelColor = iter == iterations ? Color.White : palette[iter%palette.Count];

                        line[x + 0] = pixelColor.B;
                        line[x + 1] = pixelColor.G;
                        line[x + 2] = pixelColor.R;
                        line[x + 3] = pixelColor.A;

                        xPos++;
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
