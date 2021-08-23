using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    public class Triangle : TwoDimensionalShape
    {
        // Three sides of triangle
        public double SideA { get; private set; }

        public double SideB { get; private set; }

        public double SideC { get; private set; }

        public Triangle(double a, double b, double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
        }
        /// <summary>
        /// Gets area of triange using 3 sides
        /// </summary>
        public override double GetArea()
        {
            double p = GetPerimeter() / 2; // semiperimeter
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC)); //Heron Formula
        }

        public override double GetPerimeter()
        {
            return SideA + SideB + SideC;
        }
    }
}
