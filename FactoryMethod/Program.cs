using System;
using System.Collections.Generic;

namespace FactoryPattern
{
    enum Burgers
    {
        CHEESE,
        DELUXECHEESE,
        VEGAN,
        DELUXEVEGAN,
    }

    abstract class BurgerStore
    {
        public abstract Burger CreateBurger(Burgers item);

        public Burger OrderBurger(Burgers type)
        {
            Burger burger = CreateBurger(type);
            Console.WriteLine($"--- Making a {burger.GetName()} ---");
            burger.Prepare();
            burger.Cook();
            burger.Serve();
            return burger;
        }
    }

    class CheeseBurgerStore : BurgerStore
    {
        public override Burger CreateBurger(Burgers item)
        {
            if (item == Burgers.CHEESE)
            {
                return new CheeseBurger();
            }
            else if (item == Burgers.DELUXECHEESE)
            {
                return new DeluxeCheeseBurger();
            }
            else
            {
                return null;
            }
        }
    }

    class VeganBurgerStore : BurgerStore
    {
        public override Burger CreateBurger(Burgers item)
        {
            if (item == Burgers.VEGAN)
            {
                return new VeganBurger();
            }
            else if (item == Burgers.DELUXEVEGAN)
            {
                return new DeluxeVeganBurger();
            }
            else
            {
                return null;
            }
        }
    }

    abstract class Burger
    {
        protected string name;
        protected string bread;
        protected string sauce;
        protected List<string> toppings = new List<string>();

        public void Prepare()
        {
            Console.WriteLine("Preparing the burger...");
            // Add preparation logic here
        }

        public void Cook()
        {
            Console.WriteLine("Cooking the burger...");
            // Add cooking logic here
        }

        public void Serve()
        {
            Console.WriteLine("Serving the burger...");
            // Add serving logic here
        }

        public string GetName()
        {
            return name;
        }
    }

    class CheeseBurger : Burger
    {
        public CheeseBurger()
        {
            name = "Cheese Burger";
            // Set additional properties here
        }
    }

    class DeluxeCheeseBurger : Burger
    {
        public DeluxeCheeseBurger()
        {
            name = "Deluxe Cheese Burger";
            // Set additional properties here
        }
    }

    class VeganBurger : Burger
    {
        public VeganBurger()
        {
            name = "Vegan Burger";
            // Set additional properties here
        }
    }

    class DeluxeVeganBurger : Burger
    {
        public DeluxeVeganBurger()
        {
            name = "Deluxe Vegan Burger";
            // Set additional properties here
        }
    }

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

