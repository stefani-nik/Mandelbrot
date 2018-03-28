using System;

namespace MandelbrotSet
{
    public struct ComplexPoint
    {

        public double Re { get; set; }

        public double Im { get; set; }

        public ComplexPoint(double re, double im)
        {
            this.Re = re;
            this.Im = im;
        }

        public double GetModulus()
        {
            return Math.Sqrt(this.Re * this.Re + this.Im * this.Im);
        }

        public void GetSqrt()
        {
            double temp = (Re * Re) - (Im * Im);
            this.Im = 2.0 * Re * Im;
            Re = temp;
        }

        public void Add(ComplexPoint c)
        {
            Re += c.Re;
            Im += c.Im;
        }


    }
}
