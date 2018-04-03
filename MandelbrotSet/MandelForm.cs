using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using MandelbrotSet.Contracts;

namespace MandelbrotSet
{
    public partial class MandelForm : Form
    {
        private Point zoomStart = Point.Empty;
        private Point zoomEnd = Point.Empty;
        private bool isZooming = false;
        private Rectangle zoomRectangle;
        private Stopwatch renderingTime;
        readonly IFractal mandelFractal;


        public MandelForm()
        {
            InitializeComponent();
            mandelFractal = new Mandelbrot();
            UpdateInputFields();
        }
   
        private void UpdateInputFields()
        {
            txtBoxPosX.Text = mandelFractal.PosX.ToString(CultureInfo.InvariantCulture);
            txtBoxPosY.Text = mandelFractal.PosY.ToString(CultureInfo.InvariantCulture);
            txtBoxDx.Text = mandelFractal.RangeStart.ToString(CultureInfo.InvariantCulture);
            txtBoxDy.Text = mandelFractal.RangeEnd.ToString(CultureInfo.InvariantCulture);
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
            mandelFractal.Iterations = iterations;
            StartRenderingTime();
            picBox.Image = mandelFractal.ZoomFractal(new Point(0,0), new Point(400,400));
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
                this.picBox.Image = mandelFractal.ZoomFractal(zoomStart, zoomEnd);
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
