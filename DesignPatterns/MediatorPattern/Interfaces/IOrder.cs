namespace DesignPatterns.MediatorPattern;

public interface IOrder
{ 
    int OrderId { get; } 
    string Address { get; } 
    float price { get; }
    void OrderAssigned(string name);
}