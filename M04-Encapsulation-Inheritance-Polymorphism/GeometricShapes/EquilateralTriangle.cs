using System;

namespace GeometricShapes
{
    class EquilateralTriangle : ITwoDimensionalShape
    {
        public double SideA { get; private set; }
        public EquilateralTriangle(double side)
        {
            ValidationOfFigures.CheckIfLessOrEqualZero(side);

            SideA = side;
        }    

        /// <returns>h of Triangle</returns>
        public double GetHeight() 
        {
            return (SideA * Math.Sqrt(3)) / 2;
        }

        public double GetPerimeter()
        {
            return SideA * 3;
        }

        public double GetArea()
        {
            double p = GetPerimeter() / 2; // semiperimeter
            return Math.Sqrt(p * (p - SideA) * (p - SideA) * (p - SideA)); //Heron Formula
        }
    }
}
