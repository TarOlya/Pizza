namespace FactoryDecorator.Menu
{
    public class Ester: Pizza
    {
        private const string Description = "Pizza ester";
        private const double Cost = 60;

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