using System;
using System.Globalization;
using System.Text;

namespace Program3_Events;

public abstract class Event
{
    private readonly string _title;
    private readonly string _desc;
    private readonly DateTime _day;
    private readonly string _time;
    private readonly Address _addr;

    protected Event(string title, string desc, DateTime day, string time, Address addr)
    {
        _title = title;
        _desc = desc;
        _day = day;
        _time = time;
        _addr = addr;
    }

    public string GetShortDescription() => $"{GetEventType()} | {_title} | {GetDateText()}";

    public string GetFullDetails()
    {
        var sb = new StringBuilder();
        sb.AppendLine(GetStandardDetails());
        sb.AppendLine();
        sb.AppendLine($"Type: {GetEventType()}");
        sb.Append(GetExtraDetails());
        return sb.ToString();
    }

    public string GetStandardDetails()
    {
        var sb = new StringBuilder();
        sb.AppendLine(_title);
        sb.AppendLine(_desc);
        sb.AppendLine($"Date: {GetDateText()}");
        sb.AppendLine($"Time: {_time}");
        sb.Append(_addr.GetFullAddress());
        return sb.ToString();
    }

    private string GetDateText() => _day.ToString("dd MMM yyyy", CultureInfo.InvariantCulture);

    protected abstract string GetEventType();
    protected abstract string GetExtraDetails();
}
