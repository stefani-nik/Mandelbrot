using System.Collections.Generic;
using System.Drawing;

namespace MandelbrotSet.Common
{
    public static class ColorsManager
    {
        public static int interval = Constants.ColorsInterval;
        public static readonly List<Color> colors = new List<Color>();

        public static List<Color> LoadPalette()
        {
            for  (int green = 0; green < 255; green += interval)
            {
                for (int blue = 0; blue < 255; blue += interval)
                {
                    for (int red = 0; red < 255; red += interval)
                    {
                        ColorsManager.colors.Add(Color.FromArgb(255, red, green, blue));
                    }
                }
            }
            return ColorsManager.colors;
        }

    }
}
