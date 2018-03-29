using System;
using System.Drawing;
using MandelbrotSet.Contracts;

namespace MandelbrotSet
{
    public class Renderer
    {
        const int iterations = 100;
        const int radius = 4;

        public int renderPercent = 0;
        public event EventHandler PercentChange;

        Color[] colors = new Color[256];

        public Renderer()
        {
            for (int i = 0; i < 256; i++)
            {
                this.colors[i] = Color.FromArgb(255, i, i, i);
            }
        }

        public Bitmap RenderSet(int width, int height, double xmin = -2.1, double ymin = -1.3, double xmax = 1,
            double ymax = 1.3)
        {
            Bitmap bm = new Bitmap(width, height);
            int pixelsCount = width*height;

            double intigralX = (xmax - xmin) / width;
            double intigralY = (ymax - ymin) / height;
            double x = xmin;

            for (int s = 0; s < width; s++)
            {
                double y = ymin;

                for (int p = 0; p < height; p++)
                {
                    double x1 = 0;
                    double y1 = 0;


                    double a = (double)(x - (width / 2.0)) / (double)(width / 4.0);
                    double b = (double)(y - (width / 2.0)) / (double)(width / 4.0);
                    ComplexPoint c = new ComplexPoint(a, b);
                    IComplexPoint z = new ComplexPoint(0, 0);

                    int it = 0;
                    do
                    {
                        it++;
                        z.GetSqrt();
                        z.Add(c);

                        if (z.GetModulus() > radius) break;

                    } while (it < iterations);

                    Color color;

                    if (it == iterations)
                    {
                        // if we went for so long and never escaped:
                        color = Color.White;
                    }
                    else
                    {
                        // otherwise, do two more iterations (helps reduce error)
                        it++;
                        double xtemp = (x1 * x1) - (y1 * y1) + x;
                        y1 = 2 * x1 * y1 + y;
                        x1 = xtemp;

                        it++;
                        xtemp = (x1 * x1) - (y1 * y1) + x;
                        y1 = 2 * x1 * y1 + y;
                        x1 = xtemp;

                        // then grab a number based on the number of iterations performed before the value escaped:
                        double v = ((iterations + 1) - Math.Log(Math.Log(Math.Sqrt((x1 * x1) + (y1 * y1)))) / Math.Log(2.0));
                      //  c = colors[(int)v % colors.Length];

                    }

                  //  bm.SetPixel(x, y, it < 100 ? Color.Brown : Color.Beige);
                }
            }

          //  picBox.Image = bm;

            return bm;
        }
    }
}
