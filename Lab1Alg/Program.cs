using System;

class Program
{
    static void Main()
    {
        int[] array = { 5, 2, 9, 1, 5, 6 };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        InsertionSort(array);

        Console.WriteLine("\n Отсортированный массив по невозрастанию:");
        PrintArray(array);
    }

    static void InsertionSort(int[] array)
    {
        int n = array.Length;

        for (int i = 1; i < n; i++) 
        {
            int key = array[i]; 
            int j = i - 1;

            while (j >= 0 && array[j] < key)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = key;
        }
    }
    static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
    }
}
