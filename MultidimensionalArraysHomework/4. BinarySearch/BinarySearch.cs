//Write a program, that reads from the console an array of N integers and an integer K,
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.


using System;

class BinarySearch
{
    static void Main()
    {
        //input
        Console.Write("Enter array lenght:");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("array[{0}]=", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter number K=");
        int k = int.Parse(Console.ReadLine());
        int target = k;

        //sort and find largest number  <= K
        Array.Sort(array);

        while (Array.BinarySearch(array, target) < 0)
        {
            --target;    
        }

        //output
        Console.WriteLine("The largest number in the array which is less or equal to {0} is {1} ",k ,target);
    }    
}

