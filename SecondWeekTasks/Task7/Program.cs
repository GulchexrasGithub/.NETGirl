// ---------------------------------------------------------------
// Copyright (c) Gulchexa's Program for .NET Girls Community
// FREE TO USE TO DO TASK
// ---------------------------------------------------------------

public class Program
{
    public static void Main(string[] args)
    {
        int[] myArray = { 1, 2, 3, 4, 5 };

        int sum1 = SumArrayForLoop(myArray);
        int sum2 = SumArrayWhileLoop(myArray);
        int sum3 = SumArrayRecursive(myArray, 0);

        Console.WriteLine($"The sum of the array using a for-loop is: {sum1}");
        Console.WriteLine($"The sum of the array using a while-loop is: {sum2}");
        Console.WriteLine($"The sum of the array using recursion is: {sum3}");
        Console.ReadKey();

    }

    public static int SumArrayForLoop(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }

    public static int SumArrayWhileLoop(int[] arr)
    {
        int sum = 0;
        int i = 0;
        while (i < arr.Length)
        {
            sum += arr[i];
            i++;
        }
        return sum;
    }

    public static int SumArrayRecursive(int[] arr, int index)
    {
        if (index >= arr.Length)
        {
            return 0;
        }
        return arr[index] + SumArrayRecursive(arr, index + 1);
    }
}
