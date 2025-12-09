using System;

abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    protected Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    protected DateTime GetDate()
    {
        return _date;
    }

    protected int GetMinutes()
    {
        return _minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();

        return $"{_date:dd MMM yyyy} {GetType().Name} ({_minutes} min) - Distance {distance:F1} miles, Speed {speed:F1} mph, Pace: {pace:F2} min per mile";
    }
}
