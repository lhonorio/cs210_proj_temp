using System.Text.RegularExpressions;

public class Menu
{
    List<Scriptures> _scriptList = new List<Scriptures>
    {
        new Scriptures("John 16:33", "These things I have spoken unto you, that in me ye might have peace. In the world ye shall have tribulation: but be of good cheer; I have overcome the world."),
        new Scriptures("3 Nephi 25:26", "And we talk of Christ, we rejoice in Christ, we preach of Christ, we prophesy of Christ, and we write according to our prophecies, that our children may know to what source they may look for a remission of their sins."),
        new Scriptures("James", "Non Ducor, Duco")
    };

    
    public Scriptures GetRandomScripture(List<Scriptures> scriptList)
    {
        Random random = new Random();
        int randomIndex = random.Next(0, scriptList.Count);
        Scriptures randomObject = scriptList[randomIndex];

        return randomObject;
    }

    static Random random = new Random();

    static string ReplaceWords(string textInput)
    {   
        string[] words = textInput.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            if (ShouldReplaceLettersInWord())
            {
                string word = words[i];
                string replacedWord = Regex.Replace(word, "[A-Za-z]", "_");
                words[i] = replacedWord;
            }
        }

        return string.Join(" ", words);
    }

    static bool ShouldReplaceLettersInWord()
    {
        // 50% chance of replacing letters in a word
        return random.NextDouble() < 0.25;
    }
    
    public void DisplayMenu()
    {
        Scriptures script = GetRandomScripture(_scriptList);

        string userInput = "";
        script = GetRandomScripture(_scriptList);
        string text = script.GetText();

        while (userInput != "quit")
        {
            Console.Clear();
            
            Console.WriteLine($"{script.GetVerse()} {text}\n");
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");

            userInput = Console.ReadLine();
            
            text = ReplaceWords(text);
        }
    }
}