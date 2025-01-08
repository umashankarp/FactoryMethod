using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.VehicleFactory
{
    public abstract class VehicleFactory
    {
        public abstract IVehicle CreateVehicle();
    }
}
