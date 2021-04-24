using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentGeometri.Geometry
{
    /// <summary>
    /// Class for Circle shape.
    /// </summary>
    public class Circle : GeometricThing
    {
        public float Radius { get; set; }

        public Circle(float radius)
        {
            Radius = radius;
        }

        public override float GetArea()
        {
            return (float)Math.PI * (float)Math.Pow(Radius, 2);
        }

        public override float GetPerimeter()
        {
            return 2 * (float)Math.PI * Radius;
        }
    }
}
