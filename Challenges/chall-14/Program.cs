using System;
using System.Collections.Generic;

namespace rhcodepi.shufflingcards
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Hit ENTER to shuffle the deck and deal the top 5 cards!");
            Console.ReadKey();

            // MARK: Result
            var freshDeck = new Deck();
            var shuffledDeck = Shuffle(freshDeck.cards);
            var topFive = new List<string>();
            int _five= 0;
            foreach (var item in shuffledDeck)
            {
                Console.WriteLine(item);
                if(_five < 5) topFive.Add(item);
                _five++;
            }
            Console.WriteLine("\nTop Five Cards");    
            foreach (var item in topFive)   
            {
                Console.WriteLine($"-> {item}");
            }
            
            Console.ReadKey();
        }

        // MARK: Write your solution here...
        public static List<string> Shuffle(List<string> deck)
        {
            var shuffle  = new Deck();
            Random random = new Random();
            int rand, preivosRand = 0;
            for (int i = 0; i < deck.Count; i++)
            {
                rand = random.Next(52);
                if(rand != preivosRand)
                {
                    deck[i] = shuffle.cards[rand];
                    preivosRand = rand;
                }
                else i--;
            }
            return deck;
        }
    }
}