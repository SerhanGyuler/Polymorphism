namespace Polymorphism
{
    internal class Square : Geometry 
    {
        public double Side { get; set; }


        public Square()
        {
            Side = 4;
        }
        // Class is virtual so its overrideable

        public override double Area()
        {
            return Side * Side;
        }
    }
}
