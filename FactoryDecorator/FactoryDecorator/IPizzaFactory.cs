namespace FactoryDecorator
{
    public interface IPizzaFactory
    {
        Pizza Create(string type);
    }
}