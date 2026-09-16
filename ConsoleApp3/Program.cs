using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
       

            static void Main(string[] args)
        {
            Console.WriteLine(" Gasoline Vehicle Production");
            IVehicleFactory gasolineFactory = new GasolineVehicleFactory();

            IVehicle gasCar = gasolineFactory.CreateCar();
            IVehicle gasTruck = gasolineFactory.CreateTruck();
            IEngine gasEngine = gasolineFactory.CreateEngine();

            gasCar.ShowDetails();
            gasTruck.ShowDetails();
            gasEngine.Start();

            Console.WriteLine("Electric Vehicle Production ");
            IVehicleFactory electricFactory = new ElectricVehicleFactory();

            IVehicle electricCar = electricFactory.CreateCar();
            IVehicle electricTruck = electricFactory.CreateTruck();
            IEngine electricEngine = electricFactory.CreateEngine();

            electricCar.ShowDetails();
            electricTruck.ShowDetails();
            electricEngine.Start();

            Console.ReadLine();
        }
        }
    }

