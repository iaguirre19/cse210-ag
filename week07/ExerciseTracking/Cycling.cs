using System;

class Cycling : Activity
{
    private double _speedMph;

    public Cycling(DateTime date, int minutes, double speedMph) : base(date, minutes)
    {
        _speedMph = speedMph;
    }

    public override double GetDistance()
    {
        double hours = GetMinutes() / 60.0;
        return _speedMph * hours;
    }

    public override double GetSpeed()
    {
        return _speedMph;
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        return GetMinutes() / distance;
    }
}
