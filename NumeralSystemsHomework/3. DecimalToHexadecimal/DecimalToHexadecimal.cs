//Write a program to convert decimal numbers to their hexadecimal representation.

using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        long number = long.Parse(Console.ReadLine());

        long tempNum = number;
        string strNumber = "";
        if (number != 0)
        {
            while (number > 0)
            {
                long remainder = number % 16;
                number /= 16;
                switch (remainder)
                {
                    case 10:
                        strNumber += 'A';
                        break;
                    case 11:
                        strNumber += 'B';
                        break;
                    case 12:
                        strNumber += 'C';
                        break;
                    case 13:
                        strNumber += 'D';
                        break;
                    case 14:
                        strNumber += 'E';
                        break;
                    case 15:
                        strNumber += 'F';
                        break;
                    default:
                        strNumber += remainder.ToString();
                        break;
                }
            }
            for (int i = strNumber.Length - 1; i >= 0; i--)
            {
                if (i == strNumber.Length - 1)
                {
                    Console.Write("The number {0}(dec) in hexadecimal is {1}", tempNum, strNumber[i]);
                }
                else
                {
                    Console.Write(strNumber[i]);
                }
            }
        }
        else
        {
            Console.WriteLine("The number {0}(dec) in hexadecimal is {0}", 0);
        }
        Console.WriteLine();
    }
}

