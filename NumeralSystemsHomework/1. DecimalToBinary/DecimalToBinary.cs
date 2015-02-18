//Write a program to convert decimal numbers to their binary representation.


using System;


class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        long number = long.Parse(Console.ReadLine());

        string strNumber = "";
        long tempNum = number;

        if (number != 0)
        {
            while (number > 0)
            {
                strNumber += Convert.ToString(number % 2);
                number /= 2;
            }
            for (int i = strNumber.Length - 1; i >= 0; i--)
            {
                if (i == strNumber.Length - 1)
                {
                    Console.Write("The number {0} in binary is {1}", tempNum, strNumber[i]);
                }
                else
                {
                    Console.Write(strNumber[i]);
                }
            }
        }
        else
        {
            Console.WriteLine("The number {0}(dec) in binary is {0}", 0);
        }
        Console.WriteLine();
    }
}

