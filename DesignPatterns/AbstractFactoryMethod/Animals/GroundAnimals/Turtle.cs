using DesignPatterns.AbstractFactoryMethod.Interfaces;

namespace DesignPatterns.AbstractFactoryMethod.Animals.GroundAnimals;

public class Turtle:IAmphibian
{
    private string specie="Reptile";
    private string travelForm="Walking";
    private string name="Crocodile";
    public string GetTravelFormAndSpecies()
    {
        return (specie,travelForm,name).ToString();
    }
}