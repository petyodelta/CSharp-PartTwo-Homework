//Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, the rest of the characters should be filled with *.
//Print the result string into the console.

using System;
using System.Text;


class StringLength
{
    static void Main()
    {
        Console.Write("Enter string of maximum 20 characters: ");
        string text = Console.ReadLine();

        StringBuilder builder = new StringBuilder();
        
        if (text.Length > 20)
        {
            for (int i = 0; i < 20; i++)
            {
                builder = builder.Append(text[i]);
            }
        }
        else
        {
            for (int i = 0; i < 20; i++)
            {
                if (i >= text.Length)
                {
                    builder = builder.Append("*");
                }
                else
                {
                    builder = builder.Append(text[i]);
                }
            }
        }
        Console.WriteLine(builder);
    }
}

