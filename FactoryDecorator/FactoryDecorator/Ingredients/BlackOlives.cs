namespace FactoryDecorator.Ingredients
{
    public class BlackOlives: PizzaDecorator, IIngredient
    {
        private const double Cost = 6;
        private const string Description = "Black Olives";
        private readonly Pizza _pizza;

        public BlackOlives(Pizza pizza)
        {
            _pizza = pizza;
        }

        public BlackOlives()
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