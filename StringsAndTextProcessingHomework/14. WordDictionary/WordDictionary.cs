//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary.

using System;
using System.Collections.Generic;


class WordDictionary
{
    static void Main()
    {
        var dict = new Dictionary<string, string>()
        {
            {".NET", "platform for applications from Microsoft"},
			{"CLR", "managed execution environment for .NET"},
			{"NAMESPACE", "hierarchical organization of classes"}
        };

        Console.Write("Enter word:");
        string word = Console.ReadLine();
        word = word.ToUpper();

        if (dict.ContainsKey(word))
        {
            Console.WriteLine("{0} means: {1}", word, dict[word]);
        }
        else
        {
            Console.WriteLine("The dictionary does not contains word: {0}", word);
        }
    }
}

