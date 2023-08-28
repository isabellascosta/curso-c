using Descobrindo_idades.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descobrindo_idades.Service
{
    internal class ServicoDeSaberIdade
    {
        public string DescobrindoIdade(DateTime nascimento, DateTime nascimento2 )
        {
            TimeSpan subtrair;

            if(nascimento > nascimento2)
            {
                
                 subtrair = nascimento.Subtract(nascimento2);
                return subtrair.TotalDays.ToString("f1", CultureInfo.InvariantCulture);
            }
            else
            {
                 subtrair= nascimento2.Subtract(nascimento);
                return subtrair.TotalDays.ToString("f1", CultureInfo.InvariantCulture);
            }
            
            
        }
    }
}
