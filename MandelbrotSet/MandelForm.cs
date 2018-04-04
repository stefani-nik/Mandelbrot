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
        private Rectangle zoomRectangle;
        private bool isZooming = false;
        private int iterations = Constants.DefaultIterations;
        private bool isFractalRendered = false;

        private readonly BackgroundWorker backgroundWorker;
        private readonly IRenderer renderer;

        public MandelForm()
        {
            this.InitializeComponent();
            this.renderer = new Renderer();
            this.backgroundWorker = new BackgroundWorker();
            this.InitializeBackgroundWorker();
            this.UpdateFormFields();
        }


        #region HelperMethods

        private void UpdateFormFields()
        {
            this.txtBoxPosX.Text = renderer.GetCurrentX();
            this.txtBoxPosY.Text = renderer.GetCurrentY();
            this.txtBoxDx.Text = renderer.GetCurrentRangeStart();
            this.txtBoxDy.Text = renderer.GetCurrentRangeEnd();
            this.lblTimer.Text = renderer.GetRenderingTime();
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
            this.picBox.Image = renderer.RenderMandelbrot(zoomStart, zoomEnd, iterations);
            this.UpdateFormFields();
        }


        private void btnRender_Click(object sender, EventArgs e)
        {
            this.iterations = (int)iterationsUpDown.Value;
            this.backgroundWorker.RunWorkerAsync();
            this.isFractalRendered = true;
            this.picBox.Cursor = Cursors.Cross;
        }


        private void picBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !backgroundWorker.IsBusy && isFractalRendered)
            {
                this.zoomStart = new Point(e.X, e.Y);
                Point rectStart = picBox.PointToScreen(new Point(e.X, e.Y));
                this.zoomRectangle = new Rectangle(rectStart.X, rectStart.Y, 0, 0);
                this.isZooming = true;
            }
        }
        private void picBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (isZooming && !backgroundWorker.IsBusy && isFractalRendered)
            {
                this.backgroundWorker.RunWorkerAsync();
            }

            this.zoomStart = Point.Empty;
            this.zoomEnd = Point.Empty;
            this.isZooming = false;
        }


        private void picBox_MouseMove(object sender, MouseEventArgs e)
        {
          
                if (isZooming && MouseIsOverPicture(this.picBox) && !backgroundWorker.IsBusy && isFractalRendered)
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

                    this.zoomEnd = new Point((int)(zoomStart.X + zoomWidth), (int)(zoomStart.Y + zoomHeight));

                    this.zoomRectangle.Width = (int)zoomWidth;
                    this.zoomRectangle.Height = (int)zoomHeight;

                    ControlPaint.DrawReversibleFrame(zoomRectangle, this.BackColor, FrameStyle.Dashed);
                }
        }
        #endregion
    }
}
