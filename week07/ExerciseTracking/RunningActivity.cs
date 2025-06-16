public class RunningActivity : Activity
{
    private float _distance;

    public RunningActivity(DateTime date, int duration, float distance) : base(date, duration, "Running")
    {
        _distance = distance;
    }

    public override float GetDistance()
    {
        // kilometers
        return _distance;
    }
    public override float GetSpeed()
    {
        // kilometers per hour
        return _distance / GetDuration() * 60f;
    }
    public override float GetPace()
    {
        // minutes per kilometer
        return GetDuration() / _distance;
    }
}