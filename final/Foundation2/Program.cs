using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Elm Street", "Springfield", "IL", "USA" );
        Address address2 = new Address("789 Maple Avenue", "Oakville", "CA", "United States");
        Address address3 = new Address("456 High Street", "London", "United Kingdom" );
        Address address4 = new Address("987 Pine Boulevard", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("Spacely Space Sprockets", address1);
        Customer customer2 = new Customer("InGen", address2);
        Customer customer3 = new Customer("Tyrell Corporation", address3);
        Customer customer4 = new Customer("Acme Corporation", address4);

        Product product1 = new Product("Quantum Converter", "FPID5678A", 499.99m, 10);
        Product product2 = new Product("DNA Test Kits", "TG001", 49.95m, 50);
        Product product3 = new Product("CPU", "SFED007", 100.00m, 200);
        Product product4 = new Product("Neuralyzer", "NLX2023", 29.99m, 500);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product1);

        Order order3 = new Order(customer3);
        order3.AddProduct(product2);
        order3.AddProduct(product4);

        Order order4 = new Order(customer4);
        order4.AddProduct(product1);
        order4.AddProduct(product3);
        order4.AddProduct(product2);

        Console.WriteLine("Order #1: ");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        order1.DisplayOrderTotal();
        Console.WriteLine();

        Console.WriteLine("Order #2: ");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        order2.DisplayOrderTotal();
        Console.WriteLine();

        Console.WriteLine("Order #3: ");
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        order3.DisplayOrderTotal();
        Console.WriteLine();

        Console.WriteLine("Order #4: ");
        Console.WriteLine(order4.GetPackingLabel());
        Console.WriteLine(order4.GetShippingLabel());
        order4.DisplayOrderTotal();
        Console.WriteLine();
    }
}