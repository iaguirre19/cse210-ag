using System;

class Swimming : Activity
{
    private int _laps;
    private const double LapLengthMeters = 50;

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double distanceKm = _laps * LapLengthMeters / 1000.0;
        return distanceKm * 0.62;
    }

    public override double GetSpeed()
    {
        double distance = GetDistance();
        return (distance / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        return GetMinutes() / distance;
    }
}
