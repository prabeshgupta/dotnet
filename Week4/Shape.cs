using System;
namespace Week4.Task3
{
    public class Shape
    {
        public virtual double CalculateArea()
        {
            return 0; // Base implementation for a generic shape
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("This is a generic shape.");
        }
    }

    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * radius * radius; // Area calculation specific to a circle
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Area of Circle: {CalculateArea():F2}");
        }
    }

    public class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double CalculateArea()
        {
            return length * width; // Area calculation specific to a rectangle
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Area of rectangle: {CalculateArea()}");
        }
    }

    class Program
    {
        static void Main()
        {
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(4, 6);

            circle.DisplayInfo();
            rectangle.DisplayInfo();
        }
    }
}