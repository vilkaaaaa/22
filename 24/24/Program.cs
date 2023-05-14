using System;

interface ITicket
{
    void GetTimeLeft();
    void PrintInfo();
}

interface ICloneable
{
    object Clone();
}

internal class Ticked : ITicket, ICloneable
{
    public virtual int Id
    {
        get => Id; 
        set
        {
            try
            {

                if (value < 0)


                    Id = value;
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine("Ошибка: " + ex.Message);
            }

        }
    }

    public int OwnerPassport { get; set; }
    private int _ownerPassport;
    public int TrainNumber { get; set; }
    public int Place { get; set; }
    public DateTime DepartureTime { get; set; }
    public double Hours { get; set; }

    public Ticked(int id, int ownerPassport, int trainNumber, int place, DateTime departureTime)
    {
        this.Id = id;
        this.OwnerPassport = ownerPassport;
        this.TrainNumber = trainNumber;
        this.Place = place;
        this.DepartureTime = departureTime;
    }

    public virtual void GetTimeLeft()
    {
        DateTime now = DateTime.Now;
        TimeSpan remainingTime = DepartureTime - now;
        Hours = remainingTime.TotalHours;
    }

    public virtual void PrintInfo()
    {
        GetTimeLeft();
        Console.WriteLine("Айди: {0}", Id);
        Console.WriteLine("Паспорт: {0}", OwnerPassport);
        Console.WriteLine("Номер поезда: {0}", TrainNumber);
        Console.WriteLine("Номер места: {0}", Place);
        Console.WriteLine("Часов до отправки: {0}", Math.Round(Hours));
        Console.WriteLine("Отправка в: {0}", DepartureTime);
    }

    public object Clone()
    {
        return new Ticked(Id, OwnerPassport, TrainNumber, Place, DepartureTime);
    }
}

class ReturnedTicket : Ticked, ICloneable
{
    public DateTime ReturnDate { get; set; }

    public ReturnedTicket(int id, int ownerPassport, int trainNumber, int place, DateTime departureTime)
        : base(id, ownerPassport, trainNumber, place, departureTime)
    {
    }

    public void CreateReservation()
    {
        // создаем бронь на следующий день
        ReturnDate = DepartureTime.AddDays(1);
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
            remainingTime = DepartureTime - now;
        }

        Hours = remainingTime.TotalHours;
    }

    public new object Clone()
    {
        return new ReturnedTicket(Id, OwnerPassport, TrainNumber, Place, DepartureTime);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Ticked t1 = new Ticked(1, 123456789, 101, 23, new DateTime(2023, 5, 15, 14, 30, 0));
        t1.PrintInfo();

        ReturnedTicket rt1 = new ReturnedTicket(2, 987654321, 102, 45, new DateTime(2023, 5, 20));
        t1.PrintInfo();
        rt1.CreateReservation();
        rt1.GetTimeLeft();
    }
}
