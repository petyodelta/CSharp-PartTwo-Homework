//Write a program that fills and prints a matrix of size (n, n) as shown below:
//7  11	14	16
//4  8	12	15
//2  5	9	13
//1  3	6	10


using System;

class FillTheMatrixC
{
    static void Main()
    {
        //input
        Console.Write("Enter number n=");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        //fill matrix
        int row = n - 1;
        int col = 0;
        int counter = 0;

        for (int i = 0; i < n; i++)
        {
            do
            {
                ++counter;
                if (row < 0)
                {
                    row = 0;                    
                }
                matrix[row, col] = counter;
                ++row;
                ++col;
            } while (row < n);
            row -= col + 1;
            col = 0;
        }

        row = 0;
        col = 1;
        for (int i = 0; i < n - 1; i++)
        {
            do
            {
                ++counter;
                matrix[row, col] = counter;
                ++row;
                ++col;
            } while (col < n);
            col -= row - 1;
            row = 0;
        }

        //output
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,3}",matrix[i,j]);
            }
            Console.WriteLine();
        }
    }
}

