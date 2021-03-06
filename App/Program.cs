﻿using System;
using Library;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = null;

            while (!"exit".Equals(input, comparisonType: StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("Please enter a value (or exit to terminate the program): ");
                input = Console.ReadLine();
                if (int.TryParse(input, out var number))
                {
                    Console.WriteLine($"---------------- First {number} fibonacci values are -----------------");
                    FibonacciGenerator fibonacciGenerator = new FibonacciGenerator();

                    foreach (var fibNumber in fibonacciGenerator.Generate(number))
                    {
                        Console.WriteLine(fibNumber);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input: Not a number");
                }
            }

            Console.WriteLine("Terminating the program ... bye bye !! ");
        }
    }
}
