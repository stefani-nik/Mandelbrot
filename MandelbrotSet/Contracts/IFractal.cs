using System.Drawing;

namespace MandelbrotSet.Contracts
{
    public interface IFractal
    {
        double PosX { get; set; }
        double PosY { get; set; }
        double RangeStart { get; set; }
        double RangeEnd { get; set; }
        int Iterations { get; set; }
        Bitmap RenderFractal();
        Bitmap ZoomFractal(Point zoomStart, Point zoomEnd);
    }
}
