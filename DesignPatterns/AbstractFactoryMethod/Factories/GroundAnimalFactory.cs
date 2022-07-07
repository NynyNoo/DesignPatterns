using DesignPatterns.AbstractFactoryMethod.Animals.GroundAnimals;
using DesignPatterns.AbstractFactoryMethod.Interfaces;
using DesignPatterns.FactoryMethod;

namespace DesignPatterns.AbstractFactoryMethod.Factories;

public class GroundAnimalFactory : IAnimalFactory
{
    public IAmphibian CreateAmphibian()
    {
        return new Turtle();
    }
    public IReptile CreateReptile()
    {
        return new Pterosaur();
    }
    public IMamal CreateMamal()
    {
        return new Human();
    }
}