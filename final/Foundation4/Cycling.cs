using System;

namespace Program4_Exercise;

public class Cycling : Activity
{
    private readonly double _kph;

    public Cycling(DateTime when, int mins, double kph) : base(when, mins)
    {
        _kph = kph;
    }

    public override double GetSpeed()
    {
        if (_kph < 0)
        {
            return 0;
        }
        else
        {
            return _kph;
        }
    }

    public override double GetDistance() => GetSpeed() * (Minutes / 60.0);

    public override double GetPace()
    {
        var speed = GetSpeed();
        return speed <= 0 ? 0 : 60.0 / speed;
    }

    protected override string GetActivityName() => "Cycling";
}
