//Write a program that reads a rectangular matrix of size N x M
//and finds in it the square 3 x 3 that has maximal sum of its elements.


using System;

class MaximalSum
{
    static void Main()
    {
        //input
        Console.Write("Enter N=");
        int n = int.Parse(Console.ReadLine());
        while (n < 3)
        {
            Console.Write("Invalid number (N>=3). Enter N=");
            n = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter M=");
        int m = int.Parse(Console.ReadLine());
        while (m < 3)
        {
            Console.Write("Invalid number (M>=3). Enter M=");
            m = int.Parse(Console.ReadLine());
        }

        int[,] matrix = new int[n, m];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("matrix[{0},{1}]=",i,j);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        int squareWidth = 3;
        int squareHeight = 3;
        long bestSum = long.MinValue;
        int bestRow = 0;
        int bestCol = 0;

        for (int row = 0; row < matrix.GetLength(0) - squareHeight + 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - squareWidth + 1; col++)
            {
                long sum = 0;
                for (int squareRow = row; squareRow < row + squareHeight; squareRow++)
                {
                    for (int squareCol = col; squareCol < col + squareWidth; squareCol++)
                    {
                        sum += matrix[squareRow, squareCol];
                    }
                }
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }
        //output
        Console.WriteLine("Square {0}x{1} is:", squareWidth, squareHeight);
        for (int i = bestRow; i < bestRow + squareHeight; i++)
        {
            for (int j = bestCol; j < bestCol + squareWidth; j++)
            {
                Console.Write("{0} ", matrix[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("Best sum is {0}", bestSum);
    }
}

