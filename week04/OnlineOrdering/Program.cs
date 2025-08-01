using System;

namespace OnlineOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address("123 Maple St", "Springfield", "IL", "USA");
            Customer customer1 = new Customer("John Doe", address1);
            Order order1 = new Order(customer1);
            order1.AddProduct(new Product("Laptop", "P001", 999.99, 1));
            order1.AddProduct(new Product("Mouse", "P002", 25.50, 2));

            Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
            Customer customer2 = new Customer("Jane Smith", address2);
            Order order2 = new Order(customer2);
            order2.AddProduct(new Product("Camera", "P003", 499.99, 1));
            order2.AddProduct(new Product("Tripod", "P004", 89.99, 1));
            order2.AddProduct(new Product("Memory Card", "P005", 19.99, 2));

            Console.WriteLine("Order 1:");
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order1.GetTotalPrice():F2}");
            Console.WriteLine(new string('-', 40));

            Console.WriteLine("Order 2:");
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order2.GetTotalPrice():F2}");
            Console.WriteLine(new string('-', 40));
        }
    }
}