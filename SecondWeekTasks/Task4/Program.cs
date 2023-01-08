// ---------------------------------------------------------------
// Copyright (c) Gulchexa's Program for .NET Girls Community
// FREE TO USE TO DO TASK
// ---------------------------------------------------------------

public class Program
{
    public static void Main(string[] args)
    {
        int[] myArray = { 1, 2, 3, 4, 5 };
        int[] oddPositionElements = GetOddPositionElements(myArray);
        Console.WriteLine(string.Join(", ", oddPositionElements));
        Console.ReadKey();
    }
    public static int[] GetOddPositionElements(int[] arr)
    {
        int[] oddElements = new int[(arr.Length + 1) / 2];
        for (int i = 0; i < arr.Length; i++)
        {
            if (i % 2 == 1)
            {
                oddElements[i / 2] = arr[i];
            }
        }
        return oddElements;
    }
}