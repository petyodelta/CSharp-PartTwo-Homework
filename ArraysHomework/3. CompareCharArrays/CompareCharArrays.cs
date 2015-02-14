//Write a program that compares two char arrays lexicographically (letter by letter).


using System;

class CompareCharArrays
{
    static void Main()
    {
        //input
        Console.Write("Enter arrays lenght:");
        int n = int.Parse(Console.ReadLine());

        char[] firstArray = new char[n];
        char[] secondArray = new char[n];
        bool areIdentical = true;

        Console.WriteLine("Enter first array of {0} chars:", n);
        for (int i = 0; i < firstArray.Length; i++)
        {
            Console.Write("firstArray[{0}]=", i);
            firstArray[i] = char.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter second array of {0} chars:", n);
        for (int i = 0; i < secondArray.Length; i++)
        {
            Console.Write("secondArray[{0}]=", i);
            secondArray[i] = char.Parse(Console.ReadLine());
        }

        //compare
        for (int i = 0; i < firstArray.Length; i++)
        {
            if (firstArray[i] != secondArray[i])
            {
                areIdentical = false;
                break;
            }
        }

        //output
        Console.WriteLine("The two arrays are identical: {0}", areIdentical);
    }
}

