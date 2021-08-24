using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            SideA = firstSide;
            SideB = secondSide;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Square of rectangle</returns>
        public double GetArea()
        {
            return SideA * SideB;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Summ sides of rectangle</returns>
        public double GetPerimeter()
        {
            return (2 * SideA) + (2 * SideB);
        }
    }
}
