//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.

using System;


class UnicodeCharacters
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string str = Console.ReadLine();

        for (int i = 0; i < str.Length; i++)
        {
            Console.Write("\\u{0:X4}",(ushort)str[i]);
        }
        Console.WriteLine();
    }
}

