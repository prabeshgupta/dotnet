using System;

namespace Week5.Task1
{

    // Define a struct named Point to represent a 2D point
    struct Point
    {
        public int X;
        public int Y;
    }

    class StructProgram
    {
        static void Main(string[] args)
        {
            // Declare a variable of type Point
            Point point1;

            // Assign values to the X and Y coordinates of the first point
            point1.X = 3;
            point1.Y = 5;

            // Declare and initialize another variable of type Point
            Point point2 = new Point { X = -2, Y = 7 };

            // Print out the coordinates of both points
            Console.WriteLine("First Point: (" + point1.X + ", " + point1.Y + ")");
            Console.WriteLine("Second Point: (" + point2.X + ", " + point2.Y + ")");
        }
    }
}