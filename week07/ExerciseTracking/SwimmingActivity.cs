public class SwimmingActivity : Activity
{
    private const float _lapLength = .05f;
    private int _laps;

    public SwimmingActivity(DateTime date, int duration, int laps) : base(date, duration, "Swimming")
    {
        _laps = laps;
    }

    public override float GetDistance()
    {
        // kilometers
        return _laps * _lapLength;
    }
    public override float GetSpeed()
    {
        // kilometers per hour
        return GetDistance() / GetDuration() * 60f;
    }
    public override float GetPace()
    {
        // minutes per kilometer
        return GetDuration() / GetDistance();
    }
}