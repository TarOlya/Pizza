namespace FactoryDecorator.Ingredients
{
    public class Ham: PizzaDecorator, IIngredient
    {
        private const double Cost = 7;
        private const string Description = "Ham";
        private readonly Pizza _pizza;

        public Ham(Pizza pizza)
        {
            _pizza = pizza;
        }

        public Ham()
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