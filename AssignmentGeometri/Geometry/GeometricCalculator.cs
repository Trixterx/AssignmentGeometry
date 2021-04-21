using AssignmentGeometri.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentGeometri.Geometry
{
    public class GeometricCalculator
    {
        public float GetArea(GeometricThing thing)
        {
            return 0;
        }
        public float GetPerimeter(GeometricThing thing)
        {
            return 0;
        }
        public float GetPerimeter(GeometricThing[] thing)
        {
            foreach (var shape in thing)
            {
                if (shape is Square s)
                {
                    return s.GetPerimeter();
                }
                else if (shape is Rectangle r)
                {
                    return r.GetPerimeter();
                }
            }
            return 0;
        }
    }
}
