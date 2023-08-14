using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApenasExercicios.Entities
{
    internal class Pessoas : IComparable
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoas(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        public override string ToString()
        {
            return Nome + ", " + Idade;
        }

        public int CompareTo(object? obj)
        {
            if(!(obj is Pessoas))
            {
                throw new ArgumentNullException("Precisa ser dados de uma pessoa!");
            }
            Pessoas other = obj as Pessoas;
             return Idade.CompareTo(other.Idade);
        }
    }
}
