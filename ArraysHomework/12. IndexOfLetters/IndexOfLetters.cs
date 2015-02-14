using System;

class IndexOfLetters
{
    static void Main()
    {
        char[] array = new char[52];

        for (int i = 0; i < array.Length; i++)
        {
            if (i < 26)
            {
                array[i] = (char)(i + 65);
            }
            else
            {
                array[i] = (char)(i + 71);
            }
        }

        Console.Write("Enter word: ");
        string word = Console.ReadLine();

        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (word[i] == array[j])
                {
                    Console.WriteLine("{0} -> {1}", array[j], j);
                    break;
                }
            }
        }
    }
}

