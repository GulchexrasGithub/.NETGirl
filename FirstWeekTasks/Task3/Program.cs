// ---------------------------------------------------------------
// Copyright (c) Gulchexa's Program for .NET Girls Community
// FREE TO USE TO DO TASK
// ---------------------------------------------------------------

namespace Greeter
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";

            Console.WriteLine("What is your name?");
            name = Console.ReadLine()!;

            if (name == "Alice" || name == "Bob")
            {
                Console.WriteLine($"Hi {name}!");
            }
            else
            {
                Console.WriteLine("Hi!");
            }
            Console.ReadKey();
        }
    }
}