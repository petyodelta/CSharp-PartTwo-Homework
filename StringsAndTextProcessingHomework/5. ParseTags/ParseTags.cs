//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
//The tags cannot be nested.

using System;


class ParseTags
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        while (text.IndexOf("<upcase>") != -1)
        {
            int startIndex = text.IndexOf("<upcase>");
            int endIndex = text.IndexOf("</upcase>");
            string str = text.Substring(startIndex + "<upcase>".Length, endIndex - startIndex -"<upcase>".Length);
            text = text.Replace("<upcase>" + str + "</upcase>", str.ToUpper());
        }
        Console.WriteLine("Result: {0}",text);
    }
}

