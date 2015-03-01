//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.

using System;
using System.Text;

class SeriesOfLetters
{
    static void Main()
    {
        Console.Write("Enter string:");
        string input = Console.ReadLine();

        StringBuilder builder = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            if (i == input.Length - 1)
            {
                builder = builder.Append(input[i]);
            }
            else if (input[i] != input[i + 1])
            {
                builder = builder.Append(input[i]);
            }
        }
        Console.WriteLine("Result: {0}",builder.ToString());
    }
}

