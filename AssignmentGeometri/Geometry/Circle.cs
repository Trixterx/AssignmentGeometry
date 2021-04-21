using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentGeometri.Geometry
{
    public class Circle : GeometricThing
    {
        public float Radius { get; set; }

        public Circle(float radius)
        {
            Radius = radius;
        }

        public override float GetArea()
        {
            return -1;
            //return (float)Math.Pow(side, 2)
        }

        public override float GetPerimeter()
        {
            return -1;
            //return 4 * side;
        }
    }
}
