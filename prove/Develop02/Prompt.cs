public class Prompt
{
    List <string> _promptList = new List<string>{
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?", 
        "How did I see the hand of the Lord in my life today?", 
        "What was the strongest emotion I felt today?", 
        "If I had one thing I could do over today, what would it be?"};

    
    public Prompt()
    {

    }


    public string GetRandomPrompt()
    {
        // Create a Random object
        Random random = new Random();

        // Get a random index within the range of the list
        int randomIndex = random.Next(0, _promptList.Count);

        // Get the random string from the list using the random index
        string randomString = _promptList[randomIndex];

        return randomString;
    }   
}