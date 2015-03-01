//Write a program for extracting all email addresses from given text.
//All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Collections.Generic;
using System.Text;

class ExtractEmails
{
    static void Main()
    {
        Console.Write("Enter text: ");
        char[] splitArr = {',','"' ,' ' , '?', '!', ';'};
        string[] text = Console.ReadLine().Split(splitArr, StringSplitOptions.RemoveEmptyEntries);

        var emails = new List<string>();

        foreach (string word in text)
        {
            if (word.Contains("@"))
            {
                emails.Add(word);
            }
        }

        foreach (string word in emails)
        {
            Console.WriteLine(word);
        }
    }
}

