namespace DesignPatterns.FactoryMethod;

public class DogFactory : AnimalFactory
{
    public override IAnimal CreateAnimal(string name)
    {
        return new Dog(name);
    }
}