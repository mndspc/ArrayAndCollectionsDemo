using System;
using System.Collections.Generic;


namespace ArraysAndCollections
{
    //  This program demo how to use generic Stack and Queue
    class QueueAndStackGenericDemo
    {
        static void Main()
        {
            Queue<int> intQueue = new Queue<int>();
            intQueue.Enqueue(100);
            intQueue.Enqueue(101);
            intQueue.Enqueue(102);
            //intQueue.Enqueue("hello");//error
            foreach(var num in intQueue)
            {
                Console.WriteLine(num);
            }

            Queue<Employee> employees = new Queue<Employee>();
            Employee employee1 = new Employee { EmpCode = 100, EmpName = "Scott", Email = "scott@gmail.com" };
            Employee employee2 = new Employee { EmpCode = 101, EmpName = "Tiger", Email = "tiger@gmail.com" };
            employees.Enqueue(employee1);
            employees.Enqueue(employee2);
            foreach (var emp in employees)
            {
                Console.WriteLine($"Code={emp.EmpCode}\tName={emp.EmpName}\tEmail={emp.Email}");
            }
            employees.Dequeue();
            Console.WriteLine("After removing employee1");
            foreach (var emp in employees)
            {
                Console.WriteLine($"Code={emp.EmpCode}\tName={emp.EmpName}\tEmail={emp.Email}");
            }
            Console.ReadLine();
        }
    }
}
