namespace DesignPatterns.FactoryMethod;

public class Bird : IAnimal
{ 
    string _name;
    public Bird(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }

    public string TravelStyle()
    {
        return "Fly";
    }
}