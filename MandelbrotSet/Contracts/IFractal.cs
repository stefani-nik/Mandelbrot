using System.Drawing;

namespace MandelbrotSet.Contracts
{
    public interface IFractal
    {
        double PosX { get; }
        double PosY { get; }
        double RangeStart { get; }
        double RangeEnd { get;  }
        int GetNextPixel(int x, int y, int iterations);
        void AdjustParameters(Point zoomStart, Point zoomEnd);
    }
}
