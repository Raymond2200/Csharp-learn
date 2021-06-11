using System;

namespace chhallengeslists
{
    class Program
    {
        static void Main(string[] args)
        {

            string[,] matrix;

            int[,,] threeD;


            int[,] array2D = new int[,]
            {
                { 1,2,3},
                {4,5,6 },
                {7,8,9 }

            };

            string[,,] array3D = new string[,,]
             {
                {
                    {"000","001" },
                    {"010", "101" }
                },
                {
                    {"100", "101" },
                    {"110", "111" }
                }
             };

            Console.WriteLine("Central value is {0}", array3D[1, 1, 0]);

        }
    }
}
