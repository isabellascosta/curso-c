using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    internal class Cotacao
    {
        
        public static double Conversao(double c , double g)
        {
            double valor;
            valor = c * g;
            double resultado = valor+(6 * valor / 100);
            return resultado;
        }
        public static void ImpostoIof()
        {

        }

    }
}
