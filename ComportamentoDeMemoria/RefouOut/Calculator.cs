using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefouOut
{
    internal class Calculator
    {
        //se você tentar criar um metodo pra triplicar um numero como foi feito, o valor será resolvido dentro do metodo e não será realocado para program
        //para que você possa ter esse valor realocado para a variavel da program você usa a palavra ref  dentro dos parametros do metodo
        public static void Triple(ref int x)
        {
            x = x * 3;
        }
        public static void Triple2(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
