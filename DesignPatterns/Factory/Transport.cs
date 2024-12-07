using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public abstract class Transport
    {
        // Factory Method
        public abstract IVehicle CreateTransport();

        public void StartTransport()
        {
            var vehicle = CreateTransport();
            vehicle.Start();
        }
    }
}
