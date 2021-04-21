using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentGeometri.Geometry
{
    public class Triangle : GeometricThing
    {
        public float Base { get; set; }
        public float Height { get; set; }

        public Triangle(float height, float bas)
        {
            Base = bas;
            Height = height;
        }

        public override float GetArea()
        {
            return 0;
        }

        public override float GetPerimeter()
        {
            return 0;
        }
    }
}
