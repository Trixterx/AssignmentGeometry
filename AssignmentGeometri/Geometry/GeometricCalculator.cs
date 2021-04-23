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
            if (thing == null) { return 0; }
            else { return thing.GetArea(); }
        }

        public float GetPerimeter(GeometricThing[] thing)
        {
            if (thing == null) { return 0; }
            else
            {
                if (thing.Length == 1 && thing.Length > 0)
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
                        else if (shape is Triangle t)
                        {
                            return t.GetPerimeter();
                        }
                        else if (shape is Circle c)
                        {
                            return c.GetPerimeter();
                        }
                    }
                }
                else if (thing.Length > 1)
                {
                    float sum = 0F;
                    foreach (var shape in thing)
                    {
                        sum += shape.GetPerimeter();
                    }
                    return sum;
                }
            }
            return 0;
        }
    }
}
