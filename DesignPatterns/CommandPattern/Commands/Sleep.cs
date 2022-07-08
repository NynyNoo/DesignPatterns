namespace DesignPatterns.CommandPattern;

public class Sleep : Command
{
    public Sleep()
    {
        strCommand = "Sleep";
    }
    public override void Action()
    {
        Console.WriteLine("Sleep");
    }
}