using System;

class Program
{
    static void Main(string[] args)
    {
        string play = "yes";

        while (play == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;
            int count = 0;

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                count = count + 1;

                if (guess == magicNumber)
                {
                    Console.WriteLine("You guessed it! ");
                    Console.WriteLine($"It took you {count} tries to guess the number. ");

                    Console.Write("Would you like to play again? ");
                    play = Console.ReadLine();
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower ");
                }
                else
                {
                    Console.WriteLine("Higher ");
                }

            } 
        }
    }
}