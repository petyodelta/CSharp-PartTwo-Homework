//Write a program that compares two char arrays lexicographically (letter by letter).


using System;

class CompareCharArrays
{
    static void Main()
    {
        char[] firstArray = new char[5];
        char[] secondArray = new char[5];
        bool areIdentical = true;
        int lenght = firstArray.Length;

        for (int i = 0; i < firstArray.Length; i++)
        {
            Console.WriteLine("Enter first array of 5 chars:");
            Console.Write("firstArray[{0}]=", i);
            firstArray[i] = char.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        for (int i = 0; i < secondArray.Length; i++)
        {
            Console.WriteLine("Enter second array of 5 chars:");
            Console.Write("secondArray[{0}]=", i);
            secondArray[i] = char.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        for (int i = 0; i < firstArray.Length; i++)
        {
            if (firstArray[i] != secondArray[i])
            {
                areIdentical = false;
                break;
            }
        }
        Console.WriteLine("The two arrays are identical: {0}", areIdentical);
    }
}

