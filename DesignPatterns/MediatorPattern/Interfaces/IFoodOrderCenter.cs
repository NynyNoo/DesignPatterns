namespace DesignPatterns.MediatorPattern;

internal interface IFoodOrderCenter
{
    void RegisterOrder(IOrder order);
    void BookCar(ICar car);
}