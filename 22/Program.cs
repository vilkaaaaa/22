namespace _22
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Ticked ticked = new Ticked(1, 123456789, "Электронный", 123, 45, new DateTime(2023, 5, 14, 15, 30, 0));
            ticked.PrintInfo();

            Console.ReadKey();
        }
    }
}

