// ---------------------------------------------------------------
// Copyright (c) Gulchexa's Program for .NET Girls Community
// FREE TO USE TO DO TASK
// ---------------------------------------------------------------

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Please enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int total = 0;

        for (int i = 0; i < n; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                total += i;
            }
        }

        Console.WriteLine(total);
        Console.ReadKey();
    }
}