//Write a program to convert from any numeral system of given base s 
//to any other numeral system of base d (2 ≤ s, d ≤ 16).

using System;

class OneSystemToAnyOther
{
    static void Main()
    {
        Console.Write("Enter base s(s>=2) of the number: ");
        int inputBase = int.Parse(Console.ReadLine());

        Console.Write("Enter number: ");
        string strNum = Console.ReadLine();

        Console.Write("Enter base d(d<=16) you want to convert to: ");
        int outputBase = int.Parse(Console.ReadLine());

        long numberInDec = InputNumberInDecimal(strNum, inputBase);

        if (outputBase == 10 || numberInDec == 0)
        {
            Console.WriteLine("The input number in {0} base numeral system is {1}",outputBase, numberInDec);
            return;
        }
        
        string outputNum = DecimalInOutputNumber(numberInDec, outputBase);
        
        Print(outputNum, outputBase);

    }
    static long InputNumberInDecimal(string strNum, int inputBase)
    {
        long numberInDec = 0L;

        int pow = strNum.Length - 1;

        if (inputBase < 16)
        {

            for (int i = 0; i < strNum.Length; i++)
            {
                numberInDec += long.Parse(strNum[i].ToString()) * (long)Math.Pow(inputBase, pow - i);
            }
        }
        else if (inputBase == 16)
        {
            int hexDidits = 0;

            for (int i = 0; i < strNum.Length; i++)
            {

                switch (strNum[i])
                {
                    case 'A':
                        hexDidits = 10;
                        break;
                    case 'B':
                        hexDidits = 11;
                        break;
                    case 'C':
                        hexDidits = 12;
                        break;
                    case 'D':
                        hexDidits = 13;
                        break;
                    case 'E':
                        hexDidits = 14;
                        break;
                    case 'F':
                        hexDidits = 15;
                        break;
                    default:
                        hexDidits = int.Parse(strNum[i].ToString());
                        break;
                }
                numberInDec += hexDidits * (long)Math.Pow(16, pow - i);
            }
        }
        return numberInDec;
    }

    static string DecimalInOutputNumber(long numberInDec, int outputBase)
    {
        string outputNum = "";

        if (outputBase == 16)
        {
            while (numberInDec > 0)
            {
                long remainder = numberInDec % 16;
                numberInDec /= 16;
                switch (remainder)
                {
                    case 10:
                        outputNum += 'A';
                        break;
                    case 11:
                        outputNum += 'B';
                        break;
                    case 12:
                        outputNum += 'C';
                        break;
                    case 13:
                        outputNum += 'D';
                        break;
                    case 14:
                        outputNum += 'E';
                        break;
                    case 15:
                        outputNum += 'F';
                        break;
                    default:
                        outputNum += remainder.ToString();
                        break;
                }
            }
        }
        else
        {
            while (numberInDec > 0)
            {
                outputNum += Convert.ToString(numberInDec % outputBase);
                numberInDec /= outputBase;
            }
        }
        return outputNum;
    }
    
    static void Print(string outputNum, int outputBase)
    {
        for (int i = outputNum.Length - 1; i >= 0; i--)
        {
            if (i == outputNum.Length - 1)
            {
                Console.Write("The input number in {0} base numeral system is {1}", outputBase, outputNum[i]);
            }
            else
            {
                Console.Write(outputNum[i]);
            }
        }
        Console.WriteLine();
    }

}

