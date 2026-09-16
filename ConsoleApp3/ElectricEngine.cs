using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class ElectricEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Engine : Electric engine");
        }
    }
}
