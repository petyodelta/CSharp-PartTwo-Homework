//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.

using System;
using System.Globalization;
using System.Text.RegularExpressions;



class DatesFromTextInCanada
{
    static void Main()
    {
        CultureInfo info = new CultureInfo("en-CA");
        System.Threading.Thread.CurrentThread.CurrentCulture = info;

        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        foreach (Match date in Regex.Matches(text, @"[0-9]{1,2}.[0-9]{1,2}.[0-9]{2,4}"))
        {
            DateTime result;
            if (DateTime.TryParseExact(date.Value,"d.M.yyyy",CultureInfo.InvariantCulture, DateTimeStyles.None, out result))
            {
                Console.WriteLine(result.ToString(info.DateTimeFormat.LongDatePattern));
            }
        }

    }
}

