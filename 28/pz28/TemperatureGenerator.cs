using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz28
{
    internal class TemperatureGenerator
    {
        private int temperature = -30;

        public int GetTemperature()
        {
            if (temperature < 40)
            {
                temperature++;
            }
            else
            {
                temperature = -30;
            }

            return temperature;
        }
    }
}
