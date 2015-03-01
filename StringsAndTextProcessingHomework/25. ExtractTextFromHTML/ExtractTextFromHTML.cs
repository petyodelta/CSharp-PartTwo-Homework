//Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.

using System;
using System.Collections.Generic;
using System.Text;

class ExtractTextFromHTML
{
    static void Main()
    {
        //Console.Write("Enter text: ");
        //string text = Console.ReadLine();
        string text =@"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">TelerikAcademy</a>aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p></body></html>";
        
        StringBuilder sb = new StringBuilder();

        bool isInTag = false;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '<')
            {
                isInTag = true;
            }

            if (!isInTag)
            {
                sb.Append(text[i]);

                if (text[i + 1] == '<')
                {
                    sb.AppendLine();
                }
            }

            if (text[i] == '>')
            {
                isInTag = false;
            }
        }

        Console.WriteLine(sb.ToString().Trim());
    }
}

