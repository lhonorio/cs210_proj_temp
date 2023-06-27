public class ListGoal : Goal
{
    int _maxTimes = 0;
    int _timesAccomplished = 0;
    int _bonusPoints = 0;
    

    public ListGoal()
    {
        
    }


    public void SetMaxTimes(int maxTimes)
    {
        _maxTimes = maxTimes;
    }

    public void AddTimesAccomplished()
    {
        if (_timesAccomplished < _maxTimes)
        {
            _timesAccomplished = _timesAccomplished + 1;
        }
    }

    public void SetBonusPoints(int bonusPoints = 0)
    {
        _bonusPoints = bonusPoints;
    }

    public void SetTimesAccomplished(int timesAccomplished)
    {
        _timesAccomplished = timesAccomplished;
    }

    public int GetMaxTimes()
    {
        return _maxTimes;
    }

    public int GetTimesAccomplished()
    {
        return _timesAccomplished;
    }

    public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    public override void ChangeCompletion()
    {
        if (_timesAccomplished == _maxTimes)
        {
            _completed = true;
        }
        else
        {
            _completed = false;
        }
    }

    public override string GetStringRepresentation()
    {
        string stringRepresentation = $"{GetName()}|{GetDescription()}|{GetPoints()}|{GetCompletion()}|{_maxTimes}|{_timesAccomplished}|{_bonusPoints}|{GetOptionNumber()}";

        return stringRepresentation;
    }

    public override string DisplayObjectString()
    {
        string completionString = "[ ]";

        if (_completed == true)
        {
            completionString = "[X]";
        }

        else 
        {
            completionString = "[ ]";
        }
        
        return $"{GetOptionNumber()}. {completionString} {GetName()} ({GetDescription()}) -- Currently Completed: {_timesAccomplished}/{_maxTimes}";
    }
}