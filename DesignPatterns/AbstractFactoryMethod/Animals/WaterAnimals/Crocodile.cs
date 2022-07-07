using DesignPatterns.AbstractFactoryMethod.Interfaces;

namespace DesignPatterns.AbstractFactoryMethod.Animals.WaterAnimals;

public class Crocodile:IReptile
{
    private string specie="Reptile";
    private string travelForm="Swiming";
    private string name="Crocodile";
    
    public string GetTravelFormAndSpecies()
    {
        return (specie,travelForm,name).ToString();
    }
}