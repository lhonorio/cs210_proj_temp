public class Goal
{
    protected bool _completed = false;
    string _name;
    string _description;
    int _points = 0;
    int _optionNumber = 0;


    public Goal()
    {

    }


    public void SetName(string name)
    {
        _name = name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public void SetPoints(int points = 0)
    {
        _points = points;
    }

    public void SetCompletion(string completion)
    {
        if (completion == "False")
        {
            _completed = false;
        }

        if (completion == "True")
        {
            _completed = true;
        }
    }

    public virtual void ChangeCompletion()
    {
        if (_completed == false)
        {
            _completed = true;
        }
    }

    public void SetOptionNumber(int optionNumber)
    {
        _optionNumber = optionNumber;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public bool GetCompletion()
    {
        return _completed;
    }

    public int GetPoints()
    {
        return _points;
    }

    public int GetOptionNumber()
    {
        return _optionNumber;
    }

    public virtual string GetStringRepresentation()
    {
        string stringRepresentation = $"{_name}|{_description}|{_points}|{_completed}|{_optionNumber}";

        return stringRepresentation;
    }

    public virtual string DisplayObjectString()
    {
        string completionString = "[ ]";

        if (_completed == true)
        {
            completionString = "[X]";
        }

        if (_completed == false) 
        {
            completionString = "[ ]";
        }
        
        return $"{_optionNumber}. {completionString} {_name} ({_description})";
    }
}