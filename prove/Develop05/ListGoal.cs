public class ListGoal : Goal
{
   

    public ListGoal()
    {
        
    }


    public override void ChangeCompletion()
    {
        if (_timesAccomplished < _maxTimes)
        {
            _timesAccomplished = _timesAccomplished + 1;
        }
        
        if (_timesAccomplished == _maxTimes)
        {
            _completed = true;
        }
        else
        {
            _completed = false;
        }
    }


    public override void SetBonusPoints(int bonusPoints = 0)
    {
        _bonusPoints = bonusPoints;
    }


    public override string GetStringRepresentation()
    {
        string stringRepresentation = $"{GetName()}|{GetDescription()}|{GetPoints()}|{GetCompletion()}|{_maxTimes}|{GetTimesAccomplished()}|{_bonusPoints}|{GetOptionNumber()}";

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
        
        return $"{GetOptionNumber()}. {completionString} {GetName()} ({GetDescription()}) -- Currently Completed: {GetTimesAccomplished()}/{_maxTimes}";
    }
}