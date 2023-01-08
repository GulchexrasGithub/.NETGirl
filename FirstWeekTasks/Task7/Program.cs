// ---------------------------------------------------------------
// Copyright (c) Gulchexa's Program for .NET Girls Community
// FREE TO USE TO DO TASK
// ---------------------------------------------------------------

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplication Table:\n");

            for (int i = 1; i <= 12; i++)
            {
                for (int j = 1; j <= 12; j++)
                {
                    Console.Write($"{i * j,4}");
                }
                Console.WriteLine();
            }
        }
    }
}