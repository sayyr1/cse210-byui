using System;
using System.Globalization;

namespace Program2_Ordering;

public class Program
{
    public static void Main()
    {
        var us = new Customer(
            "Juan Sebastian",
            new Address("123 St", "Austin", "TX", "USA")
        );

        var fr = new Customer(
            "Julia Stefan",
            new Address("88 ST", "Lyon", "Auvergne-Rhone-Alpes", "France")
        );

        var a = new Order(us);
        a.AddProduct(new Product("Wireless Mouse", "WM-204", 19.99m, 2));
        a.AddProduct(new Product("USB-C Cable", "UC-778", 7.50m, 3));
        a.AddProduct(new Product("Laptop Stand", "LS-110", 32.00m, 1));

        var b = new Order(fr);
        b.AddProduct(new Product("Notebook", "NB-001", 4.25m, 5));
        b.AddProduct(new Product("Pen Set", "PS-300", 8.90m, 2));

        var all = new[] { a, b };
        for (var i = 0; i < all.Length; i++)
        {
            PrintOrder(all[i]);
            if (i < all.Length - 1) Console.WriteLine(new string('=', 45));
        }
    }

    private static void PrintOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine();

        var total = order.GetTotalCost().ToString("0.00", CultureInfo.InvariantCulture);
        Console.WriteLine($"TOTAL: ${total}");
    }
}
