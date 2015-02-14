//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.


using System;

class BinarySearch
{
    static void Main()
    {
        //input

        Console.Write("Enter array lenght: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Enter array of {0} integer numbers:", n);

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("array[{0}]=", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Witch element index to find? ");
        int element = int.Parse(Console.ReadLine());

        //sorting array
        int leastNum;
        int tempNum;

        for (int i = 0; i < array.Length - 1; i++)
        {
            leastNum = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[leastNum])
                {
                    leastNum = j;
                }
            }
            if (leastNum != i)
            {
                tempNum = array[i];
                array[i] = array[leastNum];
                array[leastNum] = tempNum;
            }
        }

        //binary search
        int start = 0;
        int end = array.Length - 1;
        
        while (start <= end)
        {
            int center = (start + end) / 2;
            if (array[center] == element)
            {
                Console.WriteLine("The index of {0} is {1}", element, center);
                return;
            }
            else if (array[center] > element)
            {
                end = center - 1;
            }
            else
            {
                start = center + 1;
            }
        }
        Console.WriteLine("Element does not exist");
    }
}

