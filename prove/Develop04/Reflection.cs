public class Reflection : CommonMessage
{
    List<string> _prompts = new List<string>{};
    List<string> _reflections = new List<string>{};

    public Reflection(string activityName, string activityDesc): base(activityName, activityDesc)
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _reflections.Add("Why was this experience meaningful to you?");
        _reflections.Add("Have you ever done anything like this before?");
        _reflections.Add("How did you get started?");
        _reflections.Add("How did you feel when it was complete?");
        _reflections.Add("What made this time different than other times when you were not as successful?");
        _reflections.Add("What is your favorite thing about this experience?");
        _reflections.Add("What could you learn from this experience that applies to other situations?");
        _reflections.Add("What did you learn about yourself through this experience?");
        _reflections.Add("How can you keep this experience in mind in the future?");
    }

    private string GetRandomPrompt()
    {
        var random = new Random();
        var randomPrompt = random.Next(0, _prompts.Count);

        return _prompts[randomPrompt];
    }

    private string GetRandomReflection()
    {
        var random = new Random();
        var randomReflect = random.Next(0, _reflections.Count);

        return _reflections[randomReflect];
    }


    public void StartReflectActivity()
    {
        Console.WriteLine($"Consider the following prompt:\n{GetRandomPrompt()}\nWhen you have something in mind, press a button to continue.");
        Console.ReadKey();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.\nYou may begin in:");
        base.Countdown();
        Console.Clear();


        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_activityLength);

        while (DateTime.Now < futureTime)
        {
            Console.WriteLine($"{GetRandomReflection()}");
            base.PauseAnimation(10000);
        }
    }
}