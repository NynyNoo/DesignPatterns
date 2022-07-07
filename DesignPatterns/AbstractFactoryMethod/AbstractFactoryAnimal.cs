using DesignPatterns.AbstractFactoryMethod.Interfaces;
using DesignPatterns.AbstractFactoryMethod.Factories;

namespace DesignPatterns.AbstractFactoryMethod;

public class AbstractFactoryAnimal
{
    public void GenerateCorrectAnimal()
    {
        
        Console.WriteLine("Ground Animals:");       
        GenerateCorrectAnimal(new GroundAnimalFactory());

        Console.WriteLine("Water Animals:");
        GenerateCorrectAnimal(new WaterAnimalFactory());
    }
    public void GenerateCorrectAnimal(IAnimalFactory factory)
    {
        var animal1 = factory.CreateAmphibian();
        var animal2 = factory.CreateMamal();
        var animal3 = factory.CreateReptile();
        
        Console.WriteLine("First animal ={0}",animal1.GetTravelFormAndSpecies());
        Console.WriteLine("Second animal ={0}",animal2.GetTravelFormAndSpecies());
        Console.WriteLine("Third animal ={0}",animal3.GetTravelFormAndSpecies());
    }
}


