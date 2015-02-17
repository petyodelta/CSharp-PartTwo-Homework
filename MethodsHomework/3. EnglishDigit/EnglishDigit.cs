//Write a method that returns the last digit of given integer as an English word.


using System;

class EnglishDigit
{
    static void Main()
    {
        //input
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        //return last digit as word
        int lastDigit = number % 10;
        string word = DigitAsWord(lastDigit);

        //output
        Console.WriteLine("Las digit is {0}.", word);
    }

    static string DigitAsWord(int digit)
    {
        string word = "";
        switch(digit)
        {
            case 0: word = "zero"; break;
            case 1: word = "one"; break;
            case 2: word = "two"; break;
            case 3: word = "three"; break;
            case 4: word = "four"; break;
            case 5: word = "five"; break;
            case 6: word = "six"; break;
            case 7: word = "seven"; break;
            case 8: word = "eight"; break;
            case 9: word = "nine"; break;
        }
        return word;
    }
}

