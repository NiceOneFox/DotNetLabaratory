using System;

namespace GeometricShapes
{
    public class Rectangle : ITwoDimensionalShape
    {
        /// <summary>
        /// One of the side of Rectangle
        /// </summary>
        public double SideA { get; private set; }

        /// <summary>
        /// Second side of Rectangle
        /// </summary>
        public double SideB { get; private set; }

        public Rectangle(double firstSide, double secondSide)
        {
            ValidationOfFigures.CheckIfLessOrEqualZero(firstSide);
            ValidationOfFigures.CheckIfLessOrEqualZero(secondSide);

            SideA = firstSide;
            SideB = secondSide;
        }

        /// <returns>Square of rectangle</returns>
        public double GetArea()
        {
            return SideA * SideB;
        }

        /// <returns>Summ sides of rectangle</returns>
        public double GetPerimeter()
        {
            return (2 * SideA) + (2 * SideB);
        }
    }
}
