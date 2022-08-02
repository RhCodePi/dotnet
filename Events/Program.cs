using System;

namespace Rhcodepi
{
    class Program
    {
        
        private static int balanceGaol = 300;
        static void Main(string[] args)
        {
            string? str = "";
            int _val;
            EventPublisher obj = new EventPublisher();
            obj.changedEvent += new MyEventHandler(ChangeDeposit);

            while (str != "exit")
            {
                try
                {
                    Console.WriteLine("How much deposit ? ");
                    str = Console.ReadLine();
                    if (str == "exit") break;
                    _val = Int32.Parse(str);
                    obj.Balence = _val;
                }
                catch (FormatException) { }
            }

        }

        public static void ChangeDeposit(int value)
        {
            Console.WriteLine($"This value has change {value:C0}");
            if(value > balanceGaol)
            {
                Console.WriteLine($"You reached your savings goal! You Have {value}");
            }
        }
    }
}