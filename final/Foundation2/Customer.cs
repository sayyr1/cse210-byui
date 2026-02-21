namespace Program2_Ordering;

public class Customer
{
    private readonly string _name;
    private readonly Address _addr;

    public Customer(string name, Address addr)
    {
        _name = name;
        _addr = addr;
    }

    public string GetName() => _name;
    public Address GetAddress() => _addr;

    public bool LivesInUSA() => _addr != null && _addr.IsInUSA();
}
