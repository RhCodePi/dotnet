using System;
using System.Collections.Generic;

namespace rhcodepi.fibsequence
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Enter the number of Fibonacci elements you'd like to calculate:");
            int input = int.Parse(Console.ReadLine());

            // MARK: Result
            var sequence = CalculateFibonacci(input);
            foreach (var fibonacci in sequence)
            {
                Console.WriteLine(fibonacci);
            }

            Console.ReadKey();
        }

        // MARK: Write your solution here
        public static List<int> CalculateFibonacci(int length)
        {
            List<int> sequence = new List<int>();
            int first = 0, second = 1, sums;
            sequence.Add(first);
            sequence.Add(second);
            for (int i = 0; i < length - 2; i++)
            {
                sums = first + second;
                first = second; 
                second = sums;
                sequence.Add(sums);
            }


            return sequence;
        }
    }
}