//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

using System;


class DateDifference
{
    static void Main()
    {
        Console.Write("Enter first date: ");
        DateTime firstDate = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter second date: ");
        DateTime secondDate = DateTime.Parse(Console.ReadLine());

        TimeSpan difference = secondDate.Subtract(firstDate);

        Console.WriteLine("{0} days", difference.Days);
    }
}

