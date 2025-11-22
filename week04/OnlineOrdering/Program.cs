using System;
using OnlineOrdering;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);
        
        Product product1 = new Product("P001", "Laptop", 999.99m, 1);
        Product product2 = new Product("P002", "Mouse", 25.50m, 2);
        Product product3 = new Product("P003", "Keyboard", 75.00m, 1);
        
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);


        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(customer2);
        
        Product product4 = new Product("P004", "Monitor", 299.99m, 2);
        Product product5 = new Product("P005", "Webcam", 89.99m, 1);
        
        order2.AddProduct(product4);
        order2.AddProduct(product5);


        Address address3 = new Address("789 Oak St", "Los Angeles", "CA", "USA");
        Customer customer3 = new Customer("Alice Johnson", address3);
        Order order3 = new Order(customer3);
        Product product6 = new Product("P006", "Tablet", 450.00m, 10);
        order3.AddProduct(product6);




        Console.WriteLine("========== ORDER 1 ==========");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: {order1.GetOrderTotal():C}");
        Console.WriteLine();


        Console.WriteLine("========== ORDER 2 ==========");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: {order2.GetOrderTotal():C}");


        Console.WriteLine();
        Console.WriteLine("========== ORDER 3 ==========");
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"Total Price: {order3.GetOrderTotal():C}");
    }
}