using DesignPatterns.DesignPattern;
using DesignPatterns.DesignPattern.Builders;


public class BuilderPattern
{
    public void BuildMeAHouse()
    {
        var builder = new SmallHomeBuilder();
        builder.BuildFoundation();
        builder.BuildWalls();
        Product builded = builder.GetProduct();
        Console.WriteLine(builded.ListParts());
    }
}