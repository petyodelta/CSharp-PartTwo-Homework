//Write a program to convert binary numbers to hexadecimal numbers (directly).


using System;

class BinaryToHexadecimal
{
    static void Main()
    {
        //input
        Console.Write("Enter binary number: ");
        long number = long.Parse(Console.ReadLine());
        long temp = number;
        
        //convert       
        int[] array = new int[4];
        string hexNumber = "";
        string hexDigit = "";
        
        while (temp > 0)
        {
            for (int i = 3; i >= 0; i--)
            {
                array[i] = (int)(temp % 10);
                temp /= 10;
            }
            
            foreach (var digit in array)
            {
                hexDigit += digit.ToString();
            }
            switch (hexDigit)
            {
                case "0000": hexNumber += "0"; break;
                case "0001": hexNumber += "1"; break;
                case "0010": hexNumber += "2"; break;
                case "0011": hexNumber += "3"; break;
                case "0100": hexNumber += "4"; break;
                case "0101": hexNumber += "5"; break;
                case "0110": hexNumber += "6"; break;
                case "0111": hexNumber += "7"; break;
                case "1000": hexNumber += "8"; break;
                case "1001": hexNumber += "9"; break;
                case "1010": hexNumber += "A"; break;
                case "1011": hexNumber += "B"; break;
                case "1100": hexNumber += "C"; break;
                case "1101": hexNumber += "D"; break;
                case "1110": hexNumber += "E"; break;
                case "1111": hexNumber += "F"; break;
            }
            hexDigit = "";
            Array.Clear(array,0,4);
        }

        //output
        for (int i = hexNumber.Length - 1; i >= 0; i--)
        {
            if (i == hexNumber.Length - 1)
            {
                Console.Write("The number {0}(bin) in hexadecimal is {1}", number, hexNumber[i]);
            }
            else
            {
                Console.Write(hexNumber[i]);
            }
        }
        Console.WriteLine();
    }
}

