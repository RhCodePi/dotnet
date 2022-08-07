using System;
using System.Collections.Generic;

namespace rhcodepi.partyrsvp
{
    class MainClass
    {
        static List<string> family = new List<string>() { "Harrison", "Kelsey", "Alex", "Haley" };
        static List<string> friends = new List<string>() { "James", "Hannah", "Kelly", "Alex" };
        static List<string> rsvp = new List<string>() { "Kelly", "Harrison" };

        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Hit ENTER to see your party invite breakdown!");
            Console.ReadKey();

            // MARK: Result
            InviteDetails();
            Console.ReadKey();
        }

        // MARK: Write your solution here
        public static void InviteDetails()
        {
            int totalInvites = family.Count + friends.Count;

            List<string> dupList = FindDup(), allInvited = new List<string>();

            allInvited.AddRange(family);
            allInvited.AddRange(friends);

            var missingRsvp = allInvited.Except(rsvp);

            Console.WriteLine($"{totalInvites} total invites \n{dupList.Count} duplicat -> {String.Join(", ", dupList)}\nMissing RVPSs -> {String.Join(", ", missingRsvp)}");   
        }

        private static List<string> FindDup()
        {
            int duplicateCount = 0;
            List<string> dupStr = new List<string>();
            foreach (var i in family)
            {
                foreach (var f in friends)
                {
                    if(i == f)
                    {
                        duplicateCount++;
                        dupStr.Add(i);
                    }
                }
            }
            return dupStr;
        }
    }
}