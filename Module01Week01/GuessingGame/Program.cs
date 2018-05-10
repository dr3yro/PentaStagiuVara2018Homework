using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(0, 100);

            //guess counter
            int guesses = 1;

            Console.Write("Please enter a number between 0 and 100: ");

            int guessedNumer = int.Parse(Console.ReadLine());

        loop:
            if (randomNumber != guessedNumer)
            {
                if (randomNumber < guessedNumer)
                {
                    Console.Write("Your guess is too high. Please guess again: ");
                    guessedNumer = int.Parse(Console.ReadLine());
                    guesses += 1;
                    goto loop;
                }
                else
                {
                    Console.Write("Your guess is too low. Please guess again: ");
                    guessedNumer = int.Parse(Console.ReadLine());
                    guesses += 1;
                    goto loop;
                }
            }
            else
            {
                Console.WriteLine($"YOU GOT IT! You needed {guesses} guesses to get it right!");
                Console.ReadLine();
            }

        }
    }
}
