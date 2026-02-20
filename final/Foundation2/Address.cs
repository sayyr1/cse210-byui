using System.Text;

namespace Program2_Ordering;

public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public bool IsInUSA()
    {
        var c = (_country ?? "").Trim();
        return c.Equals("USA", System.StringComparison.OrdinalIgnoreCase)
            || c.Equals("United States", System.StringComparison.OrdinalIgnoreCase)
            || c.Equals("United States of America", System.StringComparison.OrdinalIgnoreCase);
    }

    public string GetFullAddress()
    {
        var sb = new StringBuilder();
        sb.AppendLine(_street);
        sb.AppendLine($"{_city}, {_stateProvince}");
        sb.Append(_country);
        return sb.ToString();
    }
}
