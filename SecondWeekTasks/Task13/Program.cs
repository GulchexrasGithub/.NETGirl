// ---------------------------------------------------------------
// Copyright (c) Gulchexa's Program for .NET Girls Community
// FREE TO USE TO DO TASK
// ---------------------------------------------------------------

public class Program
{
    public static void Main(string[] args)
    {
        int[] fibonacciNumbers = GetFibonacciNumbers(100);
        Console.WriteLine(string.Join(", ", fibonacciNumbers));
        Console.ReadKey();
    }

    public static int[] GetFibonacciNumbers(int count)
    {
        int[] result = new int[count];
        if (count >= 1)
        {
            result[0] = 1;
        }
        if (count >= 2)
        {
            result[1] = 1;
        }
        for (int i = 2; i < count; i++)
        {
            result[i] = result[i - 1] + result[i - 2];
        }
        return result;
    }
}