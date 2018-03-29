using System.Collections.Generic;
using System.Drawing;

namespace MandelbrotSet
{
    public static class ColorsManager
    {
        public const int interval = 40;
        public static readonly List<Color> colors = new List<Color>();

        public static List<Color> LoadPalette()
        {
            for (int blue = 0; blue < 255; blue += interval)
            {
                for (int green = 0; green < 255; green+=interval)
                {
                    for (int red = 0; red < 255; red += interval)
                    {
                        ColorsManager.colors.Add(Color.FromArgb(255,red,green,blue));
                    }
                }
            }
            return ColorsManager.colors;
        }
        
    }
}
