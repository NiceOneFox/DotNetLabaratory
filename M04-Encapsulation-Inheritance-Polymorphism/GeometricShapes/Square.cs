using System;

namespace GeometricShapes
{
    public class Square : ITwoDimensionalShape
    {
        public double SideA { get; private set; }
        public Square(double side)
        {
            SideA = side;
        }
        
        public double GetDiagonal()
        {
            return SideA * Math.Sqrt(2);
        }

        public double GetPerimeter()
        {
            return SideA * 4;
        }

        public double GetArea()
        {
            return Math.Pow(SideA, 2);
        }
    }
}
