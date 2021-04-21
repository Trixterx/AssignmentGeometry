using AssignmentGeometri.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentGeometri
{
    public class GeometricCalculator
    {
        public float GetArea(GeometricThing thing)
        {
            return 0;
        }
        public float GetPerimeter(GeometricThing thing)
        {
            if (thing is Square s)
            {

            }
            return 0;
        }
        public float GetPerimeter(GeometricThing[] thing)
        {
            foreach (var shape in thing)
            {
                if (shape is Square s)
                {
                    return s.Side * s.Side;
                }
                else if (shape is Rectangle r)
                {
                    return r.Height * r.Width;
                }
                else if (shape is Triangle t)
                {
                    return t.Base * t.Height;
                }
                else if (shape is Circle c)
                {
                    return c.Radius + c.Radius;
                }
            }
            return 0;
        }
    }
}
