//Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
//Find in Google how to download files in C#.
//Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Net;

class DownloadFile
{
    static void Main()
    {
        var myImage = new WebClient();
        try
        {
            using (myImage)
            {
                Console.Write("Enter image web address:");
                string url = Console.ReadLine();

                myImage.DownloadFile(url, @"..\..\myImage.png");

                Console.WriteLine("Image downladed.");
            }
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid address.");
        }
        catch (WebException)
        {
            Console.WriteLine("An error occurred while downloading data. Invalid address or file does not exist.");
        }
        catch (NotSupportedException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}