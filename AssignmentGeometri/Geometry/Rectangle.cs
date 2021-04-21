using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentGeometri.Geometry
{
    public class Rectangle : GeometricThing
    {
        public float Height { get; set; }
        public float Width { get; set; }

        public Rectangle(float height, float width)
        {
            Height = height;
            Width = width;
        }

        public override float GetArea()
        {
            return Height * Width;
        }

        public override float GetPerimeter()
        {
            return (Height * 2) + (Width * 2);
        }
    }
}
