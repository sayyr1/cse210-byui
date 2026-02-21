using System;

namespace Program4_Exercise;

public class Swimming : Activity
{
    private const double MetersPerLap = 50.0;
    private readonly int _laps;

    public Swimming(DateTime when, int mins, int laps) : base(when, mins)
    {
        _laps = laps < 0 ? 0 : laps;
    }

    public override double GetDistance()
    {
        var meters = _laps * MetersPerLap;
        if (meters <= 0) return 0;
        return meters / 1000.0;
    }

    protected override string GetActivityName() => "Swimming";
}
