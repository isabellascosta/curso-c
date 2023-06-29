using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComportamentoDeMemoria
{
    struct Point
    {
        public double x;
        public double y;

        public override string ToString()
        {
            return "("+x+", "+y+")";
        }
    }
}
