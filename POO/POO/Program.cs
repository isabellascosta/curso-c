using System;
using System.Xml.Linq;
using System.Globalization;
using System.Xml;

namespace POO
{
    class program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("Dados do produto"+p);
            Console.WriteLine(" ");

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine(" ");
            Console.WriteLine("Dados atualizados: "+p);
            Console.WriteLine(" ");

            Console.WriteLine("Digite o número de produtos a ser removido do estoque");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine(" ");
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine(" ");
        }
        public void AreaTriangulo()
        {
            //Usei triangulo para classificar o tipo das minhas variaveis, como int e string. 
            Triangulo x, y;
            //Para poder usar essas variaveis eu preciso instanciar elas. para isso digo que X = new Classe();
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triagulo x");
            //X é a variavel que vai ser alocada dentro do meu atributo A
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triagulo y");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double areax = x.Area();
            double areay = y.Area();



            Console.WriteLine("Area de X = " + areax.ToString("f4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y =" + areay.ToString("f4", CultureInfo.InvariantCulture));

            if (areax > areay)
            {
                Console.WriteLine("Maior area é: x");
            }
            else
            {
                Console.WriteLine("Maior area é: Y");
            }
        }
    }

}
