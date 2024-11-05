using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyweigth
{
     class PanelHouse : House
    {
        public PanelHouse()
        {
            stages = 9;
        }
        public override void Bild(double longitude, double latitude)
        {
            Console.WriteLine($"Построен панелька-дом из {stages} этажей; координаты {latitude} широты & долготы {longitude}");
        }
    }
}
