namespace FactoryDecorator.Ingredients
{
    public class CheeseFeta: PizzaDecorator, IIngredient
    {
        private const double Cost = 10;
        private const string Description = "Cheese feta";
        private readonly Pizza _pizza;

        public CheeseFeta(Pizza pizza)
        {
            _pizza = pizza;
        }

        public CheeseFeta()
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