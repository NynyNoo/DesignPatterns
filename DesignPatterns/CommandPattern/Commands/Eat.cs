namespace DesignPatterns.CommandPattern;

public class Eat : Command
{
    public Eat()
    {
        strCommand = "Eat";
    }
    public override void Action()
    {
        Console.WriteLine("Eat");
    }
}