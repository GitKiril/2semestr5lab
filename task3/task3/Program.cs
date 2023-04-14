using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Sort.GenerateRandomArray(10);
            Console.WriteLine("Unsorted array: " + string.Join(", ", array));
            Console.WriteLine();

            Sort.QuickSort(array, 0, array.Length - 1);
            Console.WriteLine("Sorted array: " + string.Join(", ", array));

            Console.ReadLine();
        }
    }
}
