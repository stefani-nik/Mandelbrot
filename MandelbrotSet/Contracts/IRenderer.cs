using System.Drawing;

namespace MandelbrotSet.Contracts
{
    public interface IRenderer
    {
        Bitmap RenderMandelbrot();
    }
}
