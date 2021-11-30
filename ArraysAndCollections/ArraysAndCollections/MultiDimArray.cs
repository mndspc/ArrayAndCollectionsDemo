using System;


namespace ArraysAndCollections
{
    //  This program demo how to declare multi dim array.
    class MultiDimArray
    {
        static void Main()
        {
            int[,] numsArray = new int[,] { {1,2,3 },{4,5,6 } };

            int[,] numsArray1 = new int[2,3];

            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write($"{numsArray[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
