using System;
using System.Drawing;
using MandelbrotSet.Contracts;

namespace MandelbrotSet.Common
{
    public class PointMapper : IPointMapper
    {

        /// <summary>
        /// According to the given parameters calculates the coordinates
        /// of the point so that they correspond to coordinates in the given range 
        /// </summary>
        public Tuple<double,double> MapPoint(Point p, double posX, double posY,
                                                    double rangeStart, double rangeEnd)
        {
         
            double newPosX = posX - 0.5 * rangeStart;
            double newPosY = posY - 0.5 * rangeEnd;

            double dxf = rangeStart * p.X / Constants.BitmapWidth;
            double dyf = rangeEnd * p.Y / Constants.BitmapHeight;


            double newX = newPosX + dxf;
            double newY = newPosY + dyf;

            return  Tuple.Create(newX, newY);
        }


    }
}
