namespace FactoryDecorator.Ingredients
{
    public class CheeseFormagio: PizzaDecorator, IIngredient 
    {
        private const double Cost = 18;
        private const string Description = "Cheese formagio";
        private readonly Pizza _pizza;

        public CheeseFormagio(Pizza pizza)
        {
            _pizza = pizza;
        }

        public CheeseFormagio()
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