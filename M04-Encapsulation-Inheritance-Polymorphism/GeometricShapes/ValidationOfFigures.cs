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

        public static void CheckIfTriangle(double SideA, double SideB, double SideC)
        {
            if (SideA + SideB <= SideC)
            {
                throw new ArgumentException($"Sum of two sides {SideA} + {SideB} can not be less than third side {SideC}");
            }
        }
    }
}
