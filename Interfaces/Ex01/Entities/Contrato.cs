using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.Entities
{
    internal class Contrato
    {
        public int Numero { get; set; }
        public DateTime Data { get; set; }
        public double ValorTotal { get; set; }

        public Parcelas Parcelas { get; set; }

        public Contrato(int numero, DateTime date, double valorTotal)
        {
            Numero = numero;
            Data = date;
            ValorTotal = valorTotal;
        }


    }
}
