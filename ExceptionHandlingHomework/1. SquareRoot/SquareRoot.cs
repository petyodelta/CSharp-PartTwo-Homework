/*Write a program that reads an integer number and calculates and prints its square root.
If the number is invalid or negative, print Invalid number.
In all cases finally print Good bye.
Use try-catch-finally block.*/

using System;


class SquareRoot
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Calculate Sqrt.");
            Console.Write("Enter positive integer number: ");
            int number = int.Parse(Console.ReadLine());
            if(number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            
            double numberSqrt = Math.Sqrt(number);
            Console.WriteLine("The square root of {0}={1:F3}", number, numberSqrt);
                      
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: The number is not in correct format!");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Error: The number should be positive.");
        }
        finally
        {
            Console.WriteLine("Good bye.");
        }
    }
}

