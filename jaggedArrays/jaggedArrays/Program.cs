using System;

namespace jaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare jagged array
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[] { 2, 3, 4, 5, 6, 7 };
            jaggedArray[1] = new int[5];
            jaggedArray[2] = new int[2];


            int[][] jaggedArray2 = new int[][]
            {
                new int[] {2,3,4,5,6,7},
                new int[] {1,2,3,4,5}
            };

            for ( int i = 0; i < 2; i++)
            {
                foreach (int j in jaggedArray2[i])
                {
                    Console.WriteLine(j);
                };
            };

            Console.WriteLine("the value in the middle of the first entry is {0}", jaggedArray2[0][2]);
        }
    }
}
