//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
//Find in MSDN how to use System.IO.File.ReadAllText(…).
//Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.IO;

class ReadFileContents
{
    static void Main()
    {
        Console.Write("Enter file path:");
        string filePath = Console.ReadLine();
        ReadFilePath(filePath);
    }

    static void ReadFilePath(string filePath)
    {
        try
        {
            string file = File.ReadAllText(filePath);
            Console.WriteLine(file);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("The path is invalid");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Path contains invalid characters.");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Path or file name exceed the system-defined maximum length.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The specified path is invalid.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file not found.");
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O error occurred while opening the file.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("You don't have permission to open this file.");
        }
        
    }
}

