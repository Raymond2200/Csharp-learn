using System;

namespace tttcsharp
{
    class Program
    {
        static sbyte status = 1;
        static int input;


        static char[,] boardStatus =
        {
            {'1','2','3'},
            {'4','5','6'},
            {'7','8','9'}
        };
        static void Main(string[] args)
        {
            int player = 2;
            bool inputCorrect = true;

            

            do
            {
                SetBoard();

                #region


                char[] playerChars = { 'X', 'O' };

                foreach(char playerChar in playerChars)
                {
                    if ((boardStatus[0, 0] == playerChar) && (boardStatus[0, 1] == playerChar) && (boardStatus[0, 2] == playerChar))
                        Console.WriteLine("we have a winner!");
                    if ((boardStatus[1, 0] == playerChar) && (boardStatus[1, 1] == playerChar) && (boardStatus[1, 2] == playerChar))
                        Console.WriteLine("we have a winner!");
                    if ((boardStatus[2, 0] == playerChar) && (boardStatus[2, 1] == playerChar) && (boardStatus[2, 2] == playerChar))
                        Console.WriteLine("we have a winner!");
                    if ((boardStatus[0, 0] == playerChar) && (boardStatus[0, 0] == playerChar) && (boardStatus[0, 0] == playerChar))
                        Console.WriteLine("we have a winner!");
                    if ((boardStatus[1, 0] == playerChar) && (boardStatus[1, 0] == playerChar) && (boardStatus[1, 0] == playerChar))
                        Console.WriteLine("we have a winner!");
                    if ((boardStatus[2, 0] == playerChar) && (boardStatus[2, 0] == playerChar) && (boardStatus[2, 0] == playerChar))
                        Console.WriteLine("we have a winner!");
                    if ((boardStatus[0, 0] == playerChar) && (boardStatus[1, 1] == playerChar) && (boardStatus[2, 2] == playerChar))
                        Console.WriteLine("we have a winner!");
                    if ((boardStatus[0, 2] == playerChar) && (boardStatus[1, 1] == playerChar) && (boardStatus[2, 0] == playerChar))
                        Console.WriteLine("we have a winner!");
                }

                #endregion

                do
                {
                    Console.WriteLine("Player {0} make your play!", status);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a number");
                    }

                    if ((input == 1) && (boardStatus[0, 0] == '1'))
                        inputCorrect = true;
                    else if ((input == 2) && (boardStatus[0, 1] == '2'))
                    inputCorrect = true;
                    else if ((input == 3) && (boardStatus[0, 2] == '3'))
                    inputCorrect = true;
                    else if ((input == 4) && (boardStatus[1, 0] == '4'))
                        inputCorrect = true;
                    else if ((input == 5) && (boardStatus[1, 1] == '5'))
                        inputCorrect = true;
                    else if ((input == 6) && (boardStatus[1, 2] == '6'))
                        inputCorrect = true;
                    else if ((input == 7) && (boardStatus[2, 0] == '7'))
                        inputCorrect = true;
                    else if ((input == 8) && (boardStatus[2, 1] == '8'))
                        inputCorrect = true;
                    else if ((input == 9) && (boardStatus[1, 2] == '9'))
                        inputCorrect = true;
                    else
                    {
                        Console.WriteLine(" Incorrect input! please use another field");
                        inputCorrect = false;
                    }
                } while (!inputCorrect);

                EnterXorO();
            } while (true);
            

        }


        
        public static void SetBoard()
        {
            string blank = "   |   |   ";
            string bottom = "___|___|___";
            Console.Clear();
            Console.WriteLine(blank);
            Console.WriteLine(" {0} | {1} | {2} ", boardStatus[0,0], boardStatus[0, 1], boardStatus[0, 2]);
            Console.WriteLine(bottom);
            Console.WriteLine(blank);
            Console.WriteLine(" {0} | {1} | {2} ", boardStatus[1, 0], boardStatus[1, 1], boardStatus[1, 2]);
            Console.WriteLine(bottom);
            Console.WriteLine(blank);
            Console.WriteLine(" {0} | {1} | {2}", boardStatus[2, 0], boardStatus[2, 1], boardStatus[2, 2]);
            Console.WriteLine(blank);
        }

        public static void EnterXorO()
        {
            char playerSign = ' ';
            if (status == 1)
            {
                playerSign = 'X';
                status = 2;
            }
            else if (status == 2)
            {
                playerSign = 'O';
                status = 1;
            }
            


            switch (input)
            {
                case 1: boardStatus[0, 0] = playerSign; break;
                case 2: boardStatus[0, 1] = playerSign; break;
                case 3: boardStatus[0, 2] = playerSign; break;
                case 4: boardStatus[1, 0] = playerSign; break;
                case 5: boardStatus[1, 1] = playerSign; break;
                case 6: boardStatus[1, 2] = playerSign; break;
                case 7: boardStatus[2, 0] = playerSign; break;
                case 8: boardStatus[2, 1] = playerSign; break;
                case 9: boardStatus[2, 2] = playerSign; break;
            }
        }
    }
}
