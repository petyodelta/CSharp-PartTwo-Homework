//Write a program that finds the maximal increasing sequence in an array.


using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.Write("Enter array lenght:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter array numbers(0,1,2,3...):");
        string[] arrayString = Console.ReadLine().Split(',');
        int[] array = new int[arrayString.Length];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(arrayString[i]);
        }

        //int startIndex = 0;
        int lenght = 1;
        int longestStart = 0;
        int longestLenght = 1;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] - 1 == array[i - 1])
            {
                ++lenght;
                if (longestLenght < lenght)
                {
                    longestLenght = lenght;
                    longestStart = i - longestLenght + 1;
                }
            }
            else
            {
                lenght = 1;
                //startIndex = i;
            }
        }

        for (int i = longestStart; i < longestStart + longestLenght; i++)
        {
            if (i == (longestStart + longestLenght - 1))
            {
                Console.Write("{0}", array[i]);
            }
            else
            {
                Console.Write("{0}, ", array[i]);
            }
        }
        Console.WriteLine();
    }
}

