using System;
using AbstractShapeDemo.Models;

namespace AbstractShapeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Circle and Rectangle
            Circle circle = new Circle(5.0);
            Rectangle rectangle = new Rectangle(4.0, 6.0);

            // Display their areas
            Console.WriteLine("Circle area: " + circle.GetArea());
            Console.WriteLine("Rectangle area: " + rectangle.GetArea());
        }
    }
}
