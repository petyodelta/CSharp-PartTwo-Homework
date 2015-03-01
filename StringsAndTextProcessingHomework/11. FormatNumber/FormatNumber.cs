//Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
//Format the output aligned right in 15 symbols.

using System;

class FormatNumber
{
    static void Main()
    {
        Console.Write("Enter number: ");
        double number = double.Parse(Console.ReadLine());

        Console.WriteLine("{0,15:D}",(int)number);
        Console.WriteLine("{0,15:X}", (int)number);
        Console.WriteLine("{0,15:P0}", number);
        Console.WriteLine("{0,15:E}", number);
    }
}

