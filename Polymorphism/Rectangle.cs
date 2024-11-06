namespace Polymorphism
{
    internal class Rectangle : Geometry
    {

        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle()
        {
            Length = 4;
            Width = 4;
        }
        // Override will override the method Area in Geometry Class
        public override double Area()
        {
            return Length * Width;
        }
    }
}
