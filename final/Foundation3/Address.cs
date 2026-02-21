using System.Text;

namespace Program3_Events;

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

    public string GetFullAddress()
    {
        var sb = new StringBuilder();
        sb.AppendLine(_line1);
        sb.AppendLine($"{_city}, {_region}");
        sb.Append(_country);
        return sb.ToString();
    }
}
