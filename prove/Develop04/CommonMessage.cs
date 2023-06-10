public class CommonMessage
{
    string _activityName = "";
    string _activityDesc = "";
    protected int _activityLength;

    public CommonMessage(string activityName, string activityDesc)
    {
        _activityName = activityName;
        _activityDesc = activityDesc;
    }


    public void DisplayInitialMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}.\n{_activityDesc}\nHow long, in seconds, would you like for your session? ");

        _activityLength = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Get ready...\n");
        PauseAnimation();
        
    }


    public void DisplayEndMessage()
    {
        Console.WriteLine("Well Done!");
        PauseAnimation();

        Console.WriteLine($"You have completed another {_activityLength} seconds of the {_activityName}.");
        PauseAnimation();
    }


    public void Countdown(int count = 3)
    {
        // Loop until count reaches 0
        while (count > 0)
        {
            Console.SetCursorPosition(0, Console.CursorTop); // Move the cursor to the beginning of the current line
            Console.Write(count);
            count--;

            // Delay for 1 second
            Thread.Sleep(1000);
        }
    }


    public void PauseAnimation(int animationDuration = 3000)
    {
        int frameCount = 0; // Number of frames displayed

        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalMilliseconds < animationDuration)
        {
            switch (frameCount % 4)
            {
                case 0: Console.Write("-"); break;
                case 1: Console.Write("\\"); break;
                case 2: Console.Write("|"); break;
                case 3: Console.Write("/"); break;
            }

            frameCount++;

            // Delay for 250 milliseconds
            DateTime innerStartTime = DateTime.Now;
            while ((DateTime.Now - innerStartTime).TotalMilliseconds < 250)
            {
                // Do nothing, just wait
            }

            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Console.Write(" ");
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
    }
}