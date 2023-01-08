// ---------------------------------------------------------------
// Copyright (c) Gulchexa's Program for .NET Girls Community
// FREE TO USE TO DO TASK
// ---------------------------------------------------------------

public class Program
{
    public static void Main(string[] args)
    {
        long[] digits = GetDigits(0110864814498415454);
        Console.WriteLine(string.Join(", ", digits));
        Console.ReadKey();
    }

    public static long[] GetDigits(long number)
    {
        List<long> digits = new List<long>();
        while (number > 0)
        {
            digits.Add(number % 10);
            number /= 10;
        }
        digits.Reverse();
        return digits.ToArray();
    }
}