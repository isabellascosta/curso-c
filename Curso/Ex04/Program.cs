using System;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using System.Globalization;
using System.Diagnostics.Contracts;
using System.ComponentModel;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] vet = Console.ReadLine().Split(' ');
            int entrada1 = int.Parse(vet[0]);
            int entrada2 = int.Parse(vet[1]);
            int dia = 24;
            int resultado1;
            int resultado2;
            int total;

            while (entrada1 <0 || entrada1 >24)
            {
                Console.WriteLine("Valor invalido, digite um valor entre 0 e 24");
                vet = Console.ReadLine().Split(' ');
                entrada1 = int.Parse(vet[0]);
                entrada2 = int.Parse(vet[1]);

                
            }
            resultado1 = dia - entrada1;
            resultado2 =  resultado1 - entrada2;

            total = resultado1 + resultado2;
            Console.WriteLine(total);



            Console.WriteLine("o jogo durou");
        }
        public void NaoNegativo()
        {
            Console.WriteLine("Escreva um numero");
            int num = int.Parse(Console.ReadLine());

            if (num >= 0)
            {
                Console.WriteLine("Não Negativo");
            }
            else
            {
                Console.WriteLine("Negativo");
            }
        }
        public void ParImpar()
        {
            Console.WriteLine("Escreva um numero");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("Impar");
            }

        }
        public void Multiplos()
        {
            double divisao;
            Console.WriteLine("Passe dois numeros");
            string[] vet = Console.ReadLine().Split(' ');

            double n1 = double.Parse(vet[0]);
            double n2 = double.Parse(vet[1]);



            if (n1 % n2 == 0 || n2 % n1 == 0)
            {
                Console.WriteLine("São Multiplos");
            }
            else
            {
                Console.WriteLine("Não São Multiplos");
            }
        }
        public void HorasJogo()
        {
            Console.WriteLine("Entre com a duração do jogo");
            string[] vet = Console.ReadLine().Split(' ');

            int horainicial = int.Parse(vet[0]);
            int horafinal = int.Parse(vet[1]);

            int tempo;

            if (horainicial < horafinal)
            {
                tempo = horafinal - horainicial;
            }
            else
            {
                tempo = 24 - horainicial + horafinal;
            }
            Console.WriteLine($"o jogo durou {tempo} horas");


        }
        public void Loja ()
        {
            Console.WriteLine("digite o código e quantidade ");
            string[] vet = Console.ReadLine().Split(' ');

            int codigo = int.Parse(vet[0]);
            int quantidade = int.Parse(vet[1]);

            double cd1 = 4.00;
            double cd2 = 4.50;
            double cd3 = 5.00;
            double cd4 = 2.00;
            double cd5 = 1.50;

            if (codigo == 1)
            {
                double resultado;
                resultado = quantidade * cd1;
                Console.WriteLine("Total:R$ " + resultado.ToString("f2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 2)
            {
                double resultado;
                resultado = quantidade * cd2;
                Console.WriteLine("Total:R$ " + resultado.ToString("f2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 3)
            {
                double resultado;
                resultado = quantidade * cd3;
                Console.WriteLine("Total:R$ " + resultado.ToString("f2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 4)
            {
                double resultado;
                resultado = quantidade * cd4;
                Console.WriteLine("Total:R$ " + resultado.ToString("f2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 5)
            {
                double resultado;
                resultado = quantidade * cd4;
                Console.WriteLine("Total:R$ " + resultado.ToString("f2", CultureInfo.InvariantCulture));
            }
            
        }
        public void Intervalor ()
        {
            Console.WriteLine("Escreva seu salário");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else if (salario <= 3000.00)
            {
                double porc = ((salario) * (8) / 100 + salario);
                double resul = porc - salario;
                Console.WriteLine("R$: " + resul.ToString("f2", CultureInfo.InvariantCulture));
            }
            else if (salario <= 4500.00)
            {
                double porc = ((salario) * (18) / 100 + salario);
                double resul = porc - salario;
                Console.WriteLine("R$: " + resul.ToString("f2", CultureInfo.InvariantCulture));
            }
            else if (salario > 4500.00)
            {
                double porc = ((salario) * (28) / 100 + salario);
                double resul = porc - salario;
                Console.WriteLine("R$: " + resul.ToString("f2", CultureInfo.InvariantCulture));
            }
            

        }
        public void Imposto ()
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto;
            if (salario <= 2000.0)
            {
                imposto = 0.0;
            }
            else if (salario <= 3000.0)
            {
                imposto = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.0)
            {
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (imposto == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }

        }
        public void PositivoOuNegativo()
        {
            Console.WriteLine("escreva um numero ");
            int num1 = int.Parse(Console.ReadLine());



            if (num1 >= 0)
            {
                Console.WriteLine("O numero é positivo");
            }
            else
            {
                Console.WriteLine("o numero é negativo");
            }
        }
        public void Sexo()
        {
            Console.WriteLine("Digite F ou M");
            char genero = char.Parse(Console.ReadLine());

            if (genero == 'F' || genero == 'f')
            {
                Console.WriteLine("F - Feminino");
            }
            else if (genero == 'M' || genero == 'm')
            {
                Console.WriteLine("M - masculino");
            }
            else
            {
                Console.WriteLine("sexo invalido");
            }

        }
        public void ConsoanteVogal()
        {
            Console.WriteLine("Escreva a letra");
            char letra = char.Parse(Console.ReadLine());

            if (letra == 'A' || letra == 'E' || letra == 'I' || letra == 'O' || letra == 'U')
            {
                Console.WriteLine("É vogal");
            }
            else
            {
                Console.WriteLine("É consoante");
            }
        }
        public  void MediaAluno()
        {
            Console.WriteLine("Escreva as duas notas do aluno");
            string[] vet = Console.ReadLine().Split(' ');

            double nota1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double nota2 = double.Parse(vet[1], CultureInfo.InvariantCulture);

            double notafinal = (nota1 + nota2) / 2;

            if (notafinal >= 7 && notafinal < 10)
            {
                Console.WriteLine("Aprovado!");
            }
            else if (notafinal == 10)
            {
                Console.WriteLine("Aprovado com distinção");
            }
            else
            {
                Console.WriteLine("Reprovado!");
            }
        }
        public void MaiorDeTres()
        {
            Console.WriteLine("Escreva 3 numeros na mesma linha");
            string[] vet = Console.ReadLine().Split(' ');

            int num1 = int.Parse(vet[0]);
            int num2 = int.Parse(vet[1]);
            int num3 = int.Parse(vet[2]);

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("Maior numero é o " + num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("Maior numero é o " + num2);
            }
            else
            {
                Console.WriteLine("Maior é o " + num3);
            }
        }
        public void MaiorEMenor()
        {
            Console.WriteLine("Escreva 3 numeros na mesma linha");
            string[] vet = Console.ReadLine().Split(' ');

            int num1 = int.Parse(vet[0]);
            int num2 = int.Parse(vet[1]);
            int num3 = int.Parse(vet[2]);

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("Maior numero é o " + num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("Maior numero é o " + num2);
            }
            else
            {
                Console.WriteLine("Maior é o " + num3);
            }

            if (num1 < num2 && num1 < num3)
            {
                Console.WriteLine("Menor numero é o " + num1);
            }
            else if (num2 < num1 && num2 < num3)
            {
                Console.WriteLine("Menor numero é o " + num2);
            }
            else
            {
                Console.WriteLine("menor é o " + num3);
            }
        }
        public void AumentoSalario()
        {
            Console.WriteLine("Informe seu salário");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double novosalario;


            if (salario <= 280.00)
            {
                double aumento;
                double porc = 20;
                novosalario = ((salario) * (porc) / 100 + salario);
                aumento = novosalario - salario;

                Console.WriteLine("Salario anterior: " + salario.ToString("f2", CultureInfo.InvariantCulture));
                Console.WriteLine("Porcentagem de ajuste: " + porc);
                Console.WriteLine("Valor de aumento: " + aumento.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Valor salario: " + novosalario.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (salario >= 280.00 && salario <= 700.00)
            {
                double aumento;
                double porc = 15;
                novosalario = ((salario) * (porc) / 100 + salario);
                aumento = novosalario - salario;

                Console.WriteLine("Salario anterior: " + salario.ToString("f2", CultureInfo.InvariantCulture));
                Console.WriteLine("Porcentagem de ajuste: " + porc);
                Console.WriteLine("Valor de aumento: " + aumento.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Valor salario: " + novosalario.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (salario >= 700.00 && salario <= 1500.00)
            {
                double aumento;
                double porc = 10;
                novosalario = ((salario) * (porc) / 100 + salario);

                aumento = novosalario - salario;

                Console.WriteLine("Salario anterior: " + salario.ToString("f2", CultureInfo.InvariantCulture));
                Console.WriteLine("Porcentagem de ajuste: " + porc);
                Console.WriteLine("Valor de aumento: " + aumento.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Valor salario: " + novosalario.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (salario > 1500.00)
            {
                double aumento;
                double porc = 5;
                novosalario = ((salario) * (porc) / 100 + salario);

                aumento = novosalario - salario;

                Console.WriteLine("Salario anterior: " + salario.ToString("f2", CultureInfo.InvariantCulture));
                Console.WriteLine("Porcentagem de ajuste: " + porc);
                Console.WriteLine("Valor de aumento: " + aumento.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Valor salario: " + novosalario.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
