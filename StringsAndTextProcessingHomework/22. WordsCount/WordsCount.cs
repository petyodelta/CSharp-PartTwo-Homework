//Write a program that reads a string from the console and lists all different words
//in the string along with information how many times each word is found.

using System;


class WordsCount
{
    static void Main()
    {
        Console.Write("Enter text: ");
        char[] splitSigns = {' ', ',', '.', '!', '?', ';', ':' };
        string[] words = Console.ReadLine().Split(splitSigns, StringSplitOptions.RemoveEmptyEntries);

        bool exists = false;
        int counter = 1;

        for (int i = 0; i <= words.Length - 1; i++)
        {
            for (int k = i - 1; k >= 0; k--)//checks if word already checked
            {
                if (words[k] == words[i])
                {
                    exists = true;
                    break;
                }
            }
            
            if (i == words.Length - 1 && exists == false)
            {
                Console.WriteLine("{0}->{1}", words[i], counter);
                return;
            }
            for (int j = i + 1; j < words.Length; j++)
            {
                
                if (words[i] == words[j] && exists ==false)
                {
                    ++counter;
                }
            }
            
            if (exists == false)
            {
                Console.WriteLine("{0}->{1}",words[i], counter);
            }
            counter = 1;
            exists = false;
        }
    }
}

