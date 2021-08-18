using System;

namespace RectangleHelper
{
    public static class Rectangle
    {
        public static double Perimeter(double a, double b)
        {
            if (a <= 0 || b <= 0)
            {
                throw new ArgumentOutOfRangeException("Lenght of side can not be less than 0 or equal");
            }
            return (2 * a) + (2 * b);
        }

        public static double Square(double a, double b)
        {
            if (a <= 0 || b <= 0)
            {
                throw new ArgumentOutOfRangeException("Lenght of side can not be less than 0 or equal");
            }
            return a * b;
        }
    }
}
