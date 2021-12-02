using System;
using System.Collections;


namespace ArraysAndCollections
{
    //  This program demo how to use ArrayList class.
    class ArrayListDemo
    {
        static void Main()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(100);//rollno
            arrayList.Add("Scott");//name
            arrayList.Add('M');//gender
            arrayList.Add(true);//isNewlyEnrolled
            arrayList.Add(8446725677);
            arrayList.Capacity = arrayList.Count;
            Console.WriteLine($"Count:{arrayList.Count} and Capacity:{arrayList.Capacity}");

            arrayList.Remove("Scott");
            arrayList.Capacity = arrayList.Count;
            Console.WriteLine($"Count:{arrayList.Count} and Capacity:{arrayList.Capacity}");

            Console.WriteLine("After removing Scott");
            foreach(var arr in arrayList)
            {
                Console.WriteLine(arr);
            }
            var result = arrayList.Contains(100) ? "RollNo is present" :"Roll No is not present";
            Console.WriteLine(result);

            arrayList.Clear();
            arrayList.Capacity = arrayList.Count;
            Console.WriteLine($"Count:{arrayList.Count} and Capacity:{arrayList.Capacity}");

            Console.ReadLine();
        }
    }
}
