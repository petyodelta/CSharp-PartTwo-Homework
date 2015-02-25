﻿//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.

using System;


class LeapYear
{
    static void Main()
    {
        Console.Write("Enter year:");
        int year = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Is year {0} leap? {1}",year , DateTime.IsLeapYear(year));
    }
}

