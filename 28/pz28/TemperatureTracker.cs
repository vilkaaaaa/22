using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz28
{
    internal class TemperatureTracker
    {
        private readonly TemperatureGenerator generator;
        private int currentTemperature;

        public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;

        public TemperatureTracker(TemperatureGenerator generator)
        {
            this.generator = generator;
            this.currentTemperature = generator.GetTemperature();

            // Start tracking temperature changes on a separate thread.
            var timer = new System.Threading.Timer(UpdateTemperature, null, TimeSpan.Zero, TimeSpan.FromSeconds(1));
        }

        private void UpdateTemperature(object state)
        {
            int newTemperature = generator.GetTemperature();
            if (newTemperature != currentTemperature)
            {
                currentTemperature = newTemperature;

                TemperatureChanged?.Invoke(this, new TemperatureChangedEventArgs(currentTemperature));
            }
        }
    }
}
