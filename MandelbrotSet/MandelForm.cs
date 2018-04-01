using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace MandelbrotSet
{
    public partial class MandelForm : Form
    {
        private Point zoomStart = Point.Empty;
        private Point zoomEnd = Point.Empty;
        private bool isZooming = false;
        private Rectangle zoomRectangle = new Rectangle();
        private bool isFractalRendered = false;

        public MandelForm()
        {
            InitializeComponent();

        }


        private void btnRender_Click(object sender, EventArgs e)
        {

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            int iterations = (int)iterationsUpDown.Value;
            double posX = double.Parse(txtBoxPosX.Text);
            double posY = double.Parse(txtBoxPosY.Text);
            double dX = double.Parse(txtBoxDx.Text);
            double dY = double.Parse(txtBoxDy.Text);
            picBox.Image = Mandelbrot.RenderSet(iterations, posX, posY, dX, dY);

            stopWatch.Stop();

            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            lblTimer.Text = $"{ts.Seconds}:{ts.Milliseconds}";
        }


        private void picBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && zoomStart == Point.Empty)
            {
                zoomStart = new Point(e.X, e.Y);
                Point rectStart = picBox.PointToScreen(new Point(e.X, e.Y));
                zoomRectangle = new Rectangle(rectStart.X, rectStart.Y, 0, 0);
                isZooming = true;
            }
        }

        private void picBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (zoomStart != Point.Empty && e.Button == MouseButtons.Left && isZooming)
            {
                double ar = 1.0;

                if (picBox.Image != null)
                {
                    ar = (double)picBox.Image.Width / (double)picBox.Image.Height;
                }

                double drw = e.X - zoomStart.X;
                double drh = e.Y - zoomEnd.Y;

                if (drw > drh) drh = drw / ar;
                else drw = drh * ar;

                zoomEnd = new Point((int)(zoomStart.X + drw), (int)(zoomStart.Y + drh));
                // ZoomFractal
            }

            zoomStart = Point.Empty;
            zoomEnd = Point.Empty;
            isZooming = false;
        }

        private void picBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (zoomStart != Point.Empty && isZooming)
            {

                ControlPaint.DrawReversibleFrame(zoomRectangle, this.BackColor, FrameStyle.Dashed);

                Point endPoint = picBox.PointToScreen(new Point(e.X, e.Y));
                Point startPoint = picBox.PointToScreen(zoomStart);


                double zoomWidth = endPoint.X - startPoint.X;
                double zoomHeight = endPoint.Y - startPoint.Y;

                // to make it a square  
                if (zoomWidth > zoomHeight)
                {
                    zoomHeight = zoomWidth;
                }
                else
                {
                    zoomWidth = zoomHeight;
                }



                zoomRectangle.Width = (int)zoomWidth;
                zoomRectangle.Height = (int)zoomHeight;

                ControlPaint.DrawReversibleFrame(zoomRectangle, this.BackColor, FrameStyle.Dashed);
            }
        }
    }
}
