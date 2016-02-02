using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// @author Saara Virtanen
/// @version 29.1.2016
/// <summary>
/// Vehicle-class
/// </summary>
namespace T4
{
    class Vehicle
    {
        //properties
        public int Speed { get; set; }
        public string Name { get; set; }
        public int Tyres { get; set; }

        //default constructor
        public Vehicle()
        {
            Speed = 0;
        }

        //parametric constructor
        public Vehicle(int speed, int tyres)
        {
            Speed = speed;
            Tyres = tyres;
        }

        //print properties to console
        public void PrintData()
        {
            Console.WriteLine("Vehicle properties:");
            Console.WriteLine("- Name: {0}", Name);
            Console.WriteLine("- Speed: {0}", Speed);
            Console.WriteLine("- Tyres: {0}", Tyres);
        }

        //method returns object properties in one string
        public override string ToString()
        {
            return "Name = " + Name + ", Speed = " + Speed + ", Tyres = " + Tyres;
        }
    }
}
