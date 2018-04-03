using System;
using System.Drawing;

namespace MandelbrotSet.Contracts
{
    public interface IPointMapper
    {
        Tuple<double, double> MapPoint(Point p, double posX, double posY,
                                        double rangeStart, double rangeEnd);
    }
}
