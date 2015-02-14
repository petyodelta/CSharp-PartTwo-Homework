//You are given an array of strings. Write a method that sorts the array by the length
//of its elements (the number of characters composing them).


using System;

class SortByStringLength
{
    static void Main()
    {
        //input
        Console.Write("Enter array lenght:");
        int n = int.Parse(Console.ReadLine());

        string[] array = new string[n];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("array[{0}]=",i);
            array[i] = Console.ReadLine();
        }

        //sort
        Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));

        //output
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("array[{0}]={1}",i, array[i]);
            Console.WriteLine();
        }
    }
}

