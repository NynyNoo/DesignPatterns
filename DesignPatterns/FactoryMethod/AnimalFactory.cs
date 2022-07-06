namespace DesignPatterns.FactoryMethod;

public abstract class AnimalFactory
{
    public abstract IAnimal CreateAnimal(string name);
}