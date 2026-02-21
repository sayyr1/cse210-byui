using System;

namespace Program3_Events;

public class Reception : Event
{
    private readonly string _rsvp;

    public Reception(string title, string desc, DateTime day, string time, Address addr, string rsvp)
        : base(title, desc, day, time, addr)
    {
        _rsvp = rsvp;
    }

    protected override string GetEventType() => "Reception";

    protected override string GetExtraDetails()
    {
        var mail = string.IsNullOrWhiteSpace(_rsvp) ? "n/a" : _rsvp;
        return $"RSVP: {mail}";
    }
}
