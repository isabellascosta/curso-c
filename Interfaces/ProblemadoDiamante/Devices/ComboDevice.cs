using ProblemadoDiamante.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratoeInterface.Model.Entities
{
    internal class ComboDevice : Device, IScanner, IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine("ComboDevice print "+document);
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("comboDevice processing "+document);
        }

        public string scan()
        {
            return "ComboDevice Scan result" ;
        }
    }
}
