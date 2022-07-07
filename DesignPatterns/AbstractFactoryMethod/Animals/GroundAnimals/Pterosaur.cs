using DesignPatterns.AbstractFactoryMethod.Interfaces;

namespace DesignPatterns.AbstractFactoryMethod.Animals.GroundAnimals;

public class Pterosaur:IReptile
{
    private string specie = "Reptile";
    private string travelForm = "Flying";
    private string name = "Pterosaur";

    public string GetTravelFormAndSpecies()
    {
        return (specie, travelForm, name).ToString();
    }
}
