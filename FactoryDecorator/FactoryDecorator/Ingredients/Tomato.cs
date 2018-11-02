namespace FactoryDecorator.Ingredients
{
    public class Tomato: PizzaDecorator, IIngredient
    {
        private const double Cost = 9;
        private const string Description = "Tomato";
        private readonly Pizza _pizza;

        public Tomato(Pizza pizza)
        {
            _pizza = pizza;
        }

        public Tomato()
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