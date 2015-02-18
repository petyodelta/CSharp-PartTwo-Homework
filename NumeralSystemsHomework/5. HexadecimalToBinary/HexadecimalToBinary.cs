//Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;

class HexadecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter hexadecimal number: ");
        string strNumber = Console.ReadLine();
        string strHexNumber = "";

        for (int i = 0; i < strNumber.Length; i++)
        {

            switch (strNumber[i])
            {
                case 'A':
                    strHexNumber += "1010";
                    break;
                case 'B':
                    strHexNumber += "1011";
                    break;
                case 'C':
                    strHexNumber += "1100";
                    break;
                case 'D':
                    strHexNumber += "1101";
                    break;
                case 'E':
                    strHexNumber += "1110";
                    break;
                case 'F':
                    strHexNumber += "1111";
                    break;
                case '0':
                    strHexNumber += "0000";
                    break;
                case '1':
                    strHexNumber += "0001";
                    break;
                case '2':
                    strHexNumber += "0010";
                    break;
                case '3':
                    strHexNumber += "0011";
                    break;
                case '4':
                    strHexNumber += "0100";
                    break;
                case '5':
                    strHexNumber += "0101";
                    break;
                case '6':
                    strHexNumber += "0110";
                    break;
                case '7':
                    strHexNumber += "0111";
                    break;
                case '8':
                    strHexNumber += "1000";
                    break;
                case '9':
                    strHexNumber += "1001";
                    break;
            }
        }

        if (strHexNumber == "0000")
        {
            Console.WriteLine("Number 0(hex) in binary is 0");
        }
        else
        {
            Console.WriteLine("Number {0}(hex) in binary is {1}", strNumber, strHexNumber.TrimStart(new char[] { '0' }));
        }
        
    }
}

