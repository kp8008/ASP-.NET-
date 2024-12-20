using System;

namespace Lab_3
{
    // Define the Shape interface
    public interface IShape
    {
        void Circle(double radius);
        void Triangle(double baseLength, double height);
        void Square(double side);
    }

    // Implement the Shape interface in a class named ShapeImpl
    public class ShapeImpl : IShape
    {
        public void Circle(double radius)
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine($"Area of Circle: {area}");
        }

        public void Triangle(double baseLength, double height)
        {
            double area = 0.5 * baseLength * height;
            Console.WriteLine($"Area of Triangle: {area}");
        }

        public void Square(double side)
        {
            double area = side * side;
            Console.WriteLine($"Area of Square: {area}");
        }
    }

}
