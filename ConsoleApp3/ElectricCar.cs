using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class ElectricCar : IVehicle
    {
        public void ShowDetails()
        {
            Console.WriteLine("Vehicle : Electrical car");
        }
    }
}
