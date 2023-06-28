public class SimpleGoal : Goal
{
    public SimpleGoal()
    {
        
    }


    public override void ChangeCompletion()
    {
        if (_completed == false)
        {
            _completed = true;
        }
    }
}