namespace FactoryDecorator.Ingredients
{
    public class CakeLayer: PizzaDecorator, IIngredient
    {
        private const double Cost = 1;
        private const string Description = "Cake layer";
        private readonly Pizza _pizza;

        public CakeLayer(Pizza pizza)
        {
            _pizza = pizza;
        }

        public CakeLayer()
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