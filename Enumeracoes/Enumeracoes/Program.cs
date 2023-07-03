using Enumeracoes.Entities;
using Enumeracoes.Entities.Enums;
using System;


namespace Enumeracoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Order ord = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(ord);
            //Convertendo um tipo enumerado para string
            string txt = OrderStatus.PendingPayment.ToString();
            //Convertendo um tipo string para enum
            //OrderStatus (nome da variavel) = Enum.Parse<Orderstatus>("Nome igualzinho o declarado na classe enum se não da erro")
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}
