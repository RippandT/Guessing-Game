using System;

namespace GuessingNumbers
{
    public enum Settings
    {
        Easy,
        Medium,
        Hard
    }
    class Program
    {
        static void Main(string[] args)
        {
            /* Class Calls */
            GuessFunc funct = new GuessFunc();
            Random rng = new Random();

            /* Main Program */
            while (funct.gameRun)
            {
                /* Difficulty Selection */
                Console.WriteLine("===== Guess the Number =====\n");
                while (funct.diffiChoice)
                {
                    Console.WriteLine("Select difficulty: (Enter the corresponding letter)\n");
                    Console.WriteLine("[E]asy - 5 tries. Numbers 1-10");
                    Console.WriteLine("[M]edium - 4 tries. Numbers 1-15");
                    Console.WriteLine("[H]ard - 3 tries. Numbers 1-20");

                    funct.difficulty(); // the prompt
                }

                funct.randomNum = rng.Next(1, funct.highNum); // Set the random number
                Console.Clear(); //Clears screen before the game starts

                /* The Game */
                while (funct.loop < funct.tries)
                {
                    Console.Write(Enum.GetName(typeof(Settings), funct.diffiSetting));
                    Console.WriteLine(". {0} / {1} tries", funct.loop + 1, funct.tries);
                    Console.Write("Guess the number: ");
                    int guess;
                    if (int.TryParse(Console.ReadLine(), out guess) && guess < funct.highNum)
                    {
                        Console.Clear();
                        funct.checker(guess);
                        if (funct.win) { break; }
                        Console.WriteLine("Last guess: {0}\n", funct.attempt);
                        funct.loop++;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Wrong input");
                        Console.WriteLine("Last guess: {0}\n", funct.attempt);
                    }
                }

                funct.endGame();
            }
        }
    }
}
