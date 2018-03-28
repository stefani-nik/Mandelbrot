using System;
using System.Drawing;
using System.Windows.Forms;

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
            int width = picBox.Width;
            int height = picBox.Height;

            Bitmap bm = new Bitmap(width, height);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    double a = (double) (x - (width / 2.0))/(double) (width / 4.0);
                    double b = (double)(y - (width / 2.0)) / (double)(width / 4.0);
                    ComplexPoint c = new ComplexPoint(a,b);
                    ComplexPoint z = new ComplexPoint(0 ,0);

                    int it = 0;
                    do
                    {
                        it++;
                        z.GetSqrt();
                        z.Add(c);

                        if(z.GetModulus() > 2.0) break;
                        
                    } while (it < 100);

                    bm.SetPixel(x,y, it<100?Color.Brown : Color.Beige);
                }
            }

            picBox.Image = bm;
        }
    }
}
