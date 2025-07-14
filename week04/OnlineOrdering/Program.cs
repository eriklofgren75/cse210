using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 State St.", "Salt Lake City", "UT", "USA");
        Customer customer1 = new Customer("Joe Smith", address1);
        Order order1 = new Order(customer1);

        Product product1 = new Product("Bookbag", "Bb111", 45.99, 1);
        Product product2 = new Product("Candy Bar", "Cb234", 1.5, 3);

        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Address address2 = new Address("229 Cherry St.", "Calgary", "AB", "Canada");
        Customer customer2 = new Customer("Karol Bigs", address2);
        Order order2 = new Order(customer2);

        Product product3 = new Product("Key Chain", "KC101", 5.99, 2);
        Product product4 = new Product("Journal", "J123", 7.75, 1);

        order2.AddProduct(product3);
        order2.AddProduct(product4);

        List<Order> orders = new List<Order> { order1, order2 };

        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.CalculateTotalCost():0.00}");
            Console.WriteLine();
        }
    }
}