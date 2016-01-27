using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Washer washer = new Washer();
            washer.PrintData();
            washer.SetTemperature(60);
            washer.SetDuration(40);
            washer.SetProgram("Hellävarainen");
            washer.PrintData();

            Washer washer2 = new Washer();
        }
    }
}
