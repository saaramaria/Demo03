using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a new car object
            Car car = new Car();
            car.Model = "Datsun 100A";
            car.Color = "Yellow";
            car.Engine = 0.4;
            car.DoorCount = 2;
            car.Accelerate();
            car.PrintData();

            // create another car object
            Car car2 = new Car("Jeep", "Red");
            car2.Engine = 5.0;
            car2.DoorCount = 4;
            car2.FuzzyDices = false;
            car2.Accelerate();
            car2.Brake();
            car2.PrintData();

            Console.ReadKey();
        }
    }
}
