using System.Collections.Generic;
using System.Linq;
using FactoryDecorator.Ingredients;

namespace FactoryDecorator.Menu
{
    public class Neopolitana: Pizza
    {
        private const double Cost = 78;
        private const string Description = "Pizza neopolitana";
        private readonly List<IIngredient> _recipe;

        public Neopolitana()
        {
            _recipe = new List<IIngredient>
            {
                new CakeLayer(),
                new Ham(),
                new BlackOlives(),
                new GreenOlives(),
                new CheeseFeta()
            };
        }

        public override double GetCost()
        {
            return Cost;
        }

        public override string GetDescription()
        {
            return Description;
        }

        public string GetRecipe()
        {
            return string.Join("\n", _recipe.Select(ingredient => ingredient.GetDescription()));
        }
    }
}