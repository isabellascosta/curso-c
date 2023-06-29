using System;
using System.Globalization;
using System.Net.Http.Headers;

namespace TopicosEspeciais
{
    class program
    {
        static void Main(string[] args)
        {
            //Adicionar horas e minutos
            Console.WriteLine("Adicionando horas");
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            DateTime d2 = d.AddHours(2);
            DateTime d3 = d2.AddMinutes(3);
            Console.WriteLine(d);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine("");


            //saber a diferença entre as datas
            Console.WriteLine("Subtraindo");
            DateTime de = new DateTime(2000,10,15);
            DateTime de2 = new DateTime(2000, 10, 18);
            TimeSpan duracao = de2.Subtract(de);

            Console.WriteLine(duracao);




        }
        public void UsandoString()
        {

            //Usando string
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            //imprimir data longa
            string s1 = d.ToLongDateString();
            string s2 = d.ToLongTimeString();
            string s3 = d.ToShortDateString();
            string s4 = d.ToShortTimeString();
            string s5 = d.ToString();
            string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);
        }
        public void TestandoPropriedades()
        {
            //LIDANDO COM PROPRIEDADES DO DATETIME
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);
            //Imprimindo somente a data
            Console.WriteLine("1) Date:" + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3)Day of week: " + d.DayOfWeek);
            Console.WriteLine("4) Day of year: " + d.DayOfYear);
            Console.WriteLine("5) hour: " + d.Hour);
            Console.WriteLine("6)Kind: " + d.Kind);
            Console.WriteLine("7)Millisecond: " + d.Millisecond);
            Console.WriteLine("8)Minute: " + d.Minute);
            Console.WriteLine("9)Month: " + d.Month);
            Console.WriteLine("10)Second: " + d.Second);
            Console.WriteLine("11)Ticks: " + d.Ticks);
            Console.WriteLine("12)TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13)Year: " + d.Year);
        }
        public void LidandoComDatas()
        {
            //passando um construtor e passando sobrecargas 
            DateTime d1 = new DateTime(2023, 06, 20);
            Console.WriteLine(d1);
            //imprimindo ano,mes,dia,hora,minutos e segundo
            DateTime d2 = new DateTime(2023, 06, 20, 11, 27, 03);
            Console.WriteLine(d2);
            //imprimindo ano,mes,dia,hora,minutos e segundos e tentando imprimir milisegundos, mas a formatação padrão não leva em consideração os mili
            DateTime d3 = new DateTime(2023, 06, 20, 11, 27, 03, 500);
            Console.WriteLine(d3);
            //Imprimindo data e hora atual
            DateTime d4 = DateTime.Now;
            Console.WriteLine(d3);
            //today vai gerar a data de hora no horario das 00 horas
            DateTime d5 = DateTime.Today;
            Console.WriteLine(d5);
            DateTime d6 = DateTime.UtcNow;
            Console.WriteLine(d6);
        }
       public void Date()
        {
            DateTime d1 = DateTime.Parse("2000-08-15");
            DateTime d2 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d3 = DateTime.Parse("15/08/2000");
            DateTime d4 = DateTime.Parse("15/08/2000 13:05:58");
            DateTime d5 = DateTime.ParseExact("2000-08-15", "yyyy-mm-dd", CultureInfo.InvariantCulture);
            DateTime d6 = DateTime.ParseExact("15/08/2000 13:06:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
        }
    }
}