using System;

namespace Rhcodepi
{
    internal class Program
    {
        private static int randomVal = 0;
        private static string? str = "";
        static void Main(string[] args)
        {
            GenarateRandom randomNu = new GenarateRandom();
            while (str != "exit")
            {
                try
                {
                    Console.WriteLine("Enter a number for the upper bound : ");
                    str = Console.ReadLine();
                    randomVal = Convert.ToInt32(str);

                    Console.WriteLine($"Random number between 0 and {randomVal} : {randomNu.GetRandomNum(randomVal)}");
                }
                catch (FormatException){}
            }
        }
    }
}