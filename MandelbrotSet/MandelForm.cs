using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
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
        private Stopwatch renderingTime;


        public MandelForm()
        {
            InitializeComponent();
            UpdateInputFields();
        }
   
        private void UpdateInputFields()
        {
            txtBoxPosX.Text = Mandelbrot.posX.ToString(CultureInfo.InvariantCulture);
            txtBoxPosY.Text = Mandelbrot.posY.ToString(CultureInfo.InvariantCulture);
            txtBoxDx.Text = Mandelbrot.rangeStart.ToString(CultureInfo.InvariantCulture);
            txtBoxDy.Text = Mandelbrot.rangeEnd.ToString(CultureInfo.InvariantCulture);
        }

        private void StartRenderingTime()
        {
            renderingTime = new Stopwatch();
            renderingTime.Start();
        }

        private void StopRenderingTime()
        {
            renderingTime.Stop();
            TimeSpan ts = renderingTime.Elapsed;
            lblTimer.Text = $"{ts.Seconds}:{ts.Milliseconds}";
        }

        private bool MouseIsOverPicture(Control c)
        {
            return c.ClientRectangle.Contains(c.PointToClient(picBox.PointToScreen(zoomEnd)));
        }

        #region EventHandlers

        private void btnRender_Click(object sender, EventArgs e)
        {

            int iterations = (int)iterationsUpDown.Value;
            Mandelbrot.iterations = iterations;
            StartRenderingTime();
            picBox.Image = Mandelbrot.RenderSet();
            StopRenderingTime();
           
        }


        private void picBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                zoomStart = new Point(e.X, e.Y);
                Point rectStart = picBox.PointToScreen(new Point(e.X, e.Y));
                zoomRectangle = new Rectangle(rectStart.X, rectStart.Y, 0, 0);
                isZooming = true;
            }
        }
        private void picBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (isZooming)
            {

                StartRenderingTime();
                this.picBox.Image = Mandelbrot.ZoomFractal(zoomStart, zoomEnd);
                StopRenderingTime();
                this.UpdateInputFields();
            }

            zoomStart = Point.Empty;
            zoomEnd = Point.Empty;
            isZooming = false;
            this.Cursor = DefaultCursor;
        }


        private void picBox_MouseMove(object sender, MouseEventArgs e)
        {
          
                if (isZooming && MouseIsOverPicture(this.picBox))
                {

                    ControlPaint.DrawReversibleFrame(zoomRectangle, this.BackColor, FrameStyle.Dashed);

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

                    zoomRectangle.Width = (int)zoomWidth;
                    zoomRectangle.Height = (int)zoomHeight;

                    ControlPaint.DrawReversibleFrame(zoomRectangle, this.BackColor, FrameStyle.Dashed);
                }
        }
        #endregion
    }
}
