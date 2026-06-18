public abstract class Activity
{
    protected string _date;
    protected int _minutes;


    public Activity(string date, int activityLength)
    {
        _date = date;
        _minutes = activityLength;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{_date} {this} ({_minutes} min)- Distance: {GetDistance():N2}, Speed: {GetSpeed():N2}, Pace: {GetPace():N2} min per mile";
    }
}