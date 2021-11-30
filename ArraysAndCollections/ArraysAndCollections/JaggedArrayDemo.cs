using System;


namespace ArraysAndCollections
{
    //  This program demo how to work with JaggedArray
    class JaggedArrayDemo
    {
        static void Main()
        {
            int[][] numsArray = new int[2][];
            numsArray[0] = new int[3] {1,2,3 };
            numsArray[1] = new int[2] {4,5 };

            for(int i = 0; i < 2; i++)
            {
                foreach(var num in numsArray[i])
                {
                    Console.Write($"{num}\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
