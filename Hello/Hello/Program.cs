using System;

namespace Hello
{
    class Program
    {

        static void Main(string[] args)
        {
            int counter = 0;
            int scores = 0;
            string command = "";
            int score;
            bool scoreConvert;

            while (command != "-1")
            {
                Console.WriteLine("enter student score");
                command = Console.ReadLine();
                scoreConvert = int.TryParse(command, out score);
                if (scoreConvert)
                {
                    if (score == -1)
                    {
                        Console.WriteLine(scores / counter);
                        break;
                    }
                    else if (score >= 0 && score <= 20)
                    {
                        scores += score;
                        counter += 1;
                    }
                    else
                    {
                        Console.WriteLine("invalid entry, must be between 0 and 20 or -1");
                    }
                }
                else
                {
                    Console.WriteLine("you must enter a number");
                }
            }
        }
    }
}
