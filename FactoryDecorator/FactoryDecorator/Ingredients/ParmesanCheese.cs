namespace FactoryDecorator.Ingredients
{
    public class ParmesanCheese: PizzaDecorator
    {
        private const double Cost = 4;
        private const string Description = "Parmesan cheese";
        private readonly Pizza _pizza;

        public ParmesanCheese(Pizza pizza)
        {
            _pizza = pizza;
        }

        public ParmesanCheese()
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