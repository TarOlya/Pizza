using System;

namespace FactoryDecorator
{
    public abstract class  Pizza
    {
        public abstract double GetCost();
        public abstract string GetDescription();
        
        protected virtual void Create()
        {
            Console.WriteLine("Pizza has created");
        }

        protected virtual void Cut()
        {
            Console.WriteLine("Pizza has sliced");
        }

        protected virtual void Box()
        {
            Console.WriteLine("Pizza has boxed");
        }

        protected virtual void Send()
        {
            Console.WriteLine("Pizza has sent");
        }
    }
}