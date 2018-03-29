using System;
using System.Windows.Forms;

namespace MandelbrotSet
{
    public partial class MandelForm : Form
    {
        public MandelForm()
        {
            InitializeComponent();
        }


        private void btnRender_Click(object sender, EventArgs e)
        {
           Mandelbrot fractal = new Mandelbrot();
           picBox.Image = fractal.RenderSet();
        }

        private void Mandelbrot_Load(object sender, EventArgs e)
        {

        }
    }
}
