using System;
using System.Text;

namespace Program3_Events;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, DateTime date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    protected override string GetEventType() => "Lecture";

    protected override string GetExtraDetails()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Speaker: {_speaker}");
        sb.Append($"Capacity: {_capacity}");
        return sb.ToString();
    }
}