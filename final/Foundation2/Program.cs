using System;

namespace Program2_Ordering;

public class Program
{
    public static void Main()
    {
        var local = new Customer(
            "Jordan Lee",
            new Address("123 Maple St", "Austin", "TX", "USA")
        );

        var abroad = new Customer(
            "Camille Moreau",
            new Address("88 Rue des Lilas", "Lyon", "Auvergne-Rhône-Alpes", "France")
        );

        var order1 = new Order(local);
        order1.AddProduct(new Product("Wireless Mouse", "WM-204", 19.99m, 2));
        order1.AddProduct(new Product("USB-C Cable", "UC-778", 7.50m, 3));
        order1.AddProduct(new Product("Laptop Stand", "LS-110", 32.00m, 1));

        var order2 = new Order(abroad);
        order2.AddProduct(new Product("Notebook", "NB-001", 4.25m, 5));
        order2.AddProduct(new Product("Pen Set", "PS-300", 8.90m, 2));

        PrintOrder(order1);
        Console.WriteLine(new string('=', 45));
        PrintOrder(order2);
    }

    private static void PrintOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"TOTAL: ${order.GetTotalCost():0.00}");
    }
}