﻿//Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

class RandomNumbers
{
    static void Main()
    {
        Random randGenerator = new Random();

        for (int i = 0; i < 10; i++)
        {
            int number = randGenerator.Next(100, 201);
            Console.WriteLine(number);
        }
    }
}

