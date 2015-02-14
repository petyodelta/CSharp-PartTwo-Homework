//Write a program that finds the maximal sequence of equal elements in an array.


using System;

class MaximalSequence
{
    static void Main()
    {
        //input
        Console.Write("Enter array lenght:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter array {0} numbers split by \",\":", n);
        string[] arrayString = Console.ReadLine().Split(',');
        int[] array = new int[n];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(arrayString[i]);
        }
        
        //find max sequence 
        int lenght = 1;
        int longestStart = 0;
        int longestLenght = 1;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i-1])
            {
                ++lenght;
                if (lenght > longestLenght)
                {
                    longestLenght = lenght;
                    longestStart = i - longestLenght + 1;
                }
            }
            else
            {
                lenght = 1;
            }
        }

        //output
        for (int i = longestStart; i < longestStart + longestLenght; i++)
        {
            if (i == (longestStart + longestLenght - 1))
            {
                Console.Write("{0}",array[i]);
            }
            else
            {
                Console.Write("{0}, ", array[i]);
            }
        }
        Console.WriteLine();
    }
}

