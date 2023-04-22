using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string userInput = Console.ReadLine();
        int gradePct = int.Parse(userInput);

        string letter = "";

        if (gradePct >= 90)
        {
            letter = "A";
        }
        else if (gradePct >= 80)
        {
            letter = "B";
        }
        else if (gradePct >= 70)
        {
            letter = "C";
        }
        else if (gradePct >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is {letter}.");

        if (gradePct >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("I am sorry, you didn't pass. But don't give up and try again next semester.");
        }
    }
}