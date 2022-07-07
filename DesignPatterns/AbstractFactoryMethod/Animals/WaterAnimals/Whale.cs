using DesignPatterns.AbstractFactoryMethod.Interfaces;

namespace DesignPatterns.AbstractFactoryMethod.Animals.WaterAnimals;

public class Whale:IMamal
{
    private string specie="Mamal";
    private string travelForm="Swiming";
    private string name="Whale";
    
    public string GetTravelFormAndSpecies()
    {
        return (specie,travelForm,name).ToString();
    }
}