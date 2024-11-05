namespace flyweigth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double longitude = 40.63;
            double latifude = 58.25;
            HouseFactory houseFactory = new HouseFactory();
            for (int i = 0;i<5; i++)
            {
                House panelHouse = houseFactory.GetHouse("Panel");
                if (panelHouse != null)
                    panelHouse.Bild(longitude, latifude);
                longitude += 0.1;
                latifude += 0.1;
            }
            for (int i = 0; i < 5; i++)
            {
                House housebrick = houseFactory.GetHouse("Brick");
                if (housebrick != null)
                    housebrick.Bild(longitude, latifude);
                longitude += 1.1;
                latifude += 1.1;
            }
                Console.Read();
            }
        
    }
}
