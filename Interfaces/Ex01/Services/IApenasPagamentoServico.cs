using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.Services
{
    interface IApenasPagamentoServico
    {
        double TaxaDePagamento(double quantia, int mes);
        List <double> Juros(double quantia, int mes);

    }
}
