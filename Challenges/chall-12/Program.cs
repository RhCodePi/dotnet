using System;
using System.Collections.Generic;
using System.Linq;

namespace rhcodepi.gamenight
{
    class MainClass
    {
        public static List<Player> players = new List<Player>()
        {
            new Player("Harrison", "Ferrone", 233, 198),
            new Player("Alex", "Ferrone", 219, 202),
            new Player("Haley", "Ferrone", 241, 222),
            new Player("John", "Doe", 144, 198),
            new Player("Sally", "Doe", 233, 198),
            new Player("Frank", "Smith", 189, 234),
            new Player("Joan", "Smith", 211, 178)
        };

        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Enter an improvement index to see which game night attendees fit the bill:");
            var targetImprovement = int.Parse(Console.ReadLine());
            
            // MARK: Result
            var playerStat = PrintStats(targetImprovement);
            playerStat.firstChar.Sort();
            
            foreach (var firstChar in playerStat.firstChar)
            {
                Console.WriteLine($"{firstChar}");
                for (int i = 0; i < playerStat.lastName.Count; i++)
                {
                    if(firstChar == playerStat.lastName[i][0])
                    {
                        Console.WriteLine($"-> {playerStat.firstName[i]} {playerStat.lastName[i]} improved");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        // MARK: Write your solution here...
        public static (List<char> firstChar, List<string> firstName, List<string> lastName) PrintStats(int targetImprovement)
        {
            HashSet<char> hashset = new HashSet<char>();
            (List<char>, List<string>, List<string>) stats = (new List<char>(), new List<string>(), new List<string>());
            int targeScore = 0;
            foreach (var player in players)
            {
                targeScore = player.currentScore - player.lastScore;
                if (targeScore > targetImprovement)
                {
                    hashset.Add(player.lastname.First());
                    stats.Item2.Add(player.firstname);
                    stats.Item3.Add(player.lastname);
                }
            }
            stats.Item1.AddRange(hashset.ToList());
            return (stats.Item1, stats.Item2, stats.Item3);
        }
    }
}