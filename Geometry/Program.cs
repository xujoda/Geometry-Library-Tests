using Geometry_Library;

namespace Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Console.WriteLine(triangle.GetArea());

            var circle = new Circle(3);
            Console.WriteLine(circle.GetArea());

            var someShape = new Shape(3,4,3,4);
            Console.WriteLine(someShape.GetArea());

            Console.ReadLine();
        }
    }
}