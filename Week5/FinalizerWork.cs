using System;
namespace Week5.Task4
{
    class MyClass
    {
        // Finalizer (destructor)
        ~MyClass()
        {
            Console.WriteLine("Finalizer (destructor) called");
        }
    }

    class FinalizerWork
    {
        static void Main(string[] args)
        {
            // Creating an instance of MyClass
            MyClass obj = new MyClass();

            // Let's make the object eligible for garbage collection
            obj = null;

            // Force garbage collection to occur (usually not needed in normal programs)
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("End of Main method");
        }
    }
}