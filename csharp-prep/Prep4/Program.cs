using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Console.WriteLine("Enter number:");
        // string userInput = Console.ReadLine();
        // int number = int.Parse(userInput);
        
        int number = -1000;

        List<int> numbers = new List<int>();

        while (number != 0)
        {
            Console.WriteLine("Enter number:");
            string userInput2 = Console.ReadLine();
                number = int.Parse(userInput2);
            
            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int total = 0;
        foreach (int n in numbers)
        {
            total += n;
        }

        Console.WriteLine($"The sum is: {total}");

        int avg = total / numbers.Count;
        Console.WriteLine($"The average is: {avg}");

        int max = numbers[0];

        foreach (int n in numbers)
        {
            if (n > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The largest number is: {max}");
    }
}