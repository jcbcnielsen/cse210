public class ChecklistGoal : Goal
{
    private int _amount;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string desc, int points, int target, int bonus) : base(name, desc, points)
    {
        _amount = 0;
        _target = target;
        _bonus = bonus;
    }
    public ChecklistGoal(string name, string desc, int points, int amount, int target, int bonus) : base(name, desc, points)
    {
        _amount = amount;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        if (IsComplete())
        {
            return 0;
        }
        else
        {
            _amount++;
            if (IsComplete())
            {
                return GetPoints() + _bonus;
            }
            else
            {
                return GetPoints();
            }
        }
    }
    public override bool IsComplete()
    {
        return _amount == _target;
    }
    public override string GetDetailStr()
    {
        return $"{GetName()}: {GetDesc()}. Completed: [{_amount} / {_target}]";
    }
    public override string GetStrRep()
    {
        return $"checklist,{GetName()},{GetDesc()},{GetPoints()},{_amount},{_target},{_bonus}";
    }
}