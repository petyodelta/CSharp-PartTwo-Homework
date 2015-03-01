//Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
//If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100


using System;


class EnterNumbers
{
    static void Main()
    {
        int start = 1;
        int end = 100;
        Console.Write("Enter 10 numbers such that 1<a1<…<a10<100: ");
        
        for (int i = 0; i < 10; i++)
        {
            start = ReadNumber(start, end);
        }
    }

    static int ReadNumber(int start, int end)
    {
        try
        {
            int number = int.Parse(Console.ReadLine());
            if (number <= start || number >= end)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
	        {
                Console.WriteLine("Number {0} is in range.", number);
                start = number;
	        }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: The number is not in correct format!");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("The number is out of range");
        }

        return start;       
    }
}

