//Write a progam that finds in given array of integers a sequence of given sum S (if present).


using System;

class FindSumInArray
{
    static void Main()
    {
        //input
        Console.Write("Enter lenght of the array:");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter array {0} numbers split by \",\":", n);
        string[] arrayString = Console.ReadLine().Split(',');

        int[] array = new int[arrayString.Length];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(arrayString[i]);
        }

        Console.Write("Enter sum s=");
        int sum = int.Parse(Console.ReadLine());

        //finding sequence
        int checkSum = 0;
        int start = 0;
        int startIndex = 0;
        int endIndex = 0;

        for (int i = 0; i < array.Length; i++)
        {
            checkSum += array[i];

            if (checkSum > sum)
            {
                checkSum = array[i];
                start = i;
                //
                if (checkSum == sum)
                {
                    startIndex = start;
                    endIndex = i;
                    break;
                }
            }
            else if (checkSum < sum)
            {
                startIndex = start;
                endIndex = i;
            }
            else if (checkSum == sum)
            {
                endIndex = i;
                break;
            }
            else
            {
                Console.WriteLine("No valid sequece");
            }

        }

        //output
        if (checkSum < sum)
        {
            Console.WriteLine("No valid sequece");
        }
        else
        {
            for (int i = startIndex; i <= endIndex; i++)
            {
                if (i == endIndex)
                {
                    Console.Write("{0}", array[i]);
                }
                else
                {
                    Console.Write("{0},", array[i]);
                }

            }
            Console.WriteLine();
        }
    }
}

