using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Ex01
{
    internal class Aluno
    {
        public string NomeAluno;
        public double PrimeiraNota;
        public double SegundaNota;
        public double TerceiraNota;
        public double NotaFinal()
        {
            
        return PrimeiraNota+SegundaNota+TerceiraNota;
        }
        public bool Aprovado()
        {
            if (NotaFinal() > 60)
            {
                return true;
            }
            else
            {
                return false;

            }
        }
        public double NotaRestante()
        {
            return 60-NotaFinal();
        }


    }

}
