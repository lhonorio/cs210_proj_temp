public class Entry
{   
    string _date;
    string _prompt;
    string _entry;


    public Entry(string date = "", string prompt = "", string entry = "")
    {
        _date = date;
        _prompt = prompt;
        _entry = entry;
    }


    public void SetCurrentDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        _date = dateText;
    }

    public void SetDate(string date)
    {
        _date = date;
    }

    public void SetPrompt(string prompt)
    {
        _prompt = prompt;
    }

    public void SetEntry(string entry)
    {
        _entry = entry;
    }

    public string DisplayEntry()
    {
        return $"Date: {_date} - Prompt: {_prompt}\n {_entry}";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{_date}|||{_prompt}|||{_entry}";
    }
}