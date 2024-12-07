using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class Car : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Car is starting.");
        }
    }
}
