using System.Globalization;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array for instances
            Geometry[] shape = new Geometry[]
            {
                new Circle(),
                new Square(),
                new Rectangle(),
            };

            // Loop to write out the resault
            for (int i = 0; i < shape.Length; i++)
            {
                // This calls the overridden Area methods
                Console.WriteLine($"Area: {Math.Round(shape[i].Area(), 2)} cm²");

            }

            // The reason for adding all the instances to an array is to be able to
            // write out all the instances by only one loop
        }
    }
}
