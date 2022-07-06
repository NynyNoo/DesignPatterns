namespace DesignPatterns.FactoryMethod;

public abstract class AnimalFactory
{
    public abstract IAnimal CreateAnimal(string name);
    public void SomeOperation(string name)
    {
        var createdAnimal = CreateAnimal(name);
        Console.Write("{0} can {1}", createdAnimal.GetName(), createdAnimal.TravelStyle());
    }
}