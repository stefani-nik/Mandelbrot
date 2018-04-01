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
            picBox.MouseDown += new MouseEventHandler(picBox_MouseDown);
            picBox.MouseUp += new MouseEventHandler(picBox_MouseUp);
            picBox.MouseMove += new MouseEventHandler(picBox_MouseMove);
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
            picBox.Image = Mandelbrot.RenderSet();

            stopWatch.Stop();

            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            lblTimer.Text = $"{ts.Seconds}:{ts.Milliseconds}";
        }


        private void picBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && zoomStart == Point.Empty && IsPointInPicture(e.X, e.Y))
            {
                zoomStart = new Point(e.X, e.Y);
                Point rectStart = picBox.PointToScreen(new Point(e.X, e.Y));
                zoomRectangle = new Rectangle(rectStart.X, rectStart.Y, 0, 0);
                isZooming = true;
            }
        }

        private void picBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (zoomStart != Point.Empty && e.Button == MouseButtons.Left && isZooming && IsPointInPicture(e.X, e.Y))
            {

                double zoomWidth = e.X - zoomStart.X;
                double zoomHeight = e.Y - zoomStart.Y;

                // to make it a square  
                if (zoomWidth > zoomHeight)
                {
                    zoomHeight = zoomWidth;
                }
                else
                {
                    zoomWidth = zoomHeight;
                }


                zoomEnd = new Point((int)(zoomStart.X + zoomWidth), (int)(zoomStart.Y + zoomHeight));
                this.picBox.Image = Mandelbrot.ZoomFractal(zoomStart, zoomEnd);
            }

            zoomStart = Point.Empty;
            zoomEnd = Point.Empty;
            isZooming = false;
            this.Cursor = DefaultCursor;
        }

        private void picBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (zoomStart != Point.Empty && isZooming)
            {

                ControlPaint.DrawReversibleFrame(zoomRectangle, this.BackColor, FrameStyle.Dashed);

                Point endPoint = picBox.PointToScreen(new Point(e.X, e.Y));
                Point startPoint = picBox.PointToScreen(zoomStart);


                double zoomWidth = e.X - zoomStart.X;
                double zoomHeight = e.Y - zoomStart.Y;

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

                //ControlPaint.DrawReversibleFrame(zoomRectangle, this.BackColor, FrameStyle.Dashed);
            }
        }

        private bool IsPointInPicture(int x, int y)
        {
            if (picBox.Width > x && picBox.Height > y)
                return true;

            return false;
        }
    }
}
