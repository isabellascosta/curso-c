using System;
using System.Net.WebSockets;

namespace TopicosEspeciais
{
    class program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(1, 30, 10);
            TimeSpan t2 = new TimeSpan(0, 10, 5);
            TimeSpan sum =  t1.Add(t2);
            TimeSpan dif = t1.Subtract(t2);
            TimeSpan mult = t2.Multiply(2.00);
            TimeSpan div = t2.Divide(2.0);
            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine();

        }


        public void UsandoTimeSpan()
        {
            //passando o costrutor vazio 
            TimeSpan t1 = new TimeSpan();
            //passando os ticks
            TimeSpan t2 = new TimeSpan(900000000L);
            //passando a hora, minuto e segundo
            TimeSpan t3 = new TimeSpan(2, 11, 21);
            //dias horas minutos e segundos
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            //dias horas minutos e segundos e milisegundo
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
        }
  
    }
}