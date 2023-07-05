using Ex01.Entities;
using Ex01.Entities.Enum;
using System;
using System.Globalization;
using System.Net.Http.Json;

namespace Enumeracoes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime momentnow = DateTime.Now;
            //Entrando com os dados do cliente
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string nameclient = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date DD/MM/YYYY: ");
            DateTime dateclient = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("");

            //entrando com os dados do pedido do cliente
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus statusorder = Enum.Parse<OrderStatus>(Console.ReadLine()); 
            Console.Write("How Many Items to this order?");
            int n = int.Parse(Console.ReadLine());

            //Instanciando as classes 
            Client client = new Client(nameclient,email,dateclient);
            Order order = new Order(momentnow,statusorder,client);


            for (int i = 1; i-1 < n; i++)
            {
                Console.WriteLine($"Enter {i} item data:");
                Console.Write("Product Name: ");
                string productName = Console.ReadLine();
                Console.Write("Product Price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                OrderItem orderitem = new OrderItem(quantity,productPrice,product);
                order.AddItem(orderitem);
                orderitem.Subtotal(quantity, productPrice);

            }

            Console.WriteLine(order);
        }
    }
}