namespace DesignPatterns.MediatorPattern;

public class Car:ICar
{
    private readonly string _name;
    private readonly bool _isFree;
    public string Name => _name;
    public bool IsFree => _isFree;
    public void Assign(int orderId, string address)
    {
        Console.WriteLine($"Car {_name}, assigned order{orderId}, to delier to {address}.");
    }

    public Car(string name, bool isFree)
    {
        _name = name;
        _isFree = isFree;
    }
}