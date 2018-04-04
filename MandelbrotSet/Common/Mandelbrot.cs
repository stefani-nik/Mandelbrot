using System.Drawing;
using MandelbrotSet.Contracts;

namespace MandelbrotSet.Common
{
    /// <summary>
    /// The actual Mandelbrot set class
    /// </summary>
    public sealed class Mandelbrot : IFractal
    {

        public double XStartValue { get; private set; } = Constants.StartValueX;

        public double YStartValue { get; private set; } = Constants.StartValueY;

        public double XRange { get; private set; } = Constants.XRange;

        public double YRange { get; private set; } = Constants.YRange;

        private double xOffset = Constants.StartOffsetX;
        private double yOffset = Constants.StartOffsetY;

        /// <summary>
        /// Calculates the next pixel with the equation Z(n+1) = Z(n)^2 + C
        /// </summary>
        public int GetNextPixel(int coordX, int coordY, int iterations)
        {

            double xValue = this.XStartValue + this.xOffset * coordX;
            double yValue = this.YStartValue + this.yOffset * coordY;

            ComplexPoint c = new ComplexPoint(xValue, yValue);
            ComplexPoint z = new ComplexPoint(0, 0);

            int it = 0;
            do
            {
                it++;
                z.Sqrt();
                z += c;

                if (z.GetModulus() > Constants.RangeRadius) break;

            } while (it < iterations);

            return it;
        }

        /// <summary>
        /// Adjusts the parameters of the set according to the zoom strat and end points
        /// </summary>
        public void AdjustParameters(Point zoomStart, Point zoomEnd)
        {
            double startX = this.XRange * zoomStart.X / Constants.BitmapWidth;
            double startY = this.YRange * zoomStart.Y / Constants.BitmapWidth;

            double endX = this.XRange * zoomEnd.X / Constants.BitmapWidth;
            double endY = this.YRange * zoomEnd.Y / Constants.BitmapWidth;


            this.XStartValue += startX;
            this.YStartValue += startY;

            this.XRange = endX - startX;
            this.YRange = endY - startY;

            this.xOffset = (endX - startX) / (double)Constants.BitmapWidth;
            this.yOffset = (endY - startY) / (double)Constants.BitmapWidth;

        }

    }
}
