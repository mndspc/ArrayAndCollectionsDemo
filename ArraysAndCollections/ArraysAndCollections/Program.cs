using System;


namespace ArraysAndCollections
{
    class Program
    {
        //  This program demo how to declare arrays.
        static void Main(string[] args)
        {
            
            //  how to declare array with default values
            int[] nums = {11,22,33,44,55,66 };

            int[] nums2 = new int[] { 11, 22, 33, 44, 55, 66 };

            //  how init. array with size
            int[] nums1 = new int[6];
            nums1[0] = 10;
            nums1[1] = 20;
            nums1[2] = 30;
            nums1[3] = 40;
            nums1[4] = 50;
            nums1[5] = 60;

            for(int i = 0; i <= 5; i++)
            {
                Console.Write($"{nums1[i]}\t");
            }
            Console.WriteLine();

            foreach(var num in nums1)
            {
                Console.Write($"{num}\t");
            }

            Console.ReadLine();
        }
    }
}
