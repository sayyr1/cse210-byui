using System;

namespace Program3_Events;

public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, DateTime date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    protected override string GetEventType() => "Reception";

    protected override string GetExtraDetails() => $"RSVP: {_rsvpEmail}";
}