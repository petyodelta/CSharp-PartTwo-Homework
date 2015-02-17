//Write a program to calculate n! for each n in the range [1..100].


using System;
using System.Numerics;

class NFactorial
{
    static void Main()
    {
        //input
        Console.Write("Enter number n=");
        int n = int.Parse(Console.ReadLine());
        
        //calculate n!
        BigInteger factorielN = CalculateFactoriel(n);

        //output
        Console.WriteLine("{0}->{1}",n , factorielN);
    }
    static BigInteger CalculateFactoriel(int n)
    {
        BigInteger factorialN = 1;
        
        for (int i = 2; i <= n; i++)
        {
            factorialN *= i;
        }
        return factorialN;
    }
}

