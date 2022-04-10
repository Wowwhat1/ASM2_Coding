﻿using System;

namespace _1618
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tempNumber = Console.ReadLine();

            PrintResult(ValidationInput(tempNumber));
        }

        static uint ValidationInput(string tempNumber)
        {
        CheckPoint:
            bool checkInput = uint.TryParse(tempNumber, out uint result);
            if (checkInput && result != 0)
            {
                return result;
            }
            else
            {
                Console.WriteLine("Retype: ");
                tempNumber = Console.ReadLine();
                goto CheckPoint;
            }
        }

        static int SumOfDigit(int eachNumber)
        {
            int modulo, sum = 0;
            while (eachNumber != 0)
            {
                modulo = eachNumber % 10;
                eachNumber /= 10;
                sum += modulo;
            }
            return sum;
        }

        static bool CheckSpecialNumber(int eachNumber)
        {
            return SumOfDigit(eachNumber) == 5 || SumOfDigit(eachNumber) == 7 || SumOfDigit(eachNumber) == 11;
        }

        static void PrintResult(uint number)
        {
            for (int i = 1; i <= number; i++)
            {
                int eachNumber = i;
                SumOfDigit(eachNumber);
                if (CheckSpecialNumber(eachNumber))
                    Console.WriteLine($"{i} => True");
                else
                    Console.WriteLine($"{i} => False");
            }
        }
    }
}
