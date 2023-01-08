// ---------------------------------------------------------------
// Copyright (c) Gulchexa's Program for .NET Girls Community
// FREE TO USE TO DO TASK
// ---------------------------------------------------------------

public class Program
{
    public static void Main(string[] args)
    {
        int[] arr1 = { 1, 4, 6, 7 };
        int[] arr2 = { 2, 3, 5, 8 };
        int[] result = MergeSortedArrays(arr1, arr2);
        Console.WriteLine(string.Join(", ", result));
        Console.ReadKey();
    }

    public static int[] MergeSortedArrays(int[] arr1, int[] arr2)
    {
        int[] result = new int[arr1.Length + arr2.Length];
        int i = 0;
        int j = 0;
        int k = 0;
        while (i < arr1.Length && j < arr2.Length)
        {
            if (arr1[i] < arr2[j])
            {
                result[k] = arr1[i];
                i++;
            }
            else
            {
                result[k] = arr2[j];
                j++;
            }
            k++;
        }
        while (i < arr1.Length)
        {
            result[k] = arr1[i];
            i++;
            k++;
        }
        while (j < arr2.Length)
        {
            result[k] = arr2[j];
            j++;
            k++;
        }
        return result;
    }
}