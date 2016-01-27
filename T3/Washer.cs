using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Washer
    {
        // properties
        public int Duration { get; set; }
        public string WashingProgram { get; set; }
        public bool IsOn { get; set; }
        public int Temperature { get; set; }

        //default constructor
        public Washer()
        {
            IsOn = true;
        }

        // parametric constructor
        public Washer(int temperature, int duration)
        {
            IsOn = true;
            Temperature = temperature;
            Duration = duration;
        }
    
        // set duration
        public void SetDuration(int duration)
        {
            Duration = duration;
        }

        // set washing program
        public void SetProgram(string program)
        {
            WashingProgram = program;
        }

        // set temperature
        public void SetTemperature(int temperature)
        {
            Temperature = temperature;
        }

        //washer on
        public void On()
        {
            IsOn = true;
        }

        //washer off
        public void Off()
        {
            IsOn = false;
        }

        // print properties to console
        public void PrintData()
        {
            Console.WriteLine("Washer data:");
            Console.WriteLine("- Duration (min): {0}", Duration);
            Console.WriteLine("- Washing program: {0}", WashingProgram);
            Console.WriteLine("- Temperature: {0}", Temperature);
            Console.WriteLine("- Is on: {0}", IsOn);
        }
    }
}
