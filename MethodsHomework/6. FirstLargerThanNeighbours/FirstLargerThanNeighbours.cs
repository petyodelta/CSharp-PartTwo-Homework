//Write a method that returns the index of the first element in array
//that is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.


using System;

class FirstLargerThanNeighbours
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

        //find first element larger than its neighbours
        
        int index = FirstLarger(array);

        //output
        if (index >= 0)
        {
            Console.WriteLine("First element larger than neighbours is {0}", index);
        }
        else
        {
            Console.WriteLine("No such element.");
        }
        
    }
    static int FirstLarger(int[] array)
    {
        int index = -1;

        if (array.Length > 1)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    if (array[i] > array[i + 1])
                    {
                        index = i;
                        break;
                    }
                }
                else if (i == array.Length - 1)
                {
                    if (array[i] > array[i - 1])
                    {
                        index = i;
                        break;
                    }
                }
                else
                {
                    if (array[i] > array[i - 1] || array[i] > array[i + 1])
                    {
                        index = i;
                        break;
                    }
                }
            }
        }
        else
        {
            index = 0;
        }
        return index;
    }
}

