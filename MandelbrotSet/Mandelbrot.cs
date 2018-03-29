using System;
using System.Drawing;
using System.Windows.Forms;
using MandelbrotSet.Common;
using MandelbrotSet.Contracts;

namespace MandelbrotSet
{
    public partial class Mandelbrot : Form
    {
        public Mandelbrot()
        {
            InitializeComponent();
        }


        private void btnRender_Click(object sender, EventArgs e)
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
                    double b = ExtensionMethods.Remap(y, 0, width, Constants.RangeStart, Constants.RangeEnd);

                    ComplexPoint c = new ComplexPoint(a,b);
                    IComplexPoint z = new ComplexPoint(0 ,0);

                    int it = 0;
                    do
                    {
                        it++;
                        z.GetSqrt();
                        z.Add(c);

                        if(z.GetModulus() > 2.0) break;
                        
                    } while (it < Constants.IterationsCount);

                    bm.SetPixel(x,y, it<100?Color.Brown : Color.Beige);
                }
            }

            picBox.Image = bm;
        }

        private void Mandelbrot_Load(object sender, EventArgs e)
        {

        }
    }
}
