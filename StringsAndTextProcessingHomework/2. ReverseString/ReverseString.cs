//Write a program that reads a string, reverses it and prints the result at the console.

using System;
using System.Linq;

class ReverseString
{
    static void Main()
    {
        Console.Write("Enter string:");
        string text = Console.ReadLine();

        var reverse = text.Reverse();
        foreach (char ch in reverse)
        {
            Console.Write(ch);
        }
        Console.WriteLine();
    }
}

