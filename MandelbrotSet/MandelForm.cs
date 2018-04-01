using System;
using System.Diagnostics;
using System.Threading;
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

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            picBox.Image = Mandelbrot.RenderSet((int)iterationsUpDown.Value);

            stopWatch.Stop();

            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            lblTimer.Text = $"{ts.Seconds}:{ts.Milliseconds}";
        }



        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
