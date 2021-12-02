using System;
using System.Collections;


namespace ArraysAndCollections
{
    //  This program demo how to use queue class.
    class QueueDemo
    {
        static void Main()
        {
            Queue queue = new Queue();
            queue.Enqueue(100);
            queue.Enqueue(101);
            queue.Enqueue(102);
            queue.Enqueue(103);

            Console.WriteLine($"Count:{queue.Count}");
            foreach(var q in queue)
            {
                Console.WriteLine(q);
            }

            Console.WriteLine($"{queue.Dequeue()} is removed");
            foreach (var q in queue)
            {
                Console.WriteLine(q);
            }
            Console.WriteLine($"{queue.Peek()} is next element to be removed");

            Console.ReadLine();

        }
    }
}
