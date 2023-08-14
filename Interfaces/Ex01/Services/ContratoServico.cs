using Ex01.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.Services
{
    internal class ContratoServico
    {
        private IApenasPagamentoServico _pagamentoServico;

        public ContratoServico(IApenasPagamentoServico pagamentoServico)
        {
            _pagamentoServico = pagamentoServico;
        }

        public void ProcessContract(Contrato contrato,  int mes)
        {
     
            double valor = contrato.ValorTotal / contrato.Parcelas.Quantia;
            double service = _pagamentoServico.TaxaDePagamento(valor, mes);
        }
        public void ProcessDate(Contrato contrato, int mes)
        {

            for (int i = 1; i <= mes; i++)
            {
                DateTime duration = contrato.Data.AddMonths(i);
            }

        }

    }
}
