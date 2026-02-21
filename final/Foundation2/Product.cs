namespace Program2_Ordering;

public class Product
{
    private readonly string _name;
    private readonly string _sku;
    private readonly decimal _unitPrice;
    private readonly int _qty;

    public Product(string name, string sku, decimal unitPrice, int qty)
    {
        _name = name;
        _sku = sku;
        _unitPrice = unitPrice < 0 ? 0 : unitPrice;
        _qty = qty < 0 ? 0 : qty;
    }

    public string GetName() => _name;
    public string GetProductId() => _sku;

    public decimal GetTotalCost() => _unitPrice * _qty;
}
