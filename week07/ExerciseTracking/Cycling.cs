public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int activityLength, double speed) : base(date, activityLength)
    {
        _speed = speed;
    }


    public override double GetDistance()
    {
        return GetSpeed() * _minutes / 60;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }
}