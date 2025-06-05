using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer ("Charles", new Address("Rochasse", "Jeremie", "GA", "Haiti"));
        List<Product> products1 = new List<Product> 
        {
            new Product("Milk", "123", 0.5, 10),
            new Product ("Flour", "043", 3.15, 1),
            new Product ("Eggs", "014", 0.25, 30)
        };
        Order order1 = new Order(customer1, products1);

        Customer customer2 = new Customer ("Johny Gargani", new Address("Ocean Drive", "Miami", "Florida", "USA"));
        List<Product> products2 = new List<Product>
        {
            new Product("Milk", "123", 0.5, 20),
            new Product ("Flour", "043", 3.15, 5),
            new Product ("Eggs", "014", 0.25, 30),
            new Product ("Sugar", "014", 1.5, 2)
        };
        Order order2 = new Order(customer2, products2);

        List<Order> orders = new List<Order> ();
        orders.Add(new Order(customer1, products1));
        orders.Add(new Order(customer2, products2));
        
        foreach (Order element  in orders)
        {
             Console.WriteLine("ORDER DETAILS");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"{element.ShowPackingLabel()}");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"Order total: ${element.OrderTotalPriceIs():F2}");
            Console.WriteLine("                     *******                     ");
            // Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("SHIPPING ADDRESS");
            // Console.ResetColor();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"{element.ShowShippingLabel()}");
            Console.WriteLine();
        }
           
    }
}