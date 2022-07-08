namespace DesignPatterns.DecoratorPattern;

public class TreePrinter
{
    public void PrintTree()
    {
        var tree = new PineTree();
        Console.WriteLine("Basic Tree: ");
        PrintTree(tree);
        Console.WriteLine("Christmas Tree: ");
        RibbonDecoration treeWithRibbon=new RibbonDecoration(tree);
        RopeDecoration treeWithRibbonAndRope = new RopeDecoration(treeWithRibbon);
        PrintTree(treeWithRibbon);
        PrintTree(treeWithRibbonAndRope);
    }
    public void PrintTree(ChristmasTree tree)
    {
        Console.WriteLine("RESULT: " + tree.DoSomething());
    }
}