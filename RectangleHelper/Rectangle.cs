using System;

namespace RectangleHelper
{
    public static class Rectangle
    {
        private static void ValidationOfRectangleSides(double a, double b)
        {
            if (a <= 0) 
            {
                throw new ArgumentOutOfRangeException($"Lenght of side a: {a}  can not be less than 0 or equal");
            }
            if (b <= 0)
            {
                throw new ArgumentOutOfRangeException($"Lenght of side b: {b}  can not be less than 0 or equal");
            }     
        }
        public static double GetPerimeter(double a, double b)
        {
            ValidationOfRectangleSides(a, b);    
            
            return (2 * a) + (2 * b);
        }

        public static double GetSquare(double a, double b)
        {
            ValidationOfRectangleSides(a, b);       
            
            return a * b;                
        }
       
    }
}
