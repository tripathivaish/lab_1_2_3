using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_ASSIGNMENTS_2
{
    abstract class Shape
    {
        public abstract double CalculateArea();
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Circle circle = new Circle(5);
            Console.WriteLine($"Circle Area: {circle.CalculateArea():F2}");

            Rectangle rectangle = new Rectangle(4, 6);
            Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea():F2}");
            Console.ReadKey();
        }
    }
}
