using System;
using System.Globalization;
using System.Net.Http.Headers;
using System.Security.Cryptography;

namespace Ex01
{
    class program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Console.Write("Nome do Aluno: ");
            aluno.NomeAluno = Console.ReadLine();
            Console.Write("Digite as três notas do aluno: ");
            aluno.PrimeiraNota= double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            aluno.SegundaNota= double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            aluno.TerceiraNota= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota Final: "+aluno.NotaFinal().ToString("f2", CultureInfo.InvariantCulture));
            if (aluno.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram: " + aluno.NotaRestante().ToString("f2", CultureInfo.InvariantCulture)+ " PONTOS");
            }
            
        }
        private void Pessoa()
        {
            Pessoa p, s;
            p = new Pessoa();
            s = new Pessoa();

            Console.WriteLine("Dados da Primeira Pessoa");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados da Segunda Pessoa");
            Console.Write("Nome: ");
            s.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            s.Idade = int.Parse(Console.ReadLine());

            if (p.Idade > s.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {p.Nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {s.Nome}");
            }
        }
        private void Funcionario()
        {
            //Instanciando as variaveis
            Funcionario p, s;
            p = new Funcionario();
            s = new Funcionario();
            double medio;
            //recebendo dados do primeiro funcionario
            Console.WriteLine("Dados do primero funcionário");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            p.SalarioBruto = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //recebendo dados do segundo fucionario
            Console.WriteLine("Dados do segundo funcionário");
            Console.Write("Nome:");
            s.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            s.SalarioBruto = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Fazendo a conta e mostrando o valor medio dos salarios dos dois funcionarios
            medio = (p.SalarioBruto + s.SalarioBruto) / 2;

            Console.WriteLine("Salário Médio: " + medio.ToString("f2", CultureInfo.InvariantCulture));


        }
        public void Retangulo()
        {
            Retangulo r;

            r = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo:");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("");
            Console.WriteLine(r);


        }
        public void AumentoSalario()
        {
            Funcionario func = new Funcionario();
            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("");
            Console.WriteLine("Funcionario: " + func);
            Console.WriteLine("");

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentoDeSalario(porc);
            Console.WriteLine("");
            Console.WriteLine("Dados atualizados: " + func);


        }
    }
}
