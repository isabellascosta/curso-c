using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descobrindo_idades.Entities
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public DateTime Nascimento {get;set;}

        public Pessoa(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
        }
        public override string ToString()
        {
            return Nome + ", " + Nascimento.ToString("dd/MM/yyyy");
        }
    }
}
