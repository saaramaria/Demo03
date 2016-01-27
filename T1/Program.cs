using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Heater heater = new Heater();
            heater.PrintData();
            heater.Temperature = 80;
            heater.Humidity = 70;
            heater.RaiseTemperature();
            heater.Off();
            heater.PrintData();
            heater.ToString();
            Console.WriteLine(heater);

            Heater heater2 = new Heater(90, 85);
            heater2.PrintData();
            heater2.LowerHumidity();
            heater2.RaiseTemperature();
            heater2.PrintData();

            Console.WriteLine("Temperature = " + heater2.Temperature);
        }
    }
}
