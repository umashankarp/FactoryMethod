namespace FactoryPattern
{
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
}

