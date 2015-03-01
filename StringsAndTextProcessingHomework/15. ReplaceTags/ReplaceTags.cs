//Write a program that replaces in a HTML document given as string all the tags
//<a href="…">…</a> with corresponding tags [URL=…]…/URL].

using System;
using System.Text.RegularExpressions;

class ReplaceTags
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string text= Console.ReadLine();

        string replacedText = Regex.Replace(text,@"<a href=""", "[URL=");
        replacedText = Regex.Replace(replacedText, @""">", "] ");
        replacedText = Regex.Replace(replacedText, "</a>", "[/URL]");
        Console.WriteLine("Result: {0}",replacedText);
    }
}
