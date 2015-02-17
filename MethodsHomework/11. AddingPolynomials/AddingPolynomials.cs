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
        Console.Write("Enter polynominal degree: ");
        int degree = int.Parse(Console.ReadLine());
        
        int[] array1 = new int[degree +1];
        Console.WriteLine("Enter first polynominal:");
        for (int i = degree; i >= 0; i--)
        {
            Console.Write("x^{0}=", i);
            array1[i] = int.Parse(Console.ReadLine());
        }
        
        int[] array2 = new int[degree + 1];
        Console.WriteLine("Enter second polynominal:");
        for (int i = degree; i >= 0; i--)
        {
            Console.Write("x^{0}=", i);
            array2[i] = int.Parse(Console.ReadLine());
        }

        int[] arraySum = AddPolynominals(array1, array2);
        
        //output
        
        for (int i = 0; i < arraySum.Length; i++)
        {
            if (i == arraySum.Length - 1)
            {
                Console.Write("{0}",arraySum[i]);
            }
            else
            {
                Console.Write("{0}x^{1}+", arraySum[i], degree);
                --degree;
            }
            
        }

    }
    static int[] AddPolynominals(int[] array1, int[] array2)
    {
        Array.Reverse(array1);
        Array.Reverse(array2);
        int[] arraySum = new int[array1.Length];
        for (int i = 0; i < arraySum.Length; i++)
        {
            arraySum[i] = array1[i] + array2[i];
        }
        return arraySum;
    }
}

