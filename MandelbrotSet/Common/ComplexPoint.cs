using System;
using MandelbrotSet.Contracts;

namespace MandelbrotSet.Common
{
    /// <summary>
    /// Struct which works with complex numbers and their calculations
    /// Each complex number consists of a real and imaginary part 
    /// Complex numbers are expressed in the form a + b*i
    /// </summary>
    public struct ComplexPoint : IComplexPoint
    {

        public ComplexPoint(double real, double imaginary)
        {
            this.Re = real;
            this.Im = imaginary;
        }

        public double Re { get; private set; }

        public double Im { get; private set; }
      
  
        /// <returns>The absolute value (modulus) of a complex number</returns>
        public double GetModulus()
        {
            return Math.Sqrt(this.Re * this.Re + this.Im * this.Im);
        }

        /// <summary>
        ///  Calculates the square root of a complex number
        /// </summary>
        public void Sqrt()
        {
            double temp = (this.Re * this.Re) - (this.Im * this.Im);
            this.Im = 2.0 * this.Re * this.Im;
            this.Re = temp;
        }

        /// <summary>
        /// Calculates the addition of two complex numbers
        /// </summary>
        public static ComplexPoint operator+(ComplexPoint c1, ComplexPoint c2)
        {
            return new ComplexPoint(c1.Re + c2.Re, c1.Im + c2.Im);
        }

    }
}
