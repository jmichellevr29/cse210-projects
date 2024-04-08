using System;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("113 Cornelia St", "NYC", "N.Y.", "USA");
        Customer customer1 = new Customer("Dorothea Taylor", address1);

        Address address2 = new Address ("101 Pine Rd", "Denver", "CO", "USA");
        Customer customer2 = new Customer("Brenda Giler", address2);

        Address address3 = new Address("America st.", "Quito", "Manabi", "EC");
        Customer customer3 = new Customer("John Smith", address3);

        // order
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Headphones", "HP001", 101, 1));
        order1.AddProduct(new Product("Mango Splash", "MS001", 20, 1));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Highlight", "HL002", 55, 2));
        order2.AddProduct(new Product("Lipstick", "L002", 34, 1));

        Order order3 = new Order(customer3);
        order3.AddProduct(new Product("Perfume", "P003", 120, 1));
        order3.AddProduct(new Product("Backpack", "B003", 60, 2));

        // information
        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label: ");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost()}");

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost()}");

        Console.WriteLine("Order 3:");
        Console.WriteLine(order3.PackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order3.ShippingLabel());
        Console.WriteLine($"Total Price: ${order3.CalculateTotalCost()}");



    }
}