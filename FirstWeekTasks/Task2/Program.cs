// ---------------------------------------------------------------
// Copyright (c) Gulchexa's Program for .NET Girls Community
// FREE TO USE TO DO TASK
// ---------------------------------------------------------------

using System;

namespace GreetUser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.ReadKey();
        }
    }
}