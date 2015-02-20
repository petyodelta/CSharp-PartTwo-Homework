//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;

class BinaryShort
{
    static void Main()
    {
        Console.Write("Enter number between -32768 and 32767: ");
        short number = short.Parse(Console.ReadLine());

        string strNumber = "";
        short tempNum = number;
        if (number > 0)
        {
            for (int i = 0; i < 16; i++)
            {
                strNumber += Convert.ToString(number % 2);
                number /= 2;
            }

            for (int i = 15; i >= 0; i--)
            {
                if (i == 15)
                {
                    Console.Write("The binary representation of {0} in \n16-bit signed integer number is {1}", tempNum, strNumber[i]);
                }
                else
                {
                    Console.Write(strNumber[i]);
                }
            }
        }
        else if (number < 0)
        {
            number *= -1;
            for (int i = 0; i < 16; i++)
            {
                if (i < 15)
                {
                    strNumber += Convert.ToString(number % 2);
                    number /= 2;
                }
                else
                {
                    strNumber += Convert.ToString(1);
                }

            }

            for (int i = 15; i >= 0; i--)
            {
                if (i == 15)
                {
                    Console.Write("The binary representation of {0} in \n16-bit signed integer number is {1}", tempNum, strNumber[i]);
                }
                else
                {
                    Console.Write(strNumber[i]);
                }
            }
        }
        else
        {
            Console.WriteLine("The binary representation of {0} in \n16-bit signed integer number is {1}", 0, new string('0', 16));
        }
        Console.WriteLine();
    }
}

