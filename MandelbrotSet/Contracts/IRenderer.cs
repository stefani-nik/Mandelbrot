using System.Drawing;

namespace MandelbrotSet.Contracts
{
    public interface IRenderer
    {
        Bitmap RenderMandelbrot(Point start, Point end, int iterations);
        string GetCurrentX();
        string GetCurrentY();
        string GetCurrentRangeStart();
        string GetCurrentRangeEnd();
        string GetRenderingTime();
    }
}
