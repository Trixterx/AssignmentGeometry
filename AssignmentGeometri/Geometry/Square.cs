using System;

namespace AssignmentGeometri
{
    public class Square : GeometricThing
    {
        public float Side { get; set; }

        public Square(float side)
        {
            Side = side;
        }

        public override float GetArea()
        {
            return (float)Math.Pow(Side, 2);
        }

        public override float GetPerimeter()
        {
            return Side * 4;
        }
    }
}
