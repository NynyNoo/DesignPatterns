namespace DesignPatterns.FactoryMethod;

public class Animals
{
    public void MakeSomeAnimals()
    {
        IAnimal dog = new DogFactory().CreateAnimal("Dogo");
        Console.WriteLine("{0} can {1}",dog.GetName(),dog.TravelStyle());
        
        
        CreateAnimal(new BirdFactory(), "Birdo");
    }
    public void CreateAnimal(AnimalFactory animalFactory,string name)
    {
        animalFactory.SomeOperation(name);
    }
}