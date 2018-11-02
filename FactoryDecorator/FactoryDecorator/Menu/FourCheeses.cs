using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using FactoryDecorator.Ingredients;

namespace FactoryDecorator.Menu
{
    public class FourCheeses: Pizza
    {
        private const double Cost = 56;
        private const string Description = "Four cheese pizza";
        private List<IIngredient> _recipe;

        public FourCheeses()
        {
            _recipe = new List<IIngredient>
            {
                new BlackOlives(),
                new CheeseFeta(),
                new CheeseFormagio(),
                new RossiyskiCheese(),
                new CreamCheese()
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