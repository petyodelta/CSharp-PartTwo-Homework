//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.


using System;

class IntegerCalculations
{
    static void Main()
    {
        Console.Write("Enter sequence of numbers split by \",\":");
        string str = Console.ReadLine();

        while (str == string.Empty)
        {
            Console.Write("The sequence should not be empty.\nEnter sequence of numbers split by \",\":");
            str = Console.ReadLine();
        }
        string[] arrayString = str.Split(',');
        int[] array = new int[arrayString.Length];

        Console.WriteLine("1-> Find min number");
        Console.WriteLine("2-> Find max number");
        Console.WriteLine("3-> Calculate average");
        Console.WriteLine("4-> Calculate sum");
        Console.WriteLine("5-> Calculate product");
        Console.Write("Enter your choice:");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                int minNumber = FindMinNumber(arrayString);
                //output
                Console.WriteLine("Minimum of the sequence is {0}", minNumber);
                break;
            case 2:
                int maxNumber = FindMaxNumber(arrayString);
                //output
                Console.WriteLine("Maximum of the sequence is {0}", maxNumber);
                break;
            case 3:
                double average = CalculateAverage(arrayString);
                //output
                Console.WriteLine("The average of the sequence is {0}", average);
                break;
            case 4:
                int sum = CalculateSum(arrayString);
                //output
                Console.WriteLine("The sum is {0}", sum);
                break;
            case 5:
                int product = CalculateProduct(arrayString);
                //output
                Console.WriteLine("The product is {0}", product);
                break;
            default: Console.WriteLine("Invalid choice");
                break;
        }
    }
    static int FindMinNumber(string[] arrayString)
    {
        int[] array = new int[arrayString.Length];
        int minNumber = int.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(arrayString[i]);
            if (array[i] < minNumber)
            {
                minNumber = array[i];
            }
        }
        return minNumber;
    }
    static int FindMaxNumber(string[] arrayString)
    {
        int[] array = new int[arrayString.Length];
        int maxNumber = int.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(arrayString[i]);
            if (array[i] > maxNumber)
            {
                maxNumber = array[i];
            }
        }
        return maxNumber;
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
    static int CalculateSum(string[] arrayString)
    {
        int[] array = new int[arrayString.Length];
        int sum = 0;
        //find sum
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(arrayString[i]);
            sum += array[i];
        }
        return sum;
    }
    static int CalculateProduct(string[] arrayString)
    {
        int[] array = new int[arrayString.Length];
        int product = 1;
        //find product
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(arrayString[i]);
            product *= array[i];
        }
        return product;
    }
}

