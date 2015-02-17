//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.


using System;

class AppearanceCount
{
    static void Main()
    {
        //input
        Console.Write("Enter array lenght: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("array[{0}]=",i);
            array[i] = int.Parse(Console.ReadLine());
        }

        //find most frequent and print
        FindMostFrequentNumber(array);
    }

    static void FindMostFrequentNumber(int[] array)
    {
        Array.Sort(array);
        int count = 1;
        int longestStart = 0;
        int longestCount = 1;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i - 1])
            {
                ++count;
                if (count > longestCount)
                {
                    longestCount = count;
                    longestStart = i - longestCount + 1;
                }
            }
            else
            {
                count = 1;
            }
        }
        Console.WriteLine("{0}({1} times)", array[longestStart], longestCount);
    }
}

