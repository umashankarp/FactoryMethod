using System;
using System.Collections.Generic;

namespace FactoryPattern
{

    class BurgerDriveThrough
    {
        static void Main(string[] args)
        {
            BurgerStore cheeseStore = new CheeseBurgerStore();
            BurgerStore veganStore = new VeganBurgerStore();

            Burger burger = cheeseStore.OrderBurger(Burgers.CHEESE);
            Console.WriteLine($"Ethan ordered a {burger.GetName()}\n");

            burger = veganStore.OrderBurger(Burgers.DELUXEVEGAN);
            Console.WriteLine($"Joel ordered a {burger.GetName()}\n");
        }
    }
}

