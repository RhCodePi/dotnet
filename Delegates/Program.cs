using System;

namespace Rhcodepi
{
    internal class Program
    {
        public delegate string MyDelegate(string zone, float price);
        static void Main(string[] args)
        {
            ShippingFess ship = new ShippingFess();
            MyDelegate F = ship.CalculateZoneFees;
            float price;
            string? str = "", str1;


            while (str != "exit")
            {
                Console.WriteLine("what is the destination zone");
                str = Console.ReadLine();
                if (str == "exit") break;
                if (ship.zoneExist)
                {
                    Console.WriteLine("What is the item price : ");
                    str1 = Console.ReadLine();
                    price = Convert.ToSingle(str1);
                    Console.WriteLine($"The shipping fees are  : {F(str, price)}");
                }
                else {
                    Console.WriteLine("Hmm, you seem to have entered unknown destination.");
                }

            }

        }
    }
}