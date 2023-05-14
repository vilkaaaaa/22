using System.Runtime.InteropServices;

namespace _22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime otprav = new DateTime(2023, 2, 20, 12, 30, 00);
            Ticket sasha = new Ticket(2654, 5649, "льгот", 7, 11, otprav);
            sasha.PrintInfo();


        }
    }
}