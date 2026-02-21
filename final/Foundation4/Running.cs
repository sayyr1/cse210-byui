using System;

namespace Program4_Exercise;

public class Running : Activity
{
    private readonly double _km;

    public Running(DateTime when, int mins, double km) : base(when, mins)
    {
        _km = km;
    }

    public override double GetDistance()
    {
        if (_km < 0) return 0;
        return _km;
    }

    protected override string GetActivityName() => "Running";
}
