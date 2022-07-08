namespace DesignPatterns.DecoratorPattern;

public class RibbonDecoration : Decorator
{
    public RibbonDecoration(ChristmasTree tree) : base(tree)
    {
    }

    public override string DoSomething()
    {
        return $"RibbonDecoration({base.DoSomething()})";
    }
}