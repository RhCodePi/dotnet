using System;

namespace Rhcodepi
{
    internal class Program
    {
         public static void Main(string[] args)
        {
            // Setup
            string exampleURL = "www.docs.microsoft.com/dotnet/csharp/whats-new/csharp-version-history";
            Console.WriteLine($"Hit ENTER to break down the URL into its component parts: {exampleURL}");
            Console.ReadKey();

            //Result
            var components = BreakdownURL(exampleURL);
            for (int i = 0; i < components.Length; i++)
            {
                var indent = new string(' ', i * 2);
                Console.WriteLine($"{indent} -> {components[i]}");
            }
        }

        // Rhcodepi: Calculation
        public static string[] BreakdownURL(string urlString)
        {
            string? str = urlString.Remove(0, 4);

            string[] strArray = str.Split("/");

            for (int i = 0; i < strArray.Count(); i++)
            {
                if(strArray[i].Contains("-")) strArray[i] = strArray[i].Replace("-", " ");
            }

            return strArray;
        }
    }
}