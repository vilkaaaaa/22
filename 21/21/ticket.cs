using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _22
{
    
    class Ticket
    {
        public int id { get; set; }
        public decimal ownerPassport { get; set; }
        public string type { get; set; }
        public int trainNumber { get; set; }
        public int place { get; set; }
        public DateTime departureTime { get; set; }
        static double hours { get; set; }
        public Ticket(int id, decimal ownerPassport, string type, int trainNumber, int place, DateTime departureTime)
        {
            this.id = id;
            this.ownerPassport = ownerPassport;
            this.type = type;
            this.trainNumber = trainNumber;
            this.place = place;
            this.departureTime = departureTime;
        }
        public void GetTimeLeft() 
        {
            DateTime now = DateTime.Now;
            TimeSpan ostalos = departureTime - now;
            hours = ostalos.TotalHours;

        }

        public void PrintInfo()
        {
            GetTimeLeft();
            Console.Write("айди ");
            Console.WriteLine(id);
            Console.Write("паспорт ");
            Console.WriteLine(ownerPassport);
            Console.Write("тип билета ");
            Console.WriteLine(type);
            Console.Write("номер поезда ");
            Console.WriteLine(trainNumber);
            Console.Write("номер места ");
            Console.WriteLine(place);
            Console.Write("часов до отправки ");
            Console.WriteLine(Math.Round(hours));
            Console.Write("отправка в ");
            Console.WriteLine(departureTime);

        }
    }
    
}
