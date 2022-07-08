namespace DesignPatterns.DecoratorPattern;

public class RopeDecoration : Decorator
{
    public RopeDecoration(ChristmasTree tree) : base(tree)
    {
    }

    public override string DoSomething()
    {
        return $"RopeDecoration({base.DoSomething()})";
    }
}