using System.Reflection.Metadata.Ecma335;

public class Running : Activity
{
    private double _distance;


    public Running(string date, int activityLength, double distance) : base(date, activityLength)
    {
        _distance = distance;
    }


    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }

    public override double GetSpeed()
    {
        return _distance / _minutes * 60;
    }
}