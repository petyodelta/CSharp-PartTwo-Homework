//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

using System;


class CorrectBrackets
{
    static void Main()
    {
        Console.Write("Enter expression: ");
        string text = Console.ReadLine();

        char closeBracket = ')';
        int countCloseBracket = 0;

        char openBracket = '(';
        int countOpenBracket = 0;

        char tempBracket = ')';
        int tempCount = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == closeBracket)
            {
                if (tempBracket == ')' && tempCount == 0)
                {
                    Console.WriteLine("Incorrect");
                    return;
                }
                else
                {
                    ++countCloseBracket;
                    tempBracket = ')';
                    --tempCount;
                }
            }
            else if (text[i] == openBracket)
            {
                ++countOpenBracket;
                ++tempCount;
                tempBracket = '(';
            }
        }
        if (countOpenBracket == countCloseBracket)
        {
            Console.WriteLine("Correct");
        }
    }
}

