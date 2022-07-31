using System;
using System.Text;

namespace Rhcodepi // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (bool, int) tup;
            string? str = " ", exit = "exit";
            
            Console.WriteLine("Let's begin ");
            while (true)
            {
                str = Console.ReadLine();
                if (str != exit)
                {
                    (tup.Item1, tup.Item2) = IsPalindrome(str);
                    Console.WriteLine("Palindrome : " + tup.Item1.ToString() + ", Length : " + tup.Item2);
                }
                else break;
            }
        }

        static (Boolean, int) IsPalindrome(string str)
        {
            int lengthStr = 0, inSameCount = 0;
            bool isPalindrome = (lengthStr % 2 == 0) ? false : true; // is false ===> not a palindrome, is true may palindrom;

            StringBuilder sb = new StringBuilder();

            foreach (var s in str)
            {
                if(!char.IsPunctuation(s) && !char.IsWhiteSpace(s)) sb.Append(s);
            }

            str = sb.ToString().ToLower();
            Console.WriteLine(str);
            lengthStr = str.Length;
            for (int i = 0; i < (int)lengthStr / 2; i++)
            {
                if (str[i] == str[lengthStr - 1 - i]) inSameCount++;
                else return (false, 0);
            }

            if (inSameCount == (int)lengthStr / 2 && inSameCount != 0) isPalindrome = true;
            return (isPalindrome, lengthStr);
        }
    }
}