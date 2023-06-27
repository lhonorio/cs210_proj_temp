public class EternalGoal : Goal
{ 
    public EternalGoal()
    {
       _completed = false; 
    }


    public override void ChangeCompletion()
    {
        _completed = false;
    }
}