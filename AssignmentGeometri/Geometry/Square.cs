﻿namespace AssignmentGeometri
{
    public class Square : GeometricThing
    {
        public float Side { get; set; }

        public Square(int side)
        {
            Side = side;
        }

        public override float GetArea()
        {
            return -1;
            //return (float)Math.Pow(Side, 2);
        }

        public override float GetPerimeter()
        {
            return -1;
            //return 4 * Side;
        }
    }
}
