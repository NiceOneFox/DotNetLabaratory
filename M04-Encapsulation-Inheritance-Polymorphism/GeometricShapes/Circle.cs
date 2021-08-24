using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    public class Circle : ICircle
    {
        public double Radius { get; private set; }

        public Circle(double R)
        {
            Radius = R;
        }
        public double GetCircumference()
        {
            return 2 * Math.PI * Math.Pow(Radius, 2);// 2PiR^2
        }

        public double GetRadius()
        {
            return Radius;
        }
    }
}
