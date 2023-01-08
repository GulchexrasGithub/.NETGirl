// ---------------------------------------------------------------
// Copyright (c) Gulchexa's Program for .NET Girls Community
// FREE TO USE TO DO TASK
// ---------------------------------------------------------------

public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        RotateArray(arr, 2);
        Console.WriteLine(string.Join(", ", arr));
        Console.ReadKey();
    }
    public static void RotateArray(int[] arr, int k)
    {
        int n = arr.Length;
        k %= n;
        ReverseArray(arr, 0, n - 1);
        ReverseArray(arr, 0, k - 1);
        ReverseArray(arr, k, n - 1);
    }

    private static void ReverseArray(int[] arr, int start, int end)
    {
        while (start < end)
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            start++;
            end--;
        }
    }

}
