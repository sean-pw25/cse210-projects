using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("7208 Main st", "Sacramento", "California", "USA");
        Customer customer1 = new Customer("Michelle Cunningham", address1);
        Order order1 = new Order(customer1, [
        new Product("Samsung TV", "SS-TV-4133", 799.99f, 1),
        new Product("Lava Lamp", "LV-LP-5398", 45.00f, 4),
        ]);

        Address address2 = new Address("3258 Ronald Dr", "Montreal", "Quebec", "Canada");
        Customer customer2 = new Customer("Simon Linstrom", address2);
        Order order2 = new Order(customer2, [
        new Product("Acer Gaming Laptop", "AC-LP-2301", 599.99f, 2),
        new Product("PlayStation 5", "SY-PS-5273", 597.90f, 1),
        ]);

        Console.WriteLine("-------------ORDER ONE-------------");
        Console.WriteLine("-------------Total Cost------------");
        Console.WriteLine(order1.GetTotalCost());
        Console.WriteLine();
        Console.WriteLine("------------Packing Label----------");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine("------------Shipping Label---------");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine("-------------ORDER TWO-------------");
        Console.WriteLine("-------------Total Cost------------");
        Console.WriteLine(order2.GetTotalCost());
        Console.WriteLine();
        Console.WriteLine("------------Packing Label----------");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine("------------Shipping Label---------");
        Console.WriteLine(order2.GetShippingLabel());
    }
}