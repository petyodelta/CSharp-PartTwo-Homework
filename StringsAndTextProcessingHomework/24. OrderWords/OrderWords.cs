//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order

using System;
using System.Text;


class OrderWords
{
    static void Main()
    {
        Console.Write("Enter words separated by space: ");
        string[] words = Console.ReadLine().Split(' ');

        Array.Sort(words);
        
        Console.Write(String.Join(" ", words));

        Console.WriteLine();
    }
}

