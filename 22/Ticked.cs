using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22
{
    internal class Ticked
    {
        public int id
        {
            get { return id; }
            set
            {
                {
                    try
                    {
                        if (value > 0)
                            throw new ArgumentException("Значение должно быть меньше или равно 0.", nameof(value));

                        id = value;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine("Ошибка: " + ex.Message);

                    }
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
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException(nameof(value));

                type = value;
            }
        }
        public int trainNumber
        {
            get { return trainNumber; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException(nameof(value));

                trainNumber = value;
            }
        }
        public int place
        {
            get { return place; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException(nameof(value));

                place = value;
            }

        }
        public DateTime departureTime
        {
            get { return departureTime; }
            set
            {
                if (value == default(DateTime))
                    throw new ArgumentException("Дата отправления не может быть пустым значением", nameof(value));

                departureTime = value;
            }

        }
        static double hours
        {
            get { return hours; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException(nameof(value));

                hours = value;
            }
        }
        public Ticked (int id, int ownerPassport, string type, int trainNumber, int place, DateTime departureTime)
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
