using System;
using System.Collections.Generic;
namespace Week5.Task7;
class QueueDemo
{
    static void Main(string[] args)
    {
        // Creating a queue of integers
        Queue<int> queue = new Queue<int>();

        // 1. Enqueuing elements into the queue
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        // 2. Peeking at the front element of the queue
        int frontElement = queue.Peek();
        Console.WriteLine("Front element of the queue: " + frontElement);

        // 3. Checking if the queue contains an element
        bool contains20 = queue.Contains(20);
        Console.WriteLine("Queue contains 20: " + contains20);

        // 4. Dequeuing elements from the queue
        int dequeuedElement = queue.Dequeue();
        Console.WriteLine("Dequeued element from the queue: " + dequeuedElement);

        // 5. Checking if the queue is empty
        bool isEmpty = queue.Count == 0;
        Console.WriteLine("Queue is empty: " + isEmpty);

        // Additional operation: Printing all elements in the queue
        Console.WriteLine("Elements in the queue:");
        foreach (int item in queue)
        {
            Console.WriteLine(item);
        }
    }
}
