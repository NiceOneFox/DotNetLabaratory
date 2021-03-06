using System;

namespace GeometricShapes
{
    public class Circle : ICircle, ITwoDimensionalShape
    {
        public double Radius { get; private set; }

        public Circle(double R)
        {
            ValidationOfFigures.CheckIfLessOrEqualZero(R);

            Radius = R;
        }

        public double GetRadius()
        {
            return Radius;
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;// 2PiR
        }

        public double GetArea()
        {
            return 2 * Math.PI * Math.Pow(Radius, 2);// 2PiR^2
        }
    }
}
