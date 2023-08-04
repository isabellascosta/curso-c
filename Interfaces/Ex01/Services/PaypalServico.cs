using Ex01.Entities;
using System.Xml.Schema;

namespace Ex01.Services
{
    internal class PaypalServico : IApenasPagamentoServico
    {

        public List<double> Juros(double quantia, int mes)
        {
            List<double> valores = new List<double>();
            double valor = 0.0;
            for (int i = 1; i <= mes; i++)
            {
                valor = quantia * 0.01 * i;
                valores.Add(valor);
            }
            return valores;
        }
        public double TaxaDePagamento(double quantia, int mes)
        {
            double total = 0.0;
            foreach (int item in Juros(quantia,mes))
            {
                total = item * 0.02;
            }
            return total; 

        }
    }
}
