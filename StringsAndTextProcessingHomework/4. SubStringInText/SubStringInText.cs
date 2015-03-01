//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


class SubStringInText
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        Console.Write("Enter target string: ");
        string target = Console.ReadLine();

        text = text.ToLower();

        int counter = 0;
                
        int index = text.IndexOf(target);
        while (index >= 0)
        {
            ++counter;
            index = text.IndexOf(target, index + 1);
        }
        Console.WriteLine("{0} found {1} times.",target, counter);
    }
}

