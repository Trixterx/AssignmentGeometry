using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentGeometri
{
    public class Square : GeometricThing
    {
        public float Side { get; set; }

        public Square(int side)
        {
            this.Side = side;
        }

        public override float GetArea()
        {
            return (float)Math.Pow(Side, 2);
        }

        public override float GetPerimeter()
        {
            return 4 * Side;
        }
    }
}
