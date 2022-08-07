using System;
using System.Collections.Generic;

namespace rhcodepi.countingvowels
{
    class MainClass
    {
        public static Dictionary<char, int> vowelScores = new Dictionary<char, int>()
        {
            { 'a', 1 },
            { 'e', 2 },
            { 'i', 3 },
            { 'o', 4 },
            { 'u', 5 },
            { 'v', 9 }
        };

        public static void Main(string[] args)
        {
            //Setup
            Console.WriteLine("Type in a word or phrase to find it's vowel score:");
            string input = Console.ReadLine().ToLower();

            //Result
            VowelCount(input);
            Console.ReadKey();
        }

        // solution
        public static void VowelCount(string text)
        {
            int score = 0; 
            foreach (var character in text)
            {
                foreach (var vowel in vowelScores)
                {
                    if(character == vowel.Key) 
                    {
                        score+= vowel.Value;
                        break;
                    }
                }    
            }

            Console.WriteLine($"Your point is {score}");
        }
    }
}