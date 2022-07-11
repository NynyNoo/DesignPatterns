namespace DesignPatterns.MediatorPattern;

public interface ICar
{
    string Name { get; }
    bool IsFree { get; }
    void Assign(int orderId, string address);
}