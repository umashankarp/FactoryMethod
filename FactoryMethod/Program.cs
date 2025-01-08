using System;
using System.Collections.Generic;
using FactoryMethod.BurgerFactory;
using FactoryMethod.VehicleFactory;

namespace FactoryPattern
{

    class BurgerDriveThrough
    {
        static void Main(string[] args)
        {

            // Burger Factory Method Implementaion
            BurgerStore cheeseStore = new CheeseBurgerStore();
            BurgerStore veganStore = new VeganBurgerStore();

            Burger burger = cheeseStore.OrderBurger(Burgers.CHEESE);
            Console.WriteLine($"Ethan ordered a {burger.GetName()}\n");

            burger = veganStore.OrderBurger(Burgers.DELUXEVEGAN);
            Console.WriteLine($"Joel ordered a {burger.GetName()}\n");

            // Vehical Factory Method Implementaion
            VehicleFactory carFactory = new CarFactory();
            VehicleFactory truckFactory = new TruckFactory();
            VehicleFactory bikeFactory = new BikeFactory();

            IVehicle myCar = carFactory.CreateVehicle();
            IVehicle myTruck = truckFactory.CreateVehicle();
            IVehicle myBike = bikeFactory.CreateVehicle();
           
            Console.WriteLine(myCar.VehicleType());   // "Car"
            Console.WriteLine(myTruck.VehicleType()); // "Truck"
            Console.WriteLine(myBike.VehicleType());  // "Bike"
        }
    }
}

