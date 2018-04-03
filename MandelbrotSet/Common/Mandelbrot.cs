using System.Drawing;
using MandelbrotSet.Contracts;

namespace MandelbrotSet.Common
{
    public class Mandelbrot : IFractal
    {

        public double PosX { get; private set; } = Constants.PositionX;

        public double PosY { get; private set; } = Constants.PositionY;

        public double RangeStart { get; private set; } = Constants.RangeStart;

        public double RangeEnd { get; private set; } = Constants.RangeEnd;


        public int GetNextPixel(int x, int y, int iterations)
        {
            double xStartPos = (this.PosX - this.RangeStart / 2.0);
            double yStartPos = (this.PosY - this.RangeEnd / 2.0);
            double xOffset = this.RangeStart / (double)Constants.BitmapWidth;
            double yOffset = this.RangeEnd / (double)Constants.BitmapWidth;

            double coordY = yStartPos + yOffset * y;
            double coordX = xStartPos + xOffset * x;

            ComplexPoint c = new ComplexPoint(coordX, coordY);
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

            this.PosX = (startX + endX) / 2.0;
            this.PosY = (startY + endY) / 2.0;
            this.RangeStart = endX - startX;
            this.RangeEnd = endY - startY;
        }

    }
}
