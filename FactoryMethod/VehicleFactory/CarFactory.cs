﻿namespace FactoryMethod.VehicleFactory
{
    public class CarFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            return new Car();
        }
    }
}
