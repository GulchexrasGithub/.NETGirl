// ---------------------------------------------------------------
// Copyright (c) Gulchexa's Program for .NET Girls Community
// FREE TO USE TO DO TASK
// ---------------------------------------------------------------

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int secretNumber = rnd.Next(1, 101);  // Generate a random number between 1 and 100
            int guess = 0;
            int numTries = 0;
            int previousGuess = 0;

            Console.WriteLine("I'm thinking of a number between 1 and 100. Can you guess what it is?");

            while (guess != secretNumber)
            {
                previousGuess = guess;
                Console.Write("Enter your guess: ");
                guess = int.Parse(Console.ReadLine()!);

                if (guess == previousGuess)
                {
                    // Do not count consecutive guesses as separate tries
                    continue;
                }
                numTries++;

                if (guess > secretNumber)
                {
                    Console.WriteLine("Your guess is too high.");
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Your guess is too low.");
                }
            }

            Console.WriteLine($"Congratulations! You guessed the secret number in {numTries} tries.");
            Console.ReadKey();
        }
    }
}

