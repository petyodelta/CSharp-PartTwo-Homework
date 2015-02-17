//Write a program that fills and prints a matrix of size (n, n) as shown below:
//1  8	9	16
//2  7	10	15
//3  6	11	14
//4  5	12	13

using System;

class FillTheMatrixB
{
    static void Main()
    {
        //input
        Console.Write("Enter number n=");
        int n = int.Parse(Console.ReadLine());
        int counter = 1;
        int[,] matrix = new int[n, n];

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            if (col == 0 || col % 2 == 0)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = counter;
                    ++counter;
                }
            }
            else
            {
                for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                {
                     matrix[row, col] = counter;
                    ++counter;
                }
            }
        }

        //output
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,3} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}

