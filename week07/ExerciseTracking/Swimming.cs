using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int minutes, int laps) 
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        // Distance in miles: laps * 50 meters / 1000 * 0.62
        return _laps * 50 / 1000.0 * 0.62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}
