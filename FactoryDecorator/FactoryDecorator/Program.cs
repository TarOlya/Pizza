using System;
using FactoryDecorator.Ingredients;
using FactoryDecorator.Menu;

namespace FactoryDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizza = new FourCheeses();
            Console.WriteLine(pizza.GetDescription());
            Console.WriteLine(pizza.GetRecipe());

            Console.WriteLine(pizza.GetDescription());
        }
    }
}