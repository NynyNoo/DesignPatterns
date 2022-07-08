namespace DesignPatterns.DecoratorPattern;

public abstract class Decorator : ChristmasTree
{
    protected ChristmasTree _tree;

    public Decorator(ChristmasTree tree)
    {
        _tree = tree;
    }

    public void SetChristmast(ChristmasTree tree)
    {
        _tree = tree;
    }
    public override string DoSomething()
    {
        if (_tree == null!)
        {
            return String.Empty;
        }
        else
        {
            return _tree.DoSomething();
        }
    }
    
}