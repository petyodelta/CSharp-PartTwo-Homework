//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position,
//find the smallest from the rest, move it at the second position, etc.


using System;

class SelectionSort
{
    static void Main()
    {
        //input
        
        Console.Write("Enter array lenght: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Enter array of {0} integer numbers:", n);

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("array[{0}]=", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        //sorting
        int leastNum;
        int tempNum;

        for (int i = 0; i < array.Length - 1; i++)
        {
            leastNum = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[leastNum])
                {
                    leastNum = j;
                }
            }
            if (leastNum != i)
            {
                tempNum = array[i];
                array[i] = array[leastNum];
                array[leastNum] = tempNum;
            }
        }
        Console.WriteLine();

        //output
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("array[{0}]={1}", i, array[i]);
        }
    }
}

