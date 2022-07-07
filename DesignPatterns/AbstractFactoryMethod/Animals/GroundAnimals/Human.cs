using DesignPatterns.AbstractFactoryMethod.Interfaces;

namespace DesignPatterns.AbstractFactoryMethod.Animals.GroundAnimals;

public class Human:IMamal
{
    private string specie = "Mamal";
    private string travelForm = "Driving";
    private string name = "Human";

    public string GetTravelFormAndSpecies()
    {
        return (specie, travelForm, name).ToString();
    }
}