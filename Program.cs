using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

namespace CollatzConjecture
{
    public class Program
    {
        public static BigInteger startingNumber = new BigInteger();
        public static BigInteger x = 1;
        public static string filePath = @"CollatzConjectureLog\";

        static void Main()
        {
            string textFile = File.ReadAllText(@"CollatzConjectureLog\CurrentNumber.txt");
            startingNumber = BigInteger.Parse(textFile);
            Loop();
            return;
        }
        public static void Loop()
        {   
            while (x == 1)
            {
                Console.WriteLine($"Starting at {startingNumber}");
                string startingString = startingNumber.ToString();
                Logging(startingString, "CurrentNumber.txt");

                CollatzCalculations();
                if (x == 1)
                {
                    startingNumber = startingNumber + 1;
                }
                Console.Clear();
            }
        }

        public static bool IsOdd(BigInteger value)
        {
            return value % 2 != 0;
        }

        public static void CollatzCalculations()
        {
            List<BigInteger> numbersCalculated = new List<BigInteger>();
            x = startingNumber;

            while (x != 1)
            {
                if (IsOdd(x))
                {
                    x = 3 * x + 1;
                    Console.WriteLine($"New number {x}");
                    if (numbersCalculated.Contains(x))
                    { 
                        Console.WriteLine($"Collatz Conjecture proven false by {startingNumber}");
                        string successPath = numbersCalculated.ToString();
                        Logging(successPath, "CollatzConjectureSolution.txt");
                        break;
                    }

                    else
                    {
                        numbersCalculated.Add(x);
                    }
                }

                else
                {
                    x /= 2;
                    Console.WriteLine($"New number {x}");
                    if (numbersCalculated.Contains(x))
                    {
                        Console.WriteLine($"Collatz Conjecture proven false by {startingNumber}");
                        string successPath = startingNumber.ToString();
                        Logging(successPath, "CollatzConjectureSolution.txt");
                    }

                    else
                    {
                        numbersCalculated.Add(x);
                    }
                }
            }
        }

        public static void Logging(string value, string file)
        {
            using StreamWriter sw = File.AppendText(filePath + file);
            sw.WriteLine(value);
        }
    }
}