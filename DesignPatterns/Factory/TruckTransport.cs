﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class TruckTransport : Transport
    {
        public override IVehicle CreateTransport()
        {
            return new Truck();
        }
    }
}
