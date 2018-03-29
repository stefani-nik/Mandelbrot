using System;
using MandelbrotSet.Contracts;

namespace MandelbrotSet
{
    public struct ComplexPoint : IComplexPoint
    {

        public ComplexPoint(double real, double imaginary)
        {
            this.Re = real;
            this.Im = imaginary;
        }

        public double Re { get; set; }

        public double Im { get; set; }
      

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
