using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using MandelbrotSet.Common;
using MandelbrotSet.Contracts;

namespace MandelbrotSet
{
    public partial class MandelForm : Form
    {
        private Point zoomStart = Point.Empty;
        private Point zoomEnd = Point.Empty;
        private bool isZooming = false;
        private Rectangle zoomRectangle;
        private int iterations = Constants.DefaultIterations;

        private readonly BackgroundWorker backgroundWorker;
        private readonly IRenderer renderer;

        public MandelForm()
        {
            InitializeComponent();
            this.renderer = new Renderer();
            this.backgroundWorker = new BackgroundWorker();
            InitializeBackgroundWorker();
            UpdateFormFields();
        }


        #region HelperMethods

        private void UpdateFormFields()
        {
            txtBoxPosX.Text = renderer.GetCurrentX();
            txtBoxPosY.Text = renderer.GetCurrentY();
            txtBoxDx.Text = renderer.GetCurrentRangeStart();
            txtBoxDy.Text = renderer.GetCurrentRangeEnd();
            lblTimer.Text = renderer.GetRenderingTime();
        }

        private bool MouseIsOverPicture(Control c)
        {
            return c.ClientRectangle.Contains(c.PointToClient(picBox.PointToScreen(zoomEnd)));
        }

        private void InitializeBackgroundWorker()
        {
            this.backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker_DoWork);
        }

        #endregion

        #region EventHandlers

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            picBox.Image = renderer.RenderMandelbrot(zoomStart, zoomEnd, iterations);
            this.UpdateFormFields();
        }


        private void btnRender_Click(object sender, EventArgs e)
        {

            iterations = (int)iterationsUpDown.Value;
            backgroundWorker.RunWorkerAsync();
            
        }


        private void picBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !backgroundWorker.IsBusy)
            {
                zoomStart = new Point(e.X, e.Y);
                Point rectStart = picBox.PointToScreen(new Point(e.X, e.Y));
                zoomRectangle = new Rectangle(rectStart.X, rectStart.Y, 0, 0);
                isZooming = true;
            }
        }
        private void picBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (isZooming && !backgroundWorker.IsBusy)
            {
                backgroundWorker.RunWorkerAsync();
            }

            zoomStart = Point.Empty;
            zoomEnd = Point.Empty;
            isZooming = false;
            this.Cursor = DefaultCursor;
        }


        private void picBox_MouseMove(object sender, MouseEventArgs e)
        {
          
                if (isZooming && MouseIsOverPicture(this.picBox) && !backgroundWorker.IsBusy)
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
