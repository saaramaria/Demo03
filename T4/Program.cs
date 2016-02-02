using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// @author Saara Virtanen
/// @version 29.1.2016
/// <summary>
/// Using Vehicle-class
/// </summary>
namespace T4
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle(); //default constructor
            vehicle.PrintData();
            vehicle.Speed = 60;
            vehicle.Name = "Vehicle 1";
            vehicle.Tyres = 4;
            vehicle.PrintData();

            vehicle.ToString();
            Console.WriteLine(vehicle);

            Vehicle vehicle2 = new Vehicle(100, 4); //parametric constructor
            vehicle2.PrintData();
            vehicle2.Name = "Vehicle 2";
            vehicle2.Speed += 10;
            vehicle2.PrintData();
        }
    }
}
