using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
     class Aluguel
    {
       
            public string Nome { get; set; }
            public string Email { get; set; }
            public Aluguel(string nome, string email)
            {
                Nome = nome;
                Email = email;
            }
            public override string ToString()
            {
                return Nome + ", " + Email;

            }
        }
}

   
