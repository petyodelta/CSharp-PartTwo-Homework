using System;
using System.Numerics;

class NumberAsArray
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        BigInteger firstNum = BigInteger.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        BigInteger secondNum = BigInteger.Parse(Console.ReadLine());

        int[] array = AddTwoArrays(firstNum, secondNum);

        //output
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
        }
        Console.WriteLine();
    }
    static int[] AddTwoArrays(BigInteger firstNum, BigInteger secondNum)
    {
        BigInteger temp = firstNum;
        int counter1 = 0;
        while (temp > 0)
        {
            temp /= 10;
            ++counter1;
        }

        temp = secondNum;
        int counter2 = 0;
        while (temp > 0)
        {
            temp /= 10;
            ++counter2;
        }

        int[] array1 = new int[counter1];
        int[] array2 = new int[counter2];

        if (counter1 > counter2)
        {
            array1 = new int[counter1];
            array2 = new int[counter1];
        }
        else if (counter2 > counter1)
        {
            array1 = new int[counter2];
            array2 = new int[counter2];
        }
        else//counter1==counter2
        {
            array1 = new int[counter1];
            array2 = new int[counter1];
        }

        for (int i = 0; i < array1.Length; i++)
        {
            int remaider = (int)(firstNum % 10);
            array1[i] = remaider;
            firstNum /= 10;
        }

        for (int i = 0; i < array2.Length; i++)
        {
            int remaider = (int)(secondNum % 10);
            array2[i] = remaider;
            secondNum /= 10;
        }

        int[] array = new int[array1.Length];
        for (int i = 0; i < array.Length; i++)
        {
            if (i == 0)
	        {
                array[i] = (array1[i] + array2[i]) % 10;
	        }
            else if (i == array.Length - 1)
            {
                array[i] = (array1[i] + array2[i]) + (array1[i - 1] + array2[i - 1]) / 10;
            }
            else
            {
                array[i] = (array1[i] + array2[i]) % 10 + (array1[i - 1] + array2[i - 1]) / 10;
            }
        }

        Array.Reverse(array);

        return array;
    }
}

