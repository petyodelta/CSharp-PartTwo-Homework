//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.

using System;

class SumIntegers
{
    static void Main()
    {
        Console.Write("Enter numbers split by space: ");
        string[] input = Console.ReadLine().Split(' ');

        int sum = CalculateSum(input);

        Console.WriteLine("The sum is {0}", sum);
    }
    static int CalculateSum(string[] input)
    {
        int[] array = new int[input.Length];
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(input[i]);
            sum += array[i];
        }
        return sum;
    }
}

