// ---------------------------------------------------------------
// Copyright (c) Gulchexa's Program for .NET Girls Community
// FREE TO USE TO DO TASK
// ---------------------------------------------------------------

public class Program
{
    public static void Main(string[] args)
    {
        int[] myArray = { 1, 3, 5, 11, 4, 6 };
        int largest = FindLargestElement(myArray);
        Console.WriteLine($"The largest element in the array is: {largest}");
        Console.ReadKey();
    }
    public static int FindLargestElement(int[] arr)
    {
        int largest = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > largest)
            {
                largest = arr[i];
            }
        }
        return largest;
    }
}