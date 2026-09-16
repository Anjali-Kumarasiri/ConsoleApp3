using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public interface IVehicleFactory 
    {
        IVehicle CreateVehicle();
        IVehicle CreateTruck();
        IEngine CreateEngine();
        IVehicle CreateCar();
    }
}
