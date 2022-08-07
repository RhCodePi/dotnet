using System;

namespace rhcodepi.tipcalculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Enter the cost of your meal to calculate tip options:");
            var input = int.Parse(Console.ReadLine());

            // MARK: Result
            //CalculateTip(input);

            var tips = CalculateTip(input);

            Console.WriteLine($"{tips.lowTip}\n{tips.midTip}\n{tips.highTip}");

            
            Console.ReadKey();
        }

        // MARK: Write your solution here
        public static (string lowTip, string midTip, string highTip) CalculateTip(int cost)
        {
            //solution without tuple

            // List<float> tipAmount = new List<float>() {0.1f, 0.175f, 0.25f};
            // float result;

            // foreach (var tip in tipAmount)
            // {
            //     result = cost*tip;
            //     Console.WriteLine($"{tip*100}% -> {result:C2}");
            // }

            // solution with tuple 
            (float, float, float) tip = (0.1f, 0.175f, 0.25f);

            float lowTip = cost * tip.Item1;
            float midTip = cost * tip.Item2;
            float highTip = cost * tip.Item3;
            
            return ($"{tip.Item1*100}% -> {lowTip:C2}", $"{tip.Item2 * 100}% -> {midTip:C2}", $"{tip.Item3*100}% -> {highTip:C2}");
        }
    }
}
