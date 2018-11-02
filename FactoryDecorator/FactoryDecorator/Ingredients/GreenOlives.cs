namespace FactoryDecorator.Ingredients
{
    public class GreenOlives: PizzaDecorator, IIngredient
    {
        private const double Cost = 11;
        private const string Description = "Green olives";
        private readonly Pizza _pizza;

        public GreenOlives(Pizza pizza)
        {
            _pizza = pizza;
        }

        public GreenOlives()
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