using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioComImposto()
        {
            double result;
            result = SalarioBruto - Imposto;
            return result;
        }

        public void AumentoDeSalario(double porcentagem)
        {
                     
            SalarioBruto = SalarioBruto+(porcentagem * SalarioComImposto() / 100);
           
        }    

        public override string ToString()
        {
            return Nome
                + ", "
                +SalarioComImposto().ToString("f2",CultureInfo.InvariantCulture);
                
         
                
        }

    }
}
