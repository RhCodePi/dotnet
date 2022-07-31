using System;
using System.Numerics;

namespace Rhcodepi // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? tmp, tmp_2;
            int _ext = -1, timesOfplay = 3, bestScore = 999;
            int guessNu = 0, countOfguess = 0;
            Random random = new Random();
            int randomNu = random.Next(1, 20);
            
            Console.WriteLine("Let's Play 'Guess the Number'\nI'm thinking of a number between 0-20\nEnter your guess or exit -1");
            while(guessNu != _ext)
            {
                try{
                    Console.WriteLine("What is your guess");
                    tmp = Console.ReadLine();
                    guessNu = Convert.ToInt32(tmp);
                    countOfguess++;
                    tmp_2 = (randomNu> guessNu) ? "higher" : "lower";
                    if(guessNu != -1)
                        Console.WriteLine((guessNu == randomNu) ? $"You got it in {countOfguess} guesses!!! ": $"Nope, {tmp_2} than that.");
                    
                    
                    if(guessNu == randomNu)
                    {
                        if(countOfguess < bestScore) bestScore = countOfguess;
                        countOfguess = 0;
                        timesOfplay--;
                        randomNu = random.Next(1, 20);
                        Console.WriteLine( $"Your best score {bestScore} last play {timesOfplay} \n");
                        if(timesOfplay == 0)break;
                    }
                    
                }
                catch (FormatException e){
                    Console.WriteLine("Hmm, that doest look like a number. Try again.");
                    Console.WriteLine(e.Message);
                    continue;
                }
            }
            

        }
    }
}