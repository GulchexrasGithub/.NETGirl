// ---------------------------------------------------------------
// Copyright (c) Gulchexa's Program for .NET Girls Community
// FREE TO USE TO DO TASK
// ---------------------------------------------------------------

public class Program
{
    public static void Main(string[] args)
    {
        int[] myArray = { 1, 2, 3, 4, 5 };
        bool elementExists = ElementOccursInArray(myArray, 5);
        Console.WriteLine(elementExists);
        Console.ReadKey();

    }
    public static bool ElementOccursInArray(int[] arr, int element)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == element)
            {
                return true;
            }
        }
        return false;
    }
}