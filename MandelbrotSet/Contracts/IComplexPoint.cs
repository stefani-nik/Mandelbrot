namespace MandelbrotSet.Contracts
{
    interface IComplexPoint
    {
        double GetModulus();
        void GetSqrt();
        void Add(ComplexPoint c);
    }
}
