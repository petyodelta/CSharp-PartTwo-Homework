//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks.

using System;


class ForbiddenWords
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();
                
        Console.Write("Enter forbidden words separated by ',': ");
        string[] forbiddenWords = Console.ReadLine().Split(',', ' ');
                
        for (int i = 0; i < forbiddenWords.Length; i++)
        {
            int foundWord = 0;
            if ((foundWord = text.IndexOf(forbiddenWords[i])) >= 0)
            {
                string result = new string('*', forbiddenWords[i].Length);
                text = text.Replace(forbiddenWords[i], result);
            }
        }
        Console.WriteLine("Result: {0}", text);
    }
}

