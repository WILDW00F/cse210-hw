using System;

class Program
{
    static void Main(string[] args)
    {
        // First Customer (USA)
        Address address1 = new Address(
            "123 Main Street",
            "Phoenix",
            "AZ",
            "USA");

        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Gaming Mouse", "GM101", 39.99, 1));
        order1.AddProduct(new Product("Mechanical Keyboard", "MK205", 89.99, 1));
        order1.AddProduct(new Product("USB-C Cable", "UC310", 12.50, 2));

        // Second Customer (International)
        Address address2 = new Address(
            "15 King's Road",
            "London",
            "England",
            "United Kingdom");

        Customer customer2 = new Customer("Emma Wilson", address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Laptop", "LP450", 999.99, 1));
        order2.AddProduct(new Product("Laptop Sleeve", "LS220", 29.99, 1));

        // Display Order 1
        Console.WriteLine("========== ORDER 1 ==========");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():F2}");

        Console.WriteLine();

        // Display Order 2
        Console.WriteLine("========== ORDER 2 ==========");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():F2}");
    }
}