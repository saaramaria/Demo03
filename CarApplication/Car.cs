using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Car
    {
        // properties
        public string Model { get; set; }
        public string Color { get; set; }
        public double Engine { get; set; }
        public int Speed { get; set; }
        public bool FuzzyDices { get; set; }
        public int DoorCount { get; set; }

        // default constructor
        public Car()
        {
            FuzzyDices = true;
        }

        //parametric constructor
        public Car(string model, string color)
        {
            Model = model;
            Color = color;
        }

        // methods

        // give more speed
        public void Accelerate()
        {
            Speed += 5;
        }

        // slow down
        public void Brake()
        {
            Speed -= 5;
        }

        // print properties to console
        public void PrintData()
        {
            Console.WriteLine("Car properties:");
            Console.WriteLine("- Model: {0}", Model);
            Console.WriteLine("- Color: {0}", Color);
            Console.WriteLine("- Engine: {0}", Engine);
            Console.WriteLine("- Speed: {0}", Speed);
            Console.WriteLine("- FuzzyDices: {0}", FuzzyDices);
            Console.WriteLine("- Door count: {0}", DoorCount);
        }
    }
}
