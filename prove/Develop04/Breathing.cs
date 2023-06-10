public class Breathing : CommonMessage
{
    public Breathing(string activityName, string activityDesc): base(activityName, activityDesc)
    {

    }


    public void StartBreathActivity()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_activityLength);

        while (DateTime.Now < futureTime)
        {
            Console.WriteLine("\nBreath in...");
            base.Countdown(3);
            Console.WriteLine("\nBreath out...");
            base.Countdown(3);
            Console.WriteLine("\n");
        }
    }
}