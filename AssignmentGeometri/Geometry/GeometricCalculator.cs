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
            return 0;
        }
        public float GetPerimeter(GeometricThing[] thing)
        {
            if (thing is Square s)
            {
                return s.Side * s.Side;
            }

            return 0;
        }
    }
}
