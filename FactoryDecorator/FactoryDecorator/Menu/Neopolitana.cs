namespace FactoryDecorator.Menu
{
    public class Neopolitana: Pizza
    {
        private const double Cost = 78;
        private const string Description = "Pizza neopolitana";
        
        public override double GetCost()
        {
            return Cost;
        }

        public override string GetDescription()
        {
            return Description;
        }
    }
}