using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 101);

        int guess = 0;
        while (guess != magicNum)
        {
            Console.WriteLine("What is your guess?");
            string userInput2 = Console.ReadLine();
            guess = int.Parse(userInput2);

            if (guess > magicNum)
            {
                Console.WriteLine("Lower");
            }

            else if (guess < magicNum)
            {
                Console.WriteLine("Higher");
            }

            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}