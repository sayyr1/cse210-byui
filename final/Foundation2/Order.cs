using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program2_Ordering;

public class Order
{
    private readonly List<Product> _items = new();
    private readonly Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product p)
    {
        if (p == null) return; // Keep bad test data from crashing later.
        _items.Add(p);
    }

    public decimal GetTotalCost()
    {
        var itemsTotal = _items.Sum(p => p.GetTotalCost());
        var shipping = 35m;
        if (_customer.LivesInUSA()) shipping = 5m;
        return itemsTotal + shipping;
    }

    public string GetShippingLabel()
    {
        var sb = new StringBuilder();
        sb.AppendLine("SHIPPING LABEL");
        sb.AppendLine(_customer.GetName());
        sb.Append(_customer.GetAddress().GetFullAddress());
        return sb.ToString();
    }

    public string GetPackingLabel()
    {
        var sb = new StringBuilder();
        sb.AppendLine("PACKING LABEL");
        foreach (var item in _items)
        {
            sb.AppendLine($"{item.GetName()} | {item.GetProductId()}");
        }

        if (_items.Count == 0) sb.Append("(empty)");
        return sb.ToString();
    }
}
