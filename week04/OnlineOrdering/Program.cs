using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 (USA Customer)
        Address addr1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer cust1 = new Customer("John Doe", addr1);
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Wireless Mouse", "P101", 25.50, 2));
        order1.AddProduct(new Product("Mechanical Keyboard", "P102", 75.00, 1));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost():F2}\n");
        Console.WriteLine(new string('=', 40) + "\n");

        // Order 2 (International Customer)
        Address addr2 = new Address("456 Park Road", "Mbabane", "Hhohho", "Eswatini");
        Customer cust2 = new Customer("Thube Dlamini", addr2);
        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("USB-C Hub", "P201", 40.00, 1));
        order2.AddProduct(new Product("HDMI Cable", "P202", 12.00, 3));
        order2.AddProduct(new Product("Laptop Stand", "P203", 35.00, 1));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost():F2}\n");
    }
}

//dwaynemaster007