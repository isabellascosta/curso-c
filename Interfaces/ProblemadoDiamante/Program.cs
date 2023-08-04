using System.Transactions;
using System.Security.Authentication;
using ProblemadoDiamante.Devices;
using ContratoeInterface.Model.Entities;
using System.Xml;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("My letter");
            p.Print("my letter ");
            Scanner s = new Scanner() { SerialNumber = 2003};
            s.ProcessDoc("My email");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() {SerialNumber = 3921};
            c.ProcessDoc("My dissertation");
            c.Print("My dissertation");
            Console.WriteLine(c.scan());

        }
    }
}
