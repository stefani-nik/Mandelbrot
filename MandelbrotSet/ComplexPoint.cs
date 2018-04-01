using System;

namespace MandelbrotSet
{
    public struct ComplexPoint
    {

        public ComplexPoint(double real, double imaginary)
        {
            this.Re = real;
            this.Im = imaginary;
        }

        public double Re { get; private set; }

        public double Im { get; private set; }
      

        public double GetModulus()
        {
            return Math.Sqrt(this.Re * this.Re + this.Im * this.Im);
        }

        public void GetSqrt()
        {
            double temp = (this.Re * this.Re) - (this.Im * this.Im);
            this.Im = 2.0 * this.Re * this.Im;
            this.Re = temp;
        }

        public void Add(ComplexPoint c)
        {
            this.Re += c.Re;
            this.Im += c.Im;
        }
    }
}
