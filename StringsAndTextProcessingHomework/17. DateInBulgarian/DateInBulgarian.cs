//Write a program that reads a date and time given in the format: day.month.year hour:minute:second
//and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

using System;
using System.Globalization;


class DateInBulgarian
{
    static void Main()
    {
        CultureInfo info = new CultureInfo("bg-BG");
        System.Threading.Thread.CurrentThread.CurrentCulture = info;
        Console.Write("Enter date: ");
        DateTime inputDate = DateTime.Parse(Console.ReadLine());

        inputDate = inputDate.AddHours(6).AddMinutes(30);
        Console.WriteLine("{0} {0:dddd}", inputDate);
    }
}

