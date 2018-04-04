using System.Drawing;
using MandelbrotSet.Contracts;

namespace MandelbrotSet.Common
{
    /// <summary>
    /// The actual Mandelbrot set class
    /// </summary>
    public sealed class Mandelbrot : IFractal
    {

        public double PosX { get; private set; } = Constants.PositionX;

        public double PosY { get; private set; } = Constants.PositionY;

        public double RangeStart { get; private set; } = Constants.RangeStart;

        public double RangeEnd { get; private set; } = Constants.RangeEnd;

        private double xStartValue =  Constants.StartValueX;
        private double yStartValue = Constants.StartValueY;
        private double xOffset = Constants.StartOffsetX;
        private double yOffset = Constants.StartOffsetY;

        /// <summary>
        /// Calculates the next pixel with the equation Z(n+1) = Z(n)^2 + C
        /// </summary>
        public int GetNextPixel(int x, int y, int iterations)
        {
            
            double xValue = xStartValue + xOffset * x;
            double yValue = yStartValue + yOffset * y;

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

        public void AdjustParameters(Point zoomStart, Point zoomEnd)
        {
            IPointMapper mapper = new PointMapper();
            var mappedStartPoint = mapper.MapPoint(zoomStart, PosX, PosY, RangeStart, RangeEnd);
            var mappedEndPont = mapper.MapPoint(zoomEnd, PosX, PosY, RangeStart, RangeEnd);

            double startX = mappedStartPoint.Item1;
            double startY = mappedStartPoint.Item2;

            double endX = mappedEndPont.Item1;
            double endY = mappedEndPont.Item2;


            // Asign the fractal parameters
            this.PosX = (startX + endX) / 2.0;
            this.PosY = (startY + endY) / 2.0;
            this.RangeStart = endX - startX;
            this.RangeEnd = endY - startY;

            this.xStartValue = (this.PosX - this.RangeStart / 2.0);
            this.yStartValue = (this.PosY - this.RangeEnd / 2.0);
            this.xOffset = this.RangeStart / (double)Constants.BitmapWidth;
            this.yOffset = this.RangeEnd / (double)Constants.BitmapWidth;

        }

    }
}
