using System;
using System.Xml.Linq;
using System.Globalization;
using System.Xml;
using System.Net.WebSockets;
using MembrosEstaticos;

namespace POO
{
    class program
    {

        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);
            Console.WriteLine("Circunferencia: "+circ.ToString("f2",CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: "+volume.ToString("f2",CultureInfo.InvariantCulture));
            Console.WriteLine("valor de pi "+Calculadora.Pi.ToString("f2",CultureInfo.InvariantCulture));
        }

    }
}