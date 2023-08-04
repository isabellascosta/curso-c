using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.Entities
{
    internal class Parcelas
    {
       // public DateTime DuoDate { get; set; }
        public double Quantia { get; set; }
       
        public Parcelas( double quantia) 
        {
          
            Quantia = quantia;
        }

    }
}
