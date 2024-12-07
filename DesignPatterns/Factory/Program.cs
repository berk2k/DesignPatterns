using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Transport carTransport = new CarTransport();
            carTransport.StartTransport();

            
            Transport bikeTransport = new BikeTransport();
            bikeTransport.StartTransport();

            
            Transport truckTransport = new TruckTransport();
            truckTransport.StartTransport();
        }
    }

}
