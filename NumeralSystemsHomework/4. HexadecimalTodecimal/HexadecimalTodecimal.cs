//Write a program to convert hexadecimal numbers to their decimal representation.

using System;

class HexadecimalTodecimal
{
    static void Main()
    {
        Console.Write("Enter hexadecimal number: ");
        string strNumber = Console.ReadLine();

        long number = 0L;
        int hexDidits = 0;
        int pow = strNumber.Length - 1;

        for (int i = 0; i < strNumber.Length; i++)
        {

            switch (strNumber[i])
            {
                case 'A':
                    hexDidits = 10;
                    break;
                case 'B':
                    hexDidits = 11;
                    break;
                case 'C':
                    hexDidits = 12;
                    break;
                case 'D':
                    hexDidits = 13;
                    break;
                case 'E':
                    hexDidits = 14;
                    break;
                case 'F':
                    hexDidits = 15;
                    break;
                default:
                    hexDidits = int.Parse(strNumber[i].ToString());
                    break;
            }
            number += hexDidits * (long)Math.Pow(16, pow - i);
        }
        Console.WriteLine("Number {0}(hex) in decimal is {1}", strNumber, number);
    }
}

