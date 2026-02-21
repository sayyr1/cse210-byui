using System;
using System.Globalization;

namespace Program4_Exercise;

public abstract class Activity
{
    private readonly DateTime _when;
    private readonly int _mins;

    protected Activity(DateTime when, int mins)
    {
        _when = when;
        _mins = mins < 0 ? 0 : mins;
    }

    protected int Minutes => _mins;

    public string GetSummary()
    {
        var day = _when.ToString("dd MMM yyyy", CultureInfo.InvariantCulture);
        var d = GetDistance();
        var s = GetSpeed();
        var p = GetPace();

        // Mantengo el formato fijo para evitar diferencias por locale.
        return FormattableString.Invariant(
            $"{day} {GetActivityName()} ({Minutes} min) - Distance {d:0.0} km, Speed {s:0.0} kph, Pace {p:0.00} min per km");
    }

    public abstract double GetDistance();

    public virtual double GetSpeed() => Minutes == 0 ? 0 : GetDistance() * 60.0 / Minutes;

    public virtual double GetPace()
    {
        var km = GetDistance();
        return km > 0 ? Minutes / km : 0;
    }

    protected abstract string GetActivityName();
}
