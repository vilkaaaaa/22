namespace pz28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureGenerator generator = new TemperatureGenerator();
            TemperatureTracker tracker = new TemperatureTracker(generator);

            tracker.TemperatureChanged += OnTemperatureChanged;

            Console.WriteLine("Press any key to stop tracking temperature...");
            Console.ReadKey(true);
        }

        private static void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
        {
            Console.WriteLine($"Temperature changed to {e.Temperature}°C");

            if (e.Temperature == -25 || e.Temperature == 0 ||
                e.Temperature == 25 || e.Temperature == 35)
            {
                Console.WriteLine($"{e.Temperature}°C - important temperature!");
            }
        }
    }
}