//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().


using System;

class GetLargestNumber
{
    static void Main()
    {
        //input
        Console.Write("Enter first number:");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Enter second number:");
        int secondNum = int.Parse(Console.ReadLine());
        Console.Write("Enter third number:");
        int thirdNum = int.Parse(Console.ReadLine());
        
        //finding biggest number
        int biggestNum;

        biggestNum = GetMax(firstNum, secondNum);
        biggestNum = GetMax(biggestNum, thirdNum);

        //output
        Console.WriteLine("The biggest number is {0}", biggestNum);

    }
    static int GetMax(int firstNum,int secondNum)
    {
        int biggestNum = firstNum;
        if (firstNum <= secondNum)
        {
            biggestNum = secondNum;
        }
        return biggestNum;
    }
}

