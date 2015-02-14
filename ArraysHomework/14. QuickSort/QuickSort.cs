//Write a program that sorts an array of strings using the Quick sort algorithm.


using System;


class QuickSort
{
    static void Main()
    {
        //input
        Console.Write("Enter array lenght:");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("array[{0}]=", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        //sort
        int start = 0;
        int end = array.Length - 1;

        Quicksort(array, start, end);

        //output
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
    }

    static int DevideArray(int[] array, int start, int end)
    {
        int pivot = array[end];
        int index = start;
        int temp = 0;
        for (int i = start; i <= end - 1; i++)
        {
            if (array[i] <= pivot)
            {
                //swap
                temp = array[i];
                array[i] = array[index];
                array[index] = temp;
                ++index;
            }
        }
        //swap pivot and number in index
        temp = array[index];
        array[index] = array[end];
        array[end] = temp;
        return index;
    }

    static void Quicksort(int[] array, int start, int end)
    {
        if (start < end)
        {
            int index = DevideArray(array, start, end);
            Quicksort(array, start, index - 1);
            Quicksort(array, index + 1, end);
        }
    }

}

