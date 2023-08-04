using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace ProblemadoDiamante.Devices
{
     class Scanner : Device
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Scanner processing: "+document);
        }
        public string Scan() {
            return "Scanner scan result ";
        }
    }
}
