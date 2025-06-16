public class CyclingActivity : Activity
{
    private float _speed;

    public CyclingActivity(DateTime date, int duration, float speed) : base(date, duration, "Cycling")
    {
        _speed = speed;
    }

    public override float GetDistance()
    {
        // kilometers
        return _speed / 60f * GetDuration();
    }
    public override float GetSpeed()
    {
        // kilometers per hour
        return _speed;
    }
    public override float GetPace()
    {
        // minutes per kilometer
        return GetDuration() / GetDistance();
    }
}