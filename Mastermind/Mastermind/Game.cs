using System;
using System.Collections.Generic;
using System.Text;

namespace Mastermind
{

    class Game
    {
        char[] colours = { 'Y', 'B', 'G', 'R', 'W', 'P', 'O' };
        Master _master;

        public Game()
        {
            _master = new Master(colours);
            
        }

        public void Run()
        {
            Console.Write("\nAvailable colours:   ");
            foreach (char colour in colours)
            {
                Console.Write(colour + "  ");
            }
            Console.WriteLine();


            for (int attempts = 9; attempts >= 0; --attempts)
            {
                if (Guess())
                {
                    Console.WriteLine("\nYou win!\n\n\n    Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                    return;
                }
                else
                {
                    Console.WriteLine("\n    You have {0} attempts remaining", attempts);
                }
            }
            Console.WriteLine("\n\n Out of attempts, you lose. Better luck next time!\n\n\n    Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }

        private bool Guess()
        {
            string guess;
            int Correct; int IncorrectPosition;

            Console.Write("\nEnter your guess: ");
            guess = Console.ReadLine();
            if (!validateGuess(guess))
            {
                Console.WriteLine("Invalid Input");
                return Guess();
            }
            else
            {
                _master.CheckString(guess, out Correct, out IncorrectPosition);
                Console.WriteLine("\n    Correct colour, correct position:     {0}\n    Correct colour, incorrect position:   {1}", Correct, IncorrectPosition);
                return Correct == 4;
            }
        }

        private bool validateGuess(string guess)
        {
            if (guess.Length != 4)
            {
                return false;
            }
            bool found;
            for (int g = 0; g < guess.Length; ++g){
                found = false;
                for (int c = 0; c < colours.Length; ++c)
                {
                    if (char.ToUpper(guess[g]) == colours[c])
                    {
                        found = true;
                        for (int i = 0; i < guess.Length; ++i)
                        {
                            if (i != g && guess[i] == guess[g])
                            {
                                return false;
                            }
                        }

                    }
                }
                if (!found)
                {
                        return false;
                }
                
            }
            return true;
        }

    }
}
