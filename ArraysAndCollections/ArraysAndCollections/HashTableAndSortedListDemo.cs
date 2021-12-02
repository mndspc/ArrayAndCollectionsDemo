using System;
using System.Collections;

namespace ArraysAndCollections
{
    class HashTableAndSortedListDemo
    {
        static void Main()
        {
            
            Hashtable hashtable = new Hashtable();
            hashtable.Add("MH", 24);
            hashtable.Add("GJ",27);
            hashtable.Add("DL",12);

            Console.WriteLine($"Count is:{hashtable.Count}");
            Console.WriteLine($"State Code for Maharashtra is:{hashtable["MH"]}");
            hashtable["MH"] = 29;
            Console.WriteLine($"State Code for Maharashtra is:{hashtable["MH"]}");

            foreach(var key in hashtable.Keys)
            {
                Console.WriteLine($"Key={key} and Value={hashtable[key]}");
            }

            hashtable.Remove("DL");
            Console.WriteLine("After removing DL");
            foreach (var key in hashtable.Keys)
            {
                Console.WriteLine($"Key={key} and Value={hashtable[key]}");
            }

            Console.WriteLine("*******SortedList*************");
            SortedList sortedList = new SortedList();
            sortedList.Add("MH", 24);
            sortedList.Add("GJ", 27);
            sortedList.Add("DL", 12);
            foreach (var key in sortedList.Keys)
            {
                Console.WriteLine($"Key={key} and Value={sortedList[key]}");
            }

            Console.ReadLine();
        }
    }
}
