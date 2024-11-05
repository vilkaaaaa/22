using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyweigth
{
     class HouseFactory
    {
        Dictionary<string, House> houses = new Dictionary<string, House>();
        public HouseFactory()
        {
            houses.Add  ("Panel", new PanelHouse());
            houses.Add("Brick", new BrickHouse());
        }
        public House GetHouse(string key)
        {
            if (houses.ContainsKey(key))
                return houses[key];
            else
                return null;
        }

    }
}
