//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;
using System.Linq;

class Workdays
{
    static void Main()
    {
        DateTime endDate = new DateTime();
        Console.Write("Enter date: ");
        endDate = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter count of public holidays:");
        int count = int.Parse(Console.ReadLine());

        DateTime[] holidays = new DateTime[count];
        for (int i = 0; i < holidays.Length; i++)
        {
            Console.Write("Enter public holiday date: ");
            holidays[i] = DateTime.Parse(Console.ReadLine());
        }
        

        DateTime today = new DateTime();
        today = DateTime.Today;

        int workDays = CalculateWorkDays(today, endDate, holidays);

        Console.WriteLine(workDays);
        
    }
    static int CalculateWorkDays(DateTime today, DateTime endDate, DateTime[] holidays)
    {
        int workDays = 0;

        for (var date = today; date <= endDate; date= date.AddDays(1))
        {
            if (date.DayOfWeek != DayOfWeek.Saturday && 
                date.DayOfWeek != DayOfWeek.Sunday &&
                !holidays.Contains(date))
                ++workDays;
        }
        return workDays;
    }
}

