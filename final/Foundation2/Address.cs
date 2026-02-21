using System;
using System.Text;

namespace Program2_Ordering;

public class Address
{
    private readonly string _line1;
    private readonly string _city;
    private readonly string _region;
    private readonly string _country;

    public Address(string line1, string city, string region, string country)
    {
        _line1 = line1;
        _city = city;
        _region = region;
        _country = country;
    }

    public bool IsInUSA()
    {
        var c = (_country ?? string.Empty).Trim();
        return c.Equals("USA", System.StringComparison.OrdinalIgnoreCase)
            || c.Equals("United States", System.StringComparison.OrdinalIgnoreCase)
            || c.Equals("United States of America", System.StringComparison.OrdinalIgnoreCase);
    }

    public string GetFullAddress()
    {
        var sb = new StringBuilder();
        sb.AppendLine(_line1);
        sb.AppendLine($"{_city}, {_region}");
        sb.Append(_country);
        return sb.ToString();
    }
}
