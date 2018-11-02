namespace FactoryDecorator.Ingredients
{
    public class Mushrooms: PizzaDecorator, IIngredient
    {
        private const double Cost = 4;
        private const string Description = "Cheese feta";
        private readonly Pizza _pizza;

        public Mushrooms(Pizza pizza)
        {
            _pizza = pizza;
        }

        public Mushrooms()
        {
            
        }
        
        public override double GetCost()
        {
            return Cost + _pizza.GetCost();
        }

        public override string GetDescription()
        {
            return $"{Description} {_pizza?.GetDescription()}";
        }
    }
}