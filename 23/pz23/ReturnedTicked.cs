using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz23
{
    class ReturnedTicket : ticked
    {
        public DateTime ReturnDate { get; set; }

        public ReturnedTicket(int id, int ownerPassport, string type, int trainNumber, int place, DateTime departureTime)
            : base(id, ownerPassport, type, trainNumber, place, departureTime)
        {
        }

        public void CreateReservation()
        {
            // создаем бронь на следующий день
            ReturnDate = departureTime.AddDays(1);
        }

        public override void GetTimeLeft()
        {
            DateTime now = DateTime.Now;
            TimeSpan remainingTime;

            if (ReturnDate != default(DateTime)) // если была создана бронь на следующий день
            {
                remainingTime = ReturnDate - now;
            }
            else
            {
                remainingTime = departureTime - now;
            }

            hours = remainingTime.TotalHours;
        }

        public override void PrintInfo()
        {
            GetTimeLeft();
            Console.WriteLine("возврващенный билет");
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
            Console.Write("возврат билета до ");
            Console.WriteLine(ReturnDate);
        }
    }

}
