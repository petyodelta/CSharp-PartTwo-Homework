//Write a program that fills and prints a matrix of size (n, n) as shown below:
//1	12	11	10
//2	13	16	9
//3	14	15	8
//4	5	6	7


using System;

class FillTheMatrixD
{
    static void Main()
    {
        //input
        Console.Write("Enter number n=");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        //fill matrix
        int currentRow = 0;
        int currentCol = 0;
        int counter = 1;
        int sideLenght = n;

        while (counter <= n * n)
        {
            //direction down
            for (int i = 0; i < sideLenght; i++)
            {
                matrix[currentRow, currentCol] = counter;
                ++currentRow;
                ++counter;
            }

            --currentRow;
            ++currentCol;
            --sideLenght;
            //direction right
            for (int i = 0; i < sideLenght; i++)
            {
                matrix[currentRow, currentCol] = counter;
                ++currentCol;
                ++counter;
            }

            --currentCol;
            --currentRow;
            //direction up
            for (int i = 0; i < sideLenght; i++)
            {
                matrix[currentRow, currentCol] = counter;
                --currentRow;
                ++counter;
            }

            ++currentRow;
            --currentCol;
            --sideLenght;
            //direction left
            for (int i = 0; i < sideLenght; i++)
            {
                matrix[currentRow, currentCol] = counter;
                --currentCol;
                ++counter;
            }

            ++currentCol;
            ++currentRow;
        }

        //output
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,3}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}

