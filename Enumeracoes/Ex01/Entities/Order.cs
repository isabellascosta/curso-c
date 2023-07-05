using Ex01.Entities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }
        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            double tot = 0;

           foreach(OrderItem i in Items)
            {
                sum += i.Price * i.Quantity;
                tot = sum;
            }
           return tot;
        }
           
            
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order sumary: ");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm.ss"));
            sb.Append("Order Status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.Append(Client.Name);
            sb.Append(" (");
            sb.Append(Client.Date.ToString("dd/MM/yyyy"));
            sb.Append(") - ");
            sb.AppendLine(Client.Email);
            sb.AppendLine("Order items:");
            foreach (OrderItem o in Items)
            {
                sb.Append(o.Product.Name);
                sb.Append(", $");
                sb.Append(o.Product.Price.ToString("f2", CultureInfo.InvariantCulture));
                sb.Append(",Quantity: ");
                sb.Append(o.Quantity);
                sb.Append(", Subtotal: $");
                sb.Append(o.Subtotal(o.Quantity,o.Price).ToString("f2",CultureInfo.InvariantCulture));
                sb.AppendLine("");
                

            }
            sb.Append("Total Price: $");
            sb.AppendLine(Total().ToString("f2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
        

    }
}
