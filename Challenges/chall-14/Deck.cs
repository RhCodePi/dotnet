using System;
using System.Collections.Generic;

namespace rhcodepi.shufflingcards
{
    enum CardSuit { HEARTS, DIAMONDS, SPADES, CLUBS }

    public class Deck
    {
        public List<string> cards;

        public Deck()
        {
            cards = new List<string>();

            foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
            {
                for (int y = 2; y < 11; y++)
                {
                    cards.Add($"{y.ToString()} of {suit}");
                }

                cards.Add($"A of {suit}");
                cards.Add($"J of {suit}");
                cards.Add($"Q of {suit}");
                cards.Add($"K of {suit}");
            }
        }
    }
}