// ---------------------------------------------------------------
// Copyright (c) Gulchexa's Program for .NET Girls Community
// FREE TO USE TO DO TASK
// ---------------------------------------------------------------

public class Program
{
    public static void Main(string[] args)
    {
        string[] arr1 = { "a", "b", "c" };
        string[] arr2 = { "1", "2", "3" };
        string[] result = ConcatenateArrays(arr1, arr2);
        Console.WriteLine(string.Join(", ", result));
        Console.ReadKey();
    }

    public static T[] ConcatenateArrays<T>(T[] arr1, T[] arr2)
    {
        T[] result = new T[arr1.Length + arr2.Length];
        Array.Copy(arr1, result, arr1.Length);
        Array.Copy(arr2, 0, result, arr1.Length, arr2.Length);
        return result;
    }
}