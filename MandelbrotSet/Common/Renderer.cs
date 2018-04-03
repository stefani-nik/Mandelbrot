using System.Collections.Generic;
using System.Drawing;
using MandelbrotSet.Contracts;

namespace MandelbrotSet.Common
{
    public class Renderer : IRenderer
    {
        private readonly List<Color> palette;
        private int bitmapWidth = Constants.BitmapWidth;
        private int bitmapHeight = Constants.BitmapHeight;
        public Bitmap Bitmap;

        public Renderer()
        {
            this.palette = ColorsManager.LoadPalette();
            this.Bitmap = new Bitmap(this.bitmapWidth, this.bitmapHeight);
        }
        

        public Bitmap RenderMandelbrot()
        {
            for (int y = 0; y < bitmapHeight; y++)
            {
                for (int x = 0; x < bitmapWidth; x++)
                {
                    
                }
            }

            return Bitmap;
        }
    }
}
