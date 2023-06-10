public class Listing : CommonMessage
{
    List<string> _prompts = new List<string>{};

    public Listing(string activityName, string activityDesc): base(activityName, activityDesc)
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    private string GetRandomPrompt()
    {
        var random = new Random();
        var randomPrompt = random.Next(0, _prompts.Count);

        return _prompts[randomPrompt];
    }

    public void StartListActivity()
    {
        Console.WriteLine($"List as many responses you can do to the following prompt:{GetRandomPrompt()}\nYou may now begin in:");
        base.Countdown(5);

        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_activityLength);

        // int numbering = 1;
        while (DateTime.Now < futureTime)
        {
            Console.Write("-");
            string userInput = Console.ReadLine();
            // Console.WriteLine("> " + userInput);
        }
    }
}