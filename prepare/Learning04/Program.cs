using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment testA = new Assignment("Eu", "So os loucos sabem");
        MathAssignment testB = new MathAssignment("Voce", "So os loucos sabem", "Disso os Loucos Sabem", "Chorao");
        WritingAssignment testC = new WritingAssignment("Eu", "Nao", "Sei");

        Console.WriteLine(testA.GetSummary());
        Console.WriteLine(testB.GetHomeworkList());
        Console.WriteLine(testC.GetWritingInformation());
    }
}