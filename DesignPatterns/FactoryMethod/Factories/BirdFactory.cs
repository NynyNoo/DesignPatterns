namespace DesignPatterns.FactoryMethod;

public class BirdFactory : AnimalFactory
{
    public override IAnimal CreateAnimal(string name)
    {
        return new Bird(name);
    }
}