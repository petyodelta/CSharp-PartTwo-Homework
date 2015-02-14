//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.


using System;

class PrimeNumbers
{
    static void Main()
    {
        int n = 10000;
        int[] array = new int[n + 1];

        for (int i = 0; i <= n; i++)
        {
            array[i] = 1;
        }
        array[0] = 0;
        array[1] = 0;

        for (int i = 2; i < Math.Sqrt(n); i++)
        {
            if (array[i] == 1)
            {
                for (int j = 2; i * j <= n; j++)
                {
                    array[i * j] = 0;
                }
            }
        }

        for (int i = 0; i <= n; i++)
        {
            if (array[i] != 0)
            {
                array[i] = i;
                Console.Write("{0} ", array[i]);
            }
        }
        Console.WriteLine();
    }
}

