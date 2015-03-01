//Write a program that extracts from a given text all sentences containing given word.

using System;


class ExtractSentences
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string[] sentences = Console.ReadLine().Split('.');

        Console.Write("Enter target word: ");
        string target = Console.ReadLine();

        for (int i = 0; i < sentences.Length; i++)
        {
            string[] words = sentences[i].Split(' ', ',');

            for (int j = 0; j < words.Length; j++)
            {
                int compare = string.Compare(words[j],target);
                if (compare == 0)
                {
                    Console.Write(sentences[i] + ". ");
                    break;
                }
            }
        }
        Console.WriteLine();
    }
}

