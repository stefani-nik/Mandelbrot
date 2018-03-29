namespace MandelbrotSet.Common
{
    public static class ExtensionMethods
    {
        public static double Remap(int value,
                                int fromBegin, int fromEnd,
                                int toBegin, int toEnd)
        {
            double scale = (double) (toEnd - toBegin)/(fromEnd - fromBegin);
            double result = toBegin + ((value - fromBegin)*scale);
            return result;
        }
    }
}
