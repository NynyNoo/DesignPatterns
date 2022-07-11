namespace DesignPatterns.MediatorPattern;

public class Order:IOrder
{
    private int _orderID;
    private string _address;
    private float _price;
    public int OrderId => _orderID;
    public string Address => _address;
    public float price => _price;

    public Order(int orderId, string address, float price)
    {
        _orderID = orderId;
        _address = address;
        _price = price;
    }

    public void OrderAssigned(string name)
    {
        Console.WriteLine($"order assigned to {name}");
    }
}