//Write a program that reads two integer arrays from the console and compares them element by element.


using System;

class CompareArrays
{
    static void Main()
    {
        int[] firstArray = new int[5];
        int[] secondArray = new int[5];
        bool areIdentical = true;
        int lenght = firstArray.Length;

        Console.WriteLine("Enter first array of 5 integer numbers");
        for (int i = 0; i < firstArray.Length; i++)
        {
            Console.Write("firstArray[{0}]=", i);
            firstArray[i] = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        Console.WriteLine("Enter second array of 5 integer numbers");
        for (int i = 0; i < secondArray.Length; i++)
        {
            Console.Write("secondArray[{0}]=", i);
            secondArray[i] = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        for (int i = 0; i < lenght; i++)
        {
            if (firstArray[i] != secondArray[i])
            {
                areIdentical = false;
                break;
            }
        }
        Console.WriteLine("Two arrays are  identical: {0}", areIdentical);
    }
}

