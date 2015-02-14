//Write a program that finds the sequence of maximal sum in given array.


using System;

class MaximalSum
{
    static void Main()
    {
        //input
        Console.Write("Enter array lenght:");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter array {0} numbers split by \",\":", n);
        string[] arrayString = Console.ReadLine().Split(',');
        
        int[] array = new int[arrayString.Length];
        
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(arrayString[i]);
        }
       
        //finding max sum sequence
        int sum = 0;
        int maxSum = int.MinValue;
        int start = 0;
        int bestStart = 0;
        int bestEnd = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (sum <= 0)
            {
                start = i;
                sum = 0;
            }
            
            sum += array[i];

            if (sum > maxSum)
            {
                maxSum = sum;
                bestStart = start;
                bestEnd = i;
            }
        }

        //output
        Console.WriteLine("Max sum is {0}", maxSum);
        Console.Write("Sequence of max sum is ");
        for (int i = bestStart; i <= bestEnd; i++)
        {
            if (i == bestEnd)
            {
                Console.Write("{0}", array[i]);
            }
            else
            {
                Console.Write("{0},", array[i]);
            }
            
        }
        Console.WriteLine();
    }
}

