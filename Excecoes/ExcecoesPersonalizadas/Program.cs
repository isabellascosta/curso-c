using System;
using ExcecoesPersonalizadas.Entities;

namespace Excecoes
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Check-in date (dd/MM/yyyy)");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Check-out date (dd/MM/yyyy)");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if (checkOut <= checkIn)
            {
                Console.WriteLine("Error in reservation: check out date must be after  check-in date");
           
            }
            else
            {
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: "+reservation);
                Console.WriteLine("");
                Console.WriteLine("Enter de data ot update the reservation: ");
                Console.WriteLine("Check-in date (dd/MM/yyyy)");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Check-out date (dd/MM/yyyy)");
                checkOut = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;
                if (checkIn < now || checkOut < now)
                {
                    Console.WriteLine("Error in reservation: Reservation dates for update must be future dates");
                }

                else if (checkOut <= checkIn)
                {
                    Console.WriteLine("Error in reservation: check out date must be after  check-in date");

                }
                else
                {
                    reservation.UpdateDates(checkIn, checkOut);
                    Console.WriteLine("Reservation: "+reservation);
                }

            }

            


        }
    }
}