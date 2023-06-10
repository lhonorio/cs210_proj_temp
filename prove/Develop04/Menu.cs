public class Menu
{
    Breathing breathing = new Breathing("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    Reflection reflection = new Reflection("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    Listing listing = new Listing("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

    public Menu()
    {

    }

    public void DisplayMenu()
    {
        int userInput = 0;

        while(userInput != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:\n");
            Console.WriteLine("1. Start Breathing Activity.\n2. Start Reflection Activity.\n3. Start Listing Activity.\n4. Quit.\n");
            Console.Write("Select a choice from the menu: ");
            userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput == 1)
            {
                breathing.DisplayInitialMessage();
                breathing.StartBreathActivity();
                breathing.DisplayEndMessage();
            }

            else if (userInput == 2)
            {
                reflection.DisplayInitialMessage();
                reflection.StartReflectActivity();
                reflection.DisplayEndMessage();
            }

            else if (userInput == 3)
            {
                listing.DisplayInitialMessage();
                listing.StartListActivity();
                listing.DisplayEndMessage();
            }

            else
            {
                Environment.Exit(0);
            }
        }
    }
}
