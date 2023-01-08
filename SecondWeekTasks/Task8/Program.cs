// ---------------------------------------------------------------
// Copyright (c) Gulchexa's Program for .NET Girls Community
// FREE TO USE TO DO TASK
// ---------------------------------------------------------------

public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        OnAll(numbers, x => Console.WriteLine($"{x} * {x} = {x * x}"));
        Console.ReadKey();
    }

    public static void OnAll(int[] arr, Action<int> func)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            func(arr[i]);
        }
    }
}