using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(double a) : base(a, a, a)
        {
        }

        /// <returns>h of Triangle</returns>
        public double GetHeight()
        {
            return (SideA * Math.Sqrt(3)) / 2;
        }
    }
}
