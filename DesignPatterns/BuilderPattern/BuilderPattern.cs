using DesignPatterns.BuilderPattern.Directors;
using DesignPatterns.DesignPattern;
using DesignPatterns.DesignPattern.Builders;

namespace DesignPatterns.BuilderPattern;

public class BuilderPattern
{
    public void BuildMeAHouse()
    {
        var builder = new SmallHomeBuilder();
        builder.BuildFoundation();
        builder.BuildWalls();
        Product builded = builder.GetProduct();
        Console.WriteLine(builded.ListParts());

        Roofer tomek = new ();
        tomek.Builder = builder;
        tomek.BuildOnlyRoof();
        Product buildedByTomek = builder.GetProduct();
        Console.WriteLine(buildedByTomek.ListParts());
        
        tomek.HireRoofersFriendToBuildEverything();
        Product buildedByTomekAndHisFriend = builder.GetProduct();
        Console.WriteLine(buildedByTomekAndHisFriend.ListParts());
    }


}