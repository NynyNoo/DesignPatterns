using DesignPatterns.AbstractFactoryMethod.Interfaces;

namespace DesignPatterns.AbstractFactoryMethod.Animals.WaterAnimals;

public class Frog:IAmphibian
{
    private string specie="Amphibian";
    private string travelForm="Swiming";
    private string name="Frog";
    
    public string GetTravelFormAndSpecies()
    {
        return (specie,travelForm,name).ToString();
    }
}