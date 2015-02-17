//Write a program that fills and prints a matrix of size (n, n) as shown below:
//1	 5	9	13
//2	 6	10	14
//3	 7	11	15
//4	 8	12	16


using System;

class FillTheMatrixA
{
    static void Main()
    {
        //input
        Console.Write("Enter number n=");
        int n = int.Parse(Console.ReadLine());
        int counter = 1;
        int[,] matrix = new int[n,n];
                
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row, col] = counter;
                ++counter;
            }
        }
        
        //output
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,3} ", matrix[row,col]);
            }
            Console.WriteLine();
        }
    }
}

