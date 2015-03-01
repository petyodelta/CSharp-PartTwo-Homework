//Write a program that reads a string from the console and prints all different letters
//in the string along with information how many times each letter is found.

using System;


class LettersCount
{
    static void Main()
    {
        Console.Write("Enter string:");
        string input = Console.ReadLine();

        int[] array = new int[26];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = 0;
        }
        
        input = input.ToLower();

        foreach (char ch in input)
        {
            if (Char.IsLetter(ch))
            {
                ++array[ch - 'a'];       
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != 0)
            {
                Console.WriteLine("{0}->{1} times", (char)(i + 'a'), array[i]);
            }
        }
    }
}

