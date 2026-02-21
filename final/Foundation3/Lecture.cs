using System;

namespace Program3_Events;

public class Lecture : Event
{
    private readonly string _speaker;
    private readonly int _cap;

    public Lecture(string title, string desc, DateTime day, string time, Address addr, string speaker, int cap)
        : base(title, desc, day, time, addr)
    {
        _speaker = speaker;
        _cap = cap < 0 ? 0 : cap;
    }

    protected override string GetEventType() => "Lecture";

    protected override string GetExtraDetails()
    {
        var seats = _cap == 0 ? "TBD" : _cap.ToString();
        return $"Speaker: {_speaker}{Environment.NewLine}Capacity: {seats}";
    }
}
