namespace DesignPatterns.CommandPattern;

public class Walk : Command
{
    public Walk()
    {
        strCommand = "Walk";
    }
    public override void Action()
    {
        Console.WriteLine("Walk");
    }
}