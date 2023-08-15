using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    static class DateTimeExtensions
    {
        //estou criando uma extensão que mostra a quantidade de dias ou hora que passou desde o momento escolhido
        public static string ElapsedTime(this DateTime thisobj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisobj);
            if (duration.TotalHours < 24.0 )
            {
                return duration.TotalHours.ToString("f1",CultureInfo.InvariantCulture)+" hours";
            }
            else
            {
                return duration.TotalDays.ToString("f1", CultureInfo.InvariantCulture) + " days";
            }
        }
    }
}
