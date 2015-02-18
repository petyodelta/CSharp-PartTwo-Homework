//Write a program to convert binary numbers to their decimal representation.

using System;

class BinaryTodecimal
{
    static void Main()
    {
        string strNumber = "";
        long number = 0L;
        bool isTrue = false;
        while (isTrue == false)
        {
            Console.Write("Enter binary number: ");
            strNumber = Console.ReadLine();

            int pow = strNumber.Length - 1;
            for (int i = 0; i < strNumber.Length; i++)
            {
                if ((char)(strNumber[i]) != '0' && (char)(strNumber[i]) != '1')
                {
                    Console.WriteLine("Invalid number");
                    isTrue = false;
                    number = 0L;
                    break;
                }
                else
                {
                    number += long.Parse(strNumber[i].ToString()) * (long)Math.Pow(2, pow - i);
                    isTrue = true;
                }
            }

        }
        Console.WriteLine("Number {0}(bin) in decimal is {1}", strNumber, number);
    }
}

