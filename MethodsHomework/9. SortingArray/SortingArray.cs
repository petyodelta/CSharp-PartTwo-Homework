//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.


using System;

class SortingArray
{
    static void Main()
    {
        Console.Write("Enter array lenght: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("array[{0}]=",i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter start index: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Enter end index: ");
        int end = int.Parse(Console.ReadLine());

        //output
        Console.WriteLine("Max element in interval {0}-{1} is {2}", start, end, FindMaxElement(array, start, end));
        Console.WriteLine("Sorted in ascending order: {0}",string.Join(", ", SortAscending(array)));
        Console.WriteLine("Sorted in descending order: {0}", string.Join(", ", SortDescending(array)));

    }
    static int FindMaxElement(int[] array, int start, int end, int max = 0)
    {
        int maxIndex = start;
        for (int i = start; i <= end; i++)
        {
            if (array[maxIndex] < array[i])
            {
                maxIndex = i;
            }
        }
        int temp = array[max];
        array[max] = array[maxIndex];
        array[maxIndex] = temp;

        return array[max];
    }
    static int[] SortAscending(int[] array)
    {
        int[] sortedArray = new int[array.Length];
        for (int i = sortedArray.Length - 1; i >= 0; i--)
        {
            sortedArray[i] = FindMaxElement(array, 0, i, i);
        }
        return sortedArray;
    }
    static int[] SortDescending(int[] array)
    {
        int[] sortedArray = new int[array.Length];
        for (int i = 0; i < sortedArray.Length; i++)
        {
            sortedArray[i] = FindMaxElement(array, i, sortedArray.Length - 1, i);
        }
        return sortedArray;
    }
}

