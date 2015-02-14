//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.


using System;

class MaximalKSum
{
    static void Main()
    {
        //input
        Console.Write("Enter number N=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter number K=");
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Enter {0} numbers in array:", n);
        for (int i = 0; i < n; i++)
        {
            Console.Write("array[{0}]=", i);
            array[i]= int.Parse(Console.ReadLine());
        }

        //finding K elements that have maximal sum
        int sum = 0;
        int maxSum = int.MinValue;
        int start = 0;

        for (int i = 0; i < (n - k) + 1; i++)
        {
            for (int j = i; j < i + k; j++)
            {
                sum += array[j];
            }
            if (sum > maxSum)
            {
                maxSum = sum;
                start = i;
            }
            sum = 0;
        }

        //output
        Console.Write("The sequence of {0} elements with max sum are ", k);
        for (int i = 0; i < k; i++)
        {
            if (i == k - 1)
            {
                Console.Write("{0}", array[start + i]);
            }
            else
            {
                Console.Write("{0}, ", array[start + i]);
            }
        }
        Console.WriteLine();
    }
}
