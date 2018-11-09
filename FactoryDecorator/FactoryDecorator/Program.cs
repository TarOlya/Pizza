using System;
using FactoryDecorator.Ingredients;
using FactoryDecorator.Menu;

namespace FactoryDecorator
{
    class Program
    {
        static void Main()
        {
            var factory = new PizzaFactory();
            Console.WriteLine(factory.Create("FactoryDecorator.Menu.Ester").GetCost());
        }
    }
}