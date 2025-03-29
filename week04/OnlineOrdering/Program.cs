using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating addresses
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Maple Road", "Toronto", "ON", "Canada");

        // Creating customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Creating orders
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "TECH001", 1000.00m, 1));
        order1.AddProduct(new Product("Mouse", "TECH002", 25.00m, 2));
        order1.AddProduct(new Product("Keyboard", "TECH003", 50.00m, 1));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Headphones", "AUDIO001", 150.00m, 1));
        order2.AddProduct(new Product("Speaker", "AUDIO002", 100.00m, 1));

        // Displaying order information
        Console.WriteLine("Order 1 Details:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nTotal Cost: ${order1.GetTotalCost():F2}");

        Console.WriteLine("\n" + new string('-', 50) + "\n");

        Console.WriteLine("Order 2 Details:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nTotal Cost: ${order2.GetTotalCost():F2}");
    }
}