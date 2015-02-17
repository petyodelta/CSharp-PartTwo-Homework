//Write a method that checks if the element at given position
//in given array of integers is larger than its two neighbours (when such exist).


using System;

class LargerThanNeighbours
{
    static void Main()
    {
        //input
        Console.Write("Enter array lenght: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("array[{0}]=", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Witch element to check: ");
        int checkElement = int.Parse(Console.ReadLine());
        
        //check if larger
        bool islarger = CheckIfLarger(array, checkElement);

        //output
        Console.WriteLine("array[{0}]={1} is larger than its neghbours: {2}", checkElement, array[checkElement], islarger);
    }
    static bool CheckIfLarger(int[] array, int checkElement)
    {
        bool isLarger = true;

        if (checkElement == 0)
        {
            if (array[checkElement] < array[checkElement + 1])
            {
                isLarger = false;
            }
        }
        else if (checkElement == array.Length - 1)
        {
            if (array[checkElement] < array[checkElement - 1])
            {
                isLarger = false;
            }
        }
        else
        {
            if (array[checkElement] < array[checkElement - 1] || array[checkElement] < array[checkElement + 1])
            {
                isLarger = false;
            }
        }
        return isLarger;
    }
}

