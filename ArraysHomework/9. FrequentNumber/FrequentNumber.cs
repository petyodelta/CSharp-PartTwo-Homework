//Write a program that finds the most frequent number in an array.


using System;

class FrequentNumber
{
    static void Main()
    {
        //input


        Console.Write("Enter array lenght:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter array numbers(0,1,2,3...):");
        string[] arrayString = Console.ReadLine().Split(',');
        int[] array = new int[arrayString.Length];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(arrayString[i]);
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

        //count most frequent
        
        int lenght = 1;
        int longestStart = 0;
        int longestLenght = 1;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i - 1])
            {
                ++lenght;
                if (lenght > longestLenght)
                {
                    longestLenght = lenght;
                    longestStart = i - longestLenght + 1;
                }
            }
            else
            {
                lenght = 1;
            }
        }

        //output
        Console.WriteLine("{0}({1} times)", array[longestStart], longestLenght);
    }
}

