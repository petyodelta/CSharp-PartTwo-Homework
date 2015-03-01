//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

using System;


class Palindromes
{
    static void Main()
    {
        Console.Write("Enter text: ");
        char[] splitSigns = { '.', ',', ' ' };

        string[] text = Console.ReadLine().Split(splitSigns, StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in text)
        {
            bool isPalindrome = true;

            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }
            if (isPalindrome && word.Length > 1)
            {
                Console.WriteLine(word);
            }
        }

    }
}

