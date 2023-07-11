using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02.Entities
{
     abstract class TaxPayer
    {
        public string name { get; set; }
        public double AnualIncome { get; set; }

        protected TaxPayer(string name, double anualIncome)
        {
            this.name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();
    }
}
