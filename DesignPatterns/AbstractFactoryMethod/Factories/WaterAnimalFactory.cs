using DesignPatterns.AbstractFactoryMethod.Animals.WaterAnimals;
using DesignPatterns.AbstractFactoryMethod.Interfaces;

namespace DesignPatterns.AbstractFactoryMethod.Factories;

public class WaterAnimalFactory:IAnimalFactory
{
    public IAmphibian CreateAmphibian()
    {
        return new Frog();
    }
    public IReptile CreateReptile()
    {
        return new Crocodile();
    }
    public IMamal CreateMamal()
    {
        return new Whale();
    }
}