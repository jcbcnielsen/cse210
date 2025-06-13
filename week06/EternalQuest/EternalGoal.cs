public class EternalGoal : Goal
{
    public EternalGoal(string name, string desc, int points) : base(name, desc, points) { }

    public override int RecordEvent()
    {
        return GetPoints();
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStrRep()
    {
        return $"eternal,{GetName()},{GetDesc()},{GetPoints()}";
    }
}