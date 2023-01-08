// ---------------------------------------------------------------
// Copyright (c) Gulchexa's Program for .NET Girls Community
// FREE TO USE TO DO TASK
// ---------------------------------------------------------------

using System;

namespace SumOrProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Would you like to compute the sum or the product of the numbers from 1 to n? (S/P)");
            string choice = Console.ReadLine().ToUpper();

            if (choice == "S")
            {
                int sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    sum += i;
                }
                Console.WriteLine($"The sum of the numbers from 1 to {n} is: {sum}");
            }
            else if (choice == "P")
            {
                long product = 1;
                for (int i = 1; i <= n; i++)
                {
                    product *= i;
                }
                Console.WriteLine($"The product of the numbers from 1 to {n} is: {product}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }
    }
}
