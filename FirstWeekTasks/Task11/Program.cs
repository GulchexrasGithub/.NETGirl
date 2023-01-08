// ---------------------------------------------------------------
// Copyright (c) Gulchexa's Program for .NET Girls Community
// FREE TO USE TO DO TASK
// ---------------------------------------------------------------

namespace AlternatingSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxK = 1000000;
            double sum = 0;
            for (int k = 1; k <= maxK; k++)
            {
                double term = 4 * Math.Pow(-1, k + 1) / (2 * k - 1);
                sum += term;
            }
            Console.WriteLine($"The sum of the alternating series is: {sum}");
            Console.ReadKey();
        }
    }
}