public abstract class Goal
{
    private string _name;
    private string _desc;
    private int _points;

    public Goal(string name, string desc, int points)
    {
        _name = name;
        _desc = desc;
        _points = points;
    }

    public string GetName()
    {
        return _name;
    }
    public string GetDesc()
    {
        return _desc;
    }
    public int GetPoints()
    {
        return _points;
    }

    public virtual string GetDetailStr()
    {
        string toReturn = $"{_name}: {_desc}. Complete: ";
        if (IsComplete())
        {
            toReturn += "[X]";
        }
        else
        {
            toReturn += "[ ]";
        }
        return toReturn;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStrRep();
}