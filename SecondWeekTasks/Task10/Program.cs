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
        string[] result = InterleaveArrays(arr1, arr2);
        Console.WriteLine(string.Join(", ", result));
        Console.ReadKey();
    }

    public static T[] InterleaveArrays<T>(T[] arr1, T[] arr2)
    {
        T[] result = new T[arr1.Length + arr2.Length];
        for (int i = 0; i < result.Length; i++)
        {
            if (i % 2 == 0)
            {
                result[i] = arr1[i / 2];
            }
            else
            {
                result[i] = arr2[i / 2];
            }
        }
        return result;
    }
}