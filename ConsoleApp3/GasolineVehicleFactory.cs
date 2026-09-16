using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class GasolineVehicleFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            return new GasolineCar();
        }
        public IVehicle CreateTruck()
        {
            return new GasolineTruck();
        }
        public IEngine CreateEngine()
        {
            return new GasolineEngine();
        }

        public IVehicle CreateCar()
        {
            throw new NotImplementedException();
        }
    }
}
