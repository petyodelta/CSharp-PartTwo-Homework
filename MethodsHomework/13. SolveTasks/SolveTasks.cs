/*Write a program that can solve these tasks:
Reverses the digits of a number
Calculates the average of a sequence of integers
Solves a linear equation a * x + b = 0
Create appropriate methods.
Provide a simple text-based menu for the user to choose which task to solve.
Validate the input data:
The decimal number should be non-negative
The sequence should not be empty
a should not be equal to 0
**/

using System;

class SolveTasks
{
    static void Main()
    {
        Console.WriteLine("1-> Reverse the digits of a number");
        Console.WriteLine("2-> Calculate the average of a sequence of integers ");
        Console.WriteLine("3-> Solve a linear equation a * x + b = 0");
        Console.Write("Enter your choice:");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                //input
                Console.Write("Enter number: ");
                int number = int.Parse(Console.ReadLine());
                while (number < 0)
                {
                    Console.Write("Enter non-negative number! ");
                    number = int.Parse(Console.ReadLine());
                }
                
                int[] array = NumberReversed(number);

                //output
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i]);
                }
                Console.WriteLine();
                break;
            case 2:
                //input
                Console.Write("Enter sequence of numbers split by \",\":");
                string str = Console.ReadLine();
                 
                while (str == string.Empty)
                {
                    Console.Write("The sequence should not be empty.\nEnter sequence of numbers split by \",\":");
                    str = Console.ReadLine();
                }
                string[] arrayString = str.Split(',');
                double average = CalculateAverage(arrayString);
                //output
                Console.WriteLine("The average of a sequence is {0}", average);
                break;
            case 3:
                //input
                Console.Write("Enter a=");
                int a = int.Parse(Console.ReadLine());
                while (a == 0)
                {
                    Console.Write("a could not be 0. Enter a=");
                    a = int.Parse(Console.ReadLine());
                }
                Console.Write("Enter b=");
                int b = int.Parse(Console.ReadLine());
                double x = CalculateLinearEquation(a, b);
                //output
                Console.WriteLine("x={0}",x);
                break;
        }
    }
    static int[] NumberReversed(int number)
    {
        int digitCount = 0;
        int temp = number;
        //count digits in number
        while (temp > 0)
        {
            temp /= 10;
            ++digitCount;
        }

        //put digits in array
        int[] array = new int[digitCount];

        while (number > 0)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = number % 10;
                number /= 10;
            }
        }

        return array;
    }
    static double CalculateAverage(string[] arrayString)
    {
        int[] array = new int[arrayString.Length];
        double sum = 0;
        //find average
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(arrayString[i]);
            sum += array[i];
        }
        double average = sum / array.Length;
        return average;
    }
    static double CalculateLinearEquation(int a, int b)
    {
        // a*x+b=0
        double x =(double)(-b) / (double)(a);
        return x;
    }
}

