using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    internal class Banco
    {
        public int NumeroConta{get; set;}
        public string NomeTitular {get; set;}
        public char DepositoInicial {get;  set;}
        public double PrimeiroDeposito {get; set;}
        public double DepositoComum { get;  set; }
        public double Saque { get;  set; }

        public Banco()
        {

        }

        public double SaldoTotal()
        {
            return PrimeiroDeposito = PrimeiroDeposito+ DepositoComum;
        }

        public double SaquedaConta()
        {
            return PrimeiroDeposito = PrimeiroDeposito - Saque-5;
        }

        public override string ToString()
        {
            return "Conta: " + NumeroConta
                +", Titular: "+NomeTitular
                +", Saldo: $"+PrimeiroDeposito.ToString("f2",CultureInfo.InvariantCulture);
        }

    }
}
