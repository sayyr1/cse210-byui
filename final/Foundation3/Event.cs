using System;
using System.Text;

namespace Program3_Events;

public abstract class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private string _time;
    private Address _address;

    protected Event(string title, string description, DateTime date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        var sb = new StringBuilder();
        sb.AppendLine(_title);
        sb.AppendLine(_description);
        sb.AppendLine($"Date: {_date:dd MMM yyyy}");
        sb.AppendLine($"Time: {_time}");
        sb.Append(_address.GetFullAddress());
        return sb.ToString();
    }

    public string GetFullDetails()
    {
        var sb = new StringBuilder();
        sb.AppendLine(GetStandardDetails());
        sb.AppendLine();
        sb.AppendLine($"Type: {GetEventType()}");
        sb.Append(GetExtraDetails());
        return sb.ToString();
    }

    public string GetShortDescription() => $"{GetEventType()} | {_title} | {_date:dd MMM yyyy}";

    protected abstract string GetEventType();
    protected abstract string GetExtraDetails();
}