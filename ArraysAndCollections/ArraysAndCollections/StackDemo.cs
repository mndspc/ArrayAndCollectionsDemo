using System;
using System.Collections;

namespace ArraysAndCollections
{
    class StackDemo
    {
        static void Main()
        {
            Stack stack = new Stack();
            stack.Push(100);
            stack.Push(101);
            stack.Push(102);
            stack.Push(103);
            Console.WriteLine($"Count is:{stack.Count}");
            foreach(var stk in stack)
            {
                Console.WriteLine(stk);
            }
           
            Console.WriteLine($"{stack.Pop()} is removed");
            foreach (var stk in stack)
            {
                Console.WriteLine(stk);
            }
            Console.WriteLine($"{stack.Peek()} is next element to be removed");
            Console.ReadLine();
        }
    }
}
