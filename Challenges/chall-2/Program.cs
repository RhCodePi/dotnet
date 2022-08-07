using System;

namespace Rhcodepi// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? str = "";
            Console.WriteLine("Enter email : ");
            str = Console.ReadLine();

            ValidateEmail(str);
        }

        private static void ValidateEmail(string eMail)
        {
            bool isFirst = false;
            string? atSymbol = "@";
            string? dotCom = ".com";

            if (char.IsNumber(eMail[0]) || char.IsPunctuation(eMail[0]) || char.IsWhiteSpace(eMail[0]))
            {
                Console.WriteLine($"first character cant be a {IsFirstChar(eMail[0])}");
                isFirst = true;
            }
            if (!isFirst)
            {
               if(!eMail.Contains(atSymbol)) Console.WriteLine("Must contain the @ symbol");
               if(!eMail.EndsWith(dotCom)) Console.WriteLine("e mail end with {.com}");
               if(eMail.Contains(atSymbol) && eMail.EndsWith(dotCom)) Console.WriteLine("Email is valid!");
            }
        }

        private static string? IsFirstChar(char character)
        {
            if(char.IsNumber(character)) return "number";
            else if(char.IsPunctuation(character)) return "symbol";
            else if(char.IsWhiteSpace(character)) return "white space";
            return null;
        }
    }
}