using System;

namespace NEsted_loops
{
    class Program
    {
        static int[,] matrix =
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };
        static void Main(string[] args)
        {
            foreach (int item in matrix)
            {
                Console.WriteLine(item + " ");
            }

            Console.WriteLine("This is our 2d Array printed using nested for loop");

            for (int i =0; i< matrix.GetLength(0); i++)
            {
                for (int j = 0; j<matrix.GetLength(1); j++)
                {
                    if ( matrix [i,j] %3 == 0)
                    {
                        Console.WriteLine(matrix[i, j]);
                    };
                }
            }
        }
    }
}
