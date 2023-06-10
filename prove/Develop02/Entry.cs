public class Entry
{   
    Prompt prompt; 


    public Entry()
        {

        }


    private string GetDate()
    {
        DateTime thisDay = DateTime.Today;
        string today = thisDay.ToString();

        return today;
    }
    

    public string DisplayEntry()
    {
        string date = GetDate();

        string text = prompt.GetRandomPrompt();

        return $"Date:{date}\nQuestion:\n{text}";
    }


    public string GetEntry()
    {
        // Console.WriteLine("Welcome!\nPlease select one of the keys below:\n(W)rite\n(D)isplay\n(L)oad\n(S)ave\n(Q)");

        string entry = DisplayEntry();
        string response = Console.ReadLine();

        return $"{entry}\nResponse:\n{response}";
    }


    
}