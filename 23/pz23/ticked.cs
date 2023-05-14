using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz23
{
     class ticked
    {
        public virtual int id
        {
            get { return id; }
            set
            {
                try
                {
                    
                    if (value < 0)
  

                    id = value;
                }
                catch (ArgumentException ex)
                {
                    
                    Console.WriteLine("Ошибка: " + ex.Message);
                }

            }
        }

        public int ownerPassport { get; set; }
        private int _ownerPassport;
        public int OwnerPassport
        {
            get { return _ownerPassport; }
            set { _ownerPassport = 100000000; }
        }
        public string type
        {
            get { return type; }
            set
            {
                try
                {
                    if (value != null)
                        type = value;
                }
                catch
                {
                    Console.WriteLine("ошибка");
                }
            }
        }
        public int trainNumber
        {
            get { return trainNumber; }
            set
            {
                if (value > 0)
                trainNumber = value;
            }
        }
        public int place
        {
            get { return place; }
            set
            {
                if (value > 0)
                place = value;
            }

        }
        public DateTime departureTime
        {
            get { return departureTime; }
            set
            {
                if (value != null)
                departureTime = value;
            }

        }
        public double hours
        {
            get { return hours; }
            set
            {
                if (value > 0)
                hours = value;
            }
        }
        public ticked (int id, int ownerPassport, string type, int trainNumber, int place, DateTime departureTime)
        {
            this.id = id;
            this.ownerPassport = ownerPassport;
            this.type = type;
            this.trainNumber = trainNumber;
            this.place = place;
            this.departureTime = departureTime;
        }
         public virtual void GetTimeLeft()
        {
            DateTime now = DateTime.Now;
            TimeSpan ostalos = departureTime - now;
            hours = ostalos.TotalHours;

        }

        public virtual void PrintInfo()
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
