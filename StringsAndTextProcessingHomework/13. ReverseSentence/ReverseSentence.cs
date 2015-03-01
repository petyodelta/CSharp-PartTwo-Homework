//Write a program that reverses the words in given sentence.

using System;
using System.Text;
using System.Collections.Generic;


class ReverseSentence
{
    static void Main()
    {
        string text = "C# is not C++, not PHP and not Delphi!";

        char end = text[text.Length - 1];
        text = text.Remove(text.Length - 1, 1);
        string[] words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Array.Reverse(words);

        Console.WriteLine("Reversed: {0}{1}", string.Join(" ", words), end);
    }
}
