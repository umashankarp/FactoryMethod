using FactoryPattern;

namespace FactoryMethod.BurgerFactory
{
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
}

