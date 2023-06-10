public class Prompt
{

    // List<string> _prompts = new List<string>();
    List<string> _prompts = new List<string>();


    private Prompt()
    {
        _prompts.Add("How was your day?");
        _prompts.Add("What was the best part of your day?");
        _prompts.Add("What would you change from today?");
        _prompts.Add("What good did you do today?");
        _prompts.Add("What was the most important thing you learned today?");
    }


    public string GetRandomPrompt()
    {
        var random = new Random();
        var randomPrompt = random.Next(0, _prompts.Count);

        return _prompts[randomPrompt];
    }
}