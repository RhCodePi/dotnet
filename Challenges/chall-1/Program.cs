using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? str = "";

            while (str != "exit")
            {
                try
                {
                    Console.WriteLine("Enter age");
                    str = Console.ReadLine();
                    if (str == "exit") break;
                    int age = Int32.Parse(str);
                    Console.WriteLine(CalculatePresidents(age));

                }
                catch (FormatException) { Console.WriteLine("only type in integer value");}
            }
        }

        private static int CalculatePresidents(int age)
        {
            int result = 0, minVotingAge = 18;

            if (age < minVotingAge)
            {
                return 0;
            }
            else
            {
                result = (age - minVotingAge) / 4;
            }
            return result;
        }
    }
}