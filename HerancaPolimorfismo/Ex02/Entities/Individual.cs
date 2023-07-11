using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome,double healthxpenditures):base (name, anualIncome)
        { 
            HealthExpenditures = healthxpenditures;
        }
        public override double Tax()
        {
            double totalperc = 0;
            if(AnualIncome < 20000.00)
            {
                if(HealthExpenditures >0)
                {
                    totalperc = (AnualIncome * 0.15) - (HealthExpenditures * 0.50);

                }
                else
                {
                    totalperc = AnualIncome * 0.15;
                }
            }
            else
            {
                if(HealthExpenditures >0)
                {
                    totalperc = (AnualIncome * 0.25) - (HealthExpenditures * 0.5);
                }
            }
            return totalperc;
        }


    }
}
