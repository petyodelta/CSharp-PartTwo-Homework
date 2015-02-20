//Extend the previous program to support also subtraction and multiplication of polynomials.


using System;

class SubtractingPolynomials
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

        int[] arraySubtract = SubtractPolynominals(array1, array2);

        Console.WriteLine("Subtraction of polynominals");
        Print(arraySubtract, degree);
        
        
        int[] arrayMultiply = MultiplicationPolynominals(array1, array2);
        degree = degreeFirstPol + degreeSecondPol;

        Console.WriteLine("Multiplication of polynominals");
        Print(arrayMultiply, degree);
        
    }
    static int[] SubtractPolynominals(int[] array1, int[] array2)
    {
        int[] arraySubtract = new int[Math.Max(array1.Length, array2.Length)];
        
        for (int i = 0; i < arraySubtract.Length; i++)
        {
            if (i < Math.Min(array1.Length, array2.Length))
            {
                arraySubtract[i] = array1[i] - array2[i];    
            }
            else
            {
                if (array1.Length > array2.Length)
                {
                    arraySubtract[i] = array1[i];
                }
                else
                {
                    arraySubtract[i] = array2[i];
                }
            }
            
        }
        Array.Reverse(arraySubtract);
        return arraySubtract;
    }
    
    static int[] MultiplicationPolynominals(int[] array1, int[] array2)
    {
        int[] arrayMultiply = new int[array1.Length + array2.Length -1];
        for (int i = 0; i < array1.Length; i++)
        {
            for (int j = 0; j < array2.Length; j++)
            {
                arrayMultiply[i + j] += array1[i] * array2[j];
            }
        }
        Array.Reverse(arrayMultiply);
        return arrayMultiply;
    }

    static void Print(int[] result, int degree)
    {
        for (int i = 0; i < result.Length; i++)
        {
            if (i == result.Length - 1)
            {
                if (result[i] != 0)
                {
                    Console.Write("+({0})", result[i]);
                }

            }
            else
            {
                if(result[i] != 0 && i < result.Length -2)
                {
                    Console.Write("({0}x^{1})+", result[i], degree);
                }
                else
                {
                    Console.Write("({0}x^{1})", result[i], degree);
                }
                --degree;
            }
        }
        Console.WriteLine();
    }
}




