using FactoryPattern;

namespace FactoryMethod.BurgerFactory
{
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
}

