using System;

namespace Program3_Events;

public class OutdoorGathering : Event
{
    private readonly string _forecast;

    public OutdoorGathering(string title, string desc, DateTime day, string time, Address addr, string forecast)
        : base(title, desc, day, time, addr)
    {
        _forecast = forecast;
    }

    protected override string GetEventType() => "Outdoor Gathering";

    protected override string GetExtraDetails()
    {
        return string.IsNullOrWhiteSpace(_forecast) ? "Weather: TBD" : $"Weather: {_forecast}";
    }
}
