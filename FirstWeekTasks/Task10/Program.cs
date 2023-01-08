// ---------------------------------------------------------------
// Copyright (c) Gulchexa's Program for .NET Girls Community
// FREE TO USE TO DO TASK
// ---------------------------------------------------------------

namespace LeapYears
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Next 20 leap years: ");

            int currentYear = DateTime.Now.Year;  // Get the current year
            int numLeapYears = 0;
            while (numLeapYears < 20)
            {
                if (DateTime.IsLeapYear(currentYear))
                {
                    Console.Write(currentYear + " ");
                    numLeapYears++;
                }
                currentYear++;
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}