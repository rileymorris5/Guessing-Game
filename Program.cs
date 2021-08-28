using System;

namespace GuessingGame
{
    class Program
{
    static void Main(string[] args)
    {
        Console.Write("What chess piece moves in the shape of an L?\n\n");
        string secretWord = "knight";
        string guess = "";
        int guessCount = 0;
        int guessLimit = 3;
        bool outofGuesses = false;
        while (guess != secretWord && !outofGuesses)
        {
            if (guessCount < guessLimit)
            {
                Console.Write("Enter guess:");
                guess = Console.ReadLine();
                guessCount++;
            }
            else
            {
                outofGuesses = true;
            }
        }
        if (outofGuesses)
        {
            Console.Write("You Lose!");
        }
        else
        {
            Console.Write("You Win!");
        }

        Console.ReadLine();
    }
}
}
