using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("Name:");
            string userName = Console.ReadLine();

            return userName;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("Favorite Number:");
            string userNumber = Console.ReadLine();
            int favNumber = int.Parse(userNumber);

            return favNumber;
        }

        static int SquareNumber(int numInput)
        {
            int numSq = numInput * numInput;

            return numSq;
        }

        static void DisplayResult(string name,int numSq)
        {
            Console.WriteLine($"{name}, the square of your favorite number is {numSq}");
        }

        // Calling the functions
        DisplayWelcome();
        string userName = PromptUserName();
        int userFavNum = PromptUserNumber();
        int favNumSq = SquareNumber(userFavNum);
        DisplayResult(userName, favNumSq);
    }
}