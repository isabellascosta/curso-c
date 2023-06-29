using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificador_de_parametro
{
    internal class Calculator
    {
        //Criei um metodo chamado Sum(soma) e passei por dentro dele um vetor chamado numbers. a paralvra "params" serve para avisar o compilador que você precisa
        //de uma quantia variavel de valores
        public static int Sum(params int[] numbers)
        {
            // criei uma variavel e iniciei em valor  0
            int sum = 0; 
            //Para i = 0, enquanto i for menor do que a quantidade a soma de todos os  numeros passados nesse vetor faca i++
            for (int i = 0; i< numbers.Length; i++)
            {
                //soma  é igual soma +numbers na posição que for passando em i
                sum+= numbers[i];
            }
            return sum;
        }
    }
}
