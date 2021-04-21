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
            return Side * Side;
        }

        public override float GetPerimeter()
        {
            return Side * 4;
        }
    }
}
