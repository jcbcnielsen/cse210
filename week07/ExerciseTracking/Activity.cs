public abstract class Activity
{
    private DateTime _date;
    private int _duration;
    private string _type;

    public Activity(DateTime date, int duration, string type)
    {
        _date = date;
        _duration = duration;
        _type = type;
    }

    public DateTime GetDate()
    {
        return _date;
    }
    public int GetDuration()
    {
        return _duration;
    }

    public string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {_type} ({_duration} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km.";
    }
    public abstract float GetDistance();
    public abstract float GetSpeed();
    public abstract float GetPace();
}