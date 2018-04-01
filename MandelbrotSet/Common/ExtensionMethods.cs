namespace MandelbrotSet.Common
{
    public static class ExtensionMethods
    {
        public static double Remap(int value,
                                double fromBegin, double fromEnd,
                                double toBegin, double toEnd)
        {
            double scale = (double) (toEnd - toBegin)/(fromEnd - fromBegin);
            double result = toBegin + ((value - fromBegin)*scale);
            return result;
        }


    }
}
