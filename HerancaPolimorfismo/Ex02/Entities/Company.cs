using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02.Entities
{
    class Company: TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome,int numberOfEmployess):base (name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployess;
        }
        public override double Tax()
        {
            double totalValue = 0.0;
            if (NumberOfEmployees >10)
            {
                totalValue = AnualIncome * 1.4;
            }
            else
            {
                totalValue = AnualIncome * 2.5;
            }
            return totalValue;
        }
    }
}
