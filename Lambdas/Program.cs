using System;

namespace Rhcodepi
{
    class Program
    {
        private static decimal balanceGaol = 300;
        static void Main(string[] args)
        {
            string? str = "";
            decimal _val;
            EventPublisher obj = new EventPublisher();
            obj.changedEvent += x =>
            {
                Console.WriteLine($"The balace amount is {x:C0}");
                if (x > balanceGaol) Console.WriteLine($"You reached your savings goal! You Have {x}");
            };


            while (str != "exit")
            {
                try
                {
                    Console.WriteLine("How much to deposit ? ");
                    str = Console.ReadLine();
                    if (str == "exit") break;
                    _val = Decimal.Parse(str);
                    obj.Balence = _val;
                }
                catch (FormatException) { }
            }

        }
    }
}