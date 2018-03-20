using System;

namespace MandelbrotSet
{
    public struct ComplexPoint
    {

        public double Re { get; }

        public double Im { get; }

        public ComplexPoint(double re, double im)
        {
            this.Re = re;
            this.Im = im;
        }

        public double GetModulus()
        {
            return Math.Sqrt(this.Re * this.Re + this.Im * this.Im);
        }

        public double GetSqrt()
        {
            return this.Re * this.Re + this.Im * this.Im;
        }

        

    }
}
