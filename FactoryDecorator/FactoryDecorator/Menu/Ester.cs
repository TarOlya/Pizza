using System.Collections.Generic;
using System.Linq;
using FactoryDecorator.Ingredients;

namespace FactoryDecorator.Menu
{
    public class Ester: Pizza
    {
        private const string Description = "Pizza ester";
        private const double Cost = 60;
        private readonly List<IIngredient> _recipe;

        public Ester()
        {
            _recipe = new List<IIngredient>
            {
                new Ham(),
                new CakeLayer(),
                new BlackOlives(),
                new GreenOlives()
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