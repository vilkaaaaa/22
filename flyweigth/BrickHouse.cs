using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyweigth
{
    class BrickHouse : House
    {
        public BrickHouse()
        {
            stages = 5;
        }
        public override void Bild(double longitude, double latitude)
        {
            Console.WriteLine("Построен кирпичный дом из 5 этажей; координаты: {0} широты и {1} долготы",latitude,longitude);
        }
    }
}
