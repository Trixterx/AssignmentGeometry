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
            return 0;
        }

        public override float GetPerimeter()
        {
            return 0;
        }
    }
}
