namespace DesignPatterns.MediatorPattern;

public class OrderFood
{
    public void StartFoodOrderSystem()
    {
        FoodOrderCenter center = new();
        Order order1 = new(123, "Bielsko-Biala Wilnowa 12", 72.32f);
        Order order2 = new(52, "Wilkowice Matejki 2/3", 122.98f);
        Car auto1 = new("Ford-1", false);
        Car auto2 = new("Yarisa-3", true);
        center.BookCar(auto1);
        center.BookCar(auto2);
        center.RegisterOrder(order1);
        center.RegisterOrder(order2);
    }
    
}