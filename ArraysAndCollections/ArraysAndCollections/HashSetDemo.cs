using System;
using System.Collections.Generic;


namespace ArraysAndCollections
{
    //  This program demo how to use HashSet generic class.
    class HashSetDemo
    {
        static void Main()
        {
           
            HashSet<int> intHash = new HashSet<int>();
            intHash.Add(100);
            intHash.Add(101);
            intHash.Add(100);
            intHash.Add(101);
            intHash.Add(102);

            foreach(var num in intHash)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}
