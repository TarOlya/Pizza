namespace FactoryDecorator.Ingredients
{
    public class RossiyskiCheese: PizzaDecorator, IIngredient
    {
        private const double Cost = 1;
        private const string Description = "Rossiyski cheese";
        private readonly Pizza _pizza;

        public RossiyskiCheese(Pizza pizza)
        {
            _pizza = pizza;
        }

        public RossiyskiCheese()
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