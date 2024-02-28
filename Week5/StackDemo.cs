using System;
using System.Collections.Generic;
namespace Week5.Task6;
class StackDemo
{
    static void Main(string[] args)
    {
        // Creating a stack of integers
        Stack<int> stack = new Stack<int>();

        // 1. Pushing elements onto the stack
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        // 2. Peeking at the top element of the stack
        int topElement = stack.Peek();
        Console.WriteLine("Top element of the stack: " + topElement);

        // 3. Checking if the stack contains an element
        bool contains20 = stack.Contains(20);
        Console.WriteLine("Stack contains 20: " + contains20);

        // 4. Popping elements off the stack
        int poppedElement = stack.Pop();
        Console.WriteLine("Popped element from the stack: " + poppedElement);

        // 5. Checking if the stack is empty
        bool isEmpty = stack.Count == 0;
        Console.WriteLine("Stack is empty: " + isEmpty);

        // Additional operation: Printing all elements in the stack
        Console.WriteLine("Elements in the stack:");
        foreach (int item in stack)
        {
            Console.WriteLine(item);
        }
    }
}
