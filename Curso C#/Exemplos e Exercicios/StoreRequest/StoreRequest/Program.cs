using System;
using System.Globalization;
using StoreRequest.Entities;
using StoreRequest.Entities.Enum;

namespace StoreRequest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            var name = Console.ReadLine();
            Console.Write("Email: ");
            var email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);
            
            DateTime moment = DateTime.Now;

            Console.WriteLine();

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(moment, status, client);

            Console.Write("How many items to this order? ");
            var n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                var nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                var price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                var quantity = int.Parse(Console.ReadLine());

                Product product = new Product(nameProduct, price);
                OrderItem orderItem = new OrderItem(quantity, price, product);  
            }

            Console.WriteLine();
            Console.WriteLine(order);
        }
    }
}