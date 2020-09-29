using System;
using static System.Console;

namespace AccessModifier
{
    class WaterHeater
    {
        protected int temperature;

        public void SetTemperature(int temperature)
        {
            if(temperature<-5 || temperature > 42)
            {
                throw new Exception("Out of temperature range");
            }
            this.temperature = temperature;
        }
        internal void TurnOnWater()
        {
            WriteLine($"Turn on water : {temperature}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WaterHeater heater = new WaterHeater();
                heater.SetTemperature(20);
                heater.TurnOnWater();

                heater.SetTemperature(-2);
                heater.TurnOnWater();

                heater.SetTemperature(50);
                heater.TurnOnWater();

            }
            catch(Exception e)
            {
                WriteLine(e.Message);
            }
        }
    }
}
