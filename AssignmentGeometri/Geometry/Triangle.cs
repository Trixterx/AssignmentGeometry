using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentGeometri.Geometry
{
    public class Triangle : GeometricThing
    {
        public float Height { get; set; }
        public float Width { get; set; }

        public Triangle(int height, int width)
        {
            Height = height;
            Width = width;
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
