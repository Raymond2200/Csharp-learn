using System;

namespace jaggedchallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[][] friends = new string[][]
            {
                new string[]{"michael", "sandy"},
                new string[]{"jeff", "goeff"},
                new string[]{"andy", "woody"}
            };

            Console.WriteLine("Hi {0}, would like to introduce {1} to you", friends[0][0], friends[1][0]);
        }
    }
}
