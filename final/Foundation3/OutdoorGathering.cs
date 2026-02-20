using System;

namespace Program3_Events;

public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string title, string description, DateTime date, string time, Address address, string weather)
        : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    protected override string GetEventType() => "Outdoor Gathering";

    protected override string GetExtraDetails() => $"Weather: {_weather}";
}