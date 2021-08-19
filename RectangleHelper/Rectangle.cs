using System;

namespace RectangleHelper
{
    public static class Rectangle
    {
        private static bool ValidationOfRectangleSides(double a, double b)
        {
            if (a <= 0) 
            {
                throw new ArgumentOutOfRangeException($"Lenght of side a: {a}  can not be less than 0 or equal");
            }
            if (b <= 0)
            {
                throw new ArgumentOutOfRangeException($"Lenght of side b: {b}  can not be less than 0 or equal");
            }
            return true;      
        }
        public static double Perimeter(double a, double b)
        {
            if (ValidationOfRectangleSides(a, b))
            {
                return (2 * a) + (2 * b);
            } 
            return -1d;
            
        }

        public static double Square(double a, double b)
        {
            if (ValidationOfRectangleSides(a, b))
            {
                return a * b;
            }
            return -1d;       
        }
       
    }
}
