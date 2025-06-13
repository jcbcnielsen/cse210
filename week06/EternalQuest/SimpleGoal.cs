public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string desc, int points) : base(name, desc, points)
    {
        _isComplete = false;
    }
    public SimpleGoal(string name, string desc, int points, bool complete) : base(name, desc, points)
    {
        _isComplete = complete;
    }

    public override int RecordEvent()
    {
        if (_isComplete == false)
        {
            _isComplete = true;
            return GetPoints();
        }
        else
        {
            return 0;
        }
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStrRep()
    {
        return $"simple,{GetName()},{GetDesc()},{GetPoints()},{_isComplete}";
    }
}