// ---------------------------------------------------------------
// Copyright (c) Gulchexa's Program for .NET Girls Community
// FREE TO USE TO DO TASK
// ---------------------------------------------------------------

namespace PrintPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a maximum value: ");
            int max = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Prime numbers up to " + max + ": ");

            for (int i = 2; i <= max; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}