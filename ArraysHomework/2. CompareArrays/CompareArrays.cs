//Write a program that reads two integer arrays from the console and compares them element by element.


using System;

class CompareArrays
{
    static void Main()
    {
        //input
        Console.Write("Enter arrays lenght:");
        int n = int.Parse(Console.ReadLine());

        int[] firstArray = new int[n];
        int[] secondArray = new int[n];
        bool areIdentical = true;
        
        Console.WriteLine("Enter first array of {0} integer numbers",n);
        for (int i = 0; i < firstArray.Length; i++)
        {
            Console.Write("firstArray[{0}]=", i);
            firstArray[i] = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        Console.WriteLine("Enter second array of {0} integer numbers",n);
        for (int i = 0; i < secondArray.Length; i++)
        {
            Console.Write("secondArray[{0}]=", i);
            secondArray[i] = int.Parse(Console.ReadLine());
            Console.WriteLine();
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
        Console.WriteLine("Two arrays are  identical: {0}", areIdentical);
    }
}

