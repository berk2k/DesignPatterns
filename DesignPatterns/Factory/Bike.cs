using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class Bike : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Bike is starting.");
        }
    }
}
