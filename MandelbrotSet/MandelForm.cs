using System;
using System.Windows.Forms;

namespace MandelbrotSet
{
    public partial class MandelForm : Form
    {
        private Timer timer;
        private DateTime startTime;
        private bool isTimerRunning;

        public MandelForm()
        {
            InitializeComponent();
            timer = new Timer {Interval = 1 };
            timer.Tick += new EventHandler(renderTimer_Tick);

        }


        private void btnRender_Click(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
            timer.Start();
            isTimerRunning = true;
            Mandelbrot fractal = new Mandelbrot();
            picBox.Image = fractal.RenderSet((int) iterationsUpDown.Value);
            //timer.Stop();

        }

        private void Mandelbrot_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void picBox_Click(object sender, EventArgs e)
        {

        }

        private void renderTimer_Tick(object sender, EventArgs e)
        {
            var timeSinceStartTime = (DateTime.Now - startTime).Milliseconds;

            string result = $"{timeSinceStartTime / 1000}:{timeSinceStartTime}";


            lblTimer.Text = result;
        }
    }
}
