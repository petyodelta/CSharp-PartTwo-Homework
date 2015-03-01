/*Write a program that encodes and decodes a string using given encryption key (cipher).
The key consists of a sequence of characters.
The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key,
the second – with the second, etc. When the last key character is reached, the next is the first.*/

using System;
using System.Text;



class EncodeDecode
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        Console.Write("Enter key word: ");
        string key = Console.ReadLine();

        string encoded = Encoding(text, key);
        string decoded = Decoding(Encoding(text, key), key);

        Console.WriteLine("Encoding: {0}", encoded);
        Console.WriteLine("Decoding: {0}", decoded);
    }

    static string Encoding(string text, string key)
    {
        StringBuilder builder = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            builder.Append((char)(text[i] ^ key[i % key.Length]));
        }
        return builder.ToString();
    }
    static string Decoding(string text, string key)
    {
        return Encoding(text, key);
    }

    
}

