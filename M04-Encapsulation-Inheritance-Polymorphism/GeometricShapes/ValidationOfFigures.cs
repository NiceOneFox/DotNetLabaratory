using System;

namespace GeometricShapes
{
    public static class ValidationOfFigures
    {
        public static void CheckIfLessOrEqualZero(double side)
        {
            if (side <= 0)
            {
                throw new ArgumentException($"Length of side {side} can not be less or equal 0");
            }
        }

        public static void CheckIfTriangle(double sideA, double sideB, double sideC)
        {
            if (sideA + sideB <= sideC)
            {
                throw new ArgumentException($"Sum of two sides {sideA} + {sideB} can not be less than third side {sideC}");
            }
        }
    }
}
