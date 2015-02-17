//Write a method that reverses the digits of given decimal number.


using System;

class ReverseNumber
{
    static void Main()
    {
        //input
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        //reverse
        int[] array = NumberReversed(number);

        //output
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
        }
        Console.WriteLine();
    }

    static int[] NumberReversed(int number)
    {
        int digitCount = 0;
        int temp = number;
        //count digits in number
        while (temp > 0)
	    {
            temp /= 10;
            ++digitCount;
	    }

        //put digits in array
        int[] array = new int[digitCount];

        while (number > 0)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = number % 10;
                number /= 10;
            }
        }

        return array;
    }
}

