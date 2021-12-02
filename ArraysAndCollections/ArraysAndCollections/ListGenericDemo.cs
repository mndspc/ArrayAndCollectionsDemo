using System;
using System.Collections.Generic;


namespace ArraysAndCollections
{
    //  This program demo how to use Generic Collection Classes.
    class ListGenericDemo
    {
        static void Main()
        {
            List<int> intList = new List<int>();
            intList.Add(100);
            intList.Add(101); ;
            //intList.Add("abc");//error
            foreach(var num in intList)
            {
                Console.WriteLine(num);
            }

            List<Employee> employees = new List<Employee>();
            Employee employee1 = new Employee {EmpCode=100,EmpName="Scott",Email="scott@gmail.com" };
            Employee employee2 = new Employee { EmpCode = 101, EmpName = "Tiger", Email = "tiger@gmail.com" };
            employees.Add(employee1);
            employees.Add(employee2);

          
            foreach(var emp in employees)
            {
                Console.WriteLine($"Code={emp.EmpCode}\tName={emp.EmpName}\tEmail={emp.Email}");
            }
            employees.Remove(employee1);
            Console.WriteLine("After removing Employee1");
            foreach (var emp in employees)
            {
                Console.WriteLine($"Code={emp.EmpCode}\tName={emp.EmpName}\tEmail={emp.Email}");
            }

            Console.ReadLine();
        }
    }

    class Employee
    {
        public int EmpCode { get; set; }
        public string EmpName { get; set; }
        public string Email { get; set; }
    }
}
