using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5];
            grades[0] = 20;
            grades[1] = 15;

            int[] gradesMath = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };


            int[] gradesBMath = new int[] { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine(gradesMath.Length);

            int[] nums = new int[10];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i;
            }

            foreach(int k in nums)
            {

            }

        }

    }
}
