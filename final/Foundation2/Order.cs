using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program2_Ordering;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product) => _products.Add(product);

    public decimal GetTotalCost()
    {
        var itemsTotal = _products.Sum(p => p.GetTotalCost());
        var shipping = _customer.LivesInUSA() ? 5m : 35m;
        return itemsTotal + shipping;
    }

    public string GetPackingLabel()
    {
        var sb = new StringBuilder();
        sb.AppendLine("PACKING LABEL");

        foreach (var p in _products)
        {
            sb.AppendLine($"{p.GetName()} | {p.GetProductId()}");
        }

        return sb.ToString();
    }

    public string GetShippingLabel()
    {
        var sb = new StringBuilder();
        sb.AppendLine("SHIPPING LABEL");
        sb.AppendLine(_customer.GetName());
        sb.Append(_customer.GetAddress().GetFullAddress());
        return sb.ToString();
    }
}
