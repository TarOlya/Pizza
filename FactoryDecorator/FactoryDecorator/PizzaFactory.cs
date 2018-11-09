using System;
using FactoryDecorator.Menu;

namespace FactoryDecorator
{
    public class PizzaFactory: IPizzaFactory
    {
        public Pizza Create(string pizzaType)
        {
            var pizza = new Ester();
            var a = pizza.GetType();
            Type type = Type.GetType(pizzaType);
            if (type == null)
            {
                throw new ArgumentException("Pizza not found");
            }

            return Activator.CreateInstance(type) as Pizza;
        }
    }
}