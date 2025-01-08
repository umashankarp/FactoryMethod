﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.VehicleFactory
{
    public class Car : IVehicle
    {
        public string VehicleType()
        {
            return "Car";
        }
    }
}