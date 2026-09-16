using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class ElectricVehicleFactory : IVehicleFactory

    {
        public IVehicle CreateVehicle()
        {
            return new ElectricVehicle();
        }
        public IVehicle CreateTruck()
        {
            return new ElectricTruck();
        }
        public IEngine CreateEngine()
        {
            return new ElectricEngine();
        }

        public IVehicle CreateCar()
        {
            throw new NotImplementedException();
        }
    }

   
}
