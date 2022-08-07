using System;
using System.Collections.Generic;
using System.Linq;

namespace Rhcodepi
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Setup
            List<int> scores = new List<int>();

            for(int i = 1; i < 4; i++)
            {
                Console.WriteLine($"How many points did you score in game #{i}?");
                int input = int.Parse(Console.ReadLine());
                scores.Add(input);
            }

            // Result
            PrintStats(scores);
            Console.ReadKey();
        }

        // Rhodepi: Write your solution here
        public static void PrintStats(List<int> scores)
        {
            // lowest , higher, sum ,average
            int lowest = scores.Min();
            int highest = scores.Max();
            int sums = scores.Sum();
            int average = sums/scores.Count;

            Console.WriteLine($"Lowest scoring game -> {lowest}");
            Console.WriteLine($"Highest scoring game -> {highest}");
            Console.WriteLine($"Total season points -> {sums}");
            Console.WriteLine($"Average points per game -> {average}");
        }
    }
}