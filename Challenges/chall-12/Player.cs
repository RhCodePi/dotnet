using System;

namespace rhcodepi.gamenight
{
    public class Player
    {
        public string firstname{get; set;}
        public string lastname {get; set;}
        public int currentScore {get; set;}
        public int lastScore{get; set;}

        public Player(string first, string last, int score, int previous)
        {
            firstname = first;
            lastname = last;
            currentScore = score;
            lastScore = previous;
        }


    }
}