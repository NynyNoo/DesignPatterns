namespace DesignPatterns.MediatorPattern;

public class FoodOrderCenter:IFoodOrderCenter
{
    private readonly Dictionary<string, ICar> cars = new();

    public void RegisterOrder(IOrder order)
    {
        foreach (var car in cars.Values.Where(c=> c.IsFree))
        {
            car.Assign(order.OrderId, order.Address);
            order.OrderAssigned(car.Name);
        }
    }

    public void BookCar(ICar car)
    {
        if(!cars.ContainsValue(car)) cars.Add(car.Name,car);
    }
}