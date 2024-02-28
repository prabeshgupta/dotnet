using System;
namespace Week5.Task2
{
    class Box<T>
    {
        private T data;

        // Constructor to initialize the data member with a given value
        public Box(T data)
        {
            this.data = data;
        }

        // Method to get the stored value
        public T GetValue()
        {
            return data;
        }

        // Method to set a new value to the data member
        public void SetValue(T newData)
        {
            this.data = newData;
        }
    }

    class GenericClass
    {
        static void Main(string[] args)
        {
            // Creating instances of Box<T> with different types

            // Box for int
            Box<int> intBox = new Box<int>(10);
            Console.WriteLine("Initial value of intBox: " + intBox.GetValue());
            intBox.SetValue(20);
            Console.WriteLine("New value of intBox: " + intBox.GetValue());

            // Box for double
            Box<double> doubleBox = new Box<double>(3.14);
            Console.WriteLine("Initial value of doubleBox: " + doubleBox.GetValue());
            doubleBox.SetValue(6.28);
            Console.WriteLine("New value of doubleBox: " + doubleBox.GetValue());

            // Box for string
            Box<string> stringBox = new Box<string>("Hello");
            Console.WriteLine("Initial value of stringBox: " + stringBox.GetValue());
            stringBox.SetValue("World");
            Console.WriteLine("New value of stringBox: " + stringBox.GetValue());
        }
    }
}