namespace DesignPatterns.FactoryMethod;

public class Dog : IAnimal
{
    private string _name;
    public Dog(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }

    public string TravelStyle()
    {
        return "Run";
    }
}