using System.Text;

namespace Program3_Events;

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

    public string GetFullAddress()
    {
        var sb = new StringBuilder();
        sb.AppendLine(_street);
        sb.AppendLine($"{_city}, {_stateProvince}");
        sb.Append(_country);
        return sb.ToString();
    }
}