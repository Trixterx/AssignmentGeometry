using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentGeometri.Geometry
{
    public class Triangle : GeometricThing
    {
        public float Side1 { get; set; }
        public float Side2 { get; set; }

        public Triangle(int side1, int side2)
        {
            this.Side1 = side1;
            this.Side2 = side2;
        }

        public override float GetArea()
        {
            return 0;
            //return (float)Math.Pow(side, 2)
        }

        public override float GetPerimeter()
        {
            return 0;
            //return 4 * side;
        }
    }
}
