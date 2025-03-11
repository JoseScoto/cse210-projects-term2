using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask for the magic number
        //Console.Write("What is the magic number? ");
        //string magicNumber = Console.ReadLine();
        //int number = int.Parse(magicNumber);
        
        // Part 3 of the challenges
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        // Initializing variable to be able to use it inside loop
        int userGuess = -1;

        while (userGuess != number)
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            userGuess = int.Parse(guess);

            if (userGuess < number)
            {
            Console.WriteLine("Higher");
            }

            else if (userGuess > number)
            {
            Console.WriteLine("Lower");
            }

            else
            {
            Console.WriteLine("You guessed it!");
            }
        }

    }
}