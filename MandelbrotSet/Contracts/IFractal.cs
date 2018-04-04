using System.Drawing;

namespace MandelbrotSet.Contracts
{
    public interface IFractal
    {
        double XStartValue { get; }
        double YStartValue { get; }
        double XRange { get; }
        double YRange { get;  }
        int GetNextPixel(int x, int y, int iterations);
        void AdjustParameters(Point zoomStart, Point zoomEnd);
    }
}
