using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01.Entities
{
    internal class Costumer
    {
        public string Nome { private get; set; }
        public DateTime DataNasc { private get; set; }
        public double Altura { private get; set; }

        public Costumer(string nome, DateTime dataNasc, double altura)
        {
            Nome = nome;
            DataNasc = dataNasc;
            Altura = altura;
        }

        public int CalculodeIdade(DateTime dataNasc)
        {
            return DateTime.Today.Year - dataNasc.Year;
        }
        public override string ToString()
        {
            return "Nome: " + Nome+"\n"
                + "Data de nascimento: " + DataNasc.ToString("dd/MM/yyyy")+"\n"
                + "Altura: " + Altura.ToString("f2");
        }
    }
}
