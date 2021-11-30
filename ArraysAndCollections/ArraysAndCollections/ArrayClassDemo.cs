using System;


namespace ArraysAndCollections
{
    //  This program demo how to use Array base class
    class ArrayClassDemo
    {
        static void Main()
        {
            int[] numsArray = new int[] { 3, 12, 5, 7, 9, 11 };
            int[] dumsArray = new int[6];

            int[,] numsArray1 = new int[2,3];

            numsArray.CopyTo(dumsArray, 0);
            Console.WriteLine("After copying elements from numsArray to dumsArray");
            foreach(var num in dumsArray)
            {
                Console.Write($"{num}\t");
            }
            Console.WriteLine();

            Console.WriteLine($"Upperbound is:{numsArray.GetUpperBound(0)} Lowerbound is:{numsArray.GetLowerBound(0)}");
            Console.WriteLine($"Upperbound is:{numsArray1.GetUpperBound(0)} and {numsArray1.GetUpperBound(1)}");

            Console.WriteLine($"Rank is:{numsArray1.Rank}\t");
            Console.WriteLine($"Count is:{numsArray.Length}");
            Console.WriteLine($"Count is {numsArray1.GetLength(0)}");

            int[] nums = new int[] { 3, 12, 5, 7, 9, 11 };
            int[] dums = new int[6];
            Array.Copy(nums, dums, 6);

            Console.WriteLine("After copying elements from nums to dums");
            foreach(var num in dums)
            {
                Console.Write($"{num}\t");
            }
            Console.WriteLine();

            Array.Reverse(dums);
            Console.WriteLine("After reversing elements");
            foreach (var num in dums)
            {
                Console.Write($"{num}\t");
            }
            Console.WriteLine();
            Array.Sort(dums);
            Console.WriteLine("After sorting array dums");
            foreach (var num in dums)
            {
                Console.Write($"{num}\t");
            }
            Console.WriteLine();

            Console.WriteLine($"index of an element 9 is:{Array.IndexOf(dums, 9)}");
            Console.ReadLine();
        }
    }
}
