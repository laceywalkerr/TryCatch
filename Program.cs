using System;
using System.Collections.Generic;
using System.Linq;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Guess a number: ");
            string input = Console.ReadLine();

            try
            {
                int inputNum = int.Parse(input);
                Console.WriteLine($"your guess was {inputNum}");

                Console.WriteLine(1000 / inputNum);
            }

            catch
            {
                Console.WriteLine($"not a valid number");
            }

        }
    }
}