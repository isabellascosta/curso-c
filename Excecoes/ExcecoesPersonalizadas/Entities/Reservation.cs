using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcecoesPersonalizadas.Entities
{
    internal class Reservation
    {
        public int RoomNuber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() { }

        public Reservation(int roomNuber, DateTime checkIn, DateTime checkOut)
        {
            RoomNuber = roomNuber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }
        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
        public override string ToString()
        {
            return "Room: "
                + RoomNuber
                + ", Check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", Check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", Durantion: "
                + Duration()
                + " nights";
                
        }


    }
}
