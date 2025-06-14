using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer customer = new Customer("John Doe", address);
        Product product1 = new Product("Widget", 101, 19.99m, 2);
        Product product2 = new Product("Gadget", 102, 29.99m, 1);
        Product product3 = new Product("Doodad", 103, 9.99m, 5);
        Order order = new Order(customer);
        order.AddProduct(product1);
        order.AddProduct(product2);
        order.AddProduct(product3);
        Console.WriteLine(order.PackingLabel());
        Console.WriteLine(order.ShippingLabel());
        Console.WriteLine($"Total Cost: ${order.TotalCost():0.00}");
        Console.WriteLine("----------------------------------");
        Address brazilAddress = new Address("456 Rua Principal", "Rio de Janeiro", "RJ", "Brasil");
        Customer brazilCustomer = new Customer("Maria Silva", brazilAddress);
        Product brazilProduct1 = new Product("Camiseta", 104, 49.99m, 3);
        Product brazilProduct2 = new Product("Calça", 105, 79.99m, 1);
        Order brazilOrder = new Order(brazilCustomer);
        brazilOrder.AddProduct(brazilProduct1);
        brazilOrder.AddProduct(brazilProduct2);
        Console.WriteLine(brazilOrder.PackingLabel());
        Console.WriteLine(brazilOrder.ShippingLabel());
        Console.WriteLine($"Total Cost: ${brazilOrder.TotalCost():0.00}");
        Console.WriteLine("----------------------------------");
    }
}