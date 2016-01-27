using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Heater
    {
        // properties
        public int Temperature { get; set; }
        public int Humidity { get; set; }
        public bool IsOn { get; set; }

        // default constructor
        public Heater()
        {
            IsOn = true;
        }

        // parametric constructor
        public Heater(int temperature, int humidity)
        {
            Temperature = temperature;
            Humidity = humidity;
            IsOn = true;
        }

        // raise temperature
        public void RaiseTemperature()
        {
            Temperature += 10;
        }

        // lower temperature
        public void LowerTemperature()
        {
            Temperature -= 10;
        }

        // heater off
        public void Off()
        {
            IsOn = false;
        }

        // heater on
        public void On()
        {
            IsOn = true;
        }

        // raise humidity
        public void RaiseHumidity()
        {
            Humidity += 5;
        }

        // lower humidity
        public void LowerHumidity()
        {
            Humidity -= 5;
        }

        // method returns object properties in one string
        public override string ToString()
        {
            return "Temp = " + Temperature + " Hum = " + Humidity + " Is on = " + IsOn;
        }

        // print properties to console
        public void PrintData()
        {
            Console.WriteLine("Heater data:");
            Console.WriteLine("- Temperature: {0}", Temperature);
            Console.WriteLine("- Humidity: {0}", Humidity);
            Console.WriteLine("- Is on: {0}", IsOn);
        }
    }
}
