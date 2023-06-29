using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;


        public double Area()
        {
            double resultadoa;
            resultadoa = Largura * Altura;
            return resultadoa;
        }
        public double Perimetro()
        {
            double resultadop = (2 * Altura) + (2 * Largura);
            return resultadop;
        }

        public double Diagonal()
        {
            double resultadod = Math.Sqrt(Math.Pow(Largura, 2)+(Math.Pow(Altura, 2)));
            return resultadod;
        }
        public override string ToString()
        {
            return "Area: "
                + Area().ToString("f2", CultureInfo.InvariantCulture)
                + " "
                + "Perímetro: "
                + Perimetro().ToString("f2", CultureInfo.InvariantCulture)
                + " "
                + "Diagonal: "
                +Diagonal().ToString("f2",CultureInfo.InvariantCulture);


        }
        

    }
}
