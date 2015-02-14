//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.

using System;

class AllocateArray
{
    static void Main()
    {
        int[] arrayNumbers = new int[20];

        for (int i = 0; i <arrayNumbers.Length; i++)
        {
            arrayNumbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arrayNumbers.Length; i++)
        {
            arrayNumbers[i] = arrayNumbers[i] * 5;
            Console.WriteLine("arrayNumbers[{0}]={1}", i, arrayNumbers[i]);
        }
    }
}

