// ---------------------------------------------------------------
// Copyright (c) Gulchexa's Program for .NET Girls Community
// FREE TO USE TO DO TASK
// ---------------------------------------------------------------

public class Program
{
    public static void Main(string[] args)
    {
        int[] MyArray = { 1, 2, 5, 6, 7, 8, };
        int sum = SumElements(MyArray);
        Console.WriteLine($"The sum of the elements is: {sum}");
        Console.ReadKey();
    }

    public static int SumElements(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }
}