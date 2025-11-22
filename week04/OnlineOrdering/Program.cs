using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // order 1
        Address adr1 = new Address("321 Main St", "Provo", "Utah", "USA");
        Customer cust1 = new Customer("John Doe", adr1);
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Laptop", "LPT100", 800, 1));
        order1.AddProduct(new Product("Mouse", "MOU010", 20, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"TOTAL: ${order1.GetTotalCost()}\n");
        //order 2
        Address adr2 = new Address("Av. Paseo de La República 500", "Chorrillos", "Lima", "Peru");
        Customer cust2 = new Customer("Luisa Lopez", adr2);
        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Keyboard", "KYB090", 50, 1));
        order2.AddProduct(new Product("Headphones", "HEP670", 120, 2));
        order2.AddProduct(new Product("Mouse", "MOU010", 120, 2));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"TOTAL: ${order2.GetTotalCost()}\n");
        //order 3
        Address adr3 = new Address("742 plain st.", "Nauvoo", "Illinois", "USA");
        Customer cust3 = new Customer("Jane Doe", adr3);

        Order order3 = new Order(cust3);
        order3.AddProduct(new Product("Tablet", "TBL450", 300, 1));
        order3.AddProduct(new Product("USB-C Cable", "USBC22", 15, 3));
        order3.AddProduct(new Product("Monitor", "MNT909", 220, 1));

        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"TOTAL: ${order3.GetTotalCost()}\n");
    }
}