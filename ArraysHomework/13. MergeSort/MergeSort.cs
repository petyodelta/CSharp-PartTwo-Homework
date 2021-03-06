﻿//Write a program that sorts an array of integers using the Merge sort algorithm.


using System;

class MergeSort
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

        Mergesort(array);
        
        //output
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
    }

    static void Merge(int[] arrayLeft, int[] arrayRight, int[] array)
    {
        int lenghtLeft = arrayLeft.Length;
        int lenghtRight = arrayRight.Length;
        int i = 0;//index Left
        int j = 0;//index Right
        int k = 0;//index array

        while (i < lenghtLeft && j < lenghtRight)
        {
            if (arrayLeft[i] <= arrayRight[j])
            {
                array[k] = arrayLeft[i];
                ++i;
            }
            else
            {
                array[k] = arrayRight[j];
                ++j;
            }
            ++k;
        }

        while (i < lenghtLeft)//if only left has elements after merge
        {
            array[k] = arrayLeft[i];
            ++i;
            ++k;
        }

        while (j < lenghtRight)//if only right has elements after merge
        {
            array[k] = arrayRight[j];
            ++j;
            ++k;
        }
    }

    static void Mergesort(int[] array)
    {
        int n = array.Length;
        if (n < 2)
        {
            return;
        }
        else
        {
            int center = n / 2;
            int[] arrayLeft = new int[center];
            int[] arrayRight = new int[n - center];

            for (int i = 0; i < center; i++)
            {
                arrayLeft[i] = array[i];
            }
            for (int i = center; i < n; i++)
            {
                arrayRight[i - center] = array[i];
            }

            Mergesort(arrayLeft);
            Mergesort(arrayRight);
            Merge(arrayLeft, arrayRight, array);
        }
    }
}

