/*Write a method that adds two polynomials.
Represent them as arrays of their coefficients.
Example:

x2 + 5 = 1x2 + 0x + 5 => {5, 0, 1}
*/

using System;

class AddingPolynomials
{
    static void Main()
    {
        Console.Write("Enter first polynominal degree: ");
        int degreeFirstPol = int.Parse(Console.ReadLine());

        int[] array1 = new int[degreeFirstPol + 1];
        Console.WriteLine("Enter first polynominal:");
        for (int i = degreeFirstPol; i >= 0; i--)
        {
            Console.Write("x^{0}=", i);
            array1[i] = int.Parse(Console.ReadLine());
        }
        
        Console.Write("Enter second polynominal degree: ");
        int degreeSecondPol = int.Parse(Console.ReadLine());

        int[] array2 = new int[degreeSecondPol + 1];
        Console.WriteLine("Enter second polynominal:");
        for (int i = degreeSecondPol; i >= 0; i--)
        {
            Console.Write("x^{0}=", i);
            array2[i] = int.Parse(Console.ReadLine());
        }
        int degree = 0;
        if (degreeFirstPol >= degreeSecondPol)
        {
            degree = degreeFirstPol;
        }
        else if (degreeSecondPol > degreeFirstPol)
        {
            degree = degreeSecondPol;
        }
        int[] arraySum = AddPolynominals(array1, array2);
        
        //output
        Print(arraySum, degree);
        
    }
    static int[] AddPolynominals(int[] array1, int[] array2)
    {

        int[] arraySum = new int[Math.Max(array1.Length, array2.Length)];
        
        for (int i = 0; i < arraySum.Length; i++)
        {
            if (i < Math.Min(array1.Length, array2.Length))
            {
                arraySum[i] = array1[i] + array2[i];
            }
            else
            {
                if (array1.Length > array2.Length)
                {
                    arraySum[i] = array1[i];
                }
                else
                {
                    arraySum[i] = array2[i];
                }
            }
        }
        Array.Reverse(arraySum);
        return arraySum;
    }

    static void Print(int[] arraySum, int degree)
    {
        for (int i = 0; i < arraySum.Length; i++)
        {
            if (i == arraySum.Length - 1)
            {
                if (arraySum[i] != 0)
                {
                    Console.Write("+{0}", arraySum[i]);
                }
                Console.WriteLine();
            }
            else
            {
                if (arraySum[i] != 0 && i < arraySum.Length - 2)
                {
                    Console.Write("{0}x^{1}+", arraySum[i], degree);
                }
                else
                {
                    Console.Write("{0}x^{1}", arraySum[i], degree);
                }

                --degree;
            }

        }
    }
}

