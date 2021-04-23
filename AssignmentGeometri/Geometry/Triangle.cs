using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentGeometri.Geometry
{
    /// <summary>
    /// kommentarer är alltid bra att ha ;)
    /// </summary>
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
            return (Base * Height) / 2;
        }

        public override float GetPerimeter()
        {
            return Base + (Height * 2);
        }
    }
}
