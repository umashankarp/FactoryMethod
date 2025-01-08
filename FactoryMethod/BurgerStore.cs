namespace FactoryPattern
{
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
}

