namespace FactoryDecorator.Ingredients
{
    public class CreamCheese: PizzaDecorator, IIngredient
    {
        private const double Cost = 16;
        private const string Description = "Cream cheese";
        private readonly Pizza _pizza;

        public CreamCheese(Pizza pizza)
        {
            _pizza = pizza;
        }

        public CreamCheese()
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