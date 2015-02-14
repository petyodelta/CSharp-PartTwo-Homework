//We are given a matrix of strings of size N x M. Sequences in the matrix we define
//as sets of several neighbour elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.


using System;

class SequenceNMatrix
{
    static void Main()
    {
        Console.Write("Enter size N=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter size M=");
        int m = int.Parse(Console.ReadLine());

        string[,] matrix = new string[n,m];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("matrix[{0},{1}]=", i, j);
                matrix[i, j] = Console.ReadLine();
            }            
        }

        int maxSequence = 0;
        int currentSequence = 0;
        string maxString = "";

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                currentSequence = 0;
                for (int currRow = row; currRow < matrix.GetLength(0) - 1; currRow++) //vertical
                {
                    if (matrix[currRow + 1,col] == matrix[currRow,col])
                    {
                        ++currentSequence;
                    }
                    if (maxSequence < currentSequence)
                    {
                        maxSequence = currentSequence;
                        maxString = matrix[currRow,col];
                    }
                }

                currentSequence = 0;
                for (int currCol = col; currCol < matrix.GetLength(1) - 1; currCol++)//horizontal
                {
                    if (matrix[row,currCol + 1] == matrix[row,currCol])
                    {
                        ++currentSequence;
                    }
                    if (maxSequence < currentSequence)
                    {
                        maxSequence = currentSequence;
                        maxString = matrix[row,currCol];
                    }
                }

                currentSequence = 0;
                for (int currRow = row, currCol = col;(currRow < matrix.GetLength(0) - 1) && (currCol < matrix.GetLength(1) - 1);
                     currRow++, currCol++)
                {
                    if (matrix[currRow + 1,currCol + 1] == matrix[currRow,currCol])
                    {
                        ++currentSequence;
                    }
                    if (maxSequence < currentSequence)
                    {
                        maxSequence = currentSequence;
                        maxString = matrix[currRow,currCol];
                    }
                }
            }
        }

        for (int i = 0; i < maxSequence + 1; i++)
        {
            Console.Write(maxString + " ");
        }
    }
}

