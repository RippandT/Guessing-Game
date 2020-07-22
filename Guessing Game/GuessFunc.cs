using System;

namespace GuessingNumbers
{
    public class GuessFunc
    {
        /* Variables */
        public int highNum;
        public int randomNum;
        public int tries;
        public int diffiSetting;
        public int attempt;
        public int loop = 0;
        public bool win = false;
        public bool gameRun = true;
        public bool diffiChoice = true;
        
        public void endGame() //Endgame result and play again prompt
        {
            Console.Clear();

            if (win)
            {
                Console.WriteLine("CONGRATULATIONS!");
                Console.WriteLine("YOU GOT THE NUMBER! The number was {0}!\n", randomNum);
            }
            else
            {
                Console.WriteLine("YOU LOST!");
                Console.WriteLine("The number was {0}. Better luck next time\n", randomNum);
            }

            Console.WriteLine("Do you want to play again? [Y/N]");
            bool exit = true;
            while (exit)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Y:
                        Console.Clear();
                        loop = 0;
                        diffiChoice = true;
                        win = false;
                        exit = false;
                        break;
                    case ConsoleKey.N:
                        Console.Clear();
                        Console.WriteLine("THANK YOU FOR PLAYING MY GAME!");
                        Console.WriteLine("..Press any key to exit...");
                        gameRun = false;
                        exit = false;
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
            }
        }
        public void checker(int guess) //Number checker
        {
            if (guess < randomNum)
            {
                Console.WriteLine("The number is too low, guess higher");
            }
            else if (guess > randomNum)
            {
                Console.WriteLine("The number is too high, guess lower");
            }
            else
            {
                win = true;
            }

            attempt = guess; //Return
        }
        public void difficulty() //Difficulty selection
        {
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.E:
                    highNum = 11;
                    tries = 5;
                    diffiSetting = 0;
                    diffiChoice = false;
                    break;
                case ConsoleKey.M:
                    highNum = 16;
                    tries = 4;
                    diffiSetting = 1;
                    diffiChoice = false;
                    break;
                case ConsoleKey.H:
                    highNum = 21;
                    tries = 3;
                    diffiSetting = 2;
                    diffiChoice = false;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("===== Guess the Number =====\n");
                    Console.WriteLine("Wrong input, try again\n");
                    break;
            }
        }
    }
}
